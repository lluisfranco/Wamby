using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Wamby.Client.Modules
{
    public partial class ResultsModule : DevExpress.XtraEditors.XtraUserControl, Interfaces.IModule
    {
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }

        public ResultsModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(API.Services.FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            resultsTreeList.StateImageList = Helpers.UIHelper.GetResultsItemTypeImageCollection();
            Initialized = true;
            setEventHandlers();
        }

        private void setEventHandlers()
        {
            resultsTreeList.GetStateImage += ResultsTreeList_GetStateImage;
        }

        private void ResultsTreeList_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            var isfolder = Convert.ToBoolean(e.Node.GetValue("IsFolder"));
            e.NodeImageIndex = isfolder ? 0 : 1;
        }

        public void RefreshModuleData()
        {
            resultsBindingSource.DataSource = FileSystemScanService.ScanResult.FolderInfo.AllFolders;
        }
    }
}
