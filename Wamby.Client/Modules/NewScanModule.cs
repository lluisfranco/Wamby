using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wamby.API.Args;
using Wamby.API.Enums;
using Wamby.API.Services;
using Wamby.Client.Interfaces;
using Wamby.Core.Model;

namespace Wamby.Client.Modules
{
    public partial class NewScanModule : XtraUserControl, IModule, IScanModule, IShowChangeFolderDialog
    {
        [Browsable(false)]
        public FileSystemScanService FileSystemScanService { get; private set; }
        public MainForm MainForm { get; private set; }
        public bool Initialized { get; private set; }

        Progress<WambyFolderEventArgs> ScanningFolderProgress;
        Progress<WambyFileSystemInfoEventArgs> ErrorReadingFileSystemInfoProgress;

        public event EventHandler NewScanButtonPressed;
        public event EventHandler ChangeFolderButtonPressed;

        public void RaiseNewScanButtonPressed() => NewScanButtonPressed?.Invoke(this, new EventArgs());
        public void RaiseChangeFolderButtonPressed() => ChangeFolderButtonPressed?.Invoke(this, new EventArgs());

        public NewScanModule()
        {
            InitializeComponent();
            SetProgressHandlers();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            imageComboBoxEditType.Properties.Items.AddEnum(typeof(ScanDetailTypeEnum));
            imageComboBoxEditType.EditValue = ScanDetailTypeEnum.Fast;
        }

        private void SetProgressHandlers()
        {
            ScanningFolderProgress = new Progress<WambyFolderEventArgs>(args => RefreshModuleData());
            ErrorReadingFileSystemInfoProgress = new Progress<WambyFileSystemInfoEventArgs>(args => RefreshModuleData());
        }

        public void RefreshModuleData()
        {
            logLineBindingSource.DataSource = FileSystemScanService.LogLines;
            gridControlLog.RefreshDataSource();
            gridViewLog.FocusedRowHandle = gridViewLog.RowCount - 1;
            MainForm?.SetMessage(FileSystemScanService.LogLines.LastOrDefault().Message);
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService scanService)
        {
            try
            {
                MainForm = mainform;
                FileSystemScanService = scanService;
                newScanPathButtonEdit.Properties.AdvancedModeOptions.AutoCompleteMode = TextEditAutoCompleteMode.SuggestAppend;
                newScanPathButtonEdit.Properties.AdvancedModeOptions.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
                RefreshScanOptionsControls();
                FileSystemScanService.ScanningFolderProgress = ScanningFolderProgress;
                FileSystemScanService.ErrorReadingFileSystemInfoProgress = ErrorReadingFileSystemInfoProgress;
                FileSystemScanService.CancelledScan += (s, e) => RefreshModuleData();
                var logcombo = Helpers.UIHelper.GetLogTypesCombo();
                logcombo.GlyphAlignment = HorzAlignment.Center;
                colLogLineType.ColumnEdit = logcombo;
                Initialized = true;
                SetEventHandlers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetEventHandlers()
        {
            newScanPathButtonEdit.ButtonClick += (s, e) =>
            {
                if (e.Button.Index == 0) RaiseNewScanButtonPressed();
                if (e.Button.Index == 1) RaiseChangeFolderButtonPressed();
            };
            newScanPathButtonEdit.KeyDown += async (s, e) => { if (e.KeyCode == Keys.Enter) await DoScan(); };
            gridViewLog.MouseDown += GridViewLog_MouseDown;
        }

        public void SetFocus()
        {
            gridControlLog.Focus();
        }

        public void RefreshScanOptionsControls()
        {
            newScanPathButtonEdit.Text = FileSystemScanService.ScanOptions.BaseFolderPath;
            includeSubfoldersCheckEdit.IsOn = FileSystemScanService.ScanOptions.IncludeSubFolders;
            searchPatternButtonEdit.Text = FileSystemScanService.ScanOptions.SearchPattern;
            imageComboBoxEditType.EditValue = FileSystemScanService.DetailType;
        }

        private void GridViewLog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) popupMenu.ShowPopup(MousePosition);
        }

        public async Task ShowChangeFolderDialog()
        {
            var fd = new FolderBrowserDialog
            {
                SelectedPath = newScanPathButtonEdit.Text
            };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                newScanPathButtonEdit.Text = fd.SelectedPath;
                if (WambyApplication.Settings.DoScanAfterChangingBaseFolderPath)
                    await DoScan();
            }
        }

        public void CancelScan()
        {
            FileSystemScanService?.Cancel();
        }

        public async Task<ScanResult> DoScan()
        {
            dxErrorProvider.ClearErrors();
            if (newScanPathButtonEdit.Text.LastOrDefault() == Path.DirectorySeparatorChar &&
                newScanPathButtonEdit.Text.Split(Path.DirectorySeparatorChar).Length > 2)
                newScanPathButtonEdit.Text = newScanPathButtonEdit.Text.Remove(newScanPathButtonEdit.Text.Length - 1, 1);
            if (!Directory.Exists(newScanPathButtonEdit.Text))
            {
                dxErrorProvider.SetError(newScanPathButtonEdit, "Folder doesn't exists.");
                return null;
            }
            FileSystemScanService.InitializeService();
            FileSystemScanService.DetailType = (ScanDetailTypeEnum)imageComboBoxEditType.EditValue;
            FileSystemScanService.ScanOptions.BaseFolderPath = newScanPathButtonEdit.Text;
            FileSystemScanService.ScanOptions.IncludeSubFolders = includeSubfoldersCheckEdit.IsOn;
            FileSystemScanService.ScanOptions.SearchPattern = searchPatternButtonEdit.Text;
            FileSystemScanService.ScanOptions.ShowMinimumFolderLevelInLog =
                 WambyApplication.Settings.ShowMinimumFolderLevelInLog;
            FileSystemScanService.UserName = WindowsIdentity.GetCurrent().Name;
            FileSystemScanService.ComputerName = Environment.MachineName;
            FileSystemScanService.OSVersionName = Environment.OSVersion.ToString();
            FileSystemScanService.ScanDate = DateTime.Now;
            try
            {
                StartScan();
                await FileSystemScanService.DoScan();
                SaveScanOptions();
                SetFocus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                EndScan();
            }
            return FileSystemScanService.ScanResult;
        }

        void SaveScanOptions()
        {
            WambyApplication.Settings.DefaultBaseFolderPath = FileSystemScanService.ScanOptions.BaseFolderPath;
            WambyApplication.Settings.DefaultIncludeSubFolders = FileSystemScanService.ScanOptions.IncludeSubFolders;
            WambyApplication.Settings.DefaultSearchPattern = FileSystemScanService.ScanOptions.SearchPattern;
            WambyApplication.Settings.DefaultDetailedScanType = FileSystemScanService.DetailType;
            WambyApplication.SettingsService.SaveSettings(WambyApplication.Settings);
        }

        void StartScan()
        {
            ActivateUI(false);
        }

        void EndScan()
        {
            ActivateUI(true);
            RefreshScanOptionsControls();
            MainForm?.ClearMessage();
            MainForm?.SetMessageLastScan(FileSystemScanService.GetSummary());
        }

        private void ActivateUI(bool activated)
        {
            newScanPathButtonEdit.ReadOnly = !activated;
            newScanPathButtonEdit.Properties.Buttons[0].Enabled = activated;
            newScanPathButtonEdit.Properties.Buttons[1].Enabled = activated;
            searchPatternButtonEdit.ReadOnly = !activated;
            includeSubfoldersCheckEdit.ReadOnly = !activated;
            imageComboBoxEditType.ReadOnly = !activated;
        }
    }
}
