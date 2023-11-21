using DevExpress.Mvvm.Native;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Linq;
using Wamby.API.Services;
using Wamby.Client.Forms;

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

        public void InitializeModules()
        {
            /*
            private DevExpress.XtraBars.Navigation.NavigationPage navigationPageScanFolder;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageResults;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageFiles;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageMap;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageAnalysis;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageErrors;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageSchedule;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageSettings;

            private Modules.NewScanModule newScanModule;
        private Modules.ResultsModule resultsModule;
        private Modules.FilesModule filesModule;
        private Modules.MapModule mapModule;
        private Modules.AnalysisModule analysisModule;
        private Modules.ErrorsModule errorsModule;

            navigationPageScanFolder = new DevExpress.XtraBars.Navigation.NavigationPage();
            newScanModule = new Modules.NewScanModule();
            navigationPageResults = new DevExpress.XtraBars.Navigation.NavigationPage();
            resultsModule = new Modules.ResultsModule();
            navigationPageFiles = new DevExpress.XtraBars.Navigation.NavigationPage();
            filesModule = new Modules.FilesModule();
            navigationPageMap = new DevExpress.XtraBars.Navigation.NavigationPage();
            mapModule = new Modules.MapModule();
            navigationPageAnalysis = new DevExpress.XtraBars.Navigation.NavigationPage();
            analysisModule = new Modules.AnalysisModule();
            navigationPageErrors = new DevExpress.XtraBars.Navigation.NavigationPage();
            errorsModule = new Modules.ErrorsModule();
            navigationPageSchedule = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();

            navigationPageScanFolder.SuspendLayout();
            navigationPageResults.SuspendLayout();
            navigationPageFiles.SuspendLayout();
            navigationPageMap.SuspendLayout();
            navigationPageAnalysis.SuspendLayout();
            navigationPageErrors.SuspendLayout();

            navigationPane.Controls.Add(navigationPageScanFolder);
            navigationPane.Controls.Add(navigationPageResults);
            navigationPane.Controls.Add(navigationPageFiles);
            navigationPane.Controls.Add(navigationPageMap);
            navigationPane.Controls.Add(navigationPageAnalysis);
            navigationPane.Controls.Add(navigationPageErrors);
            navigationPane.Controls.Add(navigationPageSchedule);
            navigationPane.Controls.Add(navigationPageSettings);

            navigationPageScanFolder.Caption = "Scan Folder";
            navigationPageScanFolder.Controls.Add(newScanModule);
            navigationPageScanFolder.ImageOptions.ImageIndex = 0;
            navigationPageScanFolder.Name = "navigationPageScanFolder";
            navigationPageScanFolder.Size = new System.Drawing.Size(677, 431);
            navigationPageScanFolder.ToolTip = "Scan Folder";
            // 
            // newScanModule
            // 
            newScanModule.Dock = System.Windows.Forms.DockStyle.Fill;
            newScanModule.Location = new System.Drawing.Point(0, 0);
            newScanModule.Name = "newScanModule";
            newScanModule.Size = new System.Drawing.Size(677, 431);
            newScanModule.TabIndex = 8;
            // 
            // navigationPageResults
            // 
            navigationPageResults.Caption = "Results";
            navigationPageResults.Controls.Add(resultsModule);
            navigationPageResults.ImageOptions.ImageIndex = 1;
            navigationPageResults.Name = "navigationPageResults";
            navigationPageResults.Size = new System.Drawing.Size(677, 440);
            navigationPageResults.ToolTip = "Results";
            // 
            // resultsModule
            // 
            resultsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            resultsModule.Location = new System.Drawing.Point(0, 0);
            resultsModule.Name = "resultsModule";
            resultsModule.Size = new System.Drawing.Size(677, 440);
            resultsModule.TabIndex = 0;
            // 
            // navigationPageFiles
            // 
            navigationPageFiles.Caption = "Files";
            navigationPageFiles.Controls.Add(filesModule);
            navigationPageFiles.ImageOptions.ImageIndex = 2;
            navigationPageFiles.Name = "navigationPageFiles";
            navigationPageFiles.Size = new System.Drawing.Size(677, 440);
            navigationPageFiles.ToolTip = "Files";
            // 
            // filesModule
            // 
            filesModule.Dock = System.Windows.Forms.DockStyle.Fill;
            filesModule.Location = new System.Drawing.Point(0, 0);
            filesModule.Name = "filesModule";
            filesModule.Size = new System.Drawing.Size(677, 440);
            filesModule.TabIndex = 0;
            // 
            // navigationPageMap
            // 
            navigationPageMap.Caption = "Map";
            navigationPageMap.Controls.Add(mapModule);
            navigationPageMap.ImageOptions.ImageIndex = 3;
            navigationPageMap.Name = "navigationPageMap";
            navigationPageMap.Size = new System.Drawing.Size(677, 440);
            navigationPageMap.ToolTip = "Map";
            // 
            // mapModule
            // 
            mapModule.Dock = System.Windows.Forms.DockStyle.Fill;
            mapModule.Location = new System.Drawing.Point(0, 0);
            mapModule.Name = "mapModule";
            mapModule.Size = new System.Drawing.Size(677, 440);
            mapModule.TabIndex = 0;
            // 
            // navigationPageAnalysis
            // 
            navigationPageAnalysis.Caption = "Analysis";
            navigationPageAnalysis.Controls.Add(analysisModule);
            navigationPageAnalysis.ImageOptions.ImageIndex = 4;
            navigationPageAnalysis.Name = "navigationPageAnalysis";
            navigationPageAnalysis.Size = new System.Drawing.Size(677, 440);
            navigationPageAnalysis.ToolTip = "Analysis";
            // 
            // analysisModule
            // 
            analysisModule.Dock = System.Windows.Forms.DockStyle.Fill;
            analysisModule.Location = new System.Drawing.Point(0, 0);
            analysisModule.Name = "analysisModule";
            analysisModule.Padding = new System.Windows.Forms.Padding(3);
            analysisModule.Size = new System.Drawing.Size(677, 440);
            analysisModule.TabIndex = 0;
            // 
            // navigationPageErrors
            // 
            navigationPageErrors.Caption = "Errors";
            navigationPageErrors.Controls.Add(errorsModule);
            navigationPageErrors.ImageOptions.ImageIndex = 5;
            navigationPageErrors.Name = "navigationPageErrors";
            navigationPageErrors.Size = new System.Drawing.Size(677, 440);
            navigationPageErrors.ToolTip = "Errors";
            // 
            // errorsModule
            // 
            errorsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            errorsModule.Location = new System.Drawing.Point(0, 0);
            errorsModule.Name = "errorsModule";
            errorsModule.Size = new System.Drawing.Size(677, 440);
            errorsModule.TabIndex = 0;
            // 
            // navigationPageSchedule
            // 
            navigationPageSchedule.Caption = "Schedule";
            navigationPageSchedule.ImageOptions.ImageIndex = 6;
            navigationPageSchedule.Name = "navigationPageSchedule";
            navigationPageSchedule.Size = new System.Drawing.Size(764, 504);
            navigationPageSchedule.ToolTip = "Schedule";
            // 
            // navigationPageSettings
            // 
            navigationPageSettings.Caption = "Settings";
            navigationPageSettings.ImageOptions.ImageIndex = 7;
            navigationPageSettings.Name = "navigationPageSettings";
            navigationPageSettings.Size = new System.Drawing.Size(764, 504);
            navigationPageSettings.ToolTip = "Settings";

            navigationPageScanFolder.ResumeLayout(false);
            navigationPageResults.ResumeLayout(false);
            navigationPageFiles.ResumeLayout(false);
            navigationPageMap.ResumeLayout(false);
            navigationPageAnalysis.ResumeLayout(false);
            navigationPageErrors.ResumeLayout(false);

            */
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService fileSystemScanService)
        {
            MainForm = mainform;
            FileSystemScanService = fileSystemScanService;
            FileSystemScanService.BeginScan+=(s, e) => { 
            }; 
            navigationPane.Pages.ForEach(p => p.PageText = p.Caption.ToUpper());
            navigationPane.Pages.Where(
                p => p.PageText != navigationPane.Pages[0].PageText).ForEach(p => p.PageEnabled = false);
            //var module = navigationPane.GetCurrentModule();
            //module.InitializeControl(mainform, FileSystemScanService);
            var modules = navigationPane.GetModules();
            foreach (var module in modules)
            {
                module.InitializeControl(mainform, FileSystemScanService);
            }
        }
    }
}