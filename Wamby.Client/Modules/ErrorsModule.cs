using DevExpress.XtraEditors;
using System.ComponentModel;
using Wamby.API.Services;
using Wamby.Client.Interfaces;

namespace Wamby.Client.Modules
{
    public partial class ErrorsModule : XtraUserControl, IModule
    {
        [Browsable(false)]
        public FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public ErrorsModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            Initialized = true;
            SetEventHandlers();
        }

        public void SetFocus()
        {
            gridControlErrors.Focus();
        }

        private void SetEventHandlers()
        {
        }

        public void RefreshModuleData()
        {
            errorsBindingSource.DataSource = FileSystemScanService.ScanResult.ScanExceptions;
        }
    }
}
