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
            cancelScanSimpleButton.Click += CancelScanSimpleButton_Click;
            Initialized = true;
            setEventHandlers();
        }

        private void CancelScanSimpleButton_Click(object sender, EventArgs e)
        {
            FileSystemScanService?.Cancel();
        }

        private void setEventHandlers()
        {
            newScanPathButtonEdit.ButtonClick += NewScanPathButtonEdit_ButtonClick;
        }

        private async void NewScanPathButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0) showSelectPathDialog();
            if (e.Button.Index == 1) FileSystemScanService.ScanResult = await DoScan();
        }

        private async void showSelectPathDialog()
        {
            var fd = new FolderBrowserDialog();
            fd.SelectedPath = newScanPathButtonEdit.Text;
            if (fd.ShowDialog() == DialogResult.OK)
            {                
                newScanPathButtonEdit.Text = fd.SelectedPath;
                if (Properties.Settings.Default.DoScanAfterChangingBaseFolderPath)
                    FileSystemScanService.ScanResult = await DoScan();
            }
        }

        private async Task<ScanResult> DoScan()
        {
            FileSystemScanService.ScanOptions.BaseFolderPath = newScanPathButtonEdit.Text;
            FileSystemScanService.ScanOptions.IncludeSubFolders = includeSubfoldersCheckEdit.Checked;
            FileSystemScanService.ScanOptions.SearchPattern = searchPatternButtonEdit.Text;
            try
            {
                FileSystemScanService.ScanResult = await FileSystemScanService.DoScan();                
                SaveScanOptions();
                MessageBox.Show(
                    $"Size: {FileSystemScanService.ScanResult.TotalSize()}\n" +
                    $"In:   {FileSystemScanService.ScanResult.TotalFilesCount()} files\n" +
                    $"Time: {FileSystemScanService.ScanResult.ElapsedTime.TotalMilliseconds.ToString("n2")} ms.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return FileSystemScanService.ScanResult;
        }

        void SaveScanOptions()
        {
            Properties.Settings.Default.DefaultBaseFolderPath = FileSystemScanService.ScanOptions.BaseFolderPath;
            Properties.Settings.Default.DefaultIncludeSubFolders = FileSystemScanService.ScanOptions.IncludeSubFolders;
            Properties.Settings.Default.Save();
        }

        private void FileSystemScanService_CancelledByUser(object sender, EventArgs e)
        {
            MessageBox.Show("Canceled");
        }

        public async Task RefreshDataAsync()
        {

        }
    }
}
