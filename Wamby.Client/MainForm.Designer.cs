namespace Wamby.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageNewScan = new DevExpress.XtraTab.XtraTabPage();
            this.newScanModule = new Wamby.Client.Modules.NewScanModule();
            this.tabPageResults = new DevExpress.XtraTab.XtraTabPage();
            this.resultsModule = new Wamby.Client.Modules.ResultsModule();
            this.tabPageMap = new DevExpress.XtraTab.XtraTabPage();
            this.mapModule = new Wamby.Client.Modules.MapModule();
            this.tabPageAnalysis = new DevExpress.XtraTab.XtraTabPage();
            this.analysisModule = new Wamby.Client.Modules.AnalysisModule();
            this.tabPageErrors = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageSchedule = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageSettings = new DevExpress.XtraTab.XtraTabPage();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.newAppBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportXls = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandTree = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemExpandLevel = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemExpandLevel1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemLayoutAlgorithm = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemLayoutAlgorithmSliceAndDice = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLayoutAlgorithmSquarified = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLayoutAlgorithmStriped = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemDirection = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemDirectionBottomLeftToTopRight = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDirectionBottomRightToTopLeft = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDirectionTopLeftToBottomRight = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDirectionTopRightToBottomLeft = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItemMapBySize = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemMapByFilesCount = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemShowProperties = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemShowChart = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupPrint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupResults = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupFiles = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupMap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupAnalysis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageNewScan.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(0, 61);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabPageNewScan;
            this.tabControl.Size = new System.Drawing.Size(1223, 639);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageNewScan,
            this.tabPageResults,
            this.tabPageMap,
            this.tabPageAnalysis,
            this.tabPageErrors,
            this.tabPageSchedule,
            this.tabPageSettings});
            this.tabControl.TabPageWidth = 90;
            // 
            // tabPageNewScan
            // 
            this.tabPageNewScan.Controls.Add(this.newScanModule);
            this.tabPageNewScan.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.New_Scan;
            this.tabPageNewScan.Name = "tabPageNewScan";
            this.tabPageNewScan.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            this.tabPageNewScan.Size = new System.Drawing.Size(1221, 591);
            this.tabPageNewScan.Text = "New Scan";
            // 
            // newScanModule
            // 
            this.newScanModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newScanModule.Location = new System.Drawing.Point(0, 0);
            this.newScanModule.Name = "newScanModule";
            this.newScanModule.Size = new System.Drawing.Size(1221, 591);
            this.newScanModule.TabIndex = 0;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.resultsModule);
            this.tabPageResults.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Results;
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Size = new System.Drawing.Size(1221, 591);
            this.tabPageResults.Text = "Results";
            // 
            // resultsModule
            // 
            this.resultsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsModule.Location = new System.Drawing.Point(0, 0);
            this.resultsModule.Name = "resultsModule";
            this.resultsModule.Padding = new System.Windows.Forms.Padding(3);
            this.resultsModule.Size = new System.Drawing.Size(1221, 591);
            this.resultsModule.TabIndex = 0;
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.mapModule);
            this.tabPageMap.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map;
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Size = new System.Drawing.Size(1221, 591);
            this.tabPageMap.Text = "Map";
            // 
            // mapModule
            // 
            this.mapModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapModule.Location = new System.Drawing.Point(0, 0);
            this.mapModule.Name = "mapModule";
            this.mapModule.Padding = new System.Windows.Forms.Padding(3);
            this.mapModule.Size = new System.Drawing.Size(1221, 591);
            this.mapModule.TabIndex = 0;
            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.Controls.Add(this.analysisModule);
            this.tabPageAnalysis.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Analyze;
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Size = new System.Drawing.Size(1221, 591);
            this.tabPageAnalysis.Text = "Analyze";
            // 
            // analysisModule
            // 
            this.analysisModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisModule.Location = new System.Drawing.Point(0, 0);
            this.analysisModule.Name = "analysisModule";
            this.analysisModule.Padding = new System.Windows.Forms.Padding(3);
            this.analysisModule.Size = new System.Drawing.Size(1221, 591);
            this.analysisModule.TabIndex = 0;
            // 
            // tabPageErrors
            // 
            this.tabPageErrors.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Errors;
            this.tabPageErrors.Name = "tabPageErrors";
            this.tabPageErrors.Size = new System.Drawing.Size(1221, 591);
            this.tabPageErrors.Text = "Errors";
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Schedule;
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Size = new System.Drawing.Size(1221, 591);
            this.tabPageSchedule.Text = "Schedule";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Settings;
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(1221, 591);
            this.tabPageSettings.Text = "Settings";
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinDropDownButtonItem1,
            this.newAppBarButtonItem,
            this.skinPaletteRibbonGalleryBarItem1,
            this.barButtonItemPrint,
            this.barButtonItemExportXls,
            this.barButtonItemExportPdf,
            this.barButtonItemExpandTree,
            this.barButtonItemCollapse,
            this.barSubItemExpandLevel,
            this.barButtonItemExpandLevel1,
            this.barButtonItemExpandLevel2,
            this.barButtonItemExpandLevel3,
            this.barButtonItemExpandLevel4,
            this.barButtonItemExpandLevel5,
            this.barButtonItem6,
            this.barSubItemLayoutAlgorithm,
            this.barSubItemDirection,
            this.barCheckItemMapBySize,
            this.barCheckItemMapByFilesCount,
            this.barButtonItemLayoutAlgorithmSliceAndDice,
            this.barButtonItemLayoutAlgorithmSquarified,
            this.barButtonItemLayoutAlgorithmStriped,
            this.barButtonItemDirectionBottomLeftToTopRight,
            this.barButtonItemDirectionBottomRightToTopLeft,
            this.barButtonItemDirectionTopLeftToBottomRight,
            this.barButtonItemDirectionTopRightToBottomLeft,
            this.barCheckItemShowProperties,
            this.barCheckItemShowChart});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 32;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(1223, 61);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 1;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // newAppBarButtonItem
            // 
            this.newAppBarButtonItem.Caption = "New Wamby";
            this.newAppBarButtonItem.Id = 2;
            this.newAppBarButtonItem.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.New;
            this.newAppBarButtonItem.Name = "newAppBarButtonItem";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "Color Palette";
            this.skinPaletteRibbonGalleryBarItem1.Id = 3;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // barButtonItemPrint
            // 
            this.barButtonItemPrint.Caption = "Print";
            this.barButtonItemPrint.Id = 4;
            this.barButtonItemPrint.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Print_Preview;
            this.barButtonItemPrint.Name = "barButtonItemPrint";
            // 
            // barButtonItemExportXls
            // 
            this.barButtonItemExportXls.Caption = "Export Xls";
            this.barButtonItemExportXls.Id = 5;
            this.barButtonItemExportXls.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Export_To_Excel;
            this.barButtonItemExportXls.Name = "barButtonItemExportXls";
            // 
            // barButtonItemExportPdf
            // 
            this.barButtonItemExportPdf.Caption = "Export Pdf";
            this.barButtonItemExportPdf.Id = 6;
            this.barButtonItemExportPdf.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Export_To_Pdf;
            this.barButtonItemExportPdf.Name = "barButtonItemExportPdf";
            // 
            // barButtonItemExpandTree
            // 
            this.barButtonItemExpandTree.Caption = "Expand";
            this.barButtonItemExpandTree.Id = 7;
            this.barButtonItemExpandTree.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Expand;
            this.barButtonItemExpandTree.Name = "barButtonItemExpandTree";
            this.barButtonItemExpandTree.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemCollapse
            // 
            this.barButtonItemCollapse.Caption = "Collapse";
            this.barButtonItemCollapse.Id = 8;
            this.barButtonItemCollapse.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Compress;
            this.barButtonItemCollapse.Name = "barButtonItemCollapse";
            this.barButtonItemCollapse.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barSubItemExpandLevel
            // 
            this.barSubItemExpandLevel.Caption = "Expand level";
            this.barSubItemExpandLevel.Id = 10;
            this.barSubItemExpandLevel.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Expand_Level;
            this.barSubItemExpandLevel.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel5)});
            this.barSubItemExpandLevel.Name = "barSubItemExpandLevel";
            // 
            // barButtonItemExpandLevel1
            // 
            this.barButtonItemExpandLevel1.Caption = "Level 1";
            this.barButtonItemExpandLevel1.Id = 11;
            this.barButtonItemExpandLevel1.Name = "barButtonItemExpandLevel1";
            this.barButtonItemExpandLevel1.Tag = 1;
            // 
            // barButtonItemExpandLevel2
            // 
            this.barButtonItemExpandLevel2.Caption = "Level 2";
            this.barButtonItemExpandLevel2.Id = 12;
            this.barButtonItemExpandLevel2.Name = "barButtonItemExpandLevel2";
            this.barButtonItemExpandLevel2.Tag = 2;
            // 
            // barButtonItemExpandLevel3
            // 
            this.barButtonItemExpandLevel3.Caption = "Level 3";
            this.barButtonItemExpandLevel3.Id = 13;
            this.barButtonItemExpandLevel3.Name = "barButtonItemExpandLevel3";
            this.barButtonItemExpandLevel3.Tag = 3;
            // 
            // barButtonItemExpandLevel4
            // 
            this.barButtonItemExpandLevel4.Caption = "Level 4";
            this.barButtonItemExpandLevel4.Id = 14;
            this.barButtonItemExpandLevel4.Name = "barButtonItemExpandLevel4";
            this.barButtonItemExpandLevel4.Tag = 4;
            // 
            // barButtonItemExpandLevel5
            // 
            this.barButtonItemExpandLevel5.Caption = "Level 5";
            this.barButtonItemExpandLevel5.Id = 15;
            this.barButtonItemExpandLevel5.Name = "barButtonItemExpandLevel5";
            this.barButtonItemExpandLevel5.Tag = 5;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 16;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barSubItemLayoutAlgorithm
            // 
            this.barSubItemLayoutAlgorithm.Caption = "Layout algorithm";
            this.barSubItemLayoutAlgorithm.Id = 18;
            this.barSubItemLayoutAlgorithm.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_Layout;
            this.barSubItemLayoutAlgorithm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLayoutAlgorithmSliceAndDice),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLayoutAlgorithmSquarified),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLayoutAlgorithmStriped)});
            this.barSubItemLayoutAlgorithm.Name = "barSubItemLayoutAlgorithm";
            // 
            // barButtonItemLayoutAlgorithmSliceAndDice
            // 
            this.barButtonItemLayoutAlgorithmSliceAndDice.Caption = "Slice And Dice";
            this.barButtonItemLayoutAlgorithmSliceAndDice.Id = 23;
            this.barButtonItemLayoutAlgorithmSliceAndDice.Name = "barButtonItemLayoutAlgorithmSliceAndDice";
            // 
            // barButtonItemLayoutAlgorithmSquarified
            // 
            this.barButtonItemLayoutAlgorithmSquarified.Caption = "Squarified";
            this.barButtonItemLayoutAlgorithmSquarified.Id = 24;
            this.barButtonItemLayoutAlgorithmSquarified.Name = "barButtonItemLayoutAlgorithmSquarified";
            // 
            // barButtonItemLayoutAlgorithmStriped
            // 
            this.barButtonItemLayoutAlgorithmStriped.Caption = "Striped";
            this.barButtonItemLayoutAlgorithmStriped.Id = 25;
            this.barButtonItemLayoutAlgorithmStriped.Name = "barButtonItemLayoutAlgorithmStriped";
            // 
            // barSubItemDirection
            // 
            this.barSubItemDirection.Caption = "Direction";
            this.barSubItemDirection.Id = 19;
            this.barSubItemDirection.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_Direction;
            this.barSubItemDirection.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionBottomLeftToTopRight),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionBottomRightToTopLeft),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionTopLeftToBottomRight),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionTopRightToBottomLeft)});
            this.barSubItemDirection.Name = "barSubItemDirection";
            // 
            // barButtonItemDirectionBottomLeftToTopRight
            // 
            this.barButtonItemDirectionBottomLeftToTopRight.Caption = "Bottom Left To Top Right";
            this.barButtonItemDirectionBottomLeftToTopRight.Id = 26;
            this.barButtonItemDirectionBottomLeftToTopRight.Name = "barButtonItemDirectionBottomLeftToTopRight";
            // 
            // barButtonItemDirectionBottomRightToTopLeft
            // 
            this.barButtonItemDirectionBottomRightToTopLeft.Caption = "Bottom Right To Top Left";
            this.barButtonItemDirectionBottomRightToTopLeft.Id = 27;
            this.barButtonItemDirectionBottomRightToTopLeft.Name = "barButtonItemDirectionBottomRightToTopLeft";
            // 
            // barButtonItemDirectionTopLeftToBottomRight
            // 
            this.barButtonItemDirectionTopLeftToBottomRight.Caption = "Top Left To Bottom Right";
            this.barButtonItemDirectionTopLeftToBottomRight.Id = 28;
            this.barButtonItemDirectionTopLeftToBottomRight.Name = "barButtonItemDirectionTopLeftToBottomRight";
            // 
            // barButtonItemDirectionTopRightToBottomLeft
            // 
            this.barButtonItemDirectionTopRightToBottomLeft.Caption = "Top Right To Bottom Left";
            this.barButtonItemDirectionTopRightToBottomLeft.Id = 29;
            this.barButtonItemDirectionTopRightToBottomLeft.Name = "barButtonItemDirectionTopRightToBottomLeft";
            // 
            // barCheckItemMapBySize
            // 
            this.barCheckItemMapBySize.BindableChecked = true;
            this.barCheckItemMapBySize.Caption = "Size";
            this.barCheckItemMapBySize.Checked = true;
            this.barCheckItemMapBySize.GroupIndex = 1;
            this.barCheckItemMapBySize.Id = 20;
            this.barCheckItemMapBySize.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_By_Size;
            this.barCheckItemMapBySize.Name = "barCheckItemMapBySize";
            // 
            // barCheckItemMapByFilesCount
            // 
            this.barCheckItemMapByFilesCount.Caption = "Files Count";
            this.barCheckItemMapByFilesCount.GroupIndex = 1;
            this.barCheckItemMapByFilesCount.Id = 21;
            this.barCheckItemMapByFilesCount.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_By_FilesCount;
            this.barCheckItemMapByFilesCount.Name = "barCheckItemMapByFilesCount";
            // 
            // barCheckItemShowProperties
            // 
            this.barCheckItemShowProperties.BindableChecked = true;
            this.barCheckItemShowProperties.Caption = "Properties";
            this.barCheckItemShowProperties.Checked = true;
            this.barCheckItemShowProperties.Id = 30;
            this.barCheckItemShowProperties.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Analysis_Show_Properties;
            this.barCheckItemShowProperties.Name = "barCheckItemShowProperties";
            // 
            // barCheckItemShowChart
            // 
            this.barCheckItemShowChart.BindableChecked = true;
            this.barCheckItemShowChart.Caption = "Chart";
            this.barCheckItemShowChart.Checked = true;
            this.barCheckItemShowChart.Id = 31;
            this.barCheckItemShowChart.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Analysis_Show_Chart;
            this.barCheckItemShowChart.Name = "barCheckItemShowChart";
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupMain,
            this.ribbonPageGroupSkins,
            this.ribbonPageGroupPrint,
            this.ribbonPageGroupResults,
            this.ribbonPageGroupFiles,
            this.ribbonPageGroupMap,
            this.ribbonPageGroupAnalysis});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Main Page";
            // 
            // ribbonPageGroupMain
            // 
            this.ribbonPageGroupMain.ItemLinks.Add(this.newAppBarButtonItem);
            this.ribbonPageGroupMain.Name = "ribbonPageGroupMain";
            this.ribbonPageGroupMain.Text = "Main";
            // 
            // ribbonPageGroupSkins
            // 
            this.ribbonPageGroupSkins.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroupSkins.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroupSkins.Name = "ribbonPageGroupSkins";
            this.ribbonPageGroupSkins.Text = "Skins";
            // 
            // ribbonPageGroupPrint
            // 
            this.ribbonPageGroupPrint.ItemLinks.Add(this.barButtonItemPrint);
            this.ribbonPageGroupPrint.ItemLinks.Add(this.barButtonItemExportXls);
            this.ribbonPageGroupPrint.ItemLinks.Add(this.barButtonItemExportPdf);
            this.ribbonPageGroupPrint.Name = "ribbonPageGroupPrint";
            this.ribbonPageGroupPrint.Text = "Print Main";
            this.ribbonPageGroupPrint.Visible = false;
            // 
            // ribbonPageGroupResults
            // 
            this.ribbonPageGroupResults.ItemLinks.Add(this.barButtonItemExpandTree);
            this.ribbonPageGroupResults.ItemLinks.Add(this.barButtonItemCollapse);
            this.ribbonPageGroupResults.ItemLinks.Add(this.barSubItemExpandLevel, true);
            this.ribbonPageGroupResults.Name = "ribbonPageGroupResults";
            this.ribbonPageGroupResults.Text = "Results Main";
            this.ribbonPageGroupResults.Visible = false;
            // 
            // ribbonPageGroupFiles
            // 
            this.ribbonPageGroupFiles.Name = "ribbonPageGroupFiles";
            this.ribbonPageGroupFiles.Text = "Files Main";
            this.ribbonPageGroupFiles.Visible = false;
            // 
            // ribbonPageGroupMap
            // 
            this.ribbonPageGroupMap.ItemLinks.Add(this.barCheckItemMapBySize);
            this.ribbonPageGroupMap.ItemLinks.Add(this.barCheckItemMapByFilesCount);
            this.ribbonPageGroupMap.ItemLinks.Add(this.barSubItemLayoutAlgorithm, true);
            this.ribbonPageGroupMap.ItemLinks.Add(this.barSubItemDirection);
            this.ribbonPageGroupMap.Name = "ribbonPageGroupMap";
            this.ribbonPageGroupMap.Text = "Map Main";
            this.ribbonPageGroupMap.Visible = false;
            // 
            // ribbonPageGroupAnalysis
            // 
            this.ribbonPageGroupAnalysis.ItemLinks.Add(this.barCheckItemShowProperties);
            this.ribbonPageGroupAnalysis.ItemLinks.Add(this.barCheckItemShowChart);
            this.ribbonPageGroupAnalysis.Name = "ribbonPageGroupAnalysis";
            this.ribbonPageGroupAnalysis.Text = "Analysis Main";
            this.ribbonPageGroupAnalysis.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.Text = "Wamby?";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageNewScan.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.tabPageMap.ResumeLayout(false);
            this.tabPageAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabPageNewScan;
        private DevExpress.XtraTab.XtraTabPage tabPageResults;
        private DevExpress.XtraTab.XtraTabPage tabPageMap;
        private DevExpress.XtraTab.XtraTabPage tabPageAnalysis;
        private DevExpress.XtraTab.XtraTabPage tabPageErrors;
        private Modules.NewScanModule newScanModule;
        private DevExpress.XtraTab.XtraTabPage tabPageSchedule;
        private DevExpress.XtraTab.XtraTabPage tabPageSettings;
        private Modules.ResultsModule resultsModule;
        private Modules.MapModule mapModule;
        private Modules.AnalysisModule analysisModule;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem newAppBarButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportXls;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportPdf;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandTree;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCollapse;
        private DevExpress.XtraBars.BarSubItem barSubItemExpandLevel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarSubItem barSubItemLayoutAlgorithm;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLayoutAlgorithmSliceAndDice;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLayoutAlgorithmSquarified;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLayoutAlgorithmStriped;
        private DevExpress.XtraBars.BarSubItem barSubItemDirection;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionBottomLeftToTopRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionBottomRightToTopLeft;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionTopLeftToBottomRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionTopRightToBottomLeft;
        private DevExpress.XtraBars.BarCheckItem barCheckItemMapBySize;
        private DevExpress.XtraBars.BarCheckItem barCheckItemMapByFilesCount;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowProperties;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowChart;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupResults;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFiles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAnalysis;
    }
}