namespace Wamby.Client.Modules
{
    partial class MapModule
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
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeMapControl = new DevExpress.XtraTreeMap.TreeMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(Wamby.Core.Model.FolderInfo);
            // 
            // treeMapControl
            // 
            this.treeMapControl.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.treeMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMapControl.GroupBorderVisible = DevExpress.Utils.DefaultBoolean.Default;
            this.treeMapControl.LeafBorderVisible = DevExpress.Utils.DefaultBoolean.Default;
            this.treeMapControl.Location = new System.Drawing.Point(0, 0);
            this.treeMapControl.Name = "treeMapControl";
            this.treeMapControl.Padding = new System.Windows.Forms.Padding(3);
            this.treeMapControl.Size = new System.Drawing.Size(610, 396);
            this.treeMapControl.TabIndex = 0;
            this.treeMapControl.ToolTipLeafPattern = "Extension {L}: {V:n2}";
            // 
            // MapModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeMapControl);
            this.Name = "MapModule";
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private DevExpress.XtraTreeMap.TreeMapControl treeMapControl;
    }
}
