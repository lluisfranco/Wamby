using DevExpress.XtraSplashScreen;
using System;
using System.Linq;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wamby.Client.Extensions;
using Wamby.Core.Model;

namespace Wamby.Client.Modules
{
    public partial class NewScanModule : DevExpress.XtraEditors.XtraUserControl, 
        Interfaces.IModule, Interfaces.IModuleRibbon, Interfaces.IModuleNewScanRequested
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }
        public string InitialFolderPath { get; set; } = null;
        public event EventHandler StartingScan;
        public event EventHandler EndingScan;
        public event EventHandler RequestNewScan;

        Progress<Wamby.API.Args.WambyFolderEventArgs> ScanningFolderProgress;
        Progress<Wamby.API.Args.WambyFileSystemInfoEventArgs> ErrorReadingFileSystemInfoProgress;

        public NewScanModule()
        {
            InitializeComponent();
            SetProgressHandlers();
        }

        private void SetProgressHandlers()
        {
            ScanningFolderProgress = new Progress<API.Args.WambyFolderEventArgs>(args =>
            {
                RefreshModuleData();
            });
            ErrorReadingFileSystemInfoProgress = new Progress<Wamby.API.Args.WambyFileSystemInfoEventArgs>(args =>
            {
                RefreshModuleData();
            });
        }

        public void RefreshModuleData()
        {
            logLineBindingSource.DataSource = FileSystemScanService.LogLines;
            gridControlLog.RefreshDataSource();
            gridViewLog.FocusedRowHandle = gridViewLog.RowCount - 1;
        }

        public string GetSelectedPath()
        {
            return newScanPathButtonEdit.Text;   
        }

        public void InitializeControl(API.Services.FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            newScanPathButtonEdit.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            newScanPathButtonEdit.MaskBox.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            RefreshScanOptionsControls();
            FileSystemScanService.ScanningFolderProgress = ScanningFolderProgress;
            FileSystemScanService.ErrorReadingFileSystemInfoProgress = ErrorReadingFileSystemInfoProgress;
            FileSystemScanService.CancelledScan -= FileSystemScanService_CancelledScan;
            FileSystemScanService.CancelledScan += FileSystemScanService_CancelledScan;
            var logcombo = Helpers.UIHelper.GetLogTypesCombo();
            logcombo.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            colLogLineType.ColumnEdit = logcombo;
            imageComboBoxEditType.Properties.Items.AddEnum(typeof(API.Enums.ScanDetailTypeEnum));
            imageComboBoxEditType.EditValue = API.Enums.ScanDetailTypeEnum.Fast;
            Initialized = true;
            setEventHandlers();
        }

        public void SetFocus()
        {
            gridControlLog.Focus();
        }

        private void FileSystemScanService_CancelledScan(object sender, EventArgs e)
        {
            RefreshModuleData();
        }

        public void RefreshScanOptionsControls()
        {
            scanOptionsGroupControl.Text = $"Scan options - {FileSystemScanService.UserName} on " +
                $"{FileSystemScanService.ComputerName} ({FileSystemScanService.OSVersionName}) at " +
                $"{FileSystemScanService.ScanDate.ToString()}";
            newScanPathButtonEdit.Text = InitialFolderPath ?? FileSystemScanService.ScanOptions.BaseFolderPath;
            includeSubfoldersCheckEdit.Checked = FileSystemScanService.ScanOptions.IncludeSubFolders;
            searchPatternButtonEdit.Text = FileSystemScanService.ScanOptions.SearchPattern;
            imageComboBoxEditType.EditValue = FileSystemScanService.DetailType;
        }

        private void setEventHandlers()
        {
            newScanPathButtonEdit.ButtonClick += NewScanPathButtonEdit_ButtonClick;
            scanLogGroupControl.CustomButtonClick += ScanLogGroupControl_CustomButtonClick;
            newScanPathButtonEdit.KeyDown += NewScanPathButtonEdit_KeyDown;
            barButtonItemChangeFolder.ItemClick += BarButtonItemChangeFolder_ItemClick;
            barButtonItemOpenFolder.ItemClick += BarButtonItemOpenFolder_ItemClick;
            barButtonItemOpenTerminal.ItemClick += BarButtonItemOpenTerminal_ItemClick;
            barButtonItemOpenInNewWamby.ItemClick += BarButtonItemOpenInNewWamby_ItemClick;
            barButtonItemCopyPath.ItemClick += BarButtonItemCopyPath_ItemClick;
            barButtonItemShowProperties.ItemClick += BarButtonItemShowProperties_ItemClick;
            barButtonItemDelete.ItemClick += BarButtonItemDelete_ItemClick;
            gridViewLog.FocusedRowObjectChanged += GridViewLog_FocusedRowObjectChanged;
            gridViewLog.MouseDown += GridViewLog_MouseDown;
        }

        private void GridViewLog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) popupMenu.ShowPopup(MousePosition);
        }
        
        private void ScanLogGroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Cancel") CancelScan();
        }

        private void BarButtonItemChangeFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showSelectPathDialog();
        }

        private async void NewScanPathButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) await DoScan();
        }
        
        private async void NewScanPathButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0) showSelectPathDialog();
            if (e.Button.Index == 1) await DoScan();
        }

        public void RequestScan()
        {
            RequestNewScan?.Invoke(this, new EventArgs());
        }

        private async void showSelectPathDialog()
        {
            var fd = new FolderBrowserDialog();
            fd.SelectedPath = newScanPathButtonEdit.Text;
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
            if(newScanPathButtonEdit.Text.LastOrDefault() == System.IO.Path.DirectorySeparatorChar &&
                newScanPathButtonEdit.Text.Split(System.IO.Path.DirectorySeparatorChar).Length > 2)
                newScanPathButtonEdit.Text = newScanPathButtonEdit.Text.Remove(newScanPathButtonEdit.Text.Length - 1, 1);
            FileSystemScanService.Clear();
            FileSystemScanService.DetailType = (API.Enums.ScanDetailTypeEnum)imageComboBoxEditType.EditValue;
            FileSystemScanService.ScanOptions.BaseFolderPath = newScanPathButtonEdit.Text;
            FileSystemScanService.ScanOptions.IncludeSubFolders = includeSubfoldersCheckEdit.Checked;
            FileSystemScanService.ScanOptions.SearchPattern = searchPatternButtonEdit.Text;
            FileSystemScanService.ScanOptions.ShowMinimumFolderLevelInLog = 
                Properties.Settings.Default.ShowMinimumFolderLevelInLog;
            FileSystemScanService.UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            FileSystemScanService.ComputerName = Environment.MachineName;
            FileSystemScanService.OSVersionName = Environment.OSVersion.ToString();
            FileSystemScanService.ScanDate = DateTime.Now;
            try
            {
                StartScan();
                await FileSystemScanService.DoScan();
                SaveScanOptions();
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
            Properties.Settings.Default.Save();
        }

        void StartScan()
        {
            StartingScan?.Invoke(this, new EventArgs());
            ActivateUI(false);
        }

        void EndScan()
        {
            ActivateUI(true);
            RefreshScanOptionsControls();
            EndingScan?.Invoke(this, new EventArgs());
        }

        private void ActivateUI(bool activated)
        {
            barButtonItemChangeFolder.Enabled = activated;
            barButtonItemOpenFolder.Enabled = activated;
            barButtonItemOpenInNewWamby.Enabled = activated;
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
            barButtonItemOpenFolder.Enabled = exists;
            barButtonItemOpenTerminal.Enabled = exists;
            barButtonItemOpenInNewWamby.Enabled = exists;
            barButtonItemCopyPath.Enabled = exists;
            barButtonItemShowProperties.Enabled = exists;
            barButtonItemDelete.Enabled = exists;
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

        private void BarButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            if (System.IO.Directory.Exists(item.Value))
            {
                var deleted = Helpers.ShellHelper.DeleteFileSystemItemProperties(FindForm(), item.Value);
                if (deleted) RequestNewScan?.Invoke(this, new EventArgs());
            }
        }
    }
}
