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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbonForm));
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            tabControl = new DevExpress.XtraTab.XtraTabControl();
            tabPageNewScan = new DevExpress.XtraTab.XtraTabPage();
            newScanModule = new Modules.NewScanModule();
            tabPageResults = new DevExpress.XtraTab.XtraTabPage();
            resultsModule = new Modules.ResultsModule();
            tabPageFiles = new DevExpress.XtraTab.XtraTabPage();
            filesModule = new Modules.FilesModule();
            tabPageMap = new DevExpress.XtraTab.XtraTabPage();
            mapModule = new Modules.MapModule();
            tabPageAnalysis = new DevExpress.XtraTab.XtraTabPage();
            analysisModule = new Modules.AnalysisModule();
            tabPageErrors = new DevExpress.XtraTab.XtraTabPage();
            errorsModule = new Modules.ErrorsModule();
            tabPageSchedule = new DevExpress.XtraTab.XtraTabPage();
            tabPageSettings = new DevExpress.XtraTab.XtraTabPage();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            barStaticItemStatusMessage = new DevExpress.XtraBars.BarStaticItem();
            barButtonItemGoToResultsModule = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemGoToErrorsModule = new DevExpress.XtraBars.BarButtonItem();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            newAppBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemExportXls = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemExportPdf = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemOpen = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDoScan = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemCancelScan = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroupMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroupPrint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElementFileSystem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showNewScanModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showResultsModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showFilesModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showMapModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showAnalyzeModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showErrorsModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementOptions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showScheduleModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            showSettingsModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControl).BeginInit();
            tabControl.SuspendLayout();
            tabPageNewScan.SuspendLayout();
            tabPageResults.SuspendLayout();
            tabPageFiles.SuspendLayout();
            tabPageMap.SuspendLayout();
            tabPageAnalysis.SuspendLayout();
            tabPageErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(tabControl);
            fluentDesignFormContainer1.Controls.Add(ribbonStatusBar);
            fluentDesignFormContainer1.Controls.Add(ribbon);
            fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 33);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new System.Drawing.Size(1254, 722);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 38);
            tabControl.Name = "tabControl";
            tabControl.SelectedTabPage = tabPageNewScan;
            tabControl.Size = new System.Drawing.Size(1254, 647);
            tabControl.TabIndex = 3;
            tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabPageNewScan, tabPageResults, tabPageFiles, tabPageMap, tabPageAnalysis, tabPageErrors, tabPageSchedule, tabPageSettings });
            tabControl.TabPageWidth = 90;
            // 
            // tabPageNewScan
            // 
            tabPageNewScan.Controls.Add(newScanModule);
            tabPageNewScan.Name = "tabPageNewScan";
            tabPageNewScan.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            tabPageNewScan.Size = new System.Drawing.Size(1252, 616);
            tabPageNewScan.Text = "New Scan";
            // 
            // newScanModule
            // 
            newScanModule.Dock = System.Windows.Forms.DockStyle.Fill;
            newScanModule.Location = new System.Drawing.Point(0, 0);
            newScanModule.Name = "newScanModule";
            newScanModule.Size = new System.Drawing.Size(1252, 616);
            newScanModule.TabIndex = 0;
            // 
            // tabPageResults
            // 
            tabPageResults.Controls.Add(resultsModule);
            tabPageResults.Name = "tabPageResults";
            tabPageResults.Size = new System.Drawing.Size(1252, 616);
            tabPageResults.Text = "Results";
            // 
            // resultsModule
            // 
            resultsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            resultsModule.Location = new System.Drawing.Point(0, 0);
            resultsModule.Name = "resultsModule";
            resultsModule.Padding = new System.Windows.Forms.Padding(3);
            resultsModule.Size = new System.Drawing.Size(1252, 616);
            resultsModule.TabIndex = 0;
            // 
            // tabPageFiles
            // 
            tabPageFiles.Controls.Add(filesModule);
            tabPageFiles.Name = "tabPageFiles";
            tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            tabPageFiles.Size = new System.Drawing.Size(1252, 639);
            tabPageFiles.Text = "Files";
            // 
            // filesModule
            // 
            filesModule.Dock = System.Windows.Forms.DockStyle.Fill;
            filesModule.Location = new System.Drawing.Point(3, 3);
            filesModule.Name = "filesModule";
            filesModule.Size = new System.Drawing.Size(1246, 633);
            filesModule.TabIndex = 0;
            // 
            // tabPageMap
            // 
            tabPageMap.Controls.Add(mapModule);
            tabPageMap.Name = "tabPageMap";
            tabPageMap.Size = new System.Drawing.Size(1252, 639);
            tabPageMap.Text = "Map";
            // 
            // mapModule
            // 
            mapModule.Dock = System.Windows.Forms.DockStyle.Fill;
            mapModule.Location = new System.Drawing.Point(0, 0);
            mapModule.Name = "mapModule";
            mapModule.Padding = new System.Windows.Forms.Padding(3);
            mapModule.Size = new System.Drawing.Size(1252, 639);
            mapModule.TabIndex = 0;
            // 
            // tabPageAnalysis
            // 
            tabPageAnalysis.Controls.Add(analysisModule);
            tabPageAnalysis.Name = "tabPageAnalysis";
            tabPageAnalysis.Size = new System.Drawing.Size(1252, 639);
            tabPageAnalysis.Text = "Analyze";
            // 
            // analysisModule
            // 
            analysisModule.Dock = System.Windows.Forms.DockStyle.Fill;
            analysisModule.Location = new System.Drawing.Point(0, 0);
            analysisModule.Name = "analysisModule";
            analysisModule.Padding = new System.Windows.Forms.Padding(3);
            analysisModule.Size = new System.Drawing.Size(1252, 639);
            analysisModule.TabIndex = 0;
            // 
            // tabPageErrors
            // 
            tabPageErrors.Controls.Add(errorsModule);
            tabPageErrors.Name = "tabPageErrors";
            tabPageErrors.Padding = new System.Windows.Forms.Padding(3);
            tabPageErrors.Size = new System.Drawing.Size(1252, 639);
            tabPageErrors.Text = "Errors";
            // 
            // errorsModule
            // 
            errorsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            errorsModule.Location = new System.Drawing.Point(3, 3);
            errorsModule.Name = "errorsModule";
            errorsModule.Size = new System.Drawing.Size(1246, 633);
            errorsModule.TabIndex = 0;
            // 
            // tabPageSchedule
            // 
            tabPageSchedule.Name = "tabPageSchedule";
            tabPageSchedule.Size = new System.Drawing.Size(1252, 639);
            tabPageSchedule.Text = "Schedule";
            // 
            // tabPageSettings
            // 
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Size = new System.Drawing.Size(1252, 639);
            tabPageSettings.Text = "Settings";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.ItemLinks.Add(barStaticItemStatusMessage, true);
            ribbonStatusBar.ItemLinks.Add(barButtonItemGoToResultsModule);
            ribbonStatusBar.ItemLinks.Add(barButtonItemGoToErrorsModule);
            ribbonStatusBar.Location = new System.Drawing.Point(0, 685);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1254, 37);
            // 
            // barStaticItemStatusMessage
            // 
            barStaticItemStatusMessage.Caption = "Ready";
            barStaticItemStatusMessage.Id = 39;
            barStaticItemStatusMessage.Name = "barStaticItemStatusMessage";
            barStaticItemStatusMessage.Size = new System.Drawing.Size(100, 0);
            barStaticItemStatusMessage.Width = 100;
            // 
            // barButtonItemGoToResultsModule
            // 
            barButtonItemGoToResultsModule.Caption = "View Results";
            barButtonItemGoToResultsModule.Id = 42;
            barButtonItemGoToResultsModule.Name = "barButtonItemGoToResultsModule";
            barButtonItemGoToResultsModule.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItemGoToErrorsModule
            // 
            barButtonItemGoToErrorsModule.Caption = "Check errors";
            barButtonItemGoToErrorsModule.Id = 46;
            barButtonItemGoToErrorsModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemGoToErrorsModule.ImageOptions.SvgImage");
            barButtonItemGoToErrorsModule.Name = "barButtonItemGoToErrorsModule";
            barButtonItemGoToErrorsModule.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbon
            // 
            ribbon.AllowMinimizeRibbon = false;
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, skinDropDownButtonItem1, newAppBarButtonItem, skinPaletteRibbonGalleryBarItem1, barButtonItemPrint, barButtonItemExportXls, barButtonItemExportPdf, barButtonItemOpen, barButtonItemSave, barButtonItemDoScan, barButtonItemCancelScan });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 37;
            ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageMain });
            ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbon.Size = new System.Drawing.Size(1254, 38);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // skinDropDownButtonItem1
            // 
            skinDropDownButtonItem1.ActAsDropDown = true;
            skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinDropDownButtonItem1.Id = 1;
            skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // newAppBarButtonItem
            // 
            newAppBarButtonItem.Caption = "New Wamby";
            newAppBarButtonItem.Id = 2;
            newAppBarButtonItem.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("newAppBarButtonItem.ImageOptions.SvgImage");
            newAppBarButtonItem.Name = "newAppBarButtonItem";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            skinPaletteRibbonGalleryBarItem1.Caption = "Color Palette";
            skinPaletteRibbonGalleryBarItem1.Id = 3;
            skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // barButtonItemPrint
            // 
            barButtonItemPrint.Caption = "Print";
            barButtonItemPrint.Id = 4;
            barButtonItemPrint.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemPrint.ImageOptions.SvgImage");
            barButtonItemPrint.Name = "barButtonItemPrint";
            // 
            // barButtonItemExportXls
            // 
            barButtonItemExportXls.Caption = "Export Xls";
            barButtonItemExportXls.Id = 5;
            barButtonItemExportXls.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemExportXls.ImageOptions.SvgImage");
            barButtonItemExportXls.Name = "barButtonItemExportXls";
            // 
            // barButtonItemExportPdf
            // 
            barButtonItemExportPdf.Caption = "Export Pdf";
            barButtonItemExportPdf.Id = 6;
            barButtonItemExportPdf.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemExportPdf.ImageOptions.SvgImage");
            barButtonItemExportPdf.Name = "barButtonItemExportPdf";
            // 
            // barButtonItemOpen
            // 
            barButtonItemOpen.Caption = "Open scan...";
            barButtonItemOpen.Id = 32;
            barButtonItemOpen.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemOpen.ImageOptions.SvgImage");
            barButtonItemOpen.Name = "barButtonItemOpen";
            // 
            // barButtonItemSave
            // 
            barButtonItemSave.Caption = "Save scan...";
            barButtonItemSave.Id = 33;
            barButtonItemSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemSave.ImageOptions.SvgImage");
            barButtonItemSave.Name = "barButtonItemSave";
            // 
            // barButtonItemDoScan
            // 
            barButtonItemDoScan.Caption = "Scan now";
            barButtonItemDoScan.Id = 34;
            barButtonItemDoScan.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemDoScan.ImageOptions.SvgImage");
            barButtonItemDoScan.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            barButtonItemDoScan.Name = "barButtonItemDoScan";
            // 
            // barButtonItemCancelScan
            // 
            barButtonItemCancelScan.Caption = "Cancel scan";
            barButtonItemCancelScan.Id = 35;
            barButtonItemCancelScan.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemCancelScan.ImageOptions.SvgImage");
            barButtonItemCancelScan.Name = "barButtonItemCancelScan";
            barButtonItemCancelScan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbonPageMain
            // 
            ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroupMain, ribbonPageGroupSkins, ribbonPageGroupPrint });
            ribbonPageMain.Name = "ribbonPageMain";
            ribbonPageMain.Text = "Main Page";
            // 
            // ribbonPageGroupMain
            // 
            ribbonPageGroupMain.ItemLinks.Add(newAppBarButtonItem);
            ribbonPageGroupMain.ItemLinks.Add(barButtonItemOpen);
            ribbonPageGroupMain.ItemLinks.Add(barButtonItemSave);
            ribbonPageGroupMain.ItemLinks.Add(barButtonItemDoScan, true);
            ribbonPageGroupMain.ItemLinks.Add(barButtonItemCancelScan);
            ribbonPageGroupMain.Name = "ribbonPageGroupMain";
            ribbonPageGroupMain.Text = "Main";
            // 
            // ribbonPageGroupSkins
            // 
            ribbonPageGroupSkins.ItemLinks.Add(skinDropDownButtonItem1);
            ribbonPageGroupSkins.ItemLinks.Add(skinPaletteRibbonGalleryBarItem1);
            ribbonPageGroupSkins.Name = "ribbonPageGroupSkins";
            ribbonPageGroupSkins.Text = "Skins";
            // 
            // ribbonPageGroupPrint
            // 
            ribbonPageGroupPrint.ItemLinks.Add(barButtonItemPrint);
            ribbonPageGroupPrint.ItemLinks.Add(barButtonItemExportXls);
            ribbonPageGroupPrint.ItemLinks.Add(barButtonItemExportPdf);
            ribbonPageGroupPrint.Name = "ribbonPageGroupPrint";
            ribbonPageGroupPrint.Text = "Print Main";
            ribbonPageGroupPrint.Visible = false;
            // 
            // accordionControl
            // 
            accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElementFileSystem, accordionControlElementOptions });
            accordionControl.Location = new System.Drawing.Point(0, 33);
            accordionControl.Name = "accordionControl";
            accordionControl.OptionsMinimizing.NormalWidth = 260;
            accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl.Size = new System.Drawing.Size(260, 722);
            accordionControl.TabIndex = 1;
            accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementFileSystem
            // 
            accordionControlElementFileSystem.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { showNewScanModule, showResultsModule, showFilesModule, showMapModule, showAnalyzeModule, showErrorsModule });
            accordionControlElementFileSystem.Expanded = true;
            accordionControlElementFileSystem.Name = "accordionControlElementFileSystem";
            accordionControlElementFileSystem.Text = "File System";
            // 
            // showNewScanModule
            // 
            showNewScanModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showNewScanModule.ImageOptions.SvgImage");
            showNewScanModule.Name = "showNewScanModule";
            showNewScanModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showNewScanModule.Text = "New Scan";
            // 
            // showResultsModule
            // 
            showResultsModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showResultsModule.ImageOptions.SvgImage");
            showResultsModule.Name = "showResultsModule";
            showResultsModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showResultsModule.Text = "Results";
            // 
            // showFilesModule
            // 
            showFilesModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showFilesModule.ImageOptions.SvgImage");
            showFilesModule.Name = "showFilesModule";
            showFilesModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showFilesModule.Text = "Files";
            // 
            // showMapModule
            // 
            showMapModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showMapModule.ImageOptions.SvgImage");
            showMapModule.Name = "showMapModule";
            showMapModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showMapModule.Text = "Map";
            // 
            // showAnalyzeModule
            // 
            showAnalyzeModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showAnalyzeModule.ImageOptions.SvgImage");
            showAnalyzeModule.Name = "showAnalyzeModule";
            showAnalyzeModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showAnalyzeModule.Text = "Analyze";
            // 
            // showErrorsModule
            // 
            showErrorsModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showErrorsModule.ImageOptions.SvgImage");
            showErrorsModule.Name = "showErrorsModule";
            showErrorsModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showErrorsModule.Text = "Errors";
            // 
            // accordionControlElementOptions
            // 
            accordionControlElementOptions.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { showScheduleModule, showSettingsModule });
            accordionControlElementOptions.Expanded = true;
            accordionControlElementOptions.Name = "accordionControlElementOptions";
            accordionControlElementOptions.Text = "Options";
            // 
            // showScheduleModule
            // 
            showScheduleModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showScheduleModule.ImageOptions.SvgImage");
            showScheduleModule.Name = "showScheduleModule";
            showScheduleModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showScheduleModule.Text = "Schedule";
            // 
            // showSettingsModule
            // 
            showSettingsModule.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("showSettingsModule.ImageOptions.SvgImage");
            showSettingsModule.Name = "showSettingsModule";
            showSettingsModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            showSettingsModule.Text = "Settings";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1514, 33);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // MainRibbonForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1514, 755);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MainRibbonForm.IconOptions.SvgImage");
            Name = "MainRibbonForm";
            NavigationControl = accordionControl;
            Text = "xf";
            TransparencyKey = System.Drawing.Color.FromArgb(250, 250, 255);
            fluentDesignFormContainer1.ResumeLayout(false);
            fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabControl).EndInit();
            tabControl.ResumeLayout(false);
            tabPageNewScan.ResumeLayout(false);
            tabPageResults.ResumeLayout(false);
            tabPageFiles.ResumeLayout(false);
            tabPageMap.ResumeLayout(false);
            tabPageAnalysis.ResumeLayout(false);
            tabPageErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ResumeLayout(false);
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
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem barStaticItemStatusMessage;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGoToResultsModule;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGoToErrorsModule;
    }
}