using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wamby.API.Extensions;
using Wamby.Core.Model;

namespace Wamby.Client.Modules
{
    public partial class NewScanModule : DevExpress.XtraEditors.XtraUserControl, Interfaces.IModule
    {
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
            Initialized = true;
            setEventHandlers();
        }

        private void setEventHandlers()
        {
            newScanPathButtonEdit.ButtonClick += NewScanPathButtonEdit_ButtonClick;
            scanLogGroupControl.CustomButtonClick += ScanLogGroupControl_CustomButtonClick;
        }

        private void ScanLogGroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Cancel") FileSystemScanService?.Cancel();
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
            FileSystemScanService.ScanOptions.BaseFolderPath = newScanPathButtonEdit.Text;
            FileSystemScanService.ScanOptions.IncludeSubFolders = includeSubfoldersCheckEdit.Checked;
            FileSystemScanService.ScanOptions.SearchPattern = searchPatternButtonEdit.Text;
            try
            {
                StartScan();            
                await FileSystemScanService.DoScan();                
                SaveScanOptions();
                //MessageBox.Show(
                //    $"Size: {FileSystemScanService.ScanResult.TotalSize()}\n" +
                //    $"In:   {FileSystemScanService.ScanResult.TotalFilesCount()} files\n" +
                //    $"Time: {FileSystemScanService.ScanResult.ElapsedTime.TotalMilliseconds.ToString("n2")} ms.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EndScan();
            }
            return FileSystemScanService.ScanResult;
        }

        private void FileSystemScanService_ScanningFolder(object sender, API.Services.ScanningFolderEventArhs e)
        {
            AddMessageToLog($"Reading: {e.FolderInfo.DirectoryInfo.FullName}");
        }

        private void AddMessageToLog(string message)
        {
            Invoke(new Action(() =>
            {
                var newindex = logListBoxControl.Items.Add(message);
                logListBoxControl.TopIndex = newindex;
                logListBoxControl.Refresh();
            }));
        }

        private void FileSystemScanService_CancelledByUser(object sender, EventArgs e)
        {
            AddMessageToLog($"** Scan cancelled by user **");
            EndScan();
        }

        void SaveScanOptions()
        {
            Properties.Settings.Default.DefaultBaseFolderPath = FileSystemScanService.ScanOptions.BaseFolderPath;
            Properties.Settings.Default.DefaultIncludeSubFolders = FileSystemScanService.ScanOptions.IncludeSubFolders;
            Properties.Settings.Default.Save();
        }

        void StartScan()
        {
            logListBoxControl.Items.Clear();
            AddMessageToLog(
                $"Started scan at {DateTime.Now.ToShortDateString()}");
            ActivateUI(false);
        }

        void EndScan()
        {
            AddMessageToLog(
                $"Finished scan. Ellapsed time: " +
                $"{FileSystemScanService.ScanResult.ElapsedTime.TotalMilliseconds.ToString("n2")}ms.");
            UpdateResults();
            ActivateUI(true);
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
            newScanPathButtonEdit.ReadOnly = !activated;
            newScanPathButtonEdit.Properties.Buttons[0].Enabled = activated;
            newScanPathButtonEdit.Properties.Buttons[1].Enabled = activated;
            searchPatternButtonEdit.ReadOnly = !activated;
            includeSubfoldersCheckEdit.ReadOnly = !activated;
            scanLogGroupControl.CustomHeaderButtons["Cancel"].Properties.Visible = !activated;
        }

        public async Task RefreshDataAsync()
        {

        }
    }
}
