using System;
using System.Windows.Forms;
using Wamby.API.Services;

namespace Wamby.Client
{
    public partial class MainForm2 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ViewModels.MainFormViewModel ViewModel { get; set; }
        public MainForm2()
        {
            InitializeComponent();
            tabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            Text = Application.ProductName;
            Icon = Properties.Resources.Wamby_App_Icon;
            ViewModel = new ViewModels.MainFormViewModel(new FileSystemScanService());
            SetEventHandlers();
        }

        private void SetEventHandlers()
        {
            Shown += MainForm_Shown;
            showNewScanModule.Click += ShowNewScanModule_Click;
            showResultsModule.Click += ShowResultsModule_Click;
            showFilesModule.Click += ShowFilesModule_Click;
            showMapModule.Click += ShowMapModule_Click;
            showAnalyzeModule.Click += ShowAnalyzeModule_Click;
            showErrorsModule.Click += ShowErrorsModule_Click;
            showScheduleModule.Click += ShowScheduleModule_Click;
            showSettingsModule.Click += ShowSettingsModule_Click;
            newAppBarButtonItem.ItemClick += NewAppBarButtonItem_ItemClick;
            newScanModule.StartingScan += NewScanModule_StartingScan;
            newScanModule.EndingScan += NewScanModule_EndingScan;
            tabControl.SelectedPageChanged += TabControl_SelectedPageChanged;
            barButtonItemPrint.ItemClick += BarButtonItemPrint_ItemClick;
            barButtonItemExportXls.ItemClick += BarButtonItemExportXls_ItemClick;
            barButtonItemExportPdf.ItemClick += BarButtonItemExportPdf_ItemClick;
            barButtonItemExpandTree.ItemClick += BarButtonItemExpandTree_ItemClick;
            barButtonItemCollapse.ItemClick += BarButtonItemCollapse_ItemClick;
            barButtonItemExpandLevel1.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel2.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel3.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel4.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel5.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barCheckItemMapBySize.ItemClick += BarCheckItemMapBySize_ItemClick;
            barCheckItemMapByFilesCount.ItemClick += BarCheckItemMapByFilesCount_ItemClick;
            barButtonItemLayoutAlgorithmSliceAndDice.ItemClick += BarButtonItemLayoutAlgorithmSliceAndDice_ItemClick;
            barButtonItemLayoutAlgorithmSquarified.ItemClick += BarButtonItemLayoutAlgorithmSquarified_ItemClick;
            barButtonItemLayoutAlgorithmStriped.ItemClick += BarButtonItemLayoutAlgorithmStriped_ItemClick;
            barButtonItemDirectionBottomLeftToTopRight.ItemClick += BarButtonItemDirectionBottomLeftToTopRight_ItemClick;
            barButtonItemDirectionBottomRightToTopLeft.ItemClick += BarButtonItemDirectionBottomRightToTopLeft_ItemClick;
            barButtonItemDirectionTopLeftToBottomRight.ItemClick += BarButtonItemDirectionTopLeftToBottomRight_ItemClick;
            barButtonItemDirectionTopRightToBottomLeft.ItemClick += BarButtonItemDirectionTopRightToBottomLeft_ItemClick;
            newScanModule.GotoTabButtonClicked += NewScanModule_GotoTabButtonClicked;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ViewModel.LoadDefaultSettings();
            newScanModule.InitializeControl(ViewModel.FileSystemScanService);
            resultsModule.InitializeControl(ViewModel.FileSystemScanService);
            filesModule.InitializeControl(ViewModel.FileSystemScanService);
            mapModule.InitializeControl(ViewModel.FileSystemScanService);
            analysisModule.InitializeControl(ViewModel.FileSystemScanService);
            ViewModel.CurrentModule = newScanModule;
        }

        private void NewScanModule_StartingScan(object sender, EventArgs e)
        {
            EnablePages(false);
        }

        private void NewScanModule_EndingScan(object sender, EventArgs e)
        {
            EnablePages(true);
            resultsModule.RefreshModuleData();
            filesModule.RefreshModuleData();
            mapModule.RefreshModuleData();
            analysisModule.RefreshModuleData();
        }

        private void EnablePages(bool enabled)
        {
            foreach (DevExpress.XtraTab.XtraTabPage tab in tabControl.TabPages)
                if (tab.Text != "New Scan") tab.PageEnabled = enabled;
        }

