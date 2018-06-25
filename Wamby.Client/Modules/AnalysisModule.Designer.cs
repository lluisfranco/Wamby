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
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldFullName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtension = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCreationTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastAccessTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastWriteTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLengthInKB = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldParentFullName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOwnerName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelProperties = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanelProperties.SuspendLayout();
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
            this.pivotGridControl.Size = new System.Drawing.Size(404, 390);
            this.pivotGridControl.TabIndex = 0;
            // 
            // fieldFullName
            // 
            this.fieldFullName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldFullName.AreaIndex = 0;
            this.fieldFullName.FieldName = "FullName";
            this.fieldFullName.Name = "fieldFullName";
            this.fieldFullName.Visible = false;
            // 
            // fieldName
            // 
            this.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldName.AreaIndex = 0;
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
            this.fieldExtension.FieldName = "Extension";
            this.fieldExtension.Name = "fieldExtension";
            // 
            // fieldCreationTime
            // 
            this.fieldCreationTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCreationTime.AreaIndex = 1;
            this.fieldCreationTime.FieldName = "CreationTime";
            this.fieldCreationTime.Name = "fieldCreationTime";
            this.fieldCreationTime.Visible = false;
            // 
            // fieldLastAccessTime
            // 
            this.fieldLastAccessTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLastAccessTime.AreaIndex = 1;
            this.fieldLastAccessTime.FieldName = "LastAccessTime";
            this.fieldLastAccessTime.Name = "fieldLastAccessTime";
            this.fieldLastAccessTime.Visible = false;
            // 
            // fieldLastWriteTime
            // 
            this.fieldLastWriteTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLastWriteTime.AreaIndex = 1;
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
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(Wamby.Core.Model.WambyFileInfo);
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelProperties});
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
            // dockPanelProperties
            // 
            this.dockPanelProperties.Controls.Add(this.dockPanel1_Container);
            this.dockPanelProperties.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanelProperties.ID = new System.Guid("ba124332-6873-43a0-9ecf-9af27e846de7");
            this.dockPanelProperties.Location = new System.Drawing.Point(407, 3);
            this.dockPanelProperties.Name = "dockPanelProperties";
            this.dockPanelProperties.Options.ShowCloseButton = false;
            this.dockPanelProperties.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelProperties.SavedSizeFactor = 0D;
            this.dockPanelProperties.Size = new System.Drawing.Size(200, 390);
            this.dockPanelProperties.Text = "Properties";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 30);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 357);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // AnalysisModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl);
            this.Controls.Add(this.dockPanelProperties);
            this.Name = "AnalysisModule";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanelProperties.ResumeLayout(false);
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
    }
}
