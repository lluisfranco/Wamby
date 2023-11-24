namespace Wamby.Client.Modules
{
    partial class ResultsModule
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
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule2 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar2 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            colDeepLength = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colDeepFilesCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            resultsTreeList = new DevExpress.XtraTreeList.TreeList();
            colLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colCreationTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colLastAccessTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colLastWriteTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colOwnerName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colAttributes = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsArchive = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsCompressed = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsDevice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsDirectory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsEncrypted = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsHidden = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsIntegrityStream = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsNormal = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsNoScrubData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsNotContentIndexed = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsOffline = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsReadOnly = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsReparsePoint = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsSparseFile = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsSystem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsTemporary = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colDeepPercent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colDeepFilesCountPercent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            resultsBindingSource = new System.Windows.Forms.BindingSource(components);
            popupMenu = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemCopyPath = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemShowInExplorer = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemShowInCmd = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemProperties = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            barManager = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            svgImageCollection16 = new DevExpress.Utils.SvgImageCollection(components);
            svgImageCollection32 = new DevExpress.Utils.SvgImageCollection(components);
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            barButtonItemOpenInNewTab = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)resultsTreeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // colDeepLength
            // 
            colDeepLength.Caption = "Size (KB)";
            colDeepLength.FieldName = "DeepLengthInKB";
            colDeepLength.Format.FormatString = "n0";
            colDeepLength.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDeepLength.Name = "colDeepLength";
            colDeepLength.Visible = true;
            colDeepLength.VisibleIndex = 1;
            colDeepLength.Width = 99;
            // 
            // colDeepFilesCount
            // 
            colDeepFilesCount.Caption = "Files";
            colDeepFilesCount.FieldName = "DeepFilesCount";
            colDeepFilesCount.Format.FormatString = "n0";
            colDeepFilesCount.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDeepFilesCount.Name = "colDeepFilesCount";
            colDeepFilesCount.Visible = true;
            colDeepFilesCount.VisibleIndex = 3;
            colDeepFilesCount.Width = 54;
            // 
            // resultsTreeList
            // 
            resultsTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { colLevel, colIsFolder, colFullName, colDeepLength, colDeepFilesCount, colCreationTime, colLastAccessTime, colLastWriteTime, colOwnerName, colAttributes, colIsArchive, colIsCompressed, colIsDevice, colIsDirectory, colIsEncrypted, colIsHidden, colIsIntegrityStream, colIsNormal, colIsNoScrubData, colIsNotContentIndexed, colIsOffline, colIsReadOnly, colIsReparsePoint, colIsSparseFile, colIsSystem, colIsTemporary, colDeepPercent, colDeepFilesCountPercent });
            resultsTreeList.DataSource = resultsBindingSource;
            treeListFormatRule1.Column = colDeepLength;
            treeListFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            treeListFormatRule1.Rule = formatConditionRuleDataBar1;
            treeListFormatRule2.Column = colDeepFilesCount;
            treeListFormatRule2.Name = "Format1";
            formatConditionRuleDataBar2.PredefinedName = "Violet";
            treeListFormatRule2.Rule = formatConditionRuleDataBar2;
            resultsTreeList.FormatRules.Add(treeListFormatRule1);
            resultsTreeList.FormatRules.Add(treeListFormatRule2);
            resultsTreeList.KeyFieldName = "FullName";
            resultsTreeList.Location = new System.Drawing.Point(12, 12);
            resultsTreeList.Name = "resultsTreeList";
            resultsTreeList.OptionsBehavior.Editable = false;
            resultsTreeList.OptionsMenu.ShowConditionalFormattingItem = true;
            resultsTreeList.OptionsSelection.SelectNodesOnRightClick = true;
            resultsTreeList.OptionsView.ShowHorzLines = false;
            resultsTreeList.OptionsView.ShowIndicator = false;
            resultsTreeList.ParentFieldName = "ParentFullName";
            resultsTreeList.Size = new System.Drawing.Size(988, 500);
            resultsTreeList.TabIndex = 0;
            // 
            // colLevel
            // 
            colLevel.FieldName = "Level";
            colLevel.Name = "colLevel";
            colLevel.Width = 122;
            // 
            // colIsFolder
            // 
            colIsFolder.FieldName = "IsFolder";
            colIsFolder.Name = "colIsFolder";
            colIsFolder.Width = 71;
            // 
            // colFullName
            // 
            colFullName.Caption = "Folder";
            colFullName.FieldName = "DisplayName";
            colFullName.Name = "colFullName";
            colFullName.Visible = true;
            colFullName.VisibleIndex = 0;
            colFullName.Width = 323;
            // 
            // colCreationTime
            // 
            colCreationTime.FieldName = "CreationTime";
            colCreationTime.Format.FormatString = "g";
            colCreationTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            colCreationTime.Name = "colCreationTime";
            colCreationTime.OptionsColumn.AllowEdit = false;
            colCreationTime.OptionsColumn.AllowSize = false;
            colCreationTime.OptionsColumn.FixedWidth = true;
            colCreationTime.OptionsColumn.ReadOnly = true;
            colCreationTime.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            colCreationTime.Visible = true;
            colCreationTime.VisibleIndex = 5;
            colCreationTime.Width = 100;
            // 
            // colLastAccessTime
            // 
            colLastAccessTime.FieldName = "LastAccessTime";
            colLastAccessTime.Format.FormatString = "g";
            colLastAccessTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            colLastAccessTime.Name = "colLastAccessTime";
            colLastAccessTime.OptionsColumn.AllowEdit = false;
            colLastAccessTime.OptionsColumn.AllowSize = false;
            colLastAccessTime.OptionsColumn.FixedWidth = true;
            colLastAccessTime.OptionsColumn.ReadOnly = true;
            colLastAccessTime.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            colLastAccessTime.Visible = true;
            colLastAccessTime.VisibleIndex = 6;
            colLastAccessTime.Width = 100;
            // 
            // colLastWriteTime
            // 
            colLastWriteTime.FieldName = "LastWriteTime";
            colLastWriteTime.Format.FormatString = "g";
            colLastWriteTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            colLastWriteTime.Name = "colLastWriteTime";
            colLastWriteTime.OptionsColumn.AllowEdit = false;
            colLastWriteTime.OptionsColumn.AllowSize = false;
            colLastWriteTime.OptionsColumn.FixedWidth = true;
            colLastWriteTime.OptionsColumn.ReadOnly = true;
            colLastWriteTime.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            colLastWriteTime.Visible = true;
            colLastWriteTime.VisibleIndex = 7;
            colLastWriteTime.Width = 100;
            // 
            // colOwnerName
            // 
            colOwnerName.Caption = "Owner";
            colOwnerName.FieldName = "OwnerName";
            colOwnerName.Name = "colOwnerName";
            colOwnerName.Visible = true;
            colOwnerName.VisibleIndex = 8;
            colOwnerName.Width = 46;
            // 
            // colAttributes
            // 
            colAttributes.AppearanceCell.Options.UseTextOptions = true;
            colAttributes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colAttributes.FieldName = "Attributes";
            colAttributes.Name = "colAttributes";
            colAttributes.OptionsColumn.AllowEdit = false;
            colAttributes.OptionsColumn.ReadOnly = true;
            colAttributes.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            colAttributes.Visible = true;
            colAttributes.VisibleIndex = 9;
            colAttributes.Width = 48;
            // 
            // colIsArchive
            // 
            colIsArchive.FieldName = "IsArchive";
            colIsArchive.Name = "colIsArchive";
            // 
            // colIsCompressed
            // 
            colIsCompressed.FieldName = "IsCompressed";
            colIsCompressed.Name = "colIsCompressed";
            // 
            // colIsDevice
            // 
            colIsDevice.FieldName = "IsDevice";
            colIsDevice.Name = "colIsDevice";
            // 
            // colIsDirectory
            // 
            colIsDirectory.FieldName = "IsDirectory";
            colIsDirectory.Name = "colIsDirectory";
            // 
            // colIsEncrypted
            // 
            colIsEncrypted.FieldName = "IsEncrypted";
            colIsEncrypted.Name = "colIsEncrypted";
            // 
            // colIsHidden
            // 
            colIsHidden.FieldName = "IsHidden";
            colIsHidden.Name = "colIsHidden";
            // 
            // colIsIntegrityStream
            // 
            colIsIntegrityStream.FieldName = "IsIntegrityStream";
            colIsIntegrityStream.Name = "colIsIntegrityStream";
            // 
            // colIsNormal
            // 
            colIsNormal.FieldName = "IsNormal";
            colIsNormal.Name = "colIsNormal";
            // 
            // colIsNoScrubData
            // 
            colIsNoScrubData.FieldName = "IsNoScrubData";
            colIsNoScrubData.Name = "colIsNoScrubData";
            // 
            // colIsNotContentIndexed
            // 
            colIsNotContentIndexed.FieldName = "IsNotContentIndexed";
            colIsNotContentIndexed.Name = "colIsNotContentIndexed";
            // 
            // colIsOffline
            // 
            colIsOffline.FieldName = "IsOffline";
            colIsOffline.Name = "colIsOffline";
            // 
            // colIsReadOnly
            // 
            colIsReadOnly.FieldName = "IsReadOnly";
            colIsReadOnly.Name = "colIsReadOnly";
            // 
            // colIsReparsePoint
            // 
            colIsReparsePoint.FieldName = "IsReparsePoint";
            colIsReparsePoint.Name = "colIsReparsePoint";
            // 
            // colIsSparseFile
            // 
            colIsSparseFile.FieldName = "IsSparseFile";
            colIsSparseFile.Name = "colIsSparseFile";
            // 
            // colIsSystem
            // 
            colIsSystem.FieldName = "IsSystem";
            colIsSystem.Name = "colIsSystem";
            // 
            // colIsTemporary
            // 
            colIsTemporary.FieldName = "IsTemporary";
            colIsTemporary.Name = "colIsTemporary";
            // 
            // colDeepPercent
            // 
            colDeepPercent.Caption = "Size (%)";
            colDeepPercent.FieldName = "DeepLenghtPercent";
            colDeepPercent.Format.FormatString = "p0";
            colDeepPercent.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDeepPercent.Name = "colDeepPercent";
            colDeepPercent.OptionsColumn.AllowSize = false;
            colDeepPercent.OptionsColumn.FixedWidth = true;
            colDeepPercent.Visible = true;
            colDeepPercent.VisibleIndex = 2;
            colDeepPercent.Width = 70;
            // 
            // colDeepFilesCountPercent
            // 
            colDeepFilesCountPercent.Caption = "Files (%)";
            colDeepFilesCountPercent.FieldName = "DeepFilesCountPercent";
            colDeepFilesCountPercent.Format.FormatString = "p0";
            colDeepFilesCountPercent.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDeepFilesCountPercent.Name = "colDeepFilesCountPercent";
            colDeepFilesCountPercent.OptionsColumn.AllowSize = false;
            colDeepFilesCountPercent.OptionsColumn.FixedWidth = true;
            colDeepFilesCountPercent.Visible = true;
            colDeepFilesCountPercent.VisibleIndex = 4;
            colDeepFilesCountPercent.Width = 70;
            // 
            // resultsBindingSource
            // 
            resultsBindingSource.DataSource = typeof(Core.Model.WambyFolderInfo);
            // 
            // popupMenu
            // 
            popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemCopyPath), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemShowInExplorer), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemShowInCmd), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemProperties), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDelete, true) });
            popupMenu.Manager = barManager;
            popupMenu.Name = "popupMenu";
            // 
            // barButtonItemCopyPath
            // 
            barButtonItemCopyPath.Caption = "Copy Path";
            barButtonItemCopyPath.Id = 2;
            barButtonItemCopyPath.ImageOptions.ImageIndex = 0;
            barButtonItemCopyPath.ImageOptions.LargeImageIndex = 0;
            barButtonItemCopyPath.Name = "barButtonItemCopyPath";
            // 
            // barButtonItemShowInExplorer
            // 
            barButtonItemShowInExplorer.Caption = "Open Folder (Explorer)";
            barButtonItemShowInExplorer.Id = 0;
            barButtonItemShowInExplorer.ImageOptions.ImageIndex = 4;
            barButtonItemShowInExplorer.ImageOptions.LargeImageIndex = 4;
            barButtonItemShowInExplorer.Name = "barButtonItemShowInExplorer";
            // 
            // barButtonItemShowInCmd
            // 
            barButtonItemShowInCmd.Caption = "Open Folder (Cmd)";
            barButtonItemShowInCmd.Id = 1;
            barButtonItemShowInCmd.ImageOptions.ImageIndex = 3;
            barButtonItemShowInCmd.ImageOptions.LargeImageIndex = 3;
            barButtonItemShowInCmd.Name = "barButtonItemShowInCmd";
            // 
            // barButtonItemProperties
            // 
            barButtonItemProperties.Caption = "Properties";
            barButtonItemProperties.Id = 3;
            barButtonItemProperties.ImageOptions.ImageIndex = 2;
            barButtonItemProperties.ImageOptions.LargeImageIndex = 2;
            barButtonItemProperties.Name = "barButtonItemProperties";
            // 
            // barButtonItemDelete
            // 
            barButtonItemDelete.Caption = "Delete";
            barButtonItemDelete.Id = 4;
            barButtonItemDelete.ImageOptions.ImageIndex = 1;
            barButtonItemDelete.ImageOptions.LargeImageIndex = 1;
            barButtonItemDelete.Name = "barButtonItemDelete";
            // 
            // barManager
            // 
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.Form = this;
            barManager.Images = svgImageCollection16;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemShowInExplorer, barButtonItemShowInCmd, barButtonItemCopyPath, barButtonItemProperties, barButtonItemDelete, barButtonItemOpenInNewTab });
            barManager.LargeImages = svgImageCollection32;
            barManager.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager;
            barDockControlTop.Size = new System.Drawing.Size(1012, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 524);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(1012, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1012, 0);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // svgImageCollection16
            // 
            svgImageCollection16.Add("CopyPath", "Wamby.Resources.Images.Results.CopyPath.svg", "Wamby.Resources");
            svgImageCollection16.Add("Delete", "Wamby.Resources.Images.Results.Delete.svg", "Wamby.Resources");
            svgImageCollection16.Add("Properties", "Wamby.Resources.Images.Results.Properties.svg", "Wamby.Resources");
            svgImageCollection16.Add("ShowInCmd", "Wamby.Resources.Images.Results.ShowInCmd.svg", "Wamby.Resources");
            svgImageCollection16.Add("ShowInExplorer", "Wamby.Resources.Images.Results.ShowInExplorer.svg", "Wamby.Resources");
            svgImageCollection16.Add("Scan", "Wamby.Resources.Images.Menu.Scan.svg", "Wamby.Resources");
            // 
            // svgImageCollection32
            // 
            svgImageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            svgImageCollection32.Add("CopyPath", "Wamby.Resources.Images.Results.CopyPath.svg", "Wamby.Resources");
            svgImageCollection32.Add("Delete", "Wamby.Resources.Images.Results.Delete.svg", "Wamby.Resources");
            svgImageCollection32.Add("Properties", "Wamby.Resources.Images.Results.Properties.svg", "Wamby.Resources");
            svgImageCollection32.Add("ShowInCmd", "Wamby.Resources.Images.Results.ShowInCmd.svg", "Wamby.Resources");
            svgImageCollection32.Add("ShowInExplorer", "Wamby.Resources.Images.Results.ShowInExplorer.svg", "Wamby.Resources");
            svgImageCollection32.Add("Scan", "Wamby.Resources.Images.Menu.Scan.svg", "Wamby.Resources");
            // 
            // layoutControl
            // 
            layoutControl.AllowCustomization = false;
            layoutControl.Controls.Add(resultsTreeList);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(1012, 524);
            layoutControl.TabIndex = 2;
            layoutControl.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1012, 524);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = resultsTreeList;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(992, 504);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // barButtonItemOpenInNewTab
            // 
            barButtonItemOpenInNewTab.Caption = "Open In New Tab";
            barButtonItemOpenInNewTab.Id = 5;
            barButtonItemOpenInNewTab.ImageOptions.ImageIndex = 5;
            barButtonItemOpenInNewTab.ImageOptions.LargeImageIndex = 5;
            barButtonItemOpenInNewTab.Name = "barButtonItemOpenInNewTab";
            // 
            // ResultsModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "ResultsModule";
            Size = new System.Drawing.Size(1012, 524);
            ((System.ComponentModel.ISupportInitialize)resultsTreeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraTreeList.TreeList resultsTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepLength;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepFilesCount;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreationTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLastAccessTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLastWriteTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colOwnerName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAttributes;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsArchive;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsCompressed;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsDevice;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsDirectory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsEncrypted;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsHidden;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsIntegrityStream;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsNormal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsNoScrubData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsNotContentIndexed;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsOffline;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsReadOnly;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsReparsePoint;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsSparseFile;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsSystem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsTemporary;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepPercent;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepFilesCountPercent;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowInExplorer;
        private DevExpress.Utils.SvgImageCollection svgImageCollection16;
        private DevExpress.Utils.SvgImageCollection svgImageCollection32;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowInCmd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCopyPath;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProperties;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenInNewTab;
    }
}
