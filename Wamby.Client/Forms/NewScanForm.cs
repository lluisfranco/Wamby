using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wamby.API.Enums;
using Wamby.API.Services;
using Wamby.Client.Extensions;
using Wamby.Client.Interfaces;
using Wamby.Client.Modules;
using Wamby.PreviousScansPersistence;

namespace Wamby.Client
{
    public partial class NewScanForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public Settings.Settings Settings { get; private set; }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public FileSystemStorageService FileSystemStorageService { get; private set; } = new();
        public NewScanForm SetParent(MainForm form) { MainForm = form; MdiParent = MainForm; return this; }
        public NewScanForm ShowProgressPanel() { handle = OverlayFormExtensions.ShowProgressPanel(navigationPane); return this; }
        public NewScanForm HideProgressPanel() { if (handle != null) OverlayFormExtensions.CloseProgressPanel(handle); return this; }
        public void SetFileSystemScanService(FileSystemScanService service) { FileSystemScanService = service; }

        IOverlaySplashScreenHandle handle = null;

        public NewScanForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
            navigationPane.AddTabMergeModulesRibbonSupport();
            SetEventHandlers();
        }

        private void SetEventHandlers()
        {
            barButtonItemSave.ItemClick += async (s, e) => await SaveScan();
            barButtonItemNewScan.ItemClick += async (s, e) => await StartScan();
            barButtonItemCancelScan.ItemClick += (s, e) => CancelScan();
            barButtonItemChangeFolder.ItemClick += async (s, e) => await ChangeSelectedFolder();
        }

        public NewScanForm InitializeModules()
        {
            navigationPageScanFolder.InitializeModule(new NewScanModule(), MainForm, "New Scan", 15, true);
            navigationPageResults.InitializeModule(new ResultsModule(), MainForm, "Results", 30);
            navigationPageFiles.InitializeModule(new FilesModule(), MainForm, "Files", 45);
            navigationPageMap.InitializeModule(new MapModule(), MainForm, "Map", 60);
            navigationPageAnalysis.InitializeModule(new AnalysisModule(), MainForm, "Analisys", 75);
            navigationPageErrors.InitializeModule(new ErrorsModule(), MainForm, "Errors", 90);
            MainForm.ClearMessage().ClearProgress();
            return this;
        }

        public NewScanForm InitializeControl()
        {
            Settings = WambyApplication.Settings;
            InitializeFileSystemScanService();
            var modules = navigationPane.GetModules();
            foreach (var module in modules)
            {
                module.InitializeControl(MainForm, FileSystemScanService);
            }
            var scanmodule = navigationPageScanFolder.GetPageModule() as IScanModule;
            scanmodule.NewScanButtonPressed += async (s, e) => await StartScan();
            scanmodule.ChangeFolderButtonPressed += async (s, e) => await ChangeSelectedFolder();
            var resultsmodule = navigationPageResults.GetPageModule() as IResultsModule;
            resultsmodule.OpenFolderInNewTabClick += async (s, e) => await MainForm.ViewModel.NewScan(e.Path);
            return this;
        }

        private void InitializeFileSystemScanService()
        {
            if (FileSystemScanService == null)
            {
                FileSystemScanService = new FileSystemScanService()
                {
                    UserName = WindowsIdentity.GetCurrent().Name,
                    ComputerName = Environment.MachineName,
                    OSVersionName = Environment.OSVersion.ToString(),
                    ScanDate = DateTime.Now,
                    DetailType = ScanDetailTypeEnum.Fast
                };
                FileSystemScanService.InitializeService();
                if (Directory.Exists(Settings.DefaultBaseFolderPath))
                    FileSystemScanService.ScanOptions.BaseFolderPath = Settings.DefaultBaseFolderPath;
                FileSystemScanService.ScanOptions.IncludeSubFolders = Settings.DefaultIncludeSubFolders;
                FileSystemScanService.ScanOptions.SearchPattern = Settings.DefaultSearchPattern;
                FileSystemScanService.DetailType = Settings.DefaultDetailedScanType;
            }
            FileSystemScanService.BeginScan += (s, e) =>
            {
                UpdateFormTitle();
                ShowProgressPanel();
            };
            FileSystemScanService.EndScan += (s, e) =>
            {
                ShowScanResultsAndAddToPreviousList();
                HideProgressPanel();
            };
        }

        private void UpdateFormTitle()
        {
            var folder = new DirectoryInfo(FileSystemScanService.ScanOptions.BaseFolderPath);
            if (folder.Exists) Text = $"{folder.Name}";
        }

        public void ShowScanResultsAndAddToPreviousList()
        {
            UpdateFormTitle();
            ShowScanResults();
            SaveScanToPreviousList();
        }

        public void ShowScanResults()
        {
            var results = FileSystemScanService.ScanResult.AllFiles.Count > 0;
            var errors = FileSystemScanService.ScanResult.ScanExceptions.Count > 0;
            navigationPageResults.PageEnabled = results;
            navigationPageFiles.PageEnabled = results;
            navigationPageMap.PageEnabled = results;
            navigationPageAnalysis.PageEnabled = results;
            navigationPageErrors.PageEnabled = errors;

            if (results) navigationPageScanFolder.GetPageModule().RefreshModuleData();
            if (results) navigationPageResults.GetPageModule().RefreshModuleData();
            if (results) navigationPageFiles.GetPageModule().RefreshModuleData();
            if (results) navigationPageMap.GetPageModule().RefreshModuleData();
            if (results) navigationPageAnalysis.GetPageModule().RefreshModuleData();
            if (errors) navigationPageErrors.GetPageModule().RefreshModuleData();
            if (Settings.ShowResultsPageAfterScan && navigationPageResults.PageEnabled)
                navigationPane.SelectedPage = navigationPageResults;
        }

        public void SaveScanToPreviousList()
        {
            var previousScans = WambyApplication.PreviousScansPersistenceService.LoadPreviousScans();
            var scan = new PreviousScan()
            {
                BaseFolderPath = FileSystemScanService.ScanOptions.BaseFolderPath,
                IncludeSubFolders = FileSystemScanService.ScanOptions.IncludeSubFolders,
                SearchPattern = FileSystemScanService.ScanOptions.SearchPattern,
                DetailType = FileSystemScanService.DetailType,
                ScanDate = FileSystemScanService.ScanDate,
                ComputerName = FileSystemScanService.ComputerName,
                UserName = FileSystemScanService.UserName,
                OSVersionName = FileSystemScanService.OSVersionName,
                ShowMinimumFolderLevelInLog = FileSystemScanService.ScanOptions.ShowMinimumFolderLevelInLog,
                FolderCount = FileSystemScanService.ScanResult.AllFolders.Count,
                FileCount = FileSystemScanService.ScanResult.AllFiles.Count,
                ErrorCount = FileSystemScanService.ScanResult.ScanExceptions.Count
            };
            if (previousScans.Exists(p => p.BaseFolderPath == FileSystemScanService.ScanOptions.BaseFolderPath))
                previousScans.RemoveAll(p => p.BaseFolderPath == FileSystemScanService.ScanOptions.BaseFolderPath);
            previousScans.Insert(0, scan);
            WambyApplication.PreviousScansPersistenceService.SavePreviousScans(
                previousScans.Take(WambyApplication.Settings.SavePreviousScansMaxCount).ToList());
        }

        private async Task SaveScan()
        {
            using (var sd = new SaveFileDialog())
            {
                sd.Filter = FileSystemStorageService.GetFilterDescription();
                var filename = new FileInfo(FileSystemScanService.ScanOptions.BaseFolderPath);
                sd.FileName = $"{filename.Name}";
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    Application.UseWaitCursor = true;
                    try
                    {
                        FileSystemStorageService.SaveReadableFormat = Settings.SaveToFileReadableFormat;
                        await FileSystemStorageService.SaveToFile(sd.FileName, FileSystemScanService);
                        Application.UseWaitCursor = false;
                    }
                    catch (Exception ex)
                    {
                        Application.UseWaitCursor = false;
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            };
        }

        public async Task StartScan()
        {
            barButtonItemNewScan.Visibility = BarItemVisibility.Never;
            barButtonItemCancelScan.Visibility = BarItemVisibility.Always;
            var module = navigationPageScanFolder.GetPageModule() as IScanModule;
            await module?.DoScan();
            barButtonItemCancelScan.Visibility = BarItemVisibility.Never;
            barButtonItemNewScan.Visibility = BarItemVisibility.Always;
        }

        private void CancelScan()
        {
            var module = navigationPageScanFolder.GetPageModule() as IScanModule;
            module?.CancelScan();
            barButtonItemCancelScan.Visibility = BarItemVisibility.Never;
            barButtonItemNewScan.Visibility = BarItemVisibility.Always;
        }

        private async Task ChangeSelectedFolder()
        {
            var module = navigationPageScanFolder.GetPageModule() as IShowChangeFolderDialog;
            await module?.ShowChangeFolderDialog();
        }
    }
}