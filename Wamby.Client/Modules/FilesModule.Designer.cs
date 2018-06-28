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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.newAppBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportXls = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandTree = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemExpandLevel = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemExpandLevel1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemLayoutAlgorithm = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemLayoutAlgorithmSliceAndDice = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLayoutAlgorithmSquarified = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLayoutAlgorithmStriped = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemDirection = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemDirectionBottomLeftToTopRight = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDirectionBottomRightToTopLeft = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDirectionTopLeftToBottomRight = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDirectionTopRightToBottomLeft = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItemMapBySize = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemMapByFilesCount = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemShowProperties = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemShowChart = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemShowColumnList = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItemShowFooter = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemSearch = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupFiles = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.gridControlFiles.Size = new System.Drawing.Size(610, 365);
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
            this.colOwnerName});
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
            this.colLastWriteTime.VisibleIndex = 5;
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
            this.colLastAccessTime.VisibleIndex = 4;
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
            this.colCreationTime.VisibleIndex = 3;
            this.colCreationTime.Width = 100;
            // 
            // colOwnerName
            // 
            this.colOwnerName.FieldName = "OwnerName";
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.Visible = true;
            this.colOwnerName.VisibleIndex = 2;
            this.colOwnerName.Width = 54;
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinDropDownButtonItem1,
            this.newAppBarButtonItem,
            this.skinPaletteRibbonGalleryBarItem1,
            this.barButtonItemPrint,
            this.barButtonItemExportXls,
            this.barButtonItemExportPdf,
            this.barButtonItemExpandTree,
            this.barButtonItemCollapse,
            this.barSubItemExpandLevel,
            this.barButtonItemExpandLevel1,
            this.barButtonItemExpandLevel2,
            this.barButtonItemExpandLevel3,
            this.barButtonItemExpandLevel4,
            this.barButtonItemExpandLevel5,
            this.barButtonItem6,
            this.barSubItemLayoutAlgorithm,
            this.barSubItemDirection,
            this.barCheckItemMapBySize,
            this.barCheckItemMapByFilesCount,
            this.barButtonItemLayoutAlgorithmSliceAndDice,
            this.barButtonItemLayoutAlgorithmSquarified,
            this.barButtonItemLayoutAlgorithmStriped,
            this.barButtonItemDirectionBottomLeftToTopRight,
            this.barButtonItemDirectionBottomRightToTopLeft,
            this.barButtonItemDirectionTopLeftToBottomRight,
            this.barButtonItemDirectionTopRightToBottomLeft,
            this.barCheckItemShowProperties,
            this.barCheckItemShowChart,
            this.barButtonItemShowColumnList,
            this.barCheckItemShowFooter,
            this.barButtonItemSearch});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 35;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(610, 31);
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
            // barButtonItemPrint
            // 
            this.barButtonItemPrint.Caption = "Print";
            this.barButtonItemPrint.Id = 4;
            this.barButtonItemPrint.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Print_Preview;
            this.barButtonItemPrint.Name = "barButtonItemPrint";
            // 
            // barButtonItemExportXls
            // 
            this.barButtonItemExportXls.Caption = "Export Xls";
            this.barButtonItemExportXls.Id = 5;
            this.barButtonItemExportXls.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Export_To_Excel;
            this.barButtonItemExportXls.Name = "barButtonItemExportXls";
            // 
            // barButtonItemExportPdf
            // 
            this.barButtonItemExportPdf.Caption = "Export Pdf";
            this.barButtonItemExportPdf.Id = 6;
            this.barButtonItemExportPdf.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Export_To_Pdf;
            this.barButtonItemExportPdf.Name = "barButtonItemExportPdf";
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
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 16;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barSubItemLayoutAlgorithm
            // 
            this.barSubItemLayoutAlgorithm.Caption = "Layout algorithm";
            this.barSubItemLayoutAlgorithm.Id = 18;
            this.barSubItemLayoutAlgorithm.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_Layout;
            this.barSubItemLayoutAlgorithm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLayoutAlgorithmSliceAndDice),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLayoutAlgorithmSquarified),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLayoutAlgorithmStriped)});
            this.barSubItemLayoutAlgorithm.Name = "barSubItemLayoutAlgorithm";
            // 
            // barButtonItemLayoutAlgorithmSliceAndDice
            // 
            this.barButtonItemLayoutAlgorithmSliceAndDice.Caption = "Slice And Dice";
            this.barButtonItemLayoutAlgorithmSliceAndDice.Id = 23;
            this.barButtonItemLayoutAlgorithmSliceAndDice.Name = "barButtonItemLayoutAlgorithmSliceAndDice";
            // 
            // barButtonItemLayoutAlgorithmSquarified
            // 
            this.barButtonItemLayoutAlgorithmSquarified.Caption = "Squarified";
            this.barButtonItemLayoutAlgorithmSquarified.Id = 24;
            this.barButtonItemLayoutAlgorithmSquarified.Name = "barButtonItemLayoutAlgorithmSquarified";
            // 
            // barButtonItemLayoutAlgorithmStriped
            // 
            this.barButtonItemLayoutAlgorithmStriped.Caption = "Striped";
            this.barButtonItemLayoutAlgorithmStriped.Id = 25;
            this.barButtonItemLayoutAlgorithmStriped.Name = "barButtonItemLayoutAlgorithmStriped";
            // 
            // barSubItemDirection
            // 
            this.barSubItemDirection.Caption = "Direction";
            this.barSubItemDirection.Id = 19;
            this.barSubItemDirection.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_Direction;
            this.barSubItemDirection.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionBottomLeftToTopRight),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionBottomRightToTopLeft),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionTopLeftToBottomRight),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDirectionTopRightToBottomLeft)});
            this.barSubItemDirection.Name = "barSubItemDirection";
            // 
            // barButtonItemDirectionBottomLeftToTopRight
            // 
            this.barButtonItemDirectionBottomLeftToTopRight.Caption = "Bottom Left To Top Right";
            this.barButtonItemDirectionBottomLeftToTopRight.Id = 26;
            this.barButtonItemDirectionBottomLeftToTopRight.Name = "barButtonItemDirectionBottomLeftToTopRight";
            // 
            // barButtonItemDirectionBottomRightToTopLeft
            // 
            this.barButtonItemDirectionBottomRightToTopLeft.Caption = "Bottom Right To Top Left";
            this.barButtonItemDirectionBottomRightToTopLeft.Id = 27;
            this.barButtonItemDirectionBottomRightToTopLeft.Name = "barButtonItemDirectionBottomRightToTopLeft";
            // 
            // barButtonItemDirectionTopLeftToBottomRight
            // 
            this.barButtonItemDirectionTopLeftToBottomRight.Caption = "Top Left To Bottom Right";
            this.barButtonItemDirectionTopLeftToBottomRight.Id = 28;
            this.barButtonItemDirectionTopLeftToBottomRight.Name = "barButtonItemDirectionTopLeftToBottomRight";
            // 
            // barButtonItemDirectionTopRightToBottomLeft
            // 
            this.barButtonItemDirectionTopRightToBottomLeft.Caption = "Top Right To Bottom Left";
            this.barButtonItemDirectionTopRightToBottomLeft.Id = 29;
            this.barButtonItemDirectionTopRightToBottomLeft.Name = "barButtonItemDirectionTopRightToBottomLeft";
            // 
            // barCheckItemMapBySize
            // 
            this.barCheckItemMapBySize.BindableChecked = true;
            this.barCheckItemMapBySize.Caption = "Size";
            this.barCheckItemMapBySize.Checked = true;
            this.barCheckItemMapBySize.GroupIndex = 1;
            this.barCheckItemMapBySize.Id = 20;
            this.barCheckItemMapBySize.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_By_Size;
            this.barCheckItemMapBySize.Name = "barCheckItemMapBySize";
            // 
            // barCheckItemMapByFilesCount
            // 
            this.barCheckItemMapByFilesCount.Caption = "Files Count";
            this.barCheckItemMapByFilesCount.GroupIndex = 1;
            this.barCheckItemMapByFilesCount.Id = 21;
            this.barCheckItemMapByFilesCount.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Map_By_FilesCount;
            this.barCheckItemMapByFilesCount.Name = "barCheckItemMapByFilesCount";
            // 
            // barCheckItemShowProperties
            // 
            this.barCheckItemShowProperties.BindableChecked = true;
            this.barCheckItemShowProperties.Caption = "Properties";
            this.barCheckItemShowProperties.Checked = true;
            this.barCheckItemShowProperties.Id = 30;
            this.barCheckItemShowProperties.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Analysis_Show_Properties;
            this.barCheckItemShowProperties.Name = "barCheckItemShowProperties";
            // 
            // barCheckItemShowChart
            // 
            this.barCheckItemShowChart.BindableChecked = true;
            this.barCheckItemShowChart.Caption = "Chart";
            this.barCheckItemShowChart.Checked = true;
            this.barCheckItemShowChart.Id = 31;
            this.barCheckItemShowChart.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Analysis_Show_Chart;
            this.barCheckItemShowChart.Name = "barCheckItemShowChart";
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
            this.barCheckItemShowFooter.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Show_Footer;
            this.barCheckItemShowFooter.Name = "barCheckItemShowFooter";
            // 
            // barButtonItemSearch
            // 
            this.barButtonItemSearch.Caption = "Search";
            this.barButtonItemSearch.Id = 34;
            this.barButtonItemSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemSearch.ImageOptions.SvgImage")));
            this.barButtonItemSearch.Name = "barButtonItemSearch";
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupFiles});
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
            // FilesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlFiles);
            this.Controls.Add(this.ribbon);
            this.Name = "FilesModule";
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
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
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem newAppBarButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportXls;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportPdf;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandTree;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCollapse;
        private DevExpress.XtraBars.BarSubItem barSubItemExpandLevel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarSubItem barSubItemLayoutAlgorithm;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLayoutAlgorithmSliceAndDice;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLayoutAlgorithmSquarified;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLayoutAlgorithmStriped;
        private DevExpress.XtraBars.BarSubItem barSubItemDirection;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionBottomLeftToTopRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionBottomRightToTopLeft;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionTopLeftToBottomRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDirectionTopRightToBottomLeft;
        private DevExpress.XtraBars.BarCheckItem barCheckItemMapBySize;
        private DevExpress.XtraBars.BarCheckItem barCheckItemMapByFilesCount;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowProperties;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowChart;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowColumnList;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFiles;
        private DevExpress.XtraBars.BarCheckItem barCheckItemShowFooter;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSearch;
    }
}
