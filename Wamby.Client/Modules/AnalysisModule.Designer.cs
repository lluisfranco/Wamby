namespace Wamby.Client.Modules
{
    partial class AnalysisModule
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            resultsBindingSource = new System.Windows.Forms.BindingSource(components);
            fieldFullName = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldName = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldExtension = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldCreationTime = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldLastAccessTime = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldLastWriteTime = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldLengthInKB = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldLengthPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldParentFullName = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldOwnerName = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldAttributes = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsArchive = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsCompressed = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsDevice = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsDirectory = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsEncrypted = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsHidden = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsIntegrityStream = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsNormal = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsNoScrubData = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsNotContentIndexed = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsOffline = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsReadOnly = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsReparsePoint = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsSparseFile = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsSystem = new DevExpress.XtraPivotGrid.PivotGridField();
            fieldIsTemporary = new DevExpress.XtraPivotGrid.PivotGridField();
            dockManager = new DevExpress.XtraBars.Docking.DockManager(components);
            panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanelProperties = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            columnsImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            dockPanelChart = new DevExpress.XtraBars.Docking.DockPanel();
            controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            chartControl = new DevExpress.XtraCharts.ChartControl();
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)pivotGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).BeginInit();
            panelContainer1.SuspendLayout();
            dockPanelProperties.SuspendLayout();
            dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propertyGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)columnsImageComboBoxEdit.Properties).BeginInit();
            dockPanelChart.SuspendLayout();
            controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideBarSeriesView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // pivotGridControl
            // 
            pivotGridControl.DataSource = resultsBindingSource;
            pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] { fieldFullName, fieldName, fieldExtension, fieldCreationTime, fieldLastAccessTime, fieldLastWriteTime, fieldLengthInKB, fieldLengthPercent, fieldParentFullName, fieldOwnerName, fieldAttributes, fieldIsArchive, fieldIsCompressed, fieldIsDevice, fieldIsDirectory, fieldIsEncrypted, fieldIsHidden, fieldIsIntegrityStream, fieldIsNormal, fieldIsNoScrubData, fieldIsNotContentIndexed, fieldIsOffline, fieldIsReadOnly, fieldIsReparsePoint, fieldIsSparseFile, fieldIsSystem, fieldIsTemporary });
            pivotGridControl.Location = new System.Drawing.Point(12, 12);
            pivotGridControl.Name = "pivotGridControl";
            pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            pivotGridControl.OptionsMenu.EnableFormatRulesMenu = true;
            pivotGridControl.Size = new System.Drawing.Size(457, 577);
            pivotGridControl.TabIndex = 0;
            // 
            // resultsBindingSource
            // 
            resultsBindingSource.DataSource = typeof(Core.Model.WambyFileInfo);
            // 
            // fieldFullName
            // 
            fieldFullName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldFullName.AreaIndex = 0;
            fieldFullName.Caption = "Full name";
            fieldFullName.FieldName = "FullName";
            fieldFullName.Name = "fieldFullName";
            fieldFullName.Visible = false;
            // 
            // fieldName
            // 
            fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldName.AreaIndex = 0;
            fieldName.Caption = "Name";
            fieldName.FieldName = "Name";
            fieldName.Name = "fieldName";
            fieldName.TotalCellFormat.FormatString = "n0";
            fieldName.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldName.TotalValueFormat.FormatString = "n0";
            fieldName.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldName.Visible = false;
            // 
            // fieldExtension
            // 
            fieldExtension.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldExtension.AreaIndex = 0;
            fieldExtension.Caption = "Extension";
            fieldExtension.FieldName = "Extension";
            fieldExtension.Name = "fieldExtension";
            // 
            // fieldCreationTime
            // 
            fieldCreationTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldCreationTime.AreaIndex = 1;
            fieldCreationTime.Caption = "Creation time";
            fieldCreationTime.FieldName = "CreationTime";
            fieldCreationTime.Name = "fieldCreationTime";
            fieldCreationTime.Visible = false;
            // 
            // fieldLastAccessTime
            // 
            fieldLastAccessTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldLastAccessTime.AreaIndex = 1;
            fieldLastAccessTime.Caption = "Last access time";
            fieldLastAccessTime.FieldName = "LastAccessTime";
            fieldLastAccessTime.Name = "fieldLastAccessTime";
            fieldLastAccessTime.Visible = false;
            // 
            // fieldLastWriteTime
            // 
            fieldLastWriteTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldLastWriteTime.AreaIndex = 1;
            fieldLastWriteTime.Caption = "Last write time";
            fieldLastWriteTime.FieldName = "LastWriteTime";
            fieldLastWriteTime.Name = "fieldLastWriteTime";
            fieldLastWriteTime.Visible = false;
            // 
            // fieldLengthInKB
            // 
            fieldLengthInKB.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldLengthInKB.AreaIndex = 0;
            fieldLengthInKB.Caption = "Size (KB)";
            fieldLengthInKB.CellFormat.FormatString = "n0";
            fieldLengthInKB.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldLengthInKB.FieldName = "LengthInKB";
            fieldLengthInKB.GrandTotalCellFormat.FormatString = "n0";
            fieldLengthInKB.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldLengthInKB.Name = "fieldLengthInKB";
            fieldLengthInKB.TotalCellFormat.FormatString = "n0";
            fieldLengthInKB.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldLengthInKB.TotalValueFormat.FormatString = "n0";
            fieldLengthInKB.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldLengthPercent
            // 
            fieldLengthPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldLengthPercent.AreaIndex = 1;
            fieldLengthPercent.Caption = "Size (%)";
            fieldLengthPercent.CellFormat.FormatString = "p0";
            fieldLengthPercent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldLengthPercent.FieldName = "LengthInKB";
            fieldLengthPercent.GrandTotalCellFormat.FormatString = "p0";
            fieldLengthPercent.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldLengthPercent.Name = "fieldLengthPercent";
            fieldLengthPercent.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
            fieldLengthPercent.TotalCellFormat.FormatString = "p0";
            fieldLengthPercent.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldLengthPercent.TotalValueFormat.FormatString = "p0";
            fieldLengthPercent.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldLengthPercent.Visible = false;
            // 
            // fieldParentFullName
            // 
            fieldParentFullName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldParentFullName.AreaIndex = 3;
            fieldParentFullName.Caption = "Folder name";
            fieldParentFullName.FieldName = "ParentFullName";
            fieldParentFullName.Name = "fieldParentFullName";
            fieldParentFullName.Visible = false;
            // 
            // fieldOwnerName
            // 
            fieldOwnerName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldOwnerName.AreaIndex = 0;
            fieldOwnerName.Caption = "Owner";
            fieldOwnerName.FieldName = "OwnerName";
            fieldOwnerName.Name = "fieldOwnerName";
            fieldOwnerName.Width = 131;
            // 
            // fieldAttributes
            // 
            fieldAttributes.AreaIndex = 0;
            fieldAttributes.FieldName = "Attributes";
            fieldAttributes.Name = "fieldAttributes";
            // 
            // fieldIsArchive
            // 
            fieldIsArchive.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsArchive.AreaIndex = 2;
            fieldIsArchive.FieldName = "IsArchive";
            fieldIsArchive.Name = "fieldIsArchive";
            fieldIsArchive.Visible = false;
            // 
            // fieldIsCompressed
            // 
            fieldIsCompressed.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsCompressed.AreaIndex = 2;
            fieldIsCompressed.FieldName = "IsCompressed";
            fieldIsCompressed.Name = "fieldIsCompressed";
            fieldIsCompressed.Visible = false;
            // 
            // fieldIsDevice
            // 
            fieldIsDevice.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsDevice.AreaIndex = 2;
            fieldIsDevice.FieldName = "IsDevice";
            fieldIsDevice.Name = "fieldIsDevice";
            fieldIsDevice.Visible = false;
            // 
            // fieldIsDirectory
            // 
            fieldIsDirectory.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsDirectory.AreaIndex = 2;
            fieldIsDirectory.FieldName = "IsDirectory";
            fieldIsDirectory.Name = "fieldIsDirectory";
            fieldIsDirectory.Visible = false;
            // 
            // fieldIsEncrypted
            // 
            fieldIsEncrypted.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsEncrypted.AreaIndex = 2;
            fieldIsEncrypted.FieldName = "IsEncrypted";
            fieldIsEncrypted.Name = "fieldIsEncrypted";
            fieldIsEncrypted.Visible = false;
            // 
            // fieldIsHidden
            // 
            fieldIsHidden.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsHidden.AreaIndex = 2;
            fieldIsHidden.FieldName = "IsHidden";
            fieldIsHidden.Name = "fieldIsHidden";
            fieldIsHidden.Visible = false;
            // 
            // fieldIsIntegrityStream
            // 
            fieldIsIntegrityStream.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsIntegrityStream.AreaIndex = 8;
            fieldIsIntegrityStream.FieldName = "IsIntegrityStream";
            fieldIsIntegrityStream.Name = "fieldIsIntegrityStream";
            fieldIsIntegrityStream.Visible = false;
            // 
            // fieldIsNormal
            // 
            fieldIsNormal.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsNormal.AreaIndex = 2;
            fieldIsNormal.FieldName = "IsNormal";
            fieldIsNormal.Name = "fieldIsNormal";
            fieldIsNormal.Visible = false;
            // 
            // fieldIsNoScrubData
            // 
            fieldIsNoScrubData.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsNoScrubData.AreaIndex = 9;
            fieldIsNoScrubData.FieldName = "IsNoScrubData";
            fieldIsNoScrubData.Name = "fieldIsNoScrubData";
            fieldIsNoScrubData.Visible = false;
            // 
            // fieldIsNotContentIndexed
            // 
            fieldIsNotContentIndexed.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsNotContentIndexed.AreaIndex = 9;
            fieldIsNotContentIndexed.FieldName = "IsNotContentIndexed";
            fieldIsNotContentIndexed.Name = "fieldIsNotContentIndexed";
            fieldIsNotContentIndexed.Visible = false;
            // 
            // fieldIsOffline
            // 
            fieldIsOffline.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsOffline.AreaIndex = 2;
            fieldIsOffline.FieldName = "IsOffline";
            fieldIsOffline.Name = "fieldIsOffline";
            fieldIsOffline.Visible = false;
            // 
            // fieldIsReadOnly
            // 
            fieldIsReadOnly.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsReadOnly.AreaIndex = 2;
            fieldIsReadOnly.FieldName = "IsReadOnly";
            fieldIsReadOnly.Name = "fieldIsReadOnly";
            fieldIsReadOnly.Visible = false;
            // 
            // fieldIsReparsePoint
            // 
            fieldIsReparsePoint.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsReparsePoint.AreaIndex = 11;
            fieldIsReparsePoint.FieldName = "IsReparsePoint";
            fieldIsReparsePoint.Name = "fieldIsReparsePoint";
            fieldIsReparsePoint.Visible = false;
            // 
            // fieldIsSparseFile
            // 
            fieldIsSparseFile.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsSparseFile.AreaIndex = 11;
            fieldIsSparseFile.FieldName = "IsSparseFile";
            fieldIsSparseFile.Name = "fieldIsSparseFile";
            fieldIsSparseFile.Visible = false;
            // 
            // fieldIsSystem
            // 
            fieldIsSystem.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsSystem.AreaIndex = 2;
            fieldIsSystem.FieldName = "IsSystem";
            fieldIsSystem.Name = "fieldIsSystem";
            fieldIsSystem.Visible = false;
            // 
            // fieldIsTemporary
            // 
            fieldIsTemporary.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldIsTemporary.AreaIndex = 2;
            fieldIsTemporary.FieldName = "IsTemporary";
            fieldIsTemporary.Name = "fieldIsTemporary";
            fieldIsTemporary.Visible = false;
            // 
            // dockManager
            // 
            dockManager.Form = this;
            dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { panelContainer1 });
            dockManager.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl" });
            // 
            // panelContainer1
            // 
            panelContainer1.Controls.Add(dockPanelProperties);
            panelContainer1.Controls.Add(dockPanelChart);
            panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            panelContainer1.ID = new System.Guid("8003839f-fdac-4597-8a08-fa0a6b503af9");
            panelContainer1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            panelContainer1.Location = new System.Drawing.Point(484, 3);
            panelContainer1.Name = "panelContainer1";
            panelContainer1.OriginalSize = new System.Drawing.Size(326, 200);
            panelContainer1.Size = new System.Drawing.Size(326, 601);
            panelContainer1.Text = "panelContainer1";
            // 
            // dockPanelProperties
            // 
            dockPanelProperties.Controls.Add(dockPanel1_Container);
            dockPanelProperties.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelProperties.ID = new System.Guid("ba124332-6873-43a0-9ecf-9af27e846de7");
            dockPanelProperties.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            dockPanelProperties.Location = new System.Drawing.Point(0, 0);
            dockPanelProperties.Name = "dockPanelProperties";
            dockPanelProperties.Options.ShowCloseButton = false;
            dockPanelProperties.OriginalSize = new System.Drawing.Size(326, 286);
            dockPanelProperties.Size = new System.Drawing.Size(326, 302);
            dockPanelProperties.Text = "Properties";
            // 
            // dockPanel1_Container
            // 
            dockPanel1_Container.Controls.Add(labelControl1);
            dockPanel1_Container.Controls.Add(propertyGridControl);
            dockPanel1_Container.Controls.Add(columnsImageComboBoxEdit);
            dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            dockPanel1_Container.Name = "dockPanel1_Container";
            dockPanel1_Container.Size = new System.Drawing.Size(319, 272);
            dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(3, 7);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(35, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Column";
            // 
            // propertyGridControl
            // 
            propertyGridControl.ActiveViewType = DevExpress.XtraVerticalGrid.PropertyGridView.Office;
            propertyGridControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            propertyGridControl.Cursor = System.Windows.Forms.Cursors.Hand;
            propertyGridControl.Location = new System.Drawing.Point(0, 30);
            propertyGridControl.Name = "propertyGridControl";
            propertyGridControl.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            propertyGridControl.Size = new System.Drawing.Size(319, 242);
            propertyGridControl.TabIndex = 1;
            // 
            // columnsImageComboBoxEdit
            // 
            columnsImageComboBoxEdit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            columnsImageComboBoxEdit.Location = new System.Drawing.Point(44, 4);
            columnsImageComboBoxEdit.Name = "columnsImageComboBoxEdit";
            columnsImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            columnsImageComboBoxEdit.Size = new System.Drawing.Size(275, 20);
            columnsImageComboBoxEdit.TabIndex = 0;
            // 
            // dockPanelChart
            // 
            dockPanelChart.Controls.Add(controlContainer1);
            dockPanelChart.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelChart.ID = new System.Guid("9d55de3c-abe2-4307-a83d-da77e613c498");
            dockPanelChart.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            dockPanelChart.Location = new System.Drawing.Point(0, 302);
            dockPanelChart.Name = "dockPanelChart";
            dockPanelChart.Options.ShowCloseButton = false;
            dockPanelChart.OriginalSize = new System.Drawing.Size(326, 284);
            dockPanelChart.Size = new System.Drawing.Size(326, 299);
            dockPanelChart.Text = "Chart";
            // 
            // controlContainer1
            // 
            controlContainer1.Controls.Add(chartControl);
            controlContainer1.Location = new System.Drawing.Point(4, 26);
            controlContainer1.Name = "controlContainer1";
            controlContainer1.Size = new System.Drawing.Size(319, 270);
            controlContainer1.TabIndex = 0;
            // 
            // chartControl
            // 
            chartControl.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries;
            chartControl.DataSource = pivotGridControl;
            xyDiagram1.AxisX.Title.Text = "Extension";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:n0}";
            xyDiagram1.AxisY.Title.Text = "Size (KB)";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            chartControl.Diagram = xyDiagram1;
            chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            chartControl.Legend.LegendID = -1;
            chartControl.Legend.MaxHorizontalPercentage = 30D;
            chartControl.Legend.Name = "Default Legend";
            chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chartControl.Location = new System.Drawing.Point(0, 0);
            chartControl.Name = "chartControl";
            chartControl.SeriesDataMember = "Series";
            chartControl.SeriesTemplate.ArgumentDataMember = "Arguments";
            chartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} {A}: {V:n0}";
            chartControl.SeriesTemplate.SeriesDataMember = "Series";
            chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values";
            sideBySideBarSeriesView1.ColorEach = true;
            chartControl.SeriesTemplate.View = sideBySideBarSeriesView1;
            chartControl.Size = new System.Drawing.Size(319, 270);
            chartControl.TabIndex = 0;
            // 
            // layoutControl
            // 
            layoutControl.AllowCustomization = false;
            layoutControl.Controls.Add(pivotGridControl);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(3, 3);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(481, 601);
            layoutControl.TabIndex = 3;
            layoutControl.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(481, 601);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = pivotGridControl;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(461, 581);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // AnalysisModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Controls.Add(panelContainer1);
            Name = "AnalysisModule";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(813, 607);
            ((System.ComponentModel.ISupportInitialize)pivotGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).EndInit();
            panelContainer1.ResumeLayout(false);
            dockPanelProperties.ResumeLayout(false);
            dockPanel1_Container.ResumeLayout(false);
            dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)propertyGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)columnsImageComboBoxEdit.Properties).EndInit();
            dockPanelChart.ResumeLayout(false);
            controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sideBySideBarSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFullName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtension;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCreationTime;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLastAccessTime;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLastWriteTime;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLengthInKB;
        private DevExpress.XtraPivotGrid.PivotGridField fieldParentFullName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOwnerName;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelProperties;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelChart;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
        private DevExpress.XtraEditors.ImageComboBoxEdit columnsImageComboBoxEdit;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAttributes;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsArchive;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsCompressed;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsDevice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsDirectory;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsEncrypted;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsHidden;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsIntegrityStream;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsNormal;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsNoScrubData;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsNotContentIndexed;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsOffline;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsReadOnly;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsReparsePoint;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsSparseFile;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsSystem;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIsTemporary;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLengthPercent;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
