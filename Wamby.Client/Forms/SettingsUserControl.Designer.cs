namespace Wamby.Client.Forms
{
    partial class SettingsUserControl
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
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            imageComboBoxEditType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            includeSubfoldersCheckEdit = new DevExpress.XtraEditors.ToggleSwitch();
            searchPatternButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
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
            toggleSwitchStartScanAfterChangingFolder = new DevExpress.XtraEditors.ToggleSwitch();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            toggleSwitchSaveFileInReadableFormat = new DevExpress.XtraEditors.ToggleSwitch();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            toggleSwitchShowWelcomeOnStartup = new DevExpress.XtraEditors.ToggleSwitch();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            toggleSwitchShowResultsPageAfterScan = new DevExpress.XtraEditors.ToggleSwitch();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageComboBoxEditType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)includeSubfoldersCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPatternButtonEdit.Properties).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)toggleSwitchStartScanAfterChangingFolder.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchSaveFileInReadableFormat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchShowWelcomeOnStartup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchShowResultsPageAfterScan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            SuspendLayout();
            // 
            // layoutControl
            // 
            layoutControl.AllowCustomization = false;
            layoutControl.Controls.Add(toggleSwitchShowResultsPageAfterScan);
            layoutControl.Controls.Add(toggleSwitchShowWelcomeOnStartup);
            layoutControl.Controls.Add(toggleSwitchSaveFileInReadableFormat);
            layoutControl.Controls.Add(toggleSwitchStartScanAfterChangingFolder);
            layoutControl.Controls.Add(imageComboBoxEditType);
            layoutControl.Controls.Add(includeSubfoldersCheckEdit);
            layoutControl.Controls.Add(searchPatternButtonEdit);
            layoutControl.Controls.Add(newScanPathButtonEdit);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(798, 492);
            layoutControl.TabIndex = 7;
            layoutControl.Text = "layoutControl1";
            // 
            // imageComboBoxEditType
            // 
            imageComboBoxEditType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            imageComboBoxEditType.Location = new System.Drawing.Point(251, 83);
            imageComboBoxEditType.Name = "imageComboBoxEditType";
            imageComboBoxEditType.Properties.AdvancedModeOptions.Label = "Scan Type";
            imageComboBoxEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            imageComboBoxEditType.Properties.ReadOnly = true;
            imageComboBoxEditType.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            imageComboBoxEditType.Size = new System.Drawing.Size(272, 34);
            imageComboBoxEditType.StyleController = layoutControl;
            imageComboBoxEditType.TabIndex = 4;
            // 
            // includeSubfoldersCheckEdit
            // 
            includeSubfoldersCheckEdit.EditValue = true;
            includeSubfoldersCheckEdit.Location = new System.Drawing.Point(535, 53);
            includeSubfoldersCheckEdit.Name = "includeSubfoldersCheckEdit";
            includeSubfoldersCheckEdit.Properties.OffText = "Include Subfolders";
            includeSubfoldersCheckEdit.Properties.OnText = "Include Subfolders";
            includeSubfoldersCheckEdit.Properties.ReadOnly = true;
            includeSubfoldersCheckEdit.Size = new System.Drawing.Size(171, 18);
            includeSubfoldersCheckEdit.StyleController = layoutControl;
            includeSubfoldersCheckEdit.TabIndex = 2;
            // 
            // searchPatternButtonEdit
            // 
            searchPatternButtonEdit.EditValue = "*.*";
            searchPatternButtonEdit.Location = new System.Drawing.Point(24, 83);
            searchPatternButtonEdit.Name = "searchPatternButtonEdit";
            searchPatternButtonEdit.Properties.AdvancedModeOptions.Label = "Search Pattern";
            searchPatternButtonEdit.Properties.ReadOnly = true;
            searchPatternButtonEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            searchPatternButtonEdit.Size = new System.Drawing.Size(223, 34);
            searchPatternButtonEdit.StyleController = layoutControl;
            searchPatternButtonEdit.TabIndex = 3;
            // 
            // newScanPathButtonEdit
            // 
            newScanPathButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            newScanPathButtonEdit.Location = new System.Drawing.Point(24, 45);
            newScanPathButtonEdit.Name = "newScanPathButtonEdit";
            newScanPathButtonEdit.Properties.AdvancedModeOptions.Label = "Path to Scan";
            newScanPathButtonEdit.Properties.ReadOnly = true;
            newScanPathButtonEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            newScanPathButtonEdit.Size = new System.Drawing.Size(499, 34);
            newScanPathButtonEdit.StyleController = layoutControl;
            newScanPathButtonEdit.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, layoutControlGroup2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(798, 492);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem4, layoutControlItem3, emptySpaceItem1, emptySpaceItem2 });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(778, 121);
            layoutControlGroup1.Text = "OPTIONS";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = newScanPathButtonEdit;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(503, 38);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = searchPatternButtonEdit;
            layoutControlItem2.Location = new System.Drawing.Point(0, 38);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(227, 38);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem4.Control = includeSubfoldersCheckEdit;
            layoutControlItem4.Location = new System.Drawing.Point(503, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            layoutControlItem4.Size = new System.Drawing.Size(183, 38);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = imageComboBoxEditType;
            layoutControlItem3.Location = new System.Drawing.Point(227, 38);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(276, 38);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(503, 38);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(183, 38);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(686, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(68, 76);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem5, emptySpaceItem3, layoutControlItem6, layoutControlItem7, layoutControlItem8 });
            layoutControlGroup2.Location = new System.Drawing.Point(0, 121);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new System.Drawing.Size(778, 351);
            layoutControlGroup2.Text = "PREFERENCES";
            // 
            // toggleSwitchStartScanAfterChangingFolder
            // 
            toggleSwitchStartScanAfterChangingFolder.EditValue = true;
            toggleSwitchStartScanAfterChangingFolder.Location = new System.Drawing.Point(30, 206);
            toggleSwitchStartScanAfterChangingFolder.Name = "toggleSwitchStartScanAfterChangingFolder";
            toggleSwitchStartScanAfterChangingFolder.Properties.OffText = "Start scan after changing folder path";
            toggleSwitchStartScanAfterChangingFolder.Properties.OnText = "Start scan after changing folder path";
            toggleSwitchStartScanAfterChangingFolder.Size = new System.Drawing.Size(738, 18);
            toggleSwitchStartScanAfterChangingFolder.StyleController = layoutControl;
            toggleSwitchStartScanAfterChangingFolder.TabIndex = 6;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = toggleSwitchStartScanAfterChangingFolder;
            layoutControlItem5.Location = new System.Drawing.Point(0, 34);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            layoutControlItem5.Size = new System.Drawing.Size(754, 34);
            layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new System.Drawing.Point(0, 136);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(754, 170);
            emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // toggleSwitchSaveFileInReadableFormat
            // 
            toggleSwitchSaveFileInReadableFormat.EditValue = true;
            toggleSwitchSaveFileInReadableFormat.Location = new System.Drawing.Point(30, 274);
            toggleSwitchSaveFileInReadableFormat.Name = "toggleSwitchSaveFileInReadableFormat";
            toggleSwitchSaveFileInReadableFormat.Properties.OffText = "Save file in readable format";
            toggleSwitchSaveFileInReadableFormat.Properties.OnText = "Save file in readable format";
            toggleSwitchSaveFileInReadableFormat.Size = new System.Drawing.Size(738, 18);
            toggleSwitchSaveFileInReadableFormat.StyleController = layoutControl;
            toggleSwitchSaveFileInReadableFormat.TabIndex = 8;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = toggleSwitchSaveFileInReadableFormat;
            layoutControlItem6.Location = new System.Drawing.Point(0, 102);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            layoutControlItem6.Size = new System.Drawing.Size(754, 34);
            layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // toggleSwitchShowWelcomeOnStartup
            // 
            toggleSwitchShowWelcomeOnStartup.EditValue = true;
            toggleSwitchShowWelcomeOnStartup.Location = new System.Drawing.Point(30, 172);
            toggleSwitchShowWelcomeOnStartup.Name = "toggleSwitchShowWelcomeOnStartup";
            toggleSwitchShowWelcomeOnStartup.Properties.OffText = "Show welcome on startup";
            toggleSwitchShowWelcomeOnStartup.Properties.OnText = "Show welcome on startup";
            toggleSwitchShowWelcomeOnStartup.Size = new System.Drawing.Size(738, 18);
            toggleSwitchShowWelcomeOnStartup.StyleController = layoutControl;
            toggleSwitchShowWelcomeOnStartup.TabIndex = 5;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = toggleSwitchShowWelcomeOnStartup;
            layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            layoutControlItem7.Size = new System.Drawing.Size(754, 34);
            layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem7.TextVisible = false;
            // 
            // toggleSwitchShowResultsPageAfterScan
            // 
            toggleSwitchShowResultsPageAfterScan.EditValue = true;
            toggleSwitchShowResultsPageAfterScan.Location = new System.Drawing.Point(30, 240);
            toggleSwitchShowResultsPageAfterScan.Name = "toggleSwitchShowResultsPageAfterScan";
            toggleSwitchShowResultsPageAfterScan.Properties.OffText = "Show results page after scan";
            toggleSwitchShowResultsPageAfterScan.Properties.OnText = "Show results page after scan";
            toggleSwitchShowResultsPageAfterScan.Size = new System.Drawing.Size(738, 18);
            toggleSwitchShowResultsPageAfterScan.StyleController = layoutControl;
            toggleSwitchShowResultsPageAfterScan.TabIndex = 7;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = toggleSwitchShowResultsPageAfterScan;
            layoutControlItem8.Location = new System.Drawing.Point(0, 68);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            layoutControlItem8.Size = new System.Drawing.Size(754, 34);
            layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem8.TextVisible = false;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Name = "SettingsUserControl";
            Size = new System.Drawing.Size(798, 492);
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageComboBoxEditType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)includeSubfoldersCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchPatternButtonEdit.Properties).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)toggleSwitchStartScanAfterChangingFolder.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchSaveFileInReadableFormat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchShowWelcomeOnStartup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitchShowResultsPageAfterScan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEditType;
        private DevExpress.XtraEditors.ToggleSwitch includeSubfoldersCheckEdit;
        private DevExpress.XtraEditors.ButtonEdit searchPatternButtonEdit;
        private DevExpress.XtraEditors.ButtonEdit newScanPathButtonEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchSaveFileInReadableFormat;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchStartScanAfterChangingFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchShowWelcomeOnStartup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchShowResultsPageAfterScan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}
