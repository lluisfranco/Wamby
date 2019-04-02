namespace Wamby.Client.Modules
{
    partial class FilesModule
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesModule));
            this.colLengthInKB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlFiles = new DevExpress.XtraGrid.GridControl();
            this.gridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastWriteTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastAccessTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttributes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsArchive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCompressed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDevice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDirectory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEncrypted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsHidden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsIntegrityStream = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNormal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNoScrubData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNotContentIndexed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsOffline = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReparsePoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSparseFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSystem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTemporary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemShowColumnList = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItemShowFooter = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenInNewWamby = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenTerminal = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCopyPath = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemShowProperties = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenRunFile = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupFiles = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // colLengthInKB
            // 
            this.colLengthInKB.Caption = "Size (KB)";
            this.colLengthInKB.DisplayFormat.FormatString = "n0";
            this.colLengthInKB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLengthInKB.FieldName = "LengthInKB";
            this.colLengthInKB.Name = "colLengthInKB";
            this.colLengthInKB.OptionsColumn.ReadOnly = true;
            this.colLengthInKB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LengthInKB", "{0:n0}")});
            this.colLengthInKB.Visible = true;
            this.colLengthInKB.VisibleIndex = 1;
            this.colLengthInKB.Width = 51;
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataSource = typeof(Wamby.Core.Model.WambyFileInfo);
            // 
            // gridControlFiles
            // 
            this.gridControlFiles.DataSource = this.filesBindingSource;
            this.gridControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlFiles.Location = new System.Drawing.Point(0, 31);
            this.gridControlFiles.MainView = this.gridViewFiles;
            this.gridControlFiles.Name = "gridControlFiles";
            this.gridControlFiles.Size = new System.Drawing.Size(919, 365);
            this.gridControlFiles.TabIndex = 0;
            this.gridControlFiles.UseEmbeddedNavigator = true;
            this.gridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFiles});
            // 
            // gridViewFiles
            // 
            this.gridViewFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExtension,
            this.colParentFullName,
            this.colFullName,
            this.colName,
            this.colLength,
            this.colLengthInKB,
            this.colLastWriteTime,
            this.colLastAccessTime,
            this.colCreationTime,
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
            this.colIsTemporary});
            gridFormatRule1.Column = this.colLengthInKB;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            this.gridViewFiles.FormatRules.Add(gridFormatRule1);
            this.gridViewFiles.GridControl = this.gridControlFiles;
            this.gridViewFiles.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Extension", null, "({0} items)")});
            this.gridViewFiles.Name = "gridViewFiles";
            this.gridViewFiles.OptionsBehavior.Editable = false;
            this.gridViewFiles.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridViewFiles.OptionsView.ShowFooter = true;
            this.gridViewFiles.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewFiles.OptionsView.ShowIndicator = false;
            this.gridViewFiles.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFullName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colExtension
            // 
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            // 
            // colParentFullName
            // 
            this.colParentFullName.FieldName = "ParentFullName";
            this.colParentFullName.Name = "colParentFullName";
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FullName", "{0}")});
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 214;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            // 
            // colLength
            // 
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            // 
            // colLastWriteTime
            // 
            this.colLastWriteTime.DisplayFormat.FormatString = "g";
            this.colLastWriteTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastWriteTime.FieldName = "LastWriteTime";
            this.colLastWriteTime.Name = "colLastWriteTime";
            this.colLastWriteTime.OptionsColumn.AllowSize = false;
            this.colLastWriteTime.OptionsColumn.FixedWidth = true;
            this.colLastWriteTime.Visible = true;
            this.colLastWriteTime.VisibleIndex = 4;
            this.colLastWriteTime.Width = 100;
            // 
            // colLastAccessTime
            // 
            this.colLastAccessTime.DisplayFormat.FormatString = "g";
            this.colLastAccessTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastAccessTime.FieldName = "LastAccessTime";
            this.colLastAccessTime.Name = "colLastAccessTime";
            this.colLastAccessTime.OptionsColumn.AllowSize = false;
            this.colLastAccessTime.OptionsColumn.FixedWidth = true;
            this.colLastAccessTime.Visible = true;
            this.colLastAccessTime.VisibleIndex = 3;
            this.colLastAccessTime.Width = 100;
            // 
            // colCreationTime
            // 
            this.colCreationTime.DisplayFormat.FormatString = "g";
            this.colCreationTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreationTime.FieldName = "CreationTime";
            this.colCreationTime.Name = "colCreationTime";
            this.colCreationTime.OptionsColumn.AllowSize = false;
            this.colCreationTime.OptionsColumn.FixedWidth = true;
            this.colCreationTime.Visible = true;
            this.colCreationTime.VisibleIndex = 2;
            this.colCreationTime.Width = 100;
            // 
            // colOwnerName
            // 
            this.colOwnerName.FieldName = "OwnerName";
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.Visible = true;
            this.colOwnerName.VisibleIndex = 5;
            this.colOwnerName.Width = 54;
            // 
            // colAttributes
            // 
            this.colAttributes.FieldName = "Attributes";
            this.colAttributes.Name = "colAttributes";
            this.colAttributes.Visible = true;
            this.colAttributes.VisibleIndex = 6;
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
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemShowColumnList,
            this.barCheckItemShowFooter,
            this.barButtonItemSearch,
            this.barButtonItemOpenFolder,
            this.barButtonItemOpenInNewWamby,
            this.barButtonItemOpenTerminal,
            this.barButtonItemCopyPath,
            this.barButtonItemShowProperties,
            this.barButtonItemDelete,
            this.barButtonItemOpenRunFile});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 36;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(919, 31);
            // 
            // barButtonItemShowColumnList
            // 
            this.barButtonItemShowColumnList.Caption = "Show columns list";
            this.barButtonItemShowColumnList.Id = 32;
            this.barButtonItemShowColumnList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemShowColumnList.ImageOptions.SvgImage")));
            this.barButtonItemShowColumnList.Name = "barButtonItemShowColumnList";
            // 
            // barCheckItemShowFooter
            // 
            this.barCheckItemShowFooter.BindableChecked = true;
            this.barCheckItemShowFooter.Caption = "Show footer";
            this.barCheckItemShowFooter.Checked = true;
            this.barCheckItemShowFooter.Id = 33;
            this.barCheckItemShowFooter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barCheckItemShowFooter.ImageOptions.SvgImage")));
            this.barCheckItemShowFooter.Name = "barCheckItemShowFooter";
            // 
            // barButtonItemSearch
            // 
            this.barButtonItemSearch.Caption = "Search";
            this.barButtonItemSearch.Id = 34;
            this.barButtonItemSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemSearch.ImageOptions.SvgImage")));
            this.barButtonItemSearch.Name = "barButtonItemSearch";
            // 
            // barButtonItemOpenFolder
            // 
            this.barButtonItemOpenFolder.Caption = "Open folder (Explorer)";
            this.barButtonItemOpenFolder.Id = 32;
            this.barButtonItemOpenFolder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemOpenFolder.ImageOptions.SvgImage")));
            this.barButtonItemOpenFolder.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.barButtonItemOpenFolder.Name = "barButtonItemOpenFolder";
            // 
            // barButtonItemOpenInNewWamby
            // 
            this.barButtonItemOpenInNewWamby.Caption = "Scan in new Wamby";
            this.barButtonItemOpenInNewWamby.Id = 33;
            this.barButtonItemOpenInNewWamby.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemOpenInNewWamby.ImageOptions.SvgImage")));
            this.barButtonItemOpenInNewWamby.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.barButtonItemOpenInNewWamby.Name = "barButtonItemOpenInNewWamby";
            // 
            // barButtonItemOpenTerminal
            // 
            this.barButtonItemOpenTerminal.Caption = "Open folder (Terminal)";
            this.barButtonItemOpenTerminal.Id = 34;
            this.barButtonItemOpenTerminal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemOpenTerminal.ImageOptions.SvgImage")));
            this.barButtonItemOpenTerminal.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.barButtonItemOpenTerminal.Name = "barButtonItemOpenTerminal";
            // 
            // barButtonItemCopyPath
            // 
            this.barButtonItemCopyPath.Caption = "Copy path";
            this.barButtonItemCopyPath.Id = 35;
            this.barButtonItemCopyPath.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemCopyPath.ImageOptions.SvgImage")));
            this.barButtonItemCopyPath.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.barButtonItemCopyPath.Name = "barButtonItemCopyPath";
            this.barButtonItemCopyPath.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemShowProperties
            // 
            this.barButtonItemShowProperties.Caption = "Show properties";
            this.barButtonItemShowProperties.Id = 36;
            this.barButtonItemShowProperties.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemShowProperties.ImageOptions.SvgImage")));
            this.barButtonItemShowProperties.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Enter));
            this.barButtonItemShowProperties.Name = "barButtonItemShowProperties";
            this.barButtonItemShowProperties.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Delete";
            this.barButtonItemDelete.Id = 37;
            this.barButtonItemDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemDelete.ImageOptions.SvgImage")));
            this.barButtonItemDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemOpenRunFile
            // 
            this.barButtonItemOpenRunFile.Caption = "Open/Run file";
            this.barButtonItemOpenRunFile.Id = 35;
            this.barButtonItemOpenRunFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemOpenRunFile.ImageOptions.SvgImage")));
            this.barButtonItemOpenRunFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.barButtonItemOpenRunFile.Name = "barButtonItemOpenRunFile";
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupFiles,
            this.ribbonPageGroupOptions});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Main Page";
            // 
            // ribbonPageGroupFiles
            // 
            this.ribbonPageGroupFiles.ItemLinks.Add(this.barButtonItemShowColumnList);
            this.ribbonPageGroupFiles.ItemLinks.Add(this.barButtonItemSearch);
            this.ribbonPageGroupFiles.ItemLinks.Add(this.barCheckItemShowFooter);
            this.ribbonPageGroupFiles.Name = "ribbonPageGroupFiles";
            this.ribbonPageGroupFiles.Text = "Files Main";
            // 
            // ribbonPageGroupOptions
            // 
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenFolder);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenTerminal);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenInNewWamby);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenRunFile, true);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemCopyPath);
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
            this.popupMenu.ItemLinks.Add(this.barButtonItemOpenRunFile, true);
            this.popupMenu.ItemLinks.Add(this.barButtonItemCopyPath);
            this.popupMenu.ItemLinks.Add(this.barButtonItemShowProperties);
            this.popupMenu.ItemLinks.Add(this.barButtonItemDelete);
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbon;
            // 
            // FilesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlFiles);
            this.Controls.Add(this.ribbon);
            this.Name = "FilesModule";
            this.Size = new System.Drawing.Size(919, 396);
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource filesBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiles;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colParentFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colLengthInKB;
        private DevExpress.XtraGrid.Columns.GridColumn colLastWriteTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLastAccessTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationTime;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerName;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowColumnList;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFiles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupOptions;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenInNewWamby;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenTerminal;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCopyPath;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowProperties;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowFooter;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colAttributes;
        private DevExpress.XtraGrid.Columns.GridColumn colIsArchive;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCompressed;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDirectory;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEncrypted;
        private DevExpress.XtraGrid.Columns.GridColumn colIsHidden;
        private DevExpress.XtraGrid.Columns.GridColumn colIsIntegrityStream;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNormal;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNoScrubData;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNotContentIndexed;
        private DevExpress.XtraGrid.Columns.GridColumn colIsOffline;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReparsePoint;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSparseFile;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSystem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTemporary;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenRunFile;
    }
}
