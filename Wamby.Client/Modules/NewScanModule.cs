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
        Interfaces.IModule, Interfaces.IModuleRibbon
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }
        public string InitialFolderPath { get; set; } = null;
        public event EventHandler StartingScan;
        public event EventHandler EndingScan;
        public event EventHandler<Args.GotoTabButtonEventArgs> GotoTabButtonClicked;

        Progress<Wamby.API.Args.WambyFolderEventArgs> ScanningFolderProgress;
        Progress<Wamby.API.Args.WambyFileSystemInfoEventArgs> ErrorReadingFileSystemInfoProgress;
        Progress<string> CancelledByUserProgress;

        Timer timer = new Timer();
        Stopwatch clock = new Stopwatch();
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
            CancelledByUserProgress = new Progress<string>(args =>
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
            FileSystemScanService.CancelledByUserProgress = CancelledByUserProgress;
            resultsGroupControl.CustomButtonClick += ResultsGroupControl_CustomButtonClick;
            var logcombo = Helpers.UIHelper.GetLogTypesCombo();
            logcombo.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            colLogLineType.ColumnEdit = logcombo;
            imageComboBoxEditType.Properties.Items.AddEnum(typeof(API.Enums.ScanDetailTypeEnum));
            imageComboBoxEditType.EditValue = API.Enums.ScanDetailTypeEnum.Fast;
            Initialized = true;
            setEventHandlers();
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

        private void ResultsGroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            GotoTabButtonClicked?.Invoke(this, new Args.GotoTabButtonEventArgs()
                { TabName = e.Button.Properties.Tag.ToString() });
        }

        private void setEventHandlers()
        {
            newScanPathButtonEdit.ButtonClick += NewScanPathButtonEdit_ButtonClick;
            scanLogGroupControl.CustomButtonClick += ScanLogGroupControl_CustomButtonClick;
            newScanPathButtonEdit.KeyDown += NewScanPathButtonEdit_KeyDown;
            barButtonItemChangeFolder.ItemClick += BarButtonItemChangeFolder_ItemClick;
            barButtonItemScanNow.ItemClick += BarButtonItemScanNow_ItemClick;
            barButtonItemOpenFolder.ItemClick += BarButtonItemOpenFolder_ItemClick;
            barButtonItemOpenInNewWamby.ItemClick += BarButtonItemOpenInNewWamby_ItemClick;
            gridViewLog.FocusedRowObjectChanged += GridViewLog_FocusedRowObjectChanged;
            gridViewLog.MouseDown += GridViewLog_MouseDown;
            timer.Enabled = false;
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
        }

        private void GridViewLog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) popupMenu.ShowPopup(MousePosition);
        }

        private void GridViewLog_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            barButtonItemOpenFolder.Enabled = System.IO.Directory.Exists(item.Value);
            barButtonItemOpenInNewWamby.Enabled = System.IO.Directory.Exists(item.Value);
        }

        private void BarButtonItemOpenFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            if (System.IO.Directory.Exists(item.Value)) Helpers.ShellHelper.Open(item.Value);
        }

        private void BarButtonItemOpenInNewWamby_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = gridViewLog.GetRow(gridViewLog.FocusedRowHandle) as Core.Model.LogLine;
            if (System.IO.Directory.Exists(item.Value)) Helpers.ShellHelper.OpenWamby(item.Value);
        }

        private void ScanLogGroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Cancel") FileSystemScanService?.Cancel();
        }

        private void BarButtonItemChangeFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showSelectPathDialog();
        }

        private async void BarButtonItemScanNow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await DoScan();
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

        public async Task<ScanResult> DoScan()
        {
            IOverlaySplashScreenHandle handle = null;
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
                handle = OverlayFormExtensions.ShowProgressPanel(gridControlLog);
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
                if (handle != null) OverlayFormExtensions.CloseProgressPanel(handle);
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
            clock.Restart();
            timer.Enabled = true;
            StartingScan?.Invoke(this, new EventArgs());
            ActivateUI(false);
            resultsGroupControl.CustomHeaderButtons[0].Properties.Visible = true;
        }

        void EndScan()
        {
            clock.Stop();
            timer.Enabled = false;
            ActivateUI(true);
            UpdateResults();
            RefreshScanOptionsControls();
            EndingScan?.Invoke(this, new EventArgs());
        }

        private void UpdateResults()
        {            
            resultsGroupControl.CustomHeaderButtons[0].Properties.Caption =
                $"{FileSystemScanService.ScanResult.WambyFolderInfo.DeepLengthInKB.ToString("n0")} KB in " +
                $"{FileSystemScanService.ScanResult.AllFolders.Count.ToString("n0")} folders and " +
                $"{FileSystemScanService.ScanResult.WambyFolderInfo.DeepFilesCount.ToString("n0")} files";
            resultsGroupControl.CustomHeaderButtons[3].Properties.Caption =
                FileSystemScanService.ScanResult.ScanExceptions.Count == 0 ?
                "No errors" : 
                $"Check {FileSystemScanService.ScanResult.ScanExceptions.Count} errors";
            resultsGroupControl.Refresh();
        }

        private void ActivateUI(bool activated)
        {
            resultsGroupControl.CustomHeaderButtons[1].Properties.Visible = activated;
            resultsGroupControl.CustomHeaderButtons[2].Properties.Visible = activated;
            resultsGroupControl.CustomHeaderButtons[3].Properties.Visible = activated;            
            barButtonItemScanNow.Enabled = activated;
            barButtonItemChangeFolder.Enabled = activated;
            barButtonItemOpenFolder.Enabled = activated;
            barButtonItemOpenInNewWamby.Enabled = activated;
            newScanPathButtonEdit.ReadOnly = !activated;
            newScanPathButtonEdit.Properties.Buttons[0].Enabled = activated;
            newScanPathButtonEdit.Properties.Buttons[1].Enabled = activated;
            searchPatternButtonEdit.ReadOnly = !activated;
            includeSubfoldersCheckEdit.ReadOnly = !activated;
            imageComboBoxEditType.ReadOnly = !activated;
            scanLogGroupControl.CustomHeaderButtons["Cancel"].Properties.Visible = !activated;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var sec = (clock.ElapsedMilliseconds / 1000) + 1;
            resultsGroupControl.CustomHeaderButtons[0].Properties.Caption = $"Scanning...{sec} sec.";
            resultsGroupControl.Refresh();
        }

    }
}
