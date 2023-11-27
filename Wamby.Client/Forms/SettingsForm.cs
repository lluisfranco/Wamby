using DevExpress.XtraEditors;

namespace Wamby.Client.Forms
{
    public partial class SettingsForm : XtraForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
            Activated += (s, e) => RefreshSettings();            
        }

        private void RefreshSettings()
        {
            settingsUserControl.LoadSettings();
        }
    }
}