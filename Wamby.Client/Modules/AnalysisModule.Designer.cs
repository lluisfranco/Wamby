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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldFullName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtension = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCreationTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastAccessTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastWriteTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLengthInKB = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldParentFullName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOwnerName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanelProperties = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.columnsImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dockPanelProperties.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsImageComboBoxEdit.Properties)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.DataSource = this.resultsBindingSource;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldFullName,
            this.fieldName,
            this.fieldExtension,
            this.fieldCreationTime,
            this.fieldLastAccessTime,
            this.fieldLastWriteTime,
            this.fieldLengthInKB,
            this.fieldParentFullName,
            this.fieldOwnerName});
            this.pivotGridControl.Location = new System.Drawing.Point(3, 3);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.Size = new System.Drawing.Size(343, 390);
            this.pivotGridControl.TabIndex = 0;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(Wamby.Core.Model.WambyFileInfo);
            // 
            // fieldFullName
            // 
            this.fieldFullName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldFullName.AreaIndex = 0;
            this.fieldFullName.Caption = "Full name";
            this.fieldFullName.FieldName = "FullName";
            this.fieldFullName.Name = "fieldFullName";
            this.fieldFullName.Visible = false;
            // 
            // fieldName
            // 
            this.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldName.AreaIndex = 0;
            this.fieldName.Caption = "Name";
            this.fieldName.FieldName = "Name";
            this.fieldName.Name = "fieldName";
            this.fieldName.TotalCellFormat.FormatString = "n0";
            this.fieldName.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldName.TotalValueFormat.FormatString = "n0";
            this.fieldName.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldName.Visible = false;
            // 
            // fieldExtension
            // 
            this.fieldExtension.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldExtension.AreaIndex = 0;
            this.fieldExtension.Caption = "Extension";
            this.fieldExtension.FieldName = "Extension";
            this.fieldExtension.Name = "fieldExtension";
            // 
            // fieldCreationTime
            // 
            this.fieldCreationTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCreationTime.AreaIndex = 1;
            this.fieldCreationTime.Caption = "Creation time";
            this.fieldCreationTime.FieldName = "CreationTime";
            this.fieldCreationTime.Name = "fieldCreationTime";
            this.fieldCreationTime.Visible = false;
            // 
            // fieldLastAccessTime
            // 
            this.fieldLastAccessTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLastAccessTime.AreaIndex = 1;
            this.fieldLastAccessTime.Caption = "Last access time";
            this.fieldLastAccessTime.FieldName = "LastAccessTime";
            this.fieldLastAccessTime.Name = "fieldLastAccessTime";
            this.fieldLastAccessTime.Visible = false;
            // 
            // fieldLastWriteTime
            // 
            this.fieldLastWriteTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLastWriteTime.AreaIndex = 1;
            this.fieldLastWriteTime.Caption = "Last write time";
            this.fieldLastWriteTime.FieldName = "LastWriteTime";
            this.fieldLastWriteTime.Name = "fieldLastWriteTime";
            this.fieldLastWriteTime.Visible = false;
            // 
            // fieldLengthInKB
            // 
            this.fieldLengthInKB.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldLengthInKB.AreaIndex = 0;
            this.fieldLengthInKB.Caption = "Size (KB)";
            this.fieldLengthInKB.CellFormat.FormatString = "n0";
            this.fieldLengthInKB.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldLengthInKB.FieldName = "LengthInKB";
            this.fieldLengthInKB.GrandTotalCellFormat.FormatString = "n0";
            this.fieldLengthInKB.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldLengthInKB.Name = "fieldLengthInKB";
            this.fieldLengthInKB.TotalCellFormat.FormatString = "n0";
            this.fieldLengthInKB.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldLengthInKB.TotalValueFormat.FormatString = "n0";
            this.fieldLengthInKB.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldParentFullName
            // 
            this.fieldParentFullName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldParentFullName.AreaIndex = 3;
            this.fieldParentFullName.Caption = "Folder name";
            this.fieldParentFullName.FieldName = "ParentFullName";
            this.fieldParentFullName.Name = "fieldParentFullName";
            this.fieldParentFullName.Visible = false;
            // 
            // fieldOwnerName
            // 
            this.fieldOwnerName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOwnerName.AreaIndex = 0;
            this.fieldOwnerName.Caption = "Owner";
            this.fieldOwnerName.FieldName = "OwnerName";
            this.fieldOwnerName.Name = "fieldOwnerName";
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.dockPanelProperties);
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("537b4ae0-d472-48e0-8574-f27b28963836");
            this.panelContainer1.Location = new System.Drawing.Point(346, 3);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(261, 200);
            this.panelContainer1.SavedSizeFactor = 0D;
            this.panelContainer1.Size = new System.Drawing.Size(261, 390);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanelProperties
            // 
            this.dockPanelProperties.Controls.Add(this.dockPanel1_Container);
            this.dockPanelProperties.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanelProperties.ID = new System.Guid("ba124332-6873-43a0-9ecf-9af27e846de7");
            this.dockPanelProperties.Location = new System.Drawing.Point(0, 0);
            this.dockPanelProperties.Name = "dockPanelProperties";
            this.dockPanelProperties.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelProperties.SavedSizeFactor = 0D;
            this.dockPanelProperties.Size = new System.Drawing.Size(261, 195);
            this.dockPanelProperties.Text = "Properties";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.propertyGridControl);
            this.dockPanel1_Container.Controls.Add(this.columnsImageComboBoxEdit);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 30);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(254, 161);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Column";
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridControl.Location = new System.Drawing.Point(0, 30);
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.Size = new System.Drawing.Size(254, 131);
            this.propertyGridControl.TabIndex = 1;
            // 
            // columnsImageComboBoxEdit
            // 
            this.columnsImageComboBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnsImageComboBoxEdit.Location = new System.Drawing.Point(44, 4);
            this.columnsImageComboBoxEdit.Name = "columnsImageComboBoxEdit";
            this.columnsImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.columnsImageComboBoxEdit.Size = new System.Drawing.Size(210, 20);
            this.columnsImageComboBoxEdit.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.controlContainer1);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.ID = new System.Guid("9d55de3c-abe2-4307-a83d-da77e613c498");
            this.dockPanel1.Location = new System.Drawing.Point(0, 195);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedSizeFactor = 0D;
            this.dockPanel1.Size = new System.Drawing.Size(261, 195);
            this.dockPanel1.Text = "Chart";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.chartControl1);
            this.controlContainer1.Location = new System.Drawing.Point(4, 30);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(254, 162);
            this.controlContainer1.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.pivotGridControl;
            xyDiagram1.AxisX.Title.Text = "Extension";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:n0}";
            xyDiagram1.AxisY.Title.Text = "Size (KB)";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "Series";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            sideBySideBarSeriesView1.ColorEach = true;
            this.chartControl1.SeriesTemplate.View = sideBySideBarSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(254, 162);
            this.chartControl1.TabIndex = 0;
            // 
            // AnalysisModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl);
            this.Controls.Add(this.panelContainer1);
            this.Name = "AnalysisModule";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dockPanelProperties.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsImageComboBoxEdit.Properties)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
        private DevExpress.XtraEditors.ImageComboBoxEdit columnsImageComboBoxEdit;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
