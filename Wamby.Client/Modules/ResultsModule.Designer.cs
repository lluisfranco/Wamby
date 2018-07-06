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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule3 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar3 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule4 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar4 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            this.colDeepLength = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeepFilesCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resultsTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreationTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLastAccessTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLastWriteTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colOwnerName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAttributes = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsArchive = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsCompressed = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsDevice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsDirectory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsEncrypted = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsHidden = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsIntegrityStream = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsNormal = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsNoScrubData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsNotContentIndexed = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsOffline = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsReadOnly = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsReparsePoint = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsSparseFile = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsSystem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsTemporary = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeepPercent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeepFilesCountPercent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemExpandTree = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemExpandLevel = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemExpandLevel1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenInNewWamby = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupResults = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemOpenTerminal = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCopyPath = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemShowProperties = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // colDeepLength
            // 
            this.colDeepLength.Caption = "Size (KB)";
            this.colDeepLength.FieldName = "DeepLengthInKB";
            this.colDeepLength.Format.FormatString = "n0";
            this.colDeepLength.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeepLength.Name = "colDeepLength";
            this.colDeepLength.Visible = true;
            this.colDeepLength.VisibleIndex = 1;
            this.colDeepLength.Width = 99;
            // 
            // colDeepFilesCount
            // 
            this.colDeepFilesCount.Caption = "Files";
            this.colDeepFilesCount.FieldName = "DeepFilesCount";
            this.colDeepFilesCount.Format.FormatString = "n0";
            this.colDeepFilesCount.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeepFilesCount.Name = "colDeepFilesCount";
            this.colDeepFilesCount.Visible = true;
            this.colDeepFilesCount.VisibleIndex = 3;
            this.colDeepFilesCount.Width = 54;
            // 
            // resultsTreeList
            // 
            this.resultsTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLevel,
            this.colIsFolder,
            this.colFullName,
            this.colDeepLength,
            this.colDeepFilesCount,
            this.colCreationTime,
            this.colLastAccessTime,
            this.colLastWriteTime,
            this.colOwnerName,
            this.colAttributes,
            this.colIsArchive,
            this.colIsCompressed,
            this.colIsDevice,
            this.colIsDirectory,
            this.colIsEncrypted,
            this.colIsHidden,
            this.colIsIntegrityStream,
            this.colIsNormal,
            this.colIsNoScrubData,
            this.colIsNotContentIndexed,
            this.colIsOffline,
            this.colIsReadOnly,
            this.colIsReparsePoint,
            this.colIsSparseFile,
            this.colIsSystem,
            this.colIsTemporary,
            this.colDeepPercent,
            this.colDeepFilesCountPercent});
            this.resultsTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultsTreeList.DataSource = this.resultsBindingSource;
            this.resultsTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeListFormatRule3.Column = this.colDeepLength;
            treeListFormatRule3.Name = "Format0";
            formatConditionRuleDataBar3.PredefinedName = "Mint";
            treeListFormatRule3.Rule = formatConditionRuleDataBar3;
            treeListFormatRule4.Column = this.colDeepFilesCount;
            treeListFormatRule4.Name = "Format1";
            formatConditionRuleDataBar4.PredefinedName = "Violet";
            treeListFormatRule4.Rule = formatConditionRuleDataBar4;
            this.resultsTreeList.FormatRules.Add(treeListFormatRule3);
            this.resultsTreeList.FormatRules.Add(treeListFormatRule4);
            this.resultsTreeList.KeyFieldName = "FullName";
            this.resultsTreeList.Location = new System.Drawing.Point(0, 31);
            this.resultsTreeList.Name = "resultsTreeList";
            this.resultsTreeList.OptionsBehavior.Editable = false;
            this.resultsTreeList.OptionsMenu.ShowConditionalFormattingItem = true;
            this.resultsTreeList.OptionsView.ShowHorzLines = false;
            this.resultsTreeList.OptionsView.ShowIndicator = false;
            this.resultsTreeList.ParentFieldName = "ParentFullName";
            this.resultsTreeList.Size = new System.Drawing.Size(1012, 493);
            this.resultsTreeList.TabIndex = 0;
            // 
            // colLevel
            // 
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Width = 122;
            // 
            // colIsFolder
            // 
            this.colIsFolder.FieldName = "IsFolder";
            this.colIsFolder.Name = "colIsFolder";
            this.colIsFolder.Width = 71;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Folder";
            this.colFullName.FieldName = "DisplayName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 323;
            // 
            // colCreationTime
            // 
            this.colCreationTime.FieldName = "CreationTime";
            this.colCreationTime.Format.FormatString = "g";
            this.colCreationTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreationTime.Name = "colCreationTime";
            this.colCreationTime.OptionsColumn.AllowEdit = false;
            this.colCreationTime.OptionsColumn.AllowSize = false;
            this.colCreationTime.OptionsColumn.FixedWidth = true;
            this.colCreationTime.OptionsColumn.ReadOnly = true;
            this.colCreationTime.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colCreationTime.Visible = true;
            this.colCreationTime.VisibleIndex = 5;
            this.colCreationTime.Width = 100;
            // 
            // colLastAccessTime
            // 
            this.colLastAccessTime.FieldName = "LastAccessTime";
            this.colLastAccessTime.Format.FormatString = "g";
            this.colLastAccessTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastAccessTime.Name = "colLastAccessTime";
            this.colLastAccessTime.OptionsColumn.AllowEdit = false;
            this.colLastAccessTime.OptionsColumn.AllowSize = false;
            this.colLastAccessTime.OptionsColumn.FixedWidth = true;
            this.colLastAccessTime.OptionsColumn.ReadOnly = true;
            this.colLastAccessTime.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colLastAccessTime.Visible = true;
            this.colLastAccessTime.VisibleIndex = 6;
            this.colLastAccessTime.Width = 100;
            // 
            // colLastWriteTime
            // 
            this.colLastWriteTime.FieldName = "LastWriteTime";
            this.colLastWriteTime.Format.FormatString = "g";
            this.colLastWriteTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastWriteTime.Name = "colLastWriteTime";
            this.colLastWriteTime.OptionsColumn.AllowEdit = false;
            this.colLastWriteTime.OptionsColumn.AllowSize = false;
            this.colLastWriteTime.OptionsColumn.FixedWidth = true;
            this.colLastWriteTime.OptionsColumn.ReadOnly = true;
            this.colLastWriteTime.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colLastWriteTime.Visible = true;
            this.colLastWriteTime.VisibleIndex = 7;
            this.colLastWriteTime.Width = 100;
            // 
            // colOwnerName
            // 
            this.colOwnerName.Caption = "Owner";
            this.colOwnerName.FieldName = "OwnerName";
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.Visible = true;
            this.colOwnerName.VisibleIndex = 8;
            this.colOwnerName.Width = 46;
            // 
            // colAttributes
            // 
            this.colAttributes.AppearanceCell.Options.UseTextOptions = true;
            this.colAttributes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAttributes.FieldName = "Attributes";
            this.colAttributes.Name = "colAttributes";
            this.colAttributes.OptionsColumn.AllowEdit = false;
            this.colAttributes.OptionsColumn.ReadOnly = true;
            this.colAttributes.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colAttributes.Visible = true;
            this.colAttributes.VisibleIndex = 9;
            this.colAttributes.Width = 48;
            // 
            // colIsArchive
            // 
            this.colIsArchive.FieldName = "IsArchive";
            this.colIsArchive.Name = "colIsArchive";
            // 
            // colIsCompressed
            // 
            this.colIsCompressed.FieldName = "IsCompressed";
            this.colIsCompressed.Name = "colIsCompressed";
            // 
            // colIsDevice
            // 
            this.colIsDevice.FieldName = "IsDevice";
            this.colIsDevice.Name = "colIsDevice";
            // 
            // colIsDirectory
            // 
            this.colIsDirectory.FieldName = "IsDirectory";
            this.colIsDirectory.Name = "colIsDirectory";
            // 
            // colIsEncrypted
            // 
            this.colIsEncrypted.FieldName = "IsEncrypted";
            this.colIsEncrypted.Name = "colIsEncrypted";
            // 
            // colIsHidden
            // 
            this.colIsHidden.FieldName = "IsHidden";
            this.colIsHidden.Name = "colIsHidden";
            // 
            // colIsIntegrityStream
            // 
            this.colIsIntegrityStream.FieldName = "IsIntegrityStream";
            this.colIsIntegrityStream.Name = "colIsIntegrityStream";
            // 
            // colIsNormal
            // 
            this.colIsNormal.FieldName = "IsNormal";
            this.colIsNormal.Name = "colIsNormal";
            // 
            // colIsNoScrubData
            // 
            this.colIsNoScrubData.FieldName = "IsNoScrubData";
            this.colIsNoScrubData.Name = "colIsNoScrubData";
            // 
            // colIsNotContentIndexed
            // 
            this.colIsNotContentIndexed.FieldName = "IsNotContentIndexed";
            this.colIsNotContentIndexed.Name = "colIsNotContentIndexed";
            // 
            // colIsOffline
            // 
            this.colIsOffline.FieldName = "IsOffline";
            this.colIsOffline.Name = "colIsOffline";
            // 
            // colIsReadOnly
            // 
            this.colIsReadOnly.FieldName = "IsReadOnly";
            this.colIsReadOnly.Name = "colIsReadOnly";
            // 
            // colIsReparsePoint
            // 
            this.colIsReparsePoint.FieldName = "IsReparsePoint";
            this.colIsReparsePoint.Name = "colIsReparsePoint";
            // 
            // colIsSparseFile
            // 
            this.colIsSparseFile.FieldName = "IsSparseFile";
            this.colIsSparseFile.Name = "colIsSparseFile";
            // 
            // colIsSystem
            // 
            this.colIsSystem.FieldName = "IsSystem";
            this.colIsSystem.Name = "colIsSystem";
            // 
            // colIsTemporary
            // 
            this.colIsTemporary.FieldName = "IsTemporary";
            this.colIsTemporary.Name = "colIsTemporary";
            // 
            // colDeepPercent
            // 
            this.colDeepPercent.Caption = "Size (%)";
            this.colDeepPercent.FieldName = "DeepLenghtPercent";
            this.colDeepPercent.Format.FormatString = "p0";
            this.colDeepPercent.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeepPercent.Name = "colDeepPercent";
            this.colDeepPercent.OptionsColumn.AllowSize = false;
            this.colDeepPercent.OptionsColumn.FixedWidth = true;
            this.colDeepPercent.Visible = true;
            this.colDeepPercent.VisibleIndex = 2;
            this.colDeepPercent.Width = 70;
            // 
            // colDeepFilesCountPercent
            // 
            this.colDeepFilesCountPercent.Caption = "Files (%)";
            this.colDeepFilesCountPercent.FieldName = "DeepFilesCountPercent";
            this.colDeepFilesCountPercent.Format.FormatString = "p0";
            this.colDeepFilesCountPercent.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeepFilesCountPercent.Name = "colDeepFilesCountPercent";
            this.colDeepFilesCountPercent.OptionsColumn.AllowSize = false;
            this.colDeepFilesCountPercent.OptionsColumn.FixedWidth = true;
            this.colDeepFilesCountPercent.Visible = true;
            this.colDeepFilesCountPercent.VisibleIndex = 4;
            this.colDeepFilesCountPercent.Width = 70;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(Wamby.Core.Model.WambyFolderInfo);
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemExpandTree,
            this.barButtonItemCollapse,
            this.barSubItemExpandLevel,
            this.barButtonItemExpandLevel1,
            this.barButtonItemExpandLevel2,
            this.barButtonItemExpandLevel3,
            this.barButtonItemExpandLevel4,
            this.barButtonItemExpandLevel5,
            this.barButtonItemOpenFolder,
            this.barButtonItemOpenInNewWamby,
            this.barButtonItemOpenTerminal,
            this.barButtonItemCopyPath,
            this.barButtonItemShowProperties,
            this.barButtonItemDelete});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 38;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(1012, 31);
            // 
            // barButtonItemExpandTree
            // 
            this.barButtonItemExpandTree.Caption = "Expand";
            this.barButtonItemExpandTree.Id = 7;
            this.barButtonItemExpandTree.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Expand;
            this.barButtonItemExpandTree.Name = "barButtonItemExpandTree";
            this.barButtonItemExpandTree.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemCollapse
            // 
            this.barButtonItemCollapse.Caption = "Collapse";
            this.barButtonItemCollapse.Id = 8;
            this.barButtonItemCollapse.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Compress;
            this.barButtonItemCollapse.Name = "barButtonItemCollapse";
            this.barButtonItemCollapse.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barSubItemExpandLevel
            // 
            this.barSubItemExpandLevel.Caption = "Expand level";
            this.barSubItemExpandLevel.Id = 10;
            this.barSubItemExpandLevel.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Expand_Level;
            this.barSubItemExpandLevel.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel5)});
            this.barSubItemExpandLevel.Name = "barSubItemExpandLevel";
            // 
            // barButtonItemExpandLevel1
            // 
            this.barButtonItemExpandLevel1.Caption = "Level 1";
            this.barButtonItemExpandLevel1.Id = 11;
            this.barButtonItemExpandLevel1.Name = "barButtonItemExpandLevel1";
            this.barButtonItemExpandLevel1.Tag = 1;
            // 
            // barButtonItemExpandLevel2
            // 
            this.barButtonItemExpandLevel2.Caption = "Level 2";
            this.barButtonItemExpandLevel2.Id = 12;
            this.barButtonItemExpandLevel2.Name = "barButtonItemExpandLevel2";
            this.barButtonItemExpandLevel2.Tag = 2;
            // 
            // barButtonItemExpandLevel3
            // 
            this.barButtonItemExpandLevel3.Caption = "Level 3";
            this.barButtonItemExpandLevel3.Id = 13;
            this.barButtonItemExpandLevel3.Name = "barButtonItemExpandLevel3";
            this.barButtonItemExpandLevel3.Tag = 3;
            // 
            // barButtonItemExpandLevel4
            // 
            this.barButtonItemExpandLevel4.Caption = "Level 4";
            this.barButtonItemExpandLevel4.Id = 14;
            this.barButtonItemExpandLevel4.Name = "barButtonItemExpandLevel4";
            this.barButtonItemExpandLevel4.Tag = 4;
            // 
            // barButtonItemExpandLevel5
            // 
            this.barButtonItemExpandLevel5.Caption = "Level 5";
            this.barButtonItemExpandLevel5.Id = 15;
            this.barButtonItemExpandLevel5.Name = "barButtonItemExpandLevel5";
            this.barButtonItemExpandLevel5.Tag = 5;
            // 
            // barButtonItemOpenFolder
            // 
            this.barButtonItemOpenFolder.Caption = "Open folder (Explorer)";
            this.barButtonItemOpenFolder.Id = 32;
            this.barButtonItemOpenFolder.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.GoTo_Folder_Explorer;
            this.barButtonItemOpenFolder.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.barButtonItemOpenFolder.Name = "barButtonItemOpenFolder";
            // 
            // barButtonItemOpenInNewWamby
            // 
            this.barButtonItemOpenInNewWamby.Caption = "Scan in new Wamby";
            this.barButtonItemOpenInNewWamby.Id = 33;
            this.barButtonItemOpenInNewWamby.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.New;
            this.barButtonItemOpenInNewWamby.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.barButtonItemOpenInNewWamby.Name = "barButtonItemOpenInNewWamby";
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupResults,
            this.ribbonPageGroupOptions});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Main Page";
            // 
            // ribbonPageGroupResults
            // 
            this.ribbonPageGroupResults.ItemLinks.Add(this.barButtonItemExpandTree);
            this.ribbonPageGroupResults.ItemLinks.Add(this.barButtonItemCollapse);
            this.ribbonPageGroupResults.ItemLinks.Add(this.barSubItemExpandLevel, true);
            this.ribbonPageGroupResults.Name = "ribbonPageGroupResults";
            this.ribbonPageGroupResults.Text = "Results";
            // 
            // ribbonPageGroupOptions
            // 
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenFolder);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenTerminal);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenInNewWamby);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemCopyPath, true);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemShowProperties);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroupOptions.Name = "ribbonPageGroupOptions";
            this.ribbonPageGroupOptions.Text = "Options";
            // 
            // popupMenu
            // 
            this.popupMenu.ItemLinks.Add(this.barButtonItemOpenFolder);
            this.popupMenu.ItemLinks.Add(this.barButtonItemOpenTerminal);
            this.popupMenu.ItemLinks.Add(this.barButtonItemOpenInNewWamby);
            this.popupMenu.ItemLinks.Add(this.barButtonItemCopyPath, true);
            this.popupMenu.ItemLinks.Add(this.barButtonItemShowProperties);
            this.popupMenu.ItemLinks.Add(this.barButtonItemDelete);
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbon;
            // 
            // barButtonItemOpenTerminal
            // 
            this.barButtonItemOpenTerminal.Caption = "Open folder (Terminal)";
            this.barButtonItemOpenTerminal.Id = 34;
            this.barButtonItemOpenTerminal.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.GoTo_Cmd;
            this.barButtonItemOpenTerminal.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.barButtonItemOpenTerminal.Name = "barButtonItemOpenTerminal";
            // 
            // barButtonItemCopyPath
            // 
            this.barButtonItemCopyPath.Caption = "Copy path";
            this.barButtonItemCopyPath.Id = 35;
            this.barButtonItemCopyPath.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Copy_Url;
            this.barButtonItemCopyPath.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.barButtonItemCopyPath.Name = "barButtonItemCopyPath";
            this.barButtonItemCopyPath.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemShowProperties
            // 
            this.barButtonItemShowProperties.Caption = "Show properties";
            this.barButtonItemShowProperties.Id = 36;
            this.barButtonItemShowProperties.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Analysis_Show_Properties;
            this.barButtonItemShowProperties.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Enter));
            this.barButtonItemShowProperties.Name = "barButtonItemShowProperties";
            this.barButtonItemShowProperties.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Delete";
            this.barButtonItemDelete.Id = 37;
            this.barButtonItemDelete.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Delete;
            this.barButtonItemDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // ResultsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultsTreeList);
            this.Controls.Add(this.ribbon);
            this.Name = "ResultsModule";
            this.Size = new System.Drawing.Size(1012, 524);
            ((System.ComponentModel.ISupportInitialize)(this.resultsTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList resultsTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepLength;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepFilesCount;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandTree;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCollapse;
        private DevExpress.XtraBars.BarSubItem barSubItemExpandLevel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupResults;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupOptions;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenInNewWamby;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenTerminal;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCopyPath;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowProperties;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
    }
}
