using DevExpress.XtraSplashScreen;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wamby.API.Extensions;
using Wamby.Client.Extensions;
using Wamby.Core.Model;

namespace Wamby.Client.Modules
{
    public partial class NewScanModule : DevExpress.XtraEditors.XtraUserControl, Interfaces.IModule
    {
        public event EventHandler StartingScan;
        public event EventHandler EndingScan;
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public NewScanModule()
        {
            InitializeComponent();
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
            newScanPathButtonEdit.Text = FileSystemScanService.ScanOptions.BaseFolderPath;
            includeSubfoldersCheckEdit.Checked = FileSystemScanService.ScanOptions.IncludeSubFolders;
            searchPatternButtonEdit.Text = FileSystemScanService.ScanOptions.SearchPattern;
            FileSystemScanService.CancelledByUser -= FileSystemScanService_CancelledByUser;
            FileSystemScanService.CancelledByUser += FileSystemScanService_CancelledByUser;
            FileSystemScanService.ScanningFolder -= FileSystemScanService_ScanningFolder;
            FileSystemScanService.ScanningFolder += FileSystemScanService_ScanningFolder;
            FileSystemScanService.ErrorReadingFileSystemInfo -= FileSystemScanService_ErrorReadingFileSystemInfo;
            FileSystemScanService.ErrorReadingFileSystemInfo += FileSystemScanService_ErrorReadingFileSystemInfo;
            Initialized = true;
            setEventHandlers();
        }

        private void setEventHandlers()
        {
            newScanPathButtonEdit.ButtonClick += NewScanPathButtonEdit_ButtonClick;
            scanLogGroupControl.CustomButtonClick += ScanLogGroupControl_CustomButtonClick;
            newScanPathButtonEdit.KeyDown += NewScanPathButtonEdit_KeyDown;
        }

        private void ScanLogGroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Cancel") FileSystemScanService?.Cancel();
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

        private async Task<ScanResult> DoScan()
        {
            IOverlaySplashScreenHandle handle = null;
            FileSystemScanService.ScanOptions.BaseFolderPath = newScanPathButtonEdit.Text;
            FileSystemScanService.ScanOptions.IncludeSubFolders = includeSubfoldersCheckEdit.Checked;
            FileSystemScanService.ScanOptions.SearchPattern = searchPatternButtonEdit.Text;
            FileSystemScanService.ScanOptions.ShowMinimumFolderLevelInLog = 
                Properties.Settings.Default.ShowMinimumFolderLevelInLog;
            try
            {
                handle = OverlayExtensions.ShowProgressPanel(logListBoxControl);
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
                if (handle != null) OverlayExtensions.CloseProgressPanel(handle);
                EndScan();
            }
            return FileSystemScanService.ScanResult;
        }

        private void FileSystemScanService_ScanningFolder(object sender, API.Services.FolderEventArgs e)
        {
            AddMessageToLog($"Reading: {e.FolderInfo.DirectoryInfo.FullName}", 
                e.FolderInfo.DirectoryInfo.FullName, Properties.Resources.Log_Folder);
        }

        private void FileSystemScanService_ErrorReadingFileSystemInfo(object sender, API.Services.FileSystemInfoEventArgs e)
        {
            AddMessageToLog($"ERROR: {e.FileSystemItem.FullName}",
                string.Empty, Properties.Resources.Errors);
        }

        private void FileSystemScanService_CancelledByUser(object sender, EventArgs e)
        {
            AddMessageToLog($"** Scan cancelled by user **".ToUpper(), 
                string.Empty, Properties.Resources.Errors);
        }

        private void AddMessageToLog(string message, string value, DevExpress.Utils.Svg.SvgImage image)
        {
            Invoke(new Action(() =>
            {
                var newitem = new DevExpress.XtraEditors.Controls.ImageListBoxItem()
                {
                    Description = message,
                    Value = value,
                };
                newitem.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
                newitem.ImageOptions.SvgImage = image;
                var newindex = logListBoxControl.Items.Add(newitem);
                logListBoxControl.TopIndex = newindex;
                logListBoxControl.Refresh();
            }));
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
            logListBoxControl.Items.Clear();
            AddMessageToLog(
                $"Started scan at {DateTime.Now.ToShortDateString()}", 
                string.Empty, Properties.Resources.Log_Info);
            resultsGroupControl.CustomHeaderButtons[0].Properties.Caption = "Scanning...";
            ActivateUI(false);
        }

        void EndScan()
        {
            AddMessageToLog(
                $"Finished scan. Ellapsed time: " +
                $"{FileSystemScanService.ScanResult.ElapsedTime.TotalMilliseconds.ToString("n2")}ms.", string.Empty, Properties.Resources.Log_Info);
            ActivateUI(true);
            UpdateResults();
            EndingScan?.Invoke(this, new EventArgs());
        }

        private void UpdateResults()
        {            
            resultsGroupControl.CustomHeaderButtons[0].Properties.Caption =
                $"{FileSystemScanService.ScanResult.TotalSizeInKb().ToString("n0")} KB in " +
                $"{FileSystemScanService.ScanResult.FolderInfo.AllFolders.Count.ToString("n0")} folders and " +
                $"{FileSystemScanService.ScanResult.TotalFilesCount().ToString("n0")} files";
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
            newScanPathButtonEdit.ReadOnly = !activated;
            newScanPathButtonEdit.Properties.Buttons[0].Enabled = activated;
            newScanPathButtonEdit.Properties.Buttons[1].Enabled = activated;
            searchPatternButtonEdit.ReadOnly = !activated;
            includeSubfoldersCheckEdit.ReadOnly = !activated;
            scanLogGroupControl.CustomHeaderButtons["Cancel"].Properties.Visible = !activated;
        }

        public void RefreshModuleData()
        {
            UpdateResults();
        }
    }
}