        private void NewAppBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewWamby();
        }

        private void OpenNewWamby()
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void TabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            SetCurrentModule(e.Page.Name);
            ShowCurrentModuleToolbars();
        }

        private void SetCurrentModule(string moduleName)
        {
            if (moduleName == tabPageNewScan.Name) ViewModel.CurrentModule = newScanModule;
            if (moduleName == tabPageResults.Name) ViewModel.CurrentModule = resultsModule;
            if (moduleName == tabPageFiles.Name) ViewModel.CurrentModule = filesModule;
            if (moduleName == tabPageMap.Name) ViewModel.CurrentModule = mapModule;
            if (moduleName == tabPageAnalysis.Name) ViewModel.CurrentModule = analysisModule;
        }

        private void ShowCurrentModuleToolbars()
        {
            ribbonPageGroupPrint.Visible = false;
            ribbonPageGroupResults.Visible = false;
            ribbonPageGroupMap.Visible = false;
            ribbonPageGroupAnalysis.Visible = false;
            if (ViewModel.CurrentModule is Interfaces.IModulePrintAndExport) ribbonPageGroupPrint.Visible = true;
            if (ViewModel.CurrentModule is Interfaces.IModuleResults) ribbonPageGroupResults.Visible = true;
            if (ViewModel.CurrentModule is Interfaces.IModuleMap) ribbonPageGroupMap.Visible = true;
            if (ViewModel.CurrentModule is Interfaces.IAnalysisMap) ribbonPageGroupMap.Visible = true;
        }

        private void NewScanModule_GotoTabButtonClicked(object sender, Args.GotoTabButtonEventArgs e)
        {
            if (e.TabName == tabPageResults.Name) tabControl.SelectedTabPage = tabPageResults;
            if (e.TabName == tabPageFiles.Name) tabControl.SelectedTabPage = tabPageFiles;
            if (e.TabName == tabPageMap.Name) tabControl.SelectedTabPage = tabPageMap;
            if (e.TabName == tabPageAnalysis.Name) tabControl.SelectedTabPage = tabPageAnalysis;
            if (e.TabName == tabPageErrors.Name) tabControl.SelectedTabPage = tabPageErrors;
        }

        private void ShowNewScanModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageNewScan;
        }

        private void ShowResultsModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageResults;
        }

        private void ShowFilesModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageFiles;
        }

        private void ShowMapModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageMap;
        }

        private void ShowAnalyzeModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageAnalysis;
        }

        private void ShowErrorsModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageErrors;
        }

        private void ShowScheduleModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageSchedule;
        }

        private void ShowSettingsModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageSettings;
        }

        private void BarButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModulePrintAndExport)?.Print();
        }

        private void BarButtonItemExportXls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModulePrintAndExport)?.ExportToXls();
        }

        private void BarButtonItemExportPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModulePrintAndExport)?.ExportToPdf();
        }

        private void BarButtonItemExpandTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleResults)?.ExpandTree();
        }

        private void BarButtonItemCollapse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleResults)?.CollapseTree();
        }

        private void BarButtonItemExpandLevel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleResults)?.
                ExpandTreeToLevel(Convert.ToInt32(e.Item.Tag) - 1);
        }

        private void BarCheckItemMapBySize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetMapByDataMember(Enums.MapValueDataMemberEnum.Size);
        }

        private void BarCheckItemMapByFilesCount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                   SetMapByDataMember(Enums.MapValueDataMemberEnum.FilesCount);
        }

        private void BarButtonItemLayoutAlgorithmSliceAndDice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum.SliceAndDice);
        }

        private void BarButtonItemLayoutAlgorithmSquarified_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum.Squarified);
        }

        private void BarButtonItemLayoutAlgorithmStriped_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum.Striped);
        }

        private void BarButtonItemDirectionBottomLeftToTopRight_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.BottomLeftToTopRight);
        }

        private void BarButtonItemDirectionBottomRightToTopLeft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.BottomRightToTopLeft);
        }

        private void BarButtonItemDirectionTopLeftToBottomRight_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.TopLeftToBottomRight);
        }

        private void BarButtonItemDirectionTopRightToBottomLeft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModuleMap)?.
                SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.TopRightToBottomLeft);
        }
    }
}