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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.newAppBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageNewScan = new DevExpress.XtraTab.XtraTabPage();
            this.newScanModule = new Wamby.Client.Modules.NewScanModule();
            this.tabPageResults = new DevExpress.XtraTab.XtraTabPage();
            this.resultsModule = new Wamby.Client.Modules.ResultsModule();
            this.tabPageMap = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageAnalysis = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageErrors = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageSchedule = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageSettings = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageNewScan.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinDropDownButtonItem1,
            this.newAppBarButtonItem,
            this.skinPaletteRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(829, 61);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.newAppBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 61);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabPageNewScan;
            this.tabControl.Size = new System.Drawing.Size(829, 513);
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
            this.tabPageNewScan.Size = new System.Drawing.Size(827, 465);
            this.tabPageNewScan.Text = "New Scan";
            // 
            // newScanModule
            // 
            this.newScanModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newScanModule.Location = new System.Drawing.Point(0, 0);
            this.newScanModule.Name = "newScanModule";
            this.newScanModule.Size = new System.Drawing.Size(827, 465);
            this.newScanModule.TabIndex = 0;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.resultsModule);
            this.tabPageResults.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Results;
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Size = new System.Drawing.Size(827, 465);
            this.tabPageResults.Text = "Results";
            // 
            // resultsModule
            // 
            this.resultsModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsModule.Location = new System.Drawing.Point(0, 0);
            this.resultsModule.Name = "resultsModule";
            this.resultsModule.Padding = new System.Windows.Forms.Padding(3);
            this.resultsModule.Size = new System.Drawing.Size(827, 465);
            this.resultsModule.TabIndex = 0;
            // 
            // tabPageMap
            // 
            this.tabPageMap.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map;
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Size = new System.Drawing.Size(827, 465);
            this.tabPageMap.Text = "Map";
            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Analyze;
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Size = new System.Drawing.Size(827, 465);
            this.tabPageAnalysis.Text = "Analyze";
            // 
            // tabPageErrors
            // 
            this.tabPageErrors.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Errors;
            this.tabPageErrors.Name = "tabPageErrors";
            this.tabPageErrors.Size = new System.Drawing.Size(827, 465);
            this.tabPageErrors.Text = "Errors";
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Schedule;
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Size = new System.Drawing.Size(827, 465);
            this.tabPageSchedule.Text = "Schedule";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Settings;
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(827, 465);
            this.tabPageSettings.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 574);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.Text = "Wamby?";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageNewScan.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabPageNewScan;
        private DevExpress.XtraTab.XtraTabPage tabPageResults;
        private DevExpress.XtraTab.XtraTabPage tabPageMap;
        private DevExpress.XtraTab.XtraTabPage tabPageAnalysis;
        private DevExpress.XtraTab.XtraTabPage tabPageErrors;
        private DevExpress.XtraBars.BarButtonItem newAppBarButtonItem;
        private Modules.NewScanModule newScanModule;
        private DevExpress.XtraTab.XtraTabPage tabPageSchedule;
        private DevExpress.XtraTab.XtraTabPage tabPageSettings;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private Modules.ResultsModule resultsModule;
    }
}