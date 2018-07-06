namespace Wamby.Client
{
    partial class MainRibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbonForm));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageNewScan = new DevExpress.XtraTab.XtraTabPage();
            this.newScanModule = new Wamby.Client.Modules.NewScanModule();
            this.tabPageResults = new DevExpress.XtraTab.XtraTabPage();
            this.resultsModule = new Wamby.Client.Modules.ResultsModule();
            this.tabPageFiles = new DevExpress.XtraTab.XtraTabPage();
            this.filesModule = new Wamby.Client.Modules.FilesModule();
            this.tabPageMap = new DevExpress.XtraTab.XtraTabPage();
            this.mapModule = new Wamby.Client.Modules.MapModule();
            this.tabPageAnalysis = new DevExpress.XtraTab.XtraTabPage();
            this.analysisModule = new Wamby.Client.Modules.AnalysisModule();
            this.tabPageErrors = new DevExpress.XtraTab.XtraTabPage();
            this.errorsModule = new Wamby.Client.Modules.ErrorsModule();
            this.tabPageSchedule = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageSettings = new DevExpress.XtraTab.XtraTabPage();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.newAppBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportXls = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDoScan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancelScan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupPrint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementFileSystem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showNewScanModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showResultsModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showFilesModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showMapModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showAnalyzeModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showErrorsModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementOptions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showScheduleModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showSettingsModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageNewScan.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageAnalysis.SuspendLayout();
            this.tabPageErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.tabControl);
            this.fluentDesignFormContainer1.Controls.Add(this.ribbon);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 30);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1258, 727);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabPageNewScan;
            this.tabControl.Size = new System.Drawing.Size(1258, 696);
            this.tabControl.TabIndex = 3;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageNewScan,
            this.tabPageResults,
            this.tabPageFiles,
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
            this.tabPageNewScan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabPageNewScan.ImageOptions.SvgImage")));
            this.tabPageNewScan.Name = "tabPageNewScan";
            this.tabPageNewScan.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            this.tabPageNewScan.Size = new System.Drawing.Size(1256, 648);
            this.tabPageNewScan.Text = "New Scan";
            // 
            // newScanModule
            // 
            this.newScanModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newScanModule.InitialFolderPath = null;
            this.newScanModule.Location = new System.Drawing.Point(0, 0);
            this.newScanModule.Name = "newScanModule";
            this.newScanModule.Size = new System.Drawing.Size(1256, 648);
            this.newScanModule.TabIndex = 0;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.resultsModule);
            this.tabPageResults.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.mainResultsModule;
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Size = new System.Drawing.Size(1256, 648);
            this.tabPageResults.Text = "Results";
            // 
            // resultsModule
            // 
            this.resultsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsModule.Location = new System.Drawing.Point(0, 0);
            this.resultsModule.Name = "resultsModule";
            this.resultsModule.Padding = new System.Windows.Forms.Padding(3);
            this.resultsModule.Size = new System.Drawing.Size(1256, 648);
            this.resultsModule.TabIndex = 0;
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.filesModule);
            this.tabPageFiles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabPageFiles.ImageOptions.SvgImage")));
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(1256, 648);
            this.tabPageFiles.Text = "Files";
            // 
            // filesModule
            // 
            this.filesModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesModule.Location = new System.Drawing.Point(3, 3);
            this.filesModule.Name = "filesModule";
            this.filesModule.Size = new System.Drawing.Size(1250, 642);
            this.filesModule.TabIndex = 0;
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.mapModule);
            this.tabPageMap.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.mainMapModule;
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Size = new System.Drawing.Size(1256, 648);
            this.tabPageMap.Text = "Map";
            // 
            // mapModule
            // 
            this.mapModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapModule.Location = new System.Drawing.Point(0, 0);
            this.mapModule.Name = "mapModule";
            this.mapModule.Padding = new System.Windows.Forms.Padding(3);
            this.mapModule.Size = new System.Drawing.Size(1256, 648);
            this.mapModule.TabIndex = 0;
            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.Controls.Add(this.analysisModule);
            this.tabPageAnalysis.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.mainAnalysisModule;
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Size = new System.Drawing.Size(1256, 648);
            this.tabPageAnalysis.Text = "Analyze";
            // 
            // analysisModule
            // 
            this.analysisModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisModule.Location = new System.Drawing.Point(0, 0);
            this.analysisModule.Name = "analysisModule";
            this.analysisModule.Padding = new System.Windows.Forms.Padding(3);
            this.analysisModule.Size = new System.Drawing.Size(1256, 648);
            this.analysisModule.TabIndex = 0;
            // 
            // tabPageErrors
            // 
            this.tabPageErrors.Controls.Add(this.errorsModule);
            this.tabPageErrors.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabPageErrors.ImageOptions.SvgImage")));
            this.tabPageErrors.Name = "tabPageErrors";
            this.tabPageErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageErrors.Size = new System.Drawing.Size(1256, 648);
            this.tabPageErrors.Text = "Errors";
            // 
            // errorsModule
            // 
            this.errorsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsModule.Location = new System.Drawing.Point(3, 3);
            this.errorsModule.Name = "errorsModule";
            this.errorsModule.Size = new System.Drawing.Size(1250, 642);
            this.errorsModule.TabIndex = 0;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabPageSchedule.ImageOptions.SvgImage")));
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Size = new System.Drawing.Size(1256, 648);
            this.tabPageSchedule.Text = "Schedule";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabPageSettings.ImageOptions.SvgImage")));
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(1256, 648);
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
            this.barButtonItemOpen,
            this.barButtonItemSave,
            this.barButtonItemDoScan,
            this.barButtonItemCancelScan});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 36;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(1258, 31);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 1;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            this.skinDropDownButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // barButtonItemOpen
            // 
            this.barButtonItemOpen.Caption = "Open scan...";
            this.barButtonItemOpen.Id = 32;
            this.barButtonItemOpen.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Open;
            this.barButtonItemOpen.Name = "barButtonItemOpen";
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Save scan...";
            this.barButtonItemSave.Id = 33;
            this.barButtonItemSave.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Save;
            this.barButtonItemSave.Name = "barButtonItemSave";
            // 
            // barButtonItemDoScan
            // 
            this.barButtonItemDoScan.Caption = "Scan now";
            this.barButtonItemDoScan.Id = 34;
            this.barButtonItemDoScan.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.NewScan_ScanNow;
            this.barButtonItemDoScan.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barButtonItemDoScan.Name = "barButtonItemDoScan";
            // 
            // barButtonItemCancelScan
            // 
            this.barButtonItemCancelScan.Caption = "Cancel scan";
            this.barButtonItemCancelScan.Id = 35;
            this.barButtonItemCancelScan.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.NewScan_CancelScan;
            this.barButtonItemCancelScan.Name = "barButtonItemCancelScan";
            this.barButtonItemCancelScan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupMain,
            this.ribbonPageGroupSkins,
            this.ribbonPageGroupPrint});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Main Page";
            // 
            // ribbonPageGroupMain
            // 
            this.ribbonPageGroupMain.ItemLinks.Add(this.newAppBarButtonItem);
            this.ribbonPageGroupMain.ItemLinks.Add(this.barButtonItemOpen);
            this.ribbonPageGroupMain.ItemLinks.Add(this.barButtonItemSave);
            this.ribbonPageGroupMain.ItemLinks.Add(this.barButtonItemDoScan, true);
            this.ribbonPageGroupMain.ItemLinks.Add(this.barButtonItemCancelScan);
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
            // accordionControl
            // 
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementFileSystem,
            this.accordionControlElementOptions});
            this.accordionControl.Location = new System.Drawing.Point(0, 30);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.OptionsMinimizing.NormalWidth = 260;
            this.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl.Size = new System.Drawing.Size(260, 727);
            this.accordionControl.TabIndex = 1;
            this.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementFileSystem
            // 
            this.accordionControlElementFileSystem.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.showNewScanModule,
            this.showResultsModule,
            this.showFilesModule,
            this.showMapModule,
            this.showAnalyzeModule,
            this.showErrorsModule});
            this.accordionControlElementFileSystem.Expanded = true;
            this.accordionControlElementFileSystem.Name = "accordionControlElementFileSystem";
            this.accordionControlElementFileSystem.Text = "File System";
            // 
            // showNewScanModule
            // 
            this.showNewScanModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showNewScanModule.ImageOptions.SvgImage")));
            this.showNewScanModule.Name = "showNewScanModule";
            this.showNewScanModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showNewScanModule.Text = "New Scan";
            // 
            // showResultsModule
            // 
            this.showResultsModule.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.mainResultsModule;
            this.showResultsModule.Name = "showResultsModule";
            this.showResultsModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showResultsModule.Text = "Results";
            // 
            // showFilesModule
            // 
            this.showFilesModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showFilesModule.ImageOptions.SvgImage")));
            this.showFilesModule.Name = "showFilesModule";
            this.showFilesModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showFilesModule.Text = "Files";
            // 
            // showMapModule
            // 
            this.showMapModule.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.mainMapModule;
            this.showMapModule.Name = "showMapModule";
            this.showMapModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showMapModule.Text = "Map";
            // 
            // showAnalyzeModule
            // 
            this.showAnalyzeModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showAnalyzeModule.ImageOptions.SvgImage")));
            this.showAnalyzeModule.Name = "showAnalyzeModule";
            this.showAnalyzeModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showAnalyzeModule.Text = "Analyze";
            // 
            // showErrorsModule
            // 
            this.showErrorsModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showErrorsModule.ImageOptions.SvgImage")));
            this.showErrorsModule.Name = "showErrorsModule";
            this.showErrorsModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showErrorsModule.Text = "Errors";
            // 
            // accordionControlElementOptions
            // 
            this.accordionControlElementOptions.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.showScheduleModule,
            this.showSettingsModule});
            this.accordionControlElementOptions.Expanded = true;
            this.accordionControlElementOptions.Name = "accordionControlElementOptions";
            this.accordionControlElementOptions.Text = "Options";
            // 
            // showScheduleModule
            // 
            this.showScheduleModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showScheduleModule.ImageOptions.SvgImage")));
            this.showScheduleModule.Name = "showScheduleModule";
            this.showScheduleModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showScheduleModule.Text = "Schedule";
            // 
            // showSettingsModule
            // 
            this.showSettingsModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showSettingsModule.ImageOptions.SvgImage")));
            this.showSettingsModule.Name = "showSettingsModule";
            this.showSettingsModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showSettingsModule.Text = "Settings";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1518, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // MainRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 757);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "MainRibbonForm";
            this.NavigationControl = this.accordionControl;
            this.Text = "xf";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageNewScan.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.tabPageFiles.ResumeLayout(false);
            this.tabPageMap.ResumeLayout(false);
            this.tabPageAnalysis.ResumeLayout(false);
            this.tabPageErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementFileSystem;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showNewScanModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementOptions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showScheduleModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showResultsModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showMapModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showAnalyzeModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showErrorsModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showSettingsModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showFilesModule;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem newAppBarButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportXls;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportPdf;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPrint;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabPageNewScan;
        private Modules.NewScanModule newScanModule;
        private DevExpress.XtraTab.XtraTabPage tabPageResults;
        private Modules.ResultsModule resultsModule;
        private DevExpress.XtraTab.XtraTabPage tabPageMap;
        private Modules.MapModule mapModule;
        private DevExpress.XtraTab.XtraTabPage tabPageAnalysis;
        private Modules.AnalysisModule analysisModule;
        private DevExpress.XtraTab.XtraTabPage tabPageErrors;
        private DevExpress.XtraTab.XtraTabPage tabPageSchedule;
        private DevExpress.XtraTab.XtraTabPage tabPageSettings;
        private DevExpress.XtraTab.XtraTabPage tabPageFiles;
        private Modules.FilesModule filesModule;
        private Modules.ErrorsModule errorsModule;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpen;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDoScan;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancelScan;
    }
}