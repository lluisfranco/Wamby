using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.IO;
using System.Security.Principal;
using Wamby.API.Enums;
using Wamby.API.Services;
using Wamby.Client.Extensions;
using Wamby.Client.Modules;

namespace Wamby.Client
{
    public partial class NewScanForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public void ShowProgressPanel() => handle = OverlayFormExtensions.ShowProgressPanel(navigationPane);
        public void HideProgressPanel() { if (handle != null) OverlayFormExtensions.CloseProgressPanel(handle); }
        IOverlaySplashScreenHandle handle = null;

        public NewScanForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
            navigationPane.AddTabMergeModulesRibbonSupport();
        }

        public void InitializeModules(MainForm mainform)
        {
            MainForm = mainform;
            navigationPageScanFolder.InitializeModule(new NewScanModule(), MainForm, "New Scan", 15, true);
            navigationPageResults.InitializeModule(new ResultsModule(), MainForm, "Results", 30);
            navigationPageFiles.InitializeModule(new FilesModule(), MainForm, "Files", 45);
            navigationPageMap.InitializeModule(new MapModule(), MainForm, "Map", 60);
            navigationPageAnalysis.InitializeModule(new AnalysisModule(), MainForm, "Analisys", 75);
            navigationPageErrors.InitializeModule(new ErrorsModule(), MainForm, "Errors", 90);
            MainForm.ClearMessage().ClearProgress();
        }

        public void InitializeControl()
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
            FileSystemScanService.BeginScan += (s, e) => ShowProgressPanel();
            FileSystemScanService.EndScan += (s, e) =>
            {
                ShowScanResults();
                HideProgressPanel();
            };
            var modules = navigationPane.GetModules();
            foreach (var module in modules)
            {
                module.InitializeControl(MainForm, FileSystemScanService);
            }
        }      

        private void ShowScanResults()
        {
            var results = FileSystemScanService.ScanResult.AllFiles.Count > 0;
            var errors = FileSystemScanService.ScanResult.ScanExceptions.Count > 0;
            navigationPageResults.PageEnabled = results;
            navigationPageFiles.PageEnabled = results;
            navigationPageMap.PageEnabled = results;
            navigationPageAnalysis.PageEnabled = results;
            navigationPageErrors.PageEnabled = results;
            navigationPageErrors.PageEnabled = errors;

            navigationPageResults.GetPageModule().RefreshModuleData();
            navigationPageFiles.GetPageModule().RefreshModuleData();
            navigationPageMap.GetPageModule().RefreshModuleData();
        }
    }
}