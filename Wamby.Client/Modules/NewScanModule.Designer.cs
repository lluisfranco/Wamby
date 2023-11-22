namespace Wamby.Client.Modules
{
    partial class NewScanModule
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            svgImageCollection16 = new DevExpress.Utils.SvgImageCollection(components);
            gridControlLog = new DevExpress.XtraGrid.GridControl();
            logLineBindingSource = new System.Windows.Forms.BindingSource(components);
            gridViewLog = new DevExpress.XtraGrid.Views.Grid.GridView();
            colLogLineType = new DevExpress.XtraGrid.Columns.GridColumn();
            colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            popupMenu = new DevExpress.XtraBars.PopupMenu(components);
            searchPatternButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            imageComboBoxEditType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            includeSubfoldersCheckEdit = new DevExpress.XtraEditors.ToggleSwitch();
            newScanPathButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            svgImageCollection32 = new DevExpress.Utils.SvgImageCollection(components);
            dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logLineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPatternButtonEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageComboBoxEditType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)includeSubfoldersCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newScanPathButtonEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // svgImageCollection16
            // 
            svgImageCollection16.Add("NewScan_CancelScan", "Wamby.Resources.Images.NewScan_CancelScan.svg", "Wamby.Resources");
            svgImageCollection16.Add("NewScan_Change_Folder", "Wamby.Resources.Images.NewScan_Change_Folder.svg", "Wamby.Resources");
            svgImageCollection16.Add("NewScan_ScanNow", "Wamby.Resources.Images.NewScan_ScanNow.svg", "Wamby.Resources");
            // 
            // gridControlLog
            // 
            gridControlLog.DataSource = logLineBindingSource;
            gridControlLog.EmbeddedNavigator.Buttons.Append.Visible = false;
            gridControlLog.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            gridControlLog.EmbeddedNavigator.Buttons.Edit.Visible = false;
            gridControlLog.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            gridControlLog.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridControlLog.Location = new System.Drawing.Point(24, 166);
            gridControlLog.MainView = gridViewLog;
            gridControlLog.Name = "gridControlLog";
            gridControlLog.Size = new System.Drawing.Size(630, 393);
            gridControlLog.TabIndex = 5;
            gridControlLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewLog });
            // 
            // logLineBindingSource
            // 
            logLineBindingSource.DataSource = typeof(Core.Model.LogLine);
            // 
            // gridViewLog
            // 
            gridViewLog.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridViewLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colLogLineType, colMessage });
            gridViewLog.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewLog.GridControl = gridControlLog;
            gridViewLog.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Extension", null, "({0} items)") });
            gridViewLog.Name = "gridViewLog";
            gridViewLog.OptionsBehavior.Editable = false;
            gridViewLog.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewLog.OptionsView.ShowColumnHeaders = false;
            gridViewLog.OptionsView.ShowGroupPanel = false;
            gridViewLog.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            gridViewLog.OptionsView.ShowIndicator = false;
            gridViewLog.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colLogLineType
            // 
            colLogLineType.FieldName = "LogLineType";
            colLogLineType.Name = "colLogLineType";
            colLogLineType.OptionsColumn.AllowSize = false;
            colLogLineType.OptionsColumn.FixedWidth = true;
            colLogLineType.Visible = true;
            colLogLineType.VisibleIndex = 0;
            colLogLineType.Width = 40;
            // 
            // colMessage
            // 
            colMessage.FieldName = "Message";
            colMessage.Name = "colMessage";
            colMessage.Visible = true;
            colMessage.VisibleIndex = 1;
            colMessage.Width = 218;
            // 
            // popupMenu
            // 
            popupMenu.Name = "popupMenu";
            // 
            // searchPatternButtonEdit
            // 
            searchPatternButtonEdit.EditValue = "*.*";
            searchPatternButtonEdit.Location = new System.Drawing.Point(24, 83);
            searchPatternButtonEdit.Name = "searchPatternButtonEdit";
            searchPatternButtonEdit.Properties.AdvancedModeOptions.Label = "Search Pattern";
            searchPatternButtonEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            searchPatternButtonEdit.Size = new System.Drawing.Size(187, 34);
            searchPatternButtonEdit.StyleController = layoutControl;
            searchPatternButtonEdit.TabIndex = 3;
            // 
            // layoutControl
            // 
            layoutControl.Controls.Add(gridControlLog);
            layoutControl.Controls.Add(imageComboBoxEditType);
            layoutControl.Controls.Add(includeSubfoldersCheckEdit);
            layoutControl.Controls.Add(searchPatternButtonEdit);
            layoutControl.Controls.Add(newScanPathButtonEdit);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(678, 583);
            layoutControl.TabIndex = 6;
            layoutControl.Text = "layoutControl1";
            // 
            // imageComboBoxEditType
            // 
            imageComboBoxEditType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            imageComboBoxEditType.Location = new System.Drawing.Point(215, 83);
            imageComboBoxEditType.Name = "imageComboBoxEditType";
            imageComboBoxEditType.Properties.AdvancedModeOptions.Label = "Scan Type";
            imageComboBoxEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            imageComboBoxEditType.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            imageComboBoxEditType.Size = new System.Drawing.Size(228, 34);
            imageComboBoxEditType.StyleController = layoutControl;
            imageComboBoxEditType.TabIndex = 4;
            // 
            // includeSubfoldersCheckEdit
            // 
            includeSubfoldersCheckEdit.EditValue = true;
            includeSubfoldersCheckEdit.Location = new System.Drawing.Point(455, 53);
            includeSubfoldersCheckEdit.Name = "includeSubfoldersCheckEdit";
            includeSubfoldersCheckEdit.Properties.OffText = "Include Subfolders";
            includeSubfoldersCheckEdit.Properties.OnText = "Include Subfolders";
            includeSubfoldersCheckEdit.Size = new System.Drawing.Size(142, 18);
            includeSubfoldersCheckEdit.StyleController = layoutControl;
            includeSubfoldersCheckEdit.TabIndex = 2;
            // 
            // newScanPathButtonEdit
            // 
            newScanPathButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            newScanPathButtonEdit.Location = new System.Drawing.Point(24, 45);
            newScanPathButtonEdit.Name = "newScanPathButtonEdit";
            newScanPathButtonEdit.Properties.AdvancedModeOptions.Label = "Path to Scan";
            editorButtonImageOptions1.ImageIndex = 2;
            editorButtonImageOptions1.ImageList = svgImageCollection16;
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            editorButtonImageOptions2.ImageIndex = 1;
            editorButtonImageOptions2.ImageList = svgImageCollection16;
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(16, 16);
            newScanPathButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Scan Now", null, null, DevExpress.Utils.ToolTipAnchor.Default), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Change Folder", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            newScanPathButtonEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            newScanPathButtonEdit.Size = new System.Drawing.Size(419, 34);
            newScanPathButtonEdit.StyleController = layoutControl;
            newScanPathButtonEdit.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, layoutControlGroup2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(678, 583);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem4, layoutControlItem3, emptySpaceItem1, emptySpaceItem2 });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(658, 121);
            layoutControlGroup1.Text = "OPTIONS";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = newScanPathButtonEdit;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(423, 38);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = searchPatternButtonEdit;
            layoutControlItem2.Location = new System.Drawing.Point(0, 38);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(191, 38);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem4.Control = includeSubfoldersCheckEdit;
            layoutControlItem4.Location = new System.Drawing.Point(423, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            layoutControlItem4.Size = new System.Drawing.Size(154, 38);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = imageComboBoxEditType;
            layoutControlItem3.Location = new System.Drawing.Point(191, 38);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(232, 38);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(423, 38);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(154, 38);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(577, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(57, 76);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem5 });
            layoutControlGroup2.Location = new System.Drawing.Point(0, 121);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new System.Drawing.Size(658, 442);
            layoutControlGroup2.Text = "LOG";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = gridControlLog;
            layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(634, 397);
            layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // svgImageCollection32
            // 
            svgImageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            svgImageCollection32.Add("NewScan_CancelScan", "Wamby.Resources.Images.NewScan_CancelScan.svg", "Wamby.Resources");
            svgImageCollection32.Add("NewScan_Change_Folder", "Wamby.Resources.Images.NewScan_Change_Folder.svg", "Wamby.Resources");
            svgImageCollection32.Add("NewScan_ScanNow", "Wamby.Resources.Images.NewScan_ScanNow.svg", "Wamby.Resources");
            // 
            // dxErrorProvider
            // 
            dxErrorProvider.ContainerControl = this;
            // 
            // NewScanModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Name = "NewScanModule";
            Size = new System.Drawing.Size(678, 583);
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)logLineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchPatternButtonEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageComboBoxEditType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)includeSubfoldersCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)newScanPathButtonEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraGrid.GridControl gridControlLog;
        private System.Windows.Forms.BindingSource logLineBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLog;
        private DevExpress.XtraGrid.Columns.GridColumn colLogLineType;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraEditors.ButtonEdit searchPatternButtonEdit;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEditType;
        private DevExpress.XtraEditors.ButtonEdit newScanPathButtonEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ToggleSwitch includeSubfoldersCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.Utils.SvgImageCollection svgImageCollection16;
        private DevExpress.Utils.SvgImageCollection svgImageCollection32;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}
