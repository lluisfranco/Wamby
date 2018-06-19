using System;
using System.Windows.Forms;
using Wamby.API.Services;

namespace Wamby.Client
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewModels.MainFormViewModel ViewModel { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Wamby_App_Icon;
            ViewModel = new ViewModels.MainFormViewModel(new FileSystemScanService());
            setEventHandlers();
        }

        private void setEventHandlers()
        {
            Shown += MainForm_Shown;
            newAppBarButtonItem.ItemClick += NewAppBarButtonItem_ItemClick;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ViewModel.LoadDefaultSettings();
            newScanModule.InitializeControl(ViewModel.FileSystemScanService);
        }

        private void NewAppBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewWamby();
        }

        private void OpenNewWamby()
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
    }
}