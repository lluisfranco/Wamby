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
            this.colLengthInKB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).BeginInit();
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
            this.colLengthInKB.Visible = true;
            this.colLengthInKB.VisibleIndex = 1;
            this.colLengthInKB.Width = 51;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(Wamby.Core.Model.WambyFileInfo);
            // 
            // gridControlFiles
            // 
            this.gridControlFiles.DataSource = this.resultsBindingSource;
            this.gridControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlFiles.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlFiles.Location = new System.Drawing.Point(0, 0);
            this.gridControlFiles.MainView = this.gridViewFiles;
            this.gridControlFiles.Name = "gridControlFiles";
            this.gridControlFiles.Size = new System.Drawing.Size(610, 396);
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
            this.gridViewFiles.Name = "gridViewFiles";
            this.gridViewFiles.OptionsBehavior.Editable = false;
            this.gridViewFiles.OptionsFind.AlwaysVisible = true;
            this.gridViewFiles.OptionsMenu.ShowConditionalFormattingItem = true;
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
            // FilesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlFiles);
            this.Name = "FilesModule";
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource resultsBindingSource;
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
    }
}
