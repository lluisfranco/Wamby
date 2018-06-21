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
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            this.colDeepLength = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resultsTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeepFilesCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultsTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
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
            this.colDeepLength.VisibleIndex = 2;
            this.colDeepLength.Width = 181;
            // 
            // resultsTreeList
            // 
            this.resultsTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLevel,
            this.colIsFolder,
            this.colFullName,
            this.colDeepLength,
            this.colDeepFilesCount});
            this.resultsTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultsTreeList.DataSource = this.resultsBindingSource;
            this.resultsTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeListFormatRule1.Column = this.colDeepLength;
            treeListFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            treeListFormatRule1.Rule = formatConditionRuleDataBar1;
            this.resultsTreeList.FormatRules.Add(treeListFormatRule1);
            this.resultsTreeList.KeyFieldName = "FullName";
            this.resultsTreeList.Location = new System.Drawing.Point(0, 0);
            this.resultsTreeList.Name = "resultsTreeList";
            this.resultsTreeList.OptionsBehavior.Editable = false;
            this.resultsTreeList.OptionsMenu.ShowConditionalFormattingItem = true;
            this.resultsTreeList.OptionsView.ShowHorzLines = false;
            this.resultsTreeList.OptionsView.ShowIndicator = false;
            this.resultsTreeList.ParentFieldName = "ParentFullName";
            this.resultsTreeList.Size = new System.Drawing.Size(610, 396);
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
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 347;
            // 
            // colDeepFilesCount
            // 
            this.colDeepFilesCount.Caption = "Files";
            this.colDeepFilesCount.FieldName = "DeepFilesCount";
            this.colDeepFilesCount.Format.FormatString = "n0";
            this.colDeepFilesCount.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeepFilesCount.Name = "colDeepFilesCount";
            this.colDeepFilesCount.Visible = true;
            this.colDeepFilesCount.VisibleIndex = 1;
            this.colDeepFilesCount.Width = 80;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(Wamby.Core.Model.FolderInfo);
            // 
            // ResultsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultsTreeList);
            this.Name = "ResultsModule";
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.resultsTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList resultsTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepLength;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepFilesCount;
    }
}
