namespace Wamby.Client
{
    partial class NewScanForm
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
            barManager = new DevExpress.XtraBars.BarManager(components);
            bar = new DevExpress.XtraBars.Bar();
            barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemNewScan = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemCancelScan = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemChangeFolder = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            svgImageCollection16 = new DevExpress.Utils.SvgImageCollection(components);
            svgImageCollection32 = new DevExpress.Utils.SvgImageCollection(components);
            svgImageCollectionForm = new DevExpress.Utils.SvgImageCollection(components);
            navigationPane = new DevExpress.XtraBars.Navigation.NavigationPane();
            navigationPageScanFolder = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPageResults = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPageFiles = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPageMap = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPageAnalysis = new DevExpress.XtraBars.Navigation.NavigationPage();
            navigationPageErrors = new DevExpress.XtraBars.Navigation.NavigationPage();
            svgImageCollectionNavigation = new DevExpress.Utils.SvgImageCollection(components);
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)navigationPane).BeginInit();
            navigationPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionNavigation).BeginInit();
            SuspendLayout();
            // 
            // barManager
            // 
            barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar });
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.Form = this;
            barManager.Images = svgImageCollection16;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemNewScan, barButtonItemCancelScan, barButtonItemChangeFolder, barButtonItemSave });
            barManager.LargeImages = svgImageCollection16;
            barManager.MaxItemId = 4;
            // 
            // bar
            // 
            bar.BarName = "Tools";
            bar.DockCol = 0;
            bar.DockRow = 0;
            bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemSave), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemNewScan), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemCancelScan), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemChangeFolder, true) });
            bar.Text = "Tools";
            // 
            // barButtonItemSave
            // 
            barButtonItemSave.Caption = "Save As...";
            barButtonItemSave.Id = 3;
            barButtonItemSave.ImageOptions.ImageIndex = 3;
            barButtonItemSave.ImageOptions.LargeImageIndex = 3;
            barButtonItemSave.Name = "barButtonItemSave";
            // 
            // barButtonItemNewScan
            // 
            barButtonItemNewScan.Caption = "Scan";
            barButtonItemNewScan.Id = 0;
            barButtonItemNewScan.ImageOptions.ImageIndex = 2;
            barButtonItemNewScan.ImageOptions.LargeImageIndex = 2;
            barButtonItemNewScan.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            barButtonItemNewScan.Name = "barButtonItemNewScan";
            // 
            // barButtonItemCancelScan
            // 
            barButtonItemCancelScan.Caption = "Cancel";
            barButtonItemCancelScan.Id = 1;
            barButtonItemCancelScan.ImageOptions.ImageIndex = 0;
            barButtonItemCancelScan.ImageOptions.LargeImageIndex = 0;
            barButtonItemCancelScan.Name = "barButtonItemCancelScan";
            barButtonItemCancelScan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItemChangeFolder
            // 
            barButtonItemChangeFolder.Caption = "Change Folder...";
            barButtonItemChangeFolder.Id = 2;
            barButtonItemChangeFolder.ImageOptions.ImageIndex = 1;
            barButtonItemChangeFolder.ImageOptions.LargeImageIndex = 1;
            barButtonItemChangeFolder.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F);
            barButtonItemChangeFolder.Name = "barButtonItemChangeFolder";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager;
            barDockControlTop.Size = new System.Drawing.Size(764, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 528);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(764, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 504);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(764, 24);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 504);
            // 
            // svgImageCollection16
            // 
            svgImageCollection16.Add("RefreshCancel", "Wamby.Resources.Images.Actions.RefreshCancel.svg", "Wamby.Resources");
            svgImageCollection16.Add("ChangeFolder", "Wamby.Resources.Images.Actions.ChangeFolder.svg", "Wamby.Resources");
            svgImageCollection16.Add("Refresh", "Wamby.Resources.Images.Actions.Refresh.svg", "Wamby.Resources");
            svgImageCollection16.Add("Save", "Wamby.Resources.Images.Actions.Save.svg", "Wamby.Resources");
            // 
            // svgImageCollection32
            // 
            svgImageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            svgImageCollection32.Add("RefreshCancel", "Wamby.Resources.Images.Actions.RefreshCancel.svg", "Wamby.Resources");
            svgImageCollection32.Add("ChangeFolder", "Wamby.Resources.Images.Actions.ChangeFolder.svg", "Wamby.Resources");
            svgImageCollection32.Add("Refresh", "Wamby.Resources.Images.Actions.Refresh.svg", "Wamby.Resources");
            svgImageCollection32.Add("Save", "Wamby.Resources.Images.Actions.Save.svg", "Wamby.Resources");
            // 
            // svgImageCollectionForm
            // 
            svgImageCollectionForm.Add("Scan", "Wamby.Resources.Images.Menu.Scan.svg", "Wamby.Resources");
            // 
            // navigationPane
            // 
            navigationPane.Controls.Add(navigationPageScanFolder);
            navigationPane.Controls.Add(navigationPageResults);
            navigationPane.Controls.Add(navigationPageFiles);
            navigationPane.Controls.Add(navigationPageMap);
            navigationPane.Controls.Add(navigationPageAnalysis);
            navigationPane.Controls.Add(navigationPageErrors);
            navigationPane.Dock = System.Windows.Forms.DockStyle.Fill;
            navigationPane.Images = svgImageCollectionNavigation;
            navigationPane.Location = new System.Drawing.Point(0, 24);
            navigationPane.Name = "navigationPane";
            navigationPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { navigationPageScanFolder, navigationPageResults, navigationPageFiles, navigationPageMap, navigationPageAnalysis, navigationPageErrors });
            navigationPane.RegularSize = new System.Drawing.Size(764, 504);
            navigationPane.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            navigationPane.SelectedPage = navigationPageScanFolder;
            navigationPane.Size = new System.Drawing.Size(764, 504);
            navigationPane.TabIndex = 4;
            navigationPane.Text = "navigationPane1";
            // 
            // navigationPageScanFolder
            // 
            navigationPageScanFolder.Caption = "Scan Folder";
            navigationPageScanFolder.ImageOptions.ImageIndex = 0;
            navigationPageScanFolder.Name = "navigationPageScanFolder";
            navigationPageScanFolder.Size = new System.Drawing.Size(677, 431);
            navigationPageScanFolder.ToolTip = "Scan Folder";
            // 
            // navigationPageResults
            // 
            navigationPageResults.Caption = "Results";
            navigationPageResults.ImageOptions.ImageIndex = 1;
            navigationPageResults.Name = "navigationPageResults";
            navigationPageResults.PageEnabled = false;
            navigationPageResults.Size = new System.Drawing.Size(764, 504);
            navigationPageResults.ToolTip = "Results";
            // 
            // navigationPageFiles
            // 
            navigationPageFiles.Caption = "Files";
            navigationPageFiles.ImageOptions.ImageIndex = 2;
            navigationPageFiles.Name = "navigationPageFiles";
            navigationPageFiles.PageEnabled = false;
            navigationPageFiles.Size = new System.Drawing.Size(764, 504);
            navigationPageFiles.ToolTip = "Files";
            // 
            // navigationPageMap
            // 
            navigationPageMap.Caption = "Map";
            navigationPageMap.ImageOptions.ImageIndex = 3;
            navigationPageMap.Name = "navigationPageMap";
            navigationPageMap.PageEnabled = false;
            navigationPageMap.Size = new System.Drawing.Size(764, 504);
            navigationPageMap.ToolTip = "Map";
            // 
            // navigationPageAnalysis
            // 
            navigationPageAnalysis.Caption = "Analysis";
            navigationPageAnalysis.ImageOptions.ImageIndex = 4;
            navigationPageAnalysis.Name = "navigationPageAnalysis";
            navigationPageAnalysis.PageEnabled = false;
            navigationPageAnalysis.Size = new System.Drawing.Size(764, 504);
            navigationPageAnalysis.ToolTip = "Analysis";
            // 
            // navigationPageErrors
            // 
            navigationPageErrors.Caption = "Errors";
            navigationPageErrors.ImageOptions.ImageIndex = 5;
            navigationPageErrors.Name = "navigationPageErrors";
            navigationPageErrors.PageEnabled = false;
            navigationPageErrors.Size = new System.Drawing.Size(764, 504);
            navigationPageErrors.ToolTip = "Errors";
            // 
            // svgImageCollectionNavigation
            // 
            svgImageCollectionNavigation.ImageSize = new System.Drawing.Size(32, 32);
            svgImageCollectionNavigation.Add("Scan", "Wamby.Resources.Images.Menu.Scan.svg", "Wamby.Resources");
            svgImageCollectionNavigation.Add("Results", "Wamby.Resources.Images.Menu.Results.svg", "Wamby.Resources");
            svgImageCollectionNavigation.Add("Files", "Wamby.Resources.Images.Menu.Files.svg", "Wamby.Resources");
            svgImageCollectionNavigation.Add("Map", "Wamby.Resources.Images.Menu.Map.svg", "Wamby.Resources");
            svgImageCollectionNavigation.Add("Analysis", "Wamby.Resources.Images.Menu.Analysis.svg", "Wamby.Resources");
            svgImageCollectionNavigation.Add("Errors", "Wamby.Resources.Images.Menu.Errors.svg", "Wamby.Resources");
            svgImageCollectionNavigation.Add("Schedule", "Wamby.Resources.Images.Menu.Schedule.svg", "Wamby.Resources");
            svgImageCollectionNavigation.Add("Settings", "Wamby.Resources.Images.Menu.Settings.svg", "Wamby.Resources");
            // 
            // NewScanForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(764, 528);
            Controls.Add(navigationPane);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "NewScanForm";
            Text = "NewScanForm";
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)navigationPane).EndInit();
            navigationPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionNavigation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewScan;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancelScan;
        private DevExpress.Utils.SvgImageCollection svgImageCollection16;
        private DevExpress.Utils.SvgImageCollection svgImageCollection32;
        private DevExpress.XtraBars.BarButtonItem barButtonItemChangeFolder;
        private DevExpress.Utils.SvgImageCollection svgImageCollectionForm;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane;
        private DevExpress.Utils.SvgImageCollection svgImageCollectionNavigation;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageScanFolder;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageResults;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageFiles;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageMap;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageAnalysis;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageErrors;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
    }
}