using DevExpress.XtraEditors;

namespace Wamby.Client.Forms
{
    public partial class WelcomeUserControl : XtraUserControl
    {
        public WelcomeUserControl()
        {
            InitializeComponent();
            pictureBox.Image = imageCollection.Images[0];
        }
    }
}
