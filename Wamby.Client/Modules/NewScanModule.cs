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
        }

        //public string GetSelectedPath()
        //{
        //    return newScanPathButtonEdit.Text;
        //}

        public void InitializeControl(MainForm mainform, FileSystemScanService scanService)
        {
            try
            {
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
            gridViewLog.FocusedRowObjectChanged += GridViewLog_FocusedRowObjectChanged;
            gridViewLog.MouseDown += GridViewLog_MouseDown;
        }

        public void SetFocus()
        {
            gridControlLog.Focus();
        }

        //private void FileSystemScanService_CancelledScan(object sender, EventArgs e)
        //{
        //    RefreshModuleData();
        //}

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

        //private void ScanLogGroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        //{
        //    if (e.Button.Properties.Caption == "Cancel") CancelScan();
        //}

        //private void BarButtonItemChangeFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    ShowSelectPathDialog();
        //}

        //private async void NewScanPathButtonEdit_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter) await DoScan();
        //}

        //private async void NewScanPathButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    if (e.Button.Index == 0) ShowSelectPathDialog();
        //    if (e.Button.Index == 1) await DoScan();
        //}

        //public void RequestScan()
        //{
        //    RequestNewScan?.Invoke(this, new EventArgs());
        //}

        public async Task ShowChangeFolderDialog()
        {
            var fd = new FolderBrowserDialog
            {
                SelectedPath = newScanPathButtonEdit.Text
            };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                newScanPathButtonEdit.Text = fd.SelectedPath;
                if (Properties.Settings.Default.DoScanAfterChangingBaseFolderPath)
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
            FileSystemScanService.Clear();
            FileSystemScanService.DetailType = (ScanDetailTypeEnum)imageComboBoxEditType.EditValue;
            FileSystemScanService.ScanOptions.BaseFolderPath = newScanPathButtonEdit.Text;
            FileSystemScanService.ScanOptions.IncludeSubFolders = includeSubfoldersCheckEdit.IsOn;
            FileSystemScanService.ScanOptions.SearchPattern = searchPatternButtonEdit.Text;
            FileSystemScanService.ScanOptions.ShowMinimumFolderLevelInLog =
                Properties.Settings.Default.ShowMinimumFolderLevelInLog;
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
            Properties.Settings.Default.DefaultBaseFolderPath = FileSystemScanService.ScanOptions.BaseFolderPath;
            Properties.Settings.Default.DefaultIncludeSubFolders = FileSystemScanService.ScanOptions.IncludeSubFolders;
            Properties.Settings.Default.DefaultSearchPattern = FileSystemScanService.ScanOptions.SearchPattern;
            Properties.Settings.Default.DefaultDetailedScanType = FileSystemScanService.DetailType;
            Properties.Settings.Default.Save();
        }

        void StartScan()
        {
            ActivateUI(false);
        }

        void EndScan()
        {
            ActivateUI(true);
            RefreshScanOptionsControls();
            //FileSystemScanService?.RaiseEndScan();
        }

        private void ActivateUI(bool activated)
        {
            //barButtonItemChangeFolder.Enabled = activated;
            //barButtonItemOpenFolder.Enabled = activated;
            //barButtonItemOpenInNewWamby.Enabled = activated;
            newScanPathButtonEdit.ReadOnly = !activated;
            newScanPathButtonEdit.Properties.Buttons[0].Enabled = activated;
            newScanPathButtonEdit.Properties.Buttons[1].Enabled = activated;
            searchPatternButtonEdit.ReadOnly = !activated;
            includeSubfoldersCheckEdit.ReadOnly = !activated;
            imageComboBoxEditType.ReadOnly = !activated;
        }

        private void GridViewLog_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            var exists = System.IO.Directory.Exists(item.Value);
            //barButtonItemOpenFolder.Enabled = exists;
            //barButtonItemOpenTerminal.Enabled = exists;
            //barButtonItemOpenInNewWamby.Enabled = exists;
            //barButtonItemCopyPath.Enabled = exists;
            //barButtonItemShowProperties.Enabled = exists;
            //barButtonItemDelete.Enabled = exists;
        }

        private void BarButtonItemOpenFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            if (System.IO.Directory.Exists(item.Value)) Helpers.ShellHelper.Open(item.Value);
        }

        private void BarButtonItemOpenTerminal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            if (System.IO.Directory.Exists(item.Value)) Helpers.ShellHelper.OpenTerminal(item.Value);
        }

        private void BarButtonItemOpenInNewWamby_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            if (System.IO.Directory.Exists(item.Value)) Helpers.ShellHelper.OpenWamby(item.Value);
        }

        private void BarButtonItemCopyPath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            Clipboard.SetText(item.Value);
        }

        private void BarButtonItemShowProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            if (System.IO.Directory.Exists(item.Value))
                Helpers.ShellHelper.ShowFileSystemItemProperties(item.Value);
        }

        //private void BarButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
        //    if (System.IO.Directory.Exists(item.Value))
        //    {
        //        var deleted = Helpers.ShellHelper.DeleteFileSystemItemProperties(FindForm(), item.Value);
        //        if (deleted) RequestNewScan?.Invoke(this, new EventArgs());
        //    }
        //}
    }
}
