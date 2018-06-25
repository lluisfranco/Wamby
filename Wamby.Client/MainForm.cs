using System;
using System.Windows.Forms;
using Wamby.API.Services;

namespace Wamby.Client
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewModels.MainFormViewModel ViewModel { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Wamby_App_Icon;
            ViewModel = new ViewModels.MainFormViewModel(new FileSystemScanService());
            setEventHandlers();
        }

        private void setEventHandlers()
        {
            Shown += MainForm_Shown;
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
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ViewModel.LoadDefaultSettings();
            newScanModule.InitializeControl(ViewModel.FileSystemScanService);
            resultsModule.InitializeControl(ViewModel.FileSystemScanService);
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
            setCurrentModule(e.Page.Name);
            showCurrentModuleToolbars();
        }

        private void setCurrentModule(string moduleName)
        {
            if (moduleName == tabPageNewScan.Name) ViewModel.CurrentModule = newScanModule;
            if (moduleName == tabPageResults.Name) ViewModel.CurrentModule = resultsModule;
            if (moduleName == tabPageMap.Name) ViewModel.CurrentModule = mapModule;
            if (moduleName == tabPageAnalysis.Name) ViewModel.CurrentModule = analysisModule;
        }

        private void showCurrentModuleToolbars()
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