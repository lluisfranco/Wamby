using DevExpress.Utils.MVVM;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.IO;
using System.Security.Principal;
using System.Threading.Tasks;
using Wamby.API.Enums;
using Wamby.API.Services;
using Wamby.Client.Extensions;
using Wamby.Client.Interfaces;
using Wamby.Client.Modules;

namespace Wamby.Client
{
    public partial class NewScanForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public NewScanForm SetParent(MainForm form) { MainForm = form; MdiParent = MainForm; return this; }
        public NewScanForm ShowProgressPanel() { handle = OverlayFormExtensions.ShowProgressPanel(navigationPane); return this; }
        public NewScanForm HideProgressPanel() { if (handle != null) OverlayFormExtensions.CloseProgressPanel(handle); return this; }

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
            InitializeFileSystemScanService();
            var modules = navigationPane.GetModules();
            foreach (var module in modules)
            {
                module.InitializeControl(MainForm, FileSystemScanService);
            }
            var scanmodule = navigationPageScanFolder.GetPageModule() as IScanModule;
            scanmodule.NewScanButtonPressed += async (s, e) => await StartScan();
            scanmodule.ChangeFolderButtonPressed += async (s, e) => await ChangeSelectedFolder();
            return this;
        }

        private void InitializeFileSystemScanService()
        {
            FileSystemScanService = new FileSystemScanService()
            {
                UserName = WindowsIdentity.GetCurrent().Name,
                ComputerName = Environment.MachineName,
                OSVersionName = Environment.OSVersion.ToString(),
                ScanDate = DateTime.Now,
                DetailType = ScanDetailTypeEnum.Fast
            };
            if (Directory.Exists(Properties.Settings.Default.DefaultBaseFolderPath))
                FileSystemScanService.ScanOptions.BaseFolderPath = Properties.Settings.Default.DefaultBaseFolderPath;
            FileSystemScanService.ScanOptions.IncludeSubFolders = Properties.Settings.Default.DefaultIncludeSubFolders;
            FileSystemScanService.ScanOptions.SearchPattern = Properties.Settings.Default.DefaultSearchPattern;
            FileSystemScanService.DetailType = Properties.Settings.Default.DefaultDetailedScanType;
            FileSystemScanService.BeginScan += (s, e) =>
            {
                UpdateFormTitle();
                ShowProgressPanel();
            };
            FileSystemScanService.EndScan += (s, e) =>
            {
                ShowScanResults();
                HideProgressPanel();
            };
        }

        private void UpdateFormTitle()
        {
            var folder = new DirectoryInfo(FileSystemScanService.ScanOptions.BaseFolderPath);
            if (folder.Exists) Text = $"{folder.Name}";
        }

        private void ShowScanResults()
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
        }

        private async Task StartScan()
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