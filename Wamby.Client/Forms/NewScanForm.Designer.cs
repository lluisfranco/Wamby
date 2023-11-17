namespace Wamby.Client
{
    partial class NewScanForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).BeginInit();
            SuspendLayout();
            // 
            // toolbarFormControl1
            // 
            toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            toolbarFormControl1.Manager = toolbarFormManager1;
            toolbarFormControl1.Name = "toolbarFormControl1";
            toolbarFormControl1.Size = new System.Drawing.Size(764, 31);
            toolbarFormControl1.TabIndex = 0;
            toolbarFormControl1.TabStop = false;
            toolbarFormControl1.TitleItemLinks.Add(barButtonItem1);
            toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            toolbarFormManager1.DockControls.Add(barDockControlTop);
            toolbarFormManager1.DockControls.Add(barDockControlBottom);
            toolbarFormManager1.DockControls.Add(barDockControlLeft);
            toolbarFormManager1.DockControls.Add(barDockControlRight);
            toolbarFormManager1.Form = this;
            toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1 });
            toolbarFormManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 31);
            barDockControlTop.Manager = toolbarFormManager1;
            barDockControlTop.Size = new System.Drawing.Size(764, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 528);
            barDockControlBottom.Manager = toolbarFormManager1;
            barDockControlBottom.Size = new System.Drawing.Size(764, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            barDockControlLeft.Manager = toolbarFormManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(764, 31);
            barDockControlRight.Manager = toolbarFormManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 497);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 0;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // NewScanForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(764, 528);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Controls.Add(toolbarFormControl1);
            Name = "NewScanForm";
            Text = "NewScanForm";
            ToolbarFormControl = toolbarFormControl1;
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}