using DevExpress.Mvvm.Native;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System.Linq;
using Wamby.API.Services;
using Wamby.Client;
using Wamby.Client.Interfaces;
using Wamby.Client.Modules;

namespace Wamby.Client
{
    public partial class NewScanForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public NewScanForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
            navigationPane.AddTabMergeModulesRibbonSupport();
        }

        public void InitializeModules(MainForm mainform)
        {
            MainForm = mainform;
            navigationPageScanFolder.InitializeModule(new NewScanModule(), MainForm, "New Scan", 15);
            navigationPageResults.InitializeModule(new ResultsModule(), MainForm, "Results", 30);
            navigationPageFiles.InitializeModule(new FilesModule(), MainForm, "Files", 45);
            navigationPageMap.InitializeModule(new MapModule(), MainForm, "Map", 60);
            navigationPageAnalysis.InitializeModule(new AnalysisModule(), MainForm, "Analisys", 75);
            navigationPageErrors.InitializeModule(new ErrorsModule(), MainForm, "Errors", 90);
            MainForm.ClearMessage().ClearProgress();
        }

        public void InitializeControl(FileSystemScanService fileSystemScanService)
        {
            FileSystemScanService = fileSystemScanService;
            FileSystemScanService.BeginScan += (s, e) =>
            {
            };
            navigationPane.Pages.ForEach(p => p.PageText = p.Caption.ToUpper());
            navigationPane.Pages.Where(
                p => p.PageText != navigationPane.Pages[0].PageText).ForEach(p => p.PageEnabled = false);
            //var module = navigationPane.GetCurrentModule();
            //module.InitializeControl(mainform, FileSystemScanService);
            var modules = navigationPane.GetModules();
            foreach (var module in modules)
            {
                module.InitializeControl(MainForm, FileSystemScanService);
            }
        }
    }
}