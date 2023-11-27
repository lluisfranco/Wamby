namespace Wamby.Client.Forms
{
    partial class ScanHistoryUserControl
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
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            bindingSource = new System.Windows.Forms.BindingSource(components);
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colBaseFolderPath = new DevExpress.XtraGrid.Columns.GridColumn();
            colIncludeSubFolders = new DevExpress.XtraGrid.Columns.GridColumn();
            colSearchPattern = new DevExpress.XtraGrid.Columns.GridColumn();
            colShowMinimumFolderLevelInLog = new DevExpress.XtraGrid.Columns.GridColumn();
            colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            colComputerName = new DevExpress.XtraGrid.Columns.GridColumn();
            colOSVersionName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDetailType = new DevExpress.XtraGrid.Columns.GridColumn();
            colScanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colFolderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            colFileCount = new DevExpress.XtraGrid.Columns.GridColumn();
            colErrorCount = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            colElapsedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl
            // 
            layoutControl.AllowCustomization = false;
            layoutControl.Controls.Add(gridControl);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(1057, 665);
            layoutControl.TabIndex = 0;
            layoutControl.Text = "layoutControl1";
            // 
            // gridControl
            // 
            gridControl.DataSource = bindingSource;
            gridControl.Location = new System.Drawing.Point(12, 12);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new System.Drawing.Size(1033, 641);
            gridControl.TabIndex = 4;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // bindingSource
            // 
            bindingSource.DataSource = typeof(PreviousScansPersistence.PreviousScan);
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colBaseFolderPath, colIncludeSubFolders, colSearchPattern, colShowMinimumFolderLevelInLog, colUserName, colComputerName, colOSVersionName, colDetailType, colScanDate, colFolderCount, colFileCount, colErrorCount, colElapsedTime });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colScanDate, DevExpress.Data.ColumnSortOrder.Descending) });
            // 
            // colBaseFolderPath
            // 
            colBaseFolderPath.Caption = "Folder";
            colBaseFolderPath.FieldName = "BaseFolderPath";
            colBaseFolderPath.Name = "colBaseFolderPath";
            colBaseFolderPath.Visible = true;
            colBaseFolderPath.VisibleIndex = 2;
            colBaseFolderPath.Width = 300;
            // 
            // colIncludeSubFolders
            // 
            colIncludeSubFolders.FieldName = "IncludeSubFolders";
            colIncludeSubFolders.Name = "colIncludeSubFolders";
            colIncludeSubFolders.Visible = true;
            colIncludeSubFolders.VisibleIndex = 5;
            colIncludeSubFolders.Width = 62;
            // 
            // colSearchPattern
            // 
            colSearchPattern.FieldName = "SearchPattern";
            colSearchPattern.Name = "colSearchPattern";
            colSearchPattern.Visible = true;
            colSearchPattern.VisibleIndex = 3;
            colSearchPattern.Width = 62;
            // 
            // colShowMinimumFolderLevelInLog
            // 
            colShowMinimumFolderLevelInLog.FieldName = "ShowMinimumFolderLevelInLog";
            colShowMinimumFolderLevelInLog.Name = "colShowMinimumFolderLevelInLog";
            // 
            // colUserName
            // 
            colUserName.FieldName = "UserName";
            colUserName.Name = "colUserName";
            // 
            // colComputerName
            // 
            colComputerName.FieldName = "ComputerName";
            colComputerName.Name = "colComputerName";
            // 
            // colOSVersionName
            // 
            colOSVersionName.FieldName = "OSVersionName";
            colOSVersionName.Name = "colOSVersionName";
            // 
            // colDetailType
            // 
            colDetailType.FieldName = "DetailType";
            colDetailType.Name = "colDetailType";
            colDetailType.Visible = true;
            colDetailType.VisibleIndex = 4;
            colDetailType.Width = 62;
            // 
            // colScanDate
            // 
            colScanDate.DisplayFormat.FormatString = "g";
            colScanDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colScanDate.FieldName = "ScanDate";
            colScanDate.Name = "colScanDate";
            colScanDate.Visible = true;
            colScanDate.VisibleIndex = 0;
            colScanDate.Width = 110;
            // 
            // colFolderCount
            // 
            colFolderCount.FieldName = "FolderCount";
            colFolderCount.Name = "colFolderCount";
            colFolderCount.Visible = true;
            colFolderCount.VisibleIndex = 6;
            colFolderCount.Width = 62;
            // 
            // colFileCount
            // 
            colFileCount.FieldName = "FileCount";
            colFileCount.Name = "colFileCount";
            colFileCount.Visible = true;
            colFileCount.VisibleIndex = 7;
            colFileCount.Width = 80;
            // 
            // colErrorCount
            // 
            colErrorCount.FieldName = "ErrorCount";
            colErrorCount.Name = "colErrorCount";
            colErrorCount.Visible = true;
            colErrorCount.VisibleIndex = 8;
            colErrorCount.Width = 80;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1057, 665);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControl;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(1037, 645);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // colElapsedTime
            // 
            colElapsedTime.FieldName = "ElapsedTime";
            colElapsedTime.Name = "colElapsedTime";
            colElapsedTime.Visible = true;
            colElapsedTime.VisibleIndex = 1;
            // 
            // ScanHistoryUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Name = "ScanHistoryUserControl";
            Size = new System.Drawing.Size(1057, 665);
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseFolderPath;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeSubFolders;
        private DevExpress.XtraGrid.Columns.GridColumn colSearchPattern;
        private DevExpress.XtraGrid.Columns.GridColumn colShowMinimumFolderLevelInLog;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colComputerName;
        private DevExpress.XtraGrid.Columns.GridColumn colOSVersionName;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailType;
        private DevExpress.XtraGrid.Columns.GridColumn colScanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFolderCount;
        private DevExpress.XtraGrid.Columns.GridColumn colFileCount;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorCount;
        private DevExpress.XtraGrid.Columns.GridColumn colElapsedTime;
    }
}
