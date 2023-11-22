using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Wamby.API.Services;

namespace Wamby.Client
{
    public partial class WelcomeForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public FileSystemStorageService FileSystemStorageService { get; private set; } = new();
        public WelcomeForm SetParent(MainForm form) { MainForm = form; MdiParent = MainForm; return this; }

        IOverlaySplashScreenHandle handle = null;

        public WelcomeForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
        }
    }
}