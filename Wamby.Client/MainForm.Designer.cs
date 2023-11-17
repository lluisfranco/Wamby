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
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItemNewScan = new DevExpress.XtraBars.BarButtonItem();
            skinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            barCheckItemCompactUI = new DevExpress.XtraBars.BarCheckItem();
            barButtonItemOpenScan = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSaveScan = new DevExpress.XtraBars.BarButtonItem();
            svgImageCollection32 = new DevExpress.Utils.SvgImageCollection(components);
            documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
            SuspendLayout();
            // 
            // toolbarFormControl
            // 
            toolbarFormControl.Location = new System.Drawing.Point(0, 0);
            toolbarFormControl.Manager = toolbarFormManager;
            toolbarFormControl.Name = "toolbarFormControl";
            toolbarFormControl.Size = new System.Drawing.Size(1095, 31);
            toolbarFormControl.TabIndex = 4;
            toolbarFormControl.TabStop = false;
            toolbarFormControl.TitleItemLinks.Add(barButtonItemNewScan);
            toolbarFormControl.TitleItemLinks.Add(barCheckItemCompactUI);
            toolbarFormControl.TitleItemLinks.Add(skinPaletteDropDownButtonItem);
            toolbarFormControl.TitleItemLinks.Add(skinDropDownButtonItem, true);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemOpenScan);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemSaveScan);
            toolbarFormControl.ToolbarForm = this;
            // 
            // toolbarFormManager
            // 
            toolbarFormManager.DockControls.Add(barDockControlTop);
            toolbarFormManager.DockControls.Add(barDockControlBottom);
            toolbarFormManager.DockControls.Add(barDockControlLeft);
            toolbarFormManager.DockControls.Add(barDockControlRight);
            toolbarFormManager.Form = this;
            toolbarFormManager.Images = svgImageCollection16;
            toolbarFormManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemNewScan, skinDropDownButtonItem, skinPaletteDropDownButtonItem, barCheckItemCompactUI, barButtonItemOpenScan, barButtonItemSaveScan });
            toolbarFormManager.LargeImages = svgImageCollection32;
            toolbarFormManager.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 31);
            barDockControlTop.Manager = toolbarFormManager;
            barDockControlTop.Size = new System.Drawing.Size(1095, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 745);
            barDockControlBottom.Manager = toolbarFormManager;
            barDockControlBottom.Size = new System.Drawing.Size(1095, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            barDockControlLeft.Manager = toolbarFormManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 714);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1095, 31);
            barDockControlRight.Manager = toolbarFormManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 714);
            // 
            // barButtonItemNewScan
            // 
            barButtonItemNewScan.Caption = "New Scan";
            barButtonItemNewScan.Id = 0;
            barButtonItemNewScan.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemNewScan.ImageOptions.SvgImage");
            barButtonItemNewScan.Name = "barButtonItemNewScan";
            barButtonItemNewScan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            barButtonItemOpenScan.Name = "barButtonItemOpenScan";
            barButtonItemOpenScan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemSaveScan
            // 
            barButtonItemSaveScan.Caption = "Save Scan...";
            barButtonItemSaveScan.Id = 6;
            barButtonItemSaveScan.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemSaveScan.ImageOptions.SvgImage");
            barButtonItemSaveScan.Name = "barButtonItemSaveScan";
            barButtonItemSaveScan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // svgImageCollection32
            // 
            svgImageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            // 
            // documentManager
            // 
            documentManager.MdiParent = this;
            documentManager.MenuManager = toolbarFormManager;
            documentManager.View = tabbedView1;
            documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1095, 745);
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
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
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
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarCheckItem barCheckItemCompactUI;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenScan;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaveScan;
    }
}