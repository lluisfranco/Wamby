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
            newScanModule.StartingScan += NewScanModule_StartingScan;
            newScanModule.EndingScan += NewScanModule_EndingScan;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ViewModel.LoadDefaultSettings();
            newScanModule.InitializeControl(ViewModel.FileSystemScanService);
            resultsModule.InitializeControl(ViewModel.FileSystemScanService);
            mapModule.InitializeControl(ViewModel.FileSystemScanService);
        }

        private void NewScanModule_StartingScan(object sender, EventArgs e)
        {
            EnablePages(false);
        }

        private void NewScanModule_EndingScan(object sender, EventArgs e)
        {
            EnablePages(true);
            resultsModule.RefreshModuleData();
            mapModule.RefreshModuleData();
        }

        private void EnablePages(bool enabled)
        {
            foreach (DevExpress.XtraTab.XtraTabPage tab in tabControl.TabPages)
                if (tab.Text != "New Scan") tab.PageEnabled = enabled;
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