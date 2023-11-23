namespace Wamby.Client.Modules
{
    partial class MapModule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapModule));
            resultsBindingSource = new System.Windows.Forms.BindingSource(components);
            treeMapControl = new DevExpress.XtraTreeMap.TreeMapControl();
            popupMenu = new DevExpress.XtraBars.PopupMenu(components);
            barManager = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            barCheckItemBySize = new DevExpress.XtraBars.BarCheckItem();
            barCheckItemShowByCount = new DevExpress.XtraBars.BarCheckItem();
            barSubItemMenuLayoutAlgorithm = new DevExpress.XtraBars.BarSubItem();
            barSubItemMenuDirection = new DevExpress.XtraBars.BarSubItem();
            barCheckItemSliceAndDice = new DevExpress.XtraBars.BarCheckItem();
            barCheckItemSquarified = new DevExpress.XtraBars.BarCheckItem();
            barCheckItemStriped = new DevExpress.XtraBars.BarCheckItem();
            barCheckItemBottomLeftToTopRight = new DevExpress.XtraBars.BarCheckItem();
            barCheckItemBottomRightToTopLeft = new DevExpress.XtraBars.BarCheckItem();
            barCheckItemTopLeftToBottomRight = new DevExpress.XtraBars.BarCheckItem();
            barCheckItemTopRightToBottomLeft = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)resultsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)treeMapControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // resultsBindingSource
            // 
            resultsBindingSource.DataSource = typeof(Core.Model.WambyFolderInfo);
            // 
            // treeMapControl
            // 
            treeMapControl.BorderOptions.Color = System.Drawing.Color.FromArgb(180, 180, 180);
            treeMapControl.Location = new System.Drawing.Point(12, 12);
            treeMapControl.Name = "treeMapControl";
            treeMapControl.Size = new System.Drawing.Size(586, 372);
            treeMapControl.TabIndex = 0;
            treeMapControl.ToolTipLeafPattern = "Extension {L}: {V:n2}";
            // 
            // popupMenu
            // 
            popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barCheckItemBySize), new DevExpress.XtraBars.LinkPersistInfo(barCheckItemShowByCount), new DevExpress.XtraBars.LinkPersistInfo(barSubItemMenuLayoutAlgorithm), new DevExpress.XtraBars.LinkPersistInfo(barSubItemMenuDirection) });
            popupMenu.Manager = barManager;
            popupMenu.Name = "popupMenu";
            // 
            // barManager
            // 
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.Form = this;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barCheckItemBySize, barCheckItemShowByCount, barSubItemMenuLayoutAlgorithm, barSubItemMenuDirection, barCheckItemSliceAndDice, barCheckItemSquarified, barCheckItemStriped, barCheckItemBottomLeftToTopRight, barCheckItemBottomRightToTopLeft, barCheckItemTopLeftToBottomRight, barCheckItemTopRightToBottomLeft });
            barManager.MaxItemId = 17;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager;
            barDockControlTop.Size = new System.Drawing.Size(610, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 396);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(610, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(610, 0);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // layoutControl
            // 
            layoutControl.AllowCustomization = false;
            layoutControl.Controls.Add(treeMapControl);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(610, 396);
            layoutControl.TabIndex = 6;
            layoutControl.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(610, 396);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = treeMapControl;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(590, 376);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // barCheckItemBySize
            // 
            barCheckItemBySize.BindableChecked = true;
            barCheckItemBySize.Caption = "Show By File Size";
            barCheckItemBySize.Checked = true;
            barCheckItemBySize.GroupIndex = 1;
            barCheckItemBySize.Id = 6;
            barCheckItemBySize.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barCheckItemBySize.ImageOptions.SvgImage");
            barCheckItemBySize.Name = "barCheckItemBySize";
            // 
            // barCheckItemShowByCount
            // 
            barCheckItemShowByCount.Caption = "Show By File Count";
            barCheckItemShowByCount.GroupIndex = 1;
            barCheckItemShowByCount.Id = 7;
            barCheckItemShowByCount.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barCheckItemShowByCount.ImageOptions.SvgImage");
            barCheckItemShowByCount.Name = "barCheckItemShowByCount";
            // 
            // barSubItemMenuLayoutAlgorithm
            // 
            barSubItemMenuLayoutAlgorithm.Caption = "Layout Algorithm";
            barSubItemMenuLayoutAlgorithm.Id = 8;
            barSubItemMenuLayoutAlgorithm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barCheckItemSliceAndDice), new DevExpress.XtraBars.LinkPersistInfo(barCheckItemSquarified), new DevExpress.XtraBars.LinkPersistInfo(barCheckItemStriped) });
            barSubItemMenuLayoutAlgorithm.Name = "barSubItemMenuLayoutAlgorithm";
            // 
            // barSubItemMenuDirection
            // 
            barSubItemMenuDirection.Caption = "Direction";
            barSubItemMenuDirection.Id = 9;
            barSubItemMenuDirection.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barCheckItemBottomLeftToTopRight), new DevExpress.XtraBars.LinkPersistInfo(barCheckItemBottomRightToTopLeft), new DevExpress.XtraBars.LinkPersistInfo(barCheckItemTopLeftToBottomRight), new DevExpress.XtraBars.LinkPersistInfo(barCheckItemTopRightToBottomLeft) });
            barSubItemMenuDirection.Name = "barSubItemMenuDirection";
            // 
            // barCheckItemSliceAndDice
            // 
            barCheckItemSliceAndDice.Caption = "Slice And Dice";
            barCheckItemSliceAndDice.GroupIndex = 2;
            barCheckItemSliceAndDice.Id = 10;
            barCheckItemSliceAndDice.Name = "barCheckItemSliceAndDice";
            // 
            // barCheckItemSquarified
            // 
            barCheckItemSquarified.BindableChecked = true;
            barCheckItemSquarified.Caption = "Squarified";
            barCheckItemSquarified.Checked = true;
            barCheckItemSquarified.GroupIndex = 2;
            barCheckItemSquarified.Id = 11;
            barCheckItemSquarified.Name = "barCheckItemSquarified";
            // 
            // barCheckItemStriped
            // 
            barCheckItemStriped.Caption = "Striped";
            barCheckItemStriped.GroupIndex = 2;
            barCheckItemStriped.Id = 12;
            barCheckItemStriped.Name = "barCheckItemStriped";
            // 
            // barCheckItemBottomLeftToTopRight
            // 
            barCheckItemBottomLeftToTopRight.Caption = "Bottom Left To Top Right";
            barCheckItemBottomLeftToTopRight.GroupIndex = 3;
            barCheckItemBottomLeftToTopRight.Id = 13;
            barCheckItemBottomLeftToTopRight.Name = "barCheckItemBottomLeftToTopRight";
            // 
            // barCheckItemBottomRightToTopLeft
            // 
            barCheckItemBottomRightToTopLeft.Caption = "Bottom Right To Top Left";
            barCheckItemBottomRightToTopLeft.GroupIndex = 3;
            barCheckItemBottomRightToTopLeft.Id = 14;
            barCheckItemBottomRightToTopLeft.Name = "barCheckItemBottomRightToTopLeft";
            // 
            // barCheckItemTopLeftToBottomRight
            // 
            barCheckItemTopLeftToBottomRight.BindableChecked = true;
            barCheckItemTopLeftToBottomRight.Caption = "Top Left To Bottom Right";
            barCheckItemTopLeftToBottomRight.Checked = true;
            barCheckItemTopLeftToBottomRight.GroupIndex = 3;
            barCheckItemTopLeftToBottomRight.Id = 15;
            barCheckItemTopLeftToBottomRight.Name = "barCheckItemTopLeftToBottomRight";
            // 
            // barCheckItemTopRightToBottomLeft
            // 
            barCheckItemTopRightToBottomLeft.Caption = "Top Right To Bottom Left";
            barCheckItemTopRightToBottomLeft.GroupIndex = 3;
            barCheckItemTopRightToBottomLeft.Id = 16;
            barCheckItemTopRightToBottomLeft.Name = "barCheckItemTopRightToBottomLeft";
            // 
            // MapModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "MapModule";
            Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)resultsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)treeMapControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private DevExpress.XtraTreeMap.TreeMapControl treeMapControl;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItemBySize;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowByCount;
        private DevExpress.XtraBars.BarSubItem barSubItemMenuLayoutAlgorithm;
        private DevExpress.XtraBars.BarSubItem barSubItemMenuDirection;
        private DevExpress.XtraBars.BarCheckItem barCheckItemSliceAndDice;
        private DevExpress.XtraBars.BarCheckItem barCheckItemSquarified;
        private DevExpress.XtraBars.BarCheckItem barCheckItemStriped;
        private DevExpress.XtraBars.BarCheckItem barCheckItemBottomLeftToTopRight;
        private DevExpress.XtraBars.BarCheckItem barCheckItemBottomRightToTopLeft;
        private DevExpress.XtraBars.BarCheckItem barCheckItemTopLeftToBottomRight;
        private DevExpress.XtraBars.BarCheckItem barCheckItemTopRightToBottomLeft;
    }
}
