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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            svgImageCollection16 = new DevExpress.Utils.SvgImageCollection(components);
            toolbarFormControl = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            toolbarFormManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            barEditItemProgress = new DevExpress.XtraBars.BarEditItem();
            repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            barStaticItemMessage = new DevExpress.XtraBars.BarStaticItem();
            barStaticItemMessageLastScan = new DevExpress.XtraBars.BarStaticItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItemNewScan = new DevExpress.XtraBars.BarButtonItem();
            skinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            barCheckItemCompactUI = new DevExpress.XtraBars.BarCheckItem();
            barButtonItemOpenScan = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSchedule = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSettings = new DevExpress.XtraBars.BarButtonItem();
            svgImageCollection32 = new DevExpress.Utils.SvgImageCollection(components);
            documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            svgImageCollectionForm = new DevExpress.Utils.SvgImageCollection(components);
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionForm).BeginInit();
            SuspendLayout();
            // 
            // svgImageCollection16
            // 
            svgImageCollection16.Add("New", "Wamby.Resources.Images.Actions.New.svg", "Wamby.Resources");
            svgImageCollection16.Add("Open", "Wamby.Resources.Images.Actions.Open.svg", "Wamby.Resources");
            svgImageCollection16.Add("Schedule", "Wamby.Resources.Images.Menu.Schedule.svg", "Wamby.Resources");
            svgImageCollection16.Add("Settings", "Wamby.Resources.Images.Menu.Settings.svg", "Wamby.Resources");
            // 
            // toolbarFormControl
            // 
            toolbarFormControl.Location = new System.Drawing.Point(0, 0);
            toolbarFormControl.Manager = toolbarFormManager;
            toolbarFormControl.Name = "toolbarFormControl";
            toolbarFormControl.Size = new System.Drawing.Size(1330, 33);
            toolbarFormControl.TabIndex = 4;
            toolbarFormControl.TabStop = false;
            toolbarFormControl.TitleItemLinks.Add(barButtonItemNewScan);
            toolbarFormControl.TitleItemLinks.Add(barCheckItemCompactUI);
            toolbarFormControl.TitleItemLinks.Add(skinPaletteDropDownButtonItem);
            toolbarFormControl.TitleItemLinks.Add(skinDropDownButtonItem, true);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemOpenScan);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemSchedule);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemSettings);
            toolbarFormControl.ToolbarForm = this;
            // 
            // toolbarFormManager
            // 
            toolbarFormManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
            toolbarFormManager.DockControls.Add(barDockControlTop);
            toolbarFormManager.DockControls.Add(barDockControlBottom);
            toolbarFormManager.DockControls.Add(barDockControlLeft);
            toolbarFormManager.DockControls.Add(barDockControlRight);
            toolbarFormManager.Form = this;
            toolbarFormManager.Images = svgImageCollection16;
            toolbarFormManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemNewScan, skinDropDownButtonItem, skinPaletteDropDownButtonItem, barCheckItemCompactUI, barButtonItemOpenScan, barEditItemProgress, barStaticItemMessage, barStaticItemMessageLastScan, barButtonItemSchedule, barButtonItemSettings });
            toolbarFormManager.LargeImages = svgImageCollection32;
            toolbarFormManager.MaxItemId = 12;
            toolbarFormManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemProgressBar1 });
            toolbarFormManager.StatusBar = bar1;
            // 
            // bar1
            // 
            bar1.BarName = "StatusBar";
            bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, barEditItemProgress, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(barStaticItemMessage), new DevExpress.XtraBars.LinkPersistInfo(barStaticItemMessageLastScan) });
            bar1.OptionsBar.AllowQuickCustomization = false;
            bar1.OptionsBar.DrawDragBorder = false;
            bar1.OptionsBar.UseWholeRow = true;
            bar1.Text = "Custom 2";
            // 
            // barEditItemProgress
            // 
            barEditItemProgress.Edit = repositoryItemProgressBar1;
            barEditItemProgress.EditWidth = 150;
            barEditItemProgress.Id = 7;
            barEditItemProgress.Name = "barEditItemProgress";
            barEditItemProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemProgressBar1
            // 
            repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // barStaticItemMessage
            // 
            barStaticItemMessage.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            barStaticItemMessage.Caption = "Ready";
            barStaticItemMessage.Id = 8;
            barStaticItemMessage.Name = "barStaticItemMessage";
            // 
            // barStaticItemMessageLastScan
            // 
            barStaticItemMessageLastScan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barStaticItemMessageLastScan.Caption = "No scan data";
            barStaticItemMessageLastScan.Id = 9;
            barStaticItemMessageLastScan.Name = "barStaticItemMessageLastScan";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 33);
            barDockControlTop.Manager = toolbarFormManager;
            barDockControlTop.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 881);
            barDockControlBottom.Manager = toolbarFormManager;
            barDockControlBottom.Size = new System.Drawing.Size(1330, 37);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            barDockControlLeft.Manager = toolbarFormManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 848);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1330, 33);
            barDockControlRight.Manager = toolbarFormManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 848);
            // 
            // barButtonItemNewScan
            // 
            barButtonItemNewScan.Caption = "New Scan";
            barButtonItemNewScan.Id = 0;
            barButtonItemNewScan.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemNewScan.ImageOptions.SvgImage");
            barButtonItemNewScan.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N);
            barButtonItemNewScan.Name = "barButtonItemNewScan";
            // 
            // skinDropDownButtonItem
            // 
            skinDropDownButtonItem.ActAsDropDown = true;
            skinDropDownButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            skinDropDownButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinDropDownButtonItem.Id = 2;
            skinDropDownButtonItem.Name = "skinDropDownButtonItem";
            // 
            // skinPaletteDropDownButtonItem
            // 
            skinPaletteDropDownButtonItem.ActAsDropDown = true;
            skinPaletteDropDownButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            skinPaletteDropDownButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem.Id = 3;
            skinPaletteDropDownButtonItem.Name = "skinPaletteDropDownButtonItem";
            // 
            // barCheckItemCompactUI
            // 
            barCheckItemCompactUI.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barCheckItemCompactUI.BindableChecked = true;
            barCheckItemCompactUI.Caption = "Compact UI";
            barCheckItemCompactUI.Checked = true;
            barCheckItemCompactUI.Id = 4;
            barCheckItemCompactUI.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barCheckItemCompactUI.ImageOptions.SvgImage");
            barCheckItemCompactUI.Name = "barCheckItemCompactUI";
            // 
            // barButtonItemOpenScan
            // 
            barButtonItemOpenScan.Caption = "Open Scan...";
            barButtonItemOpenScan.Id = 5;
            barButtonItemOpenScan.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemOpenScan.ImageOptions.SvgImage");
            barButtonItemOpenScan.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O);
            barButtonItemOpenScan.Name = "barButtonItemOpenScan";
            // 
            // barButtonItemSchedule
            // 
            barButtonItemSchedule.Caption = "Schedule";
            barButtonItemSchedule.Enabled = false;
            barButtonItemSchedule.Id = 10;
            barButtonItemSchedule.ImageOptions.ImageIndex = 2;
            barButtonItemSchedule.ImageOptions.LargeImageIndex = 2;
            barButtonItemSchedule.Name = "barButtonItemSchedule";
            // 
            // barButtonItemSettings
            // 
            barButtonItemSettings.Caption = "Settings";
            barButtonItemSettings.Id = 11;
            barButtonItemSettings.ImageOptions.ImageIndex = 3;
            barButtonItemSettings.ImageOptions.LargeImageIndex = 3;
            barButtonItemSettings.Name = "barButtonItemSettings";
            // 
            // svgImageCollection32
            // 
            svgImageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            svgImageCollection32.Add("New", "Wamby.Resources.Images.Actions.New.svg", "Wamby.Resources");
            svgImageCollection32.Add("Open", "Wamby.Resources.Images.Actions.Open.svg", "Wamby.Resources");
            svgImageCollection32.Add("Schedule", "Wamby.Resources.Images.Menu.Schedule.svg", "Wamby.Resources");
            svgImageCollection32.Add("Settings", "Wamby.Resources.Images.Menu.Settings.svg", "Wamby.Resources");
            // 
            // documentManager
            // 
            documentManager.MdiParent = this;
            documentManager.MenuManager = toolbarFormManager;
            documentManager.View = tabbedView;
            documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView });
            // 
            // tabbedView
            // 
            tabbedView.DocumentProperties.AllowPin = true;
            tabbedView.DocumentProperties.UseFormIconAsDocumentImage = true;
            // 
            // svgImageCollectionForm
            // 
            svgImageCollectionForm.Add("AppIcon", "Wamby.Resources.Images.App.AppIcon.svg", "Wamby.Resources");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1330, 918);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Controls.Add(toolbarFormControl);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "MainForm";
            ToolbarFormControl = toolbarFormControl;
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewScan;

        private DevExpress.Utils.SvgImageCollection svgImageCollection16;
        private DevExpress.Utils.SvgImageCollection svgImageCollection32;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.BarCheckItem barCheckItemCompactUI;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenScan;
        private DevExpress.Utils.SvgImageCollection svgImageCollectionForm;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem barEditItemProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItemMessage;
        private DevExpress.XtraBars.BarStaticItem barStaticItemMessageLastScan;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSchedule;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSettings;
    }
}