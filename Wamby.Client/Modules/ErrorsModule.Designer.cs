namespace Wamby.Client.Modules
{
    partial class ErrorsModule
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupErrors = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlErrors = new DevExpress.XtraGrid.GridControl();
            this.errorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewErrors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStackTrace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInnerException = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileFullPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewErrors)).BeginInit();
            this.SuspendLayout();
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
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 33;
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 32;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupErrors});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Main Page";
            // 
            // ribbonPageGroupErrors
            // 
            this.ribbonPageGroupErrors.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroupErrors.Name = "ribbonPageGroupErrors";
            this.ribbonPageGroupErrors.Text = "Errors";
            // 
            // gridControlErrors
            // 
            this.gridControlErrors.DataSource = this.errorsBindingSource;
            this.gridControlErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlErrors.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlErrors.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlErrors.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlErrors.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlErrors.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlErrors.Location = new System.Drawing.Point(0, 31);
            this.gridControlErrors.MainView = this.gridViewErrors;
            this.gridControlErrors.Name = "gridControlErrors";
            this.gridControlErrors.Size = new System.Drawing.Size(610, 365);
            this.gridControlErrors.TabIndex = 1;
            this.gridControlErrors.UseEmbeddedNavigator = true;
            this.gridControlErrors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewErrors});
            // 
            // errorsBindingSource
            // 
            this.errorsBindingSource.DataSource = typeof(Wamby.Core.Model.ScanException);
            // 
            // gridViewErrors
            // 
            this.gridViewErrors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSource,
            this.colStackTrace,
            this.colTargetSite,
            this.colInnerException,
            this.colHResult,
            this.colTypeName,
            this.colFileFullPath,
            this.colMessage});
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            this.gridViewErrors.FormatRules.Add(gridFormatRule1);
            this.gridViewErrors.GridControl = this.gridControlErrors;
            this.gridViewErrors.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Extension", null, "({0} items)")});
            this.gridViewErrors.Name = "gridViewErrors";
            this.gridViewErrors.OptionsBehavior.Editable = false;
            this.gridViewErrors.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridViewErrors.OptionsView.ShowFooter = true;
            this.gridViewErrors.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewErrors.OptionsView.ShowIndicator = false;
            // 
            // colSource
            // 
            this.colSource.FieldName = "Source";
            this.colSource.Name = "colSource";
            this.colSource.OptionsColumn.ReadOnly = true;
            this.colSource.Width = 76;
            // 
            // colStackTrace
            // 
            this.colStackTrace.FieldName = "StackTrace";
            this.colStackTrace.Name = "colStackTrace";
            this.colStackTrace.OptionsColumn.ReadOnly = true;
            this.colStackTrace.Width = 76;
            // 
            // colTargetSite
            // 
            this.colTargetSite.FieldName = "TargetSite";
            this.colTargetSite.Name = "colTargetSite";
            this.colTargetSite.OptionsColumn.ReadOnly = true;
            // 
            // colInnerException
            // 
            this.colInnerException.FieldName = "InnerException";
            this.colInnerException.Name = "colInnerException";
            this.colInnerException.OptionsColumn.ReadOnly = true;
            // 
            // colHResult
            // 
            this.colHResult.FieldName = "HResult";
            this.colHResult.Name = "colHResult";
            this.colHResult.OptionsColumn.ReadOnly = true;
            this.colHResult.Width = 83;
            // 
            // colTypeName
            // 
            this.colTypeName.Caption = "Type";
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.OptionsColumn.ReadOnly = true;
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 2;
            this.colTypeName.Width = 76;
            // 
            // colFileFullPath
            // 
            this.colFileFullPath.Caption = "Full path";
            this.colFileFullPath.FieldName = "FileFullPath";
            this.colFileFullPath.Name = "colFileFullPath";
            this.colFileFullPath.Visible = true;
            this.colFileFullPath.VisibleIndex = 0;
            this.colFileFullPath.Width = 187;
            // 
            // colMessage
            // 
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 1;
            this.colMessage.Width = 110;
            // 
            // ErrorsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlErrors);
            this.Controls.Add(this.ribbon);
            this.Name = "ErrorsModule";
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupErrors;
        private DevExpress.XtraGrid.GridControl gridControlErrors;
        private System.Windows.Forms.BindingSource errorsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewErrors;
        private DevExpress.XtraGrid.Columns.GridColumn colSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStackTrace;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetSite;
        private DevExpress.XtraGrid.Columns.GridColumn colInnerException;
        private DevExpress.XtraGrid.Columns.GridColumn colHResult;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colFileFullPath;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
    }
}
