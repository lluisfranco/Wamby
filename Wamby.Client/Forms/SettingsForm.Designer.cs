namespace Wamby.Client.Forms
{
    partial class SettingsForm
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
            svgImageCollectionForm = new DevExpress.Utils.SvgImageCollection(components);
            settingsUserControl = new SettingsUserControl();
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionForm).BeginInit();
            SuspendLayout();
            // 
            // svgImageCollectionForm
            // 
            svgImageCollectionForm.Add("Settings", "Wamby.Resources.Images.Menu.Settings.svg", "Wamby.Resources");
            // 
            // settingsUserControl
            // 
            settingsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            settingsUserControl.Location = new System.Drawing.Point(0, 0);
            settingsUserControl.Name = "settingsUserControl";
            settingsUserControl.Size = new System.Drawing.Size(571, 442);
            settingsUserControl.TabIndex = 6;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(571, 442);
            Controls.Add(settingsUserControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)svgImageCollectionForm).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.Utils.SvgImageCollection svgImageCollectionForm;
        private SettingsUserControl settingsUserControl;
    }
}