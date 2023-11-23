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
            components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            gridControlErrors = new DevExpress.XtraGrid.GridControl();
            errorsBindingSource = new System.Windows.Forms.BindingSource(components);
            gridViewErrors = new DevExpress.XtraGrid.Views.Grid.GridView();
            colSource = new DevExpress.XtraGrid.Columns.GridColumn();
            colStackTrace = new DevExpress.XtraGrid.Columns.GridColumn();
            colTargetSite = new DevExpress.XtraGrid.Columns.GridColumn();
            colInnerException = new DevExpress.XtraGrid.Columns.GridColumn();
            colHResult = new DevExpress.XtraGrid.Columns.GridColumn();
            colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colFileFullPath = new DevExpress.XtraGrid.Columns.GridColumn();
            colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)gridControlErrors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewErrors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // gridControlErrors
            // 
            gridControlErrors.DataSource = errorsBindingSource;
            gridControlErrors.EmbeddedNavigator.Buttons.Append.Visible = false;
            gridControlErrors.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            gridControlErrors.EmbeddedNavigator.Buttons.Edit.Visible = false;
            gridControlErrors.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            gridControlErrors.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridControlErrors.Location = new System.Drawing.Point(12, 12);
            gridControlErrors.MainView = gridViewErrors;
            gridControlErrors.Name = "gridControlErrors";
            gridControlErrors.Size = new System.Drawing.Size(586, 372);
            gridControlErrors.TabIndex = 1;
            gridControlErrors.UseEmbeddedNavigator = true;
            gridControlErrors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewErrors });
            // 
            // errorsBindingSource
            // 
            errorsBindingSource.DataSource = typeof(Core.Model.ScanException);
            // 
            // gridViewErrors
            // 
            gridViewErrors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colSource, colStackTrace, colTargetSite, colInnerException, colHResult, colTypeName, colFileFullPath, colMessage });
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            gridViewErrors.FormatRules.Add(gridFormatRule1);
            gridViewErrors.GridControl = gridControlErrors;
            gridViewErrors.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Extension", null, "({0} items)") });
            gridViewErrors.Name = "gridViewErrors";
            gridViewErrors.OptionsBehavior.Editable = false;
            gridViewErrors.OptionsMenu.ShowConditionalFormattingItem = true;
            gridViewErrors.OptionsView.ShowFooter = true;
            gridViewErrors.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            gridViewErrors.OptionsView.ShowIndicator = false;
            // 
            // colSource
            // 
            colSource.FieldName = "Source";
            colSource.Name = "colSource";
            colSource.OptionsColumn.ReadOnly = true;
            colSource.Width = 76;
            // 
            // colStackTrace
            // 
            colStackTrace.FieldName = "StackTrace";
            colStackTrace.Name = "colStackTrace";
            colStackTrace.OptionsColumn.ReadOnly = true;
            colStackTrace.Width = 76;
            // 
            // colTargetSite
            // 
            colTargetSite.FieldName = "TargetSiteName";
            colTargetSite.Name = "colTargetSite";
            colTargetSite.OptionsColumn.ReadOnly = true;
            // 
            // colInnerException
            // 
            colInnerException.FieldName = "InnerExceptionMessage";
            colInnerException.Name = "colInnerException";
            colInnerException.OptionsColumn.ReadOnly = true;
            // 
            // colHResult
            // 
            colHResult.FieldName = "HResult";
            colHResult.Name = "colHResult";
            colHResult.OptionsColumn.ReadOnly = true;
            colHResult.Width = 83;
            // 
            // colTypeName
            // 
            colTypeName.Caption = "Type";
            colTypeName.FieldName = "TypeName";
            colTypeName.Name = "colTypeName";
            colTypeName.OptionsColumn.ReadOnly = true;
            colTypeName.Visible = true;
            colTypeName.VisibleIndex = 2;
            colTypeName.Width = 76;
            // 
            // colFileFullPath
            // 
            colFileFullPath.Caption = "Full path";
            colFileFullPath.FieldName = "FileFullPath";
            colFileFullPath.Name = "colFileFullPath";
            colFileFullPath.Visible = true;
            colFileFullPath.VisibleIndex = 0;
            colFileFullPath.Width = 187;
            // 
            // colMessage
            // 
            colMessage.FieldName = "Message";
            colMessage.Name = "colMessage";
            colMessage.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Message", "{0}") });
            colMessage.Visible = true;
            colMessage.VisibleIndex = 1;
            colMessage.Width = 110;
            // 
            // layoutControl
            // 
            layoutControl.AllowCustomization = false;
            layoutControl.Controls.Add(gridControlErrors);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(610, 396);
            layoutControl.TabIndex = 2;
            layoutControl.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(610, 396);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlErrors;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(590, 376);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // ErrorsModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Name = "ErrorsModule";
            Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)gridControlErrors).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewErrors).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
