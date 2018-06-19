namespace Wamby.Client.Modules
{
    partial class NewScanModule
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.newScanPathButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.includeSubfoldersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.searchPatternButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.cancelScanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newScanPathButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeSubfoldersCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatternButtonEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.includeSubfoldersCheckEdit);
            this.groupControl1.Controls.Add(this.searchPatternButtonEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.newScanPathButtonEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 114);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Scan options";
            // 
            // newScanPathButtonEdit
            // 
            this.newScanPathButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newScanPathButtonEdit.Location = new System.Drawing.Point(91, 37);
            this.newScanPathButtonEdit.Name = "newScanPathButtonEdit";
            this.newScanPathButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Change folder", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Scan now", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.newScanPathButtonEdit.Size = new System.Drawing.Size(648, 20);
            this.newScanPathButtonEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Path";
            // 
            // includeSubfoldersCheckEdit
            // 
            this.includeSubfoldersCheckEdit.Location = new System.Drawing.Point(16, 76);
            this.includeSubfoldersCheckEdit.Name = "includeSubfoldersCheckEdit";
            this.includeSubfoldersCheckEdit.Properties.Caption = "Include subfolders";
            this.includeSubfoldersCheckEdit.Size = new System.Drawing.Size(159, 20);
            this.includeSubfoldersCheckEdit.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(365, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Search pattern";
            // 
            // searchPatternButtonEdit
            // 
            this.searchPatternButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPatternButtonEdit.EditValue = "*";
            this.searchPatternButtonEdit.Location = new System.Drawing.Point(440, 76);
            this.searchPatternButtonEdit.Name = "searchPatternButtonEdit";
            this.searchPatternButtonEdit.Size = new System.Drawing.Size(299, 20);
            this.searchPatternButtonEdit.TabIndex = 1;
            // 
            // cancelScanSimpleButton
            // 
            this.cancelScanSimpleButton.Location = new System.Drawing.Point(3, 137);
            this.cancelScanSimpleButton.Name = "cancelScanSimpleButton";
            this.cancelScanSimpleButton.Size = new System.Drawing.Size(153, 23);
            this.cancelScanSimpleButton.TabIndex = 1;
            this.cancelScanSimpleButton.Text = "Cancel";
            // 
            // NewScanModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelScanSimpleButton);
            this.Controls.Add(this.groupControl1);
            this.Name = "NewScanModule";
            this.Size = new System.Drawing.Size(766, 316);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newScanPathButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeSubfoldersCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatternButtonEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit newScanPathButtonEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit includeSubfoldersCheckEdit;
        private DevExpress.XtraEditors.ButtonEdit searchPatternButtonEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cancelScanSimpleButton;
    }
}
