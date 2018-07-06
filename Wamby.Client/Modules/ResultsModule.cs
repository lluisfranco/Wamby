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
using System.Diagnostics;

namespace Wamby.Client.Modules
{
    public partial class ResultsModule : DevExpress.XtraEditors.XtraUserControl, 
        Interfaces.IModule, Interfaces.IModulePrintAndExport, Interfaces.IModuleResults, 
        Interfaces.IModuleRibbon, Interfaces.IModuleNewScanRequested
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }
        public event EventHandler RequestNewScan;

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
            barButtonItemExpandTree.ItemClick += BarButtonItemExpandTree_ItemClick;
            barButtonItemCollapse.ItemClick += BarButtonItemCollapse_ItemClick;
            barButtonItemExpandLevel1.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel2.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel3.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel4.ItemClick += BarButtonItemExpandLevel_ItemClick;
            barButtonItemExpandLevel5.ItemClick += BarButtonItemExpandLevel_ItemClick;
            resultsTreeList.GetStateImage += ResultsTreeList_GetStateImage;
            resultsTreeList.FocusedNodeChanged += ResultsTreeList_FocusedNodeChanged;
            resultsTreeList.MouseDown += ResultsTreeList_MouseDown;
            barButtonItemOpenFolder.ItemClick += BarButtonItemOpenFolder_ItemClick;
            barButtonItemOpenTerminal.ItemClick += BarButtonItemOpenTerminal_ItemClick;
            barButtonItemOpenInNewWamby.ItemClick += BarButtonItemOpenInNewWamby_ItemClick;
            barButtonItemCopyPath.ItemClick += BarButtonItemCopyPath_ItemClick;
            barButtonItemShowProperties.ItemClick += BarButtonItemShowProperties_ItemClick;
            barButtonItemDelete.ItemClick += BarButtonItemDelete_ItemClick;

        }

        private void ResultsTreeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var node = resultsTreeList.GetNodeAt(e.Location);
                if (node == null) return;
                var item = resultsTreeList.GetRow(node.Id) as Core.Model.WambyFileSystemItem;
                if (item == null) return;
                resultsTreeList.FocusedNode = node;
                popupMenu.ShowPopup(MousePosition);
            }
        }

        private void BarButtonItemExpandTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExpandTree();
        }

        private void BarButtonItemCollapse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CollapseTree();
        }

        private void BarButtonItemExpandLevel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExpandTreeToLevel(Convert.ToInt32(e.Item.Tag) - 1);
        }

        private void ResultsTreeList_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            var isfolder = Convert.ToBoolean(e.Node.GetValue("IsFolder"));
            e.NodeImageIndex = isfolder ? 0 : 1;
        }

        public void RefreshModuleData()
        {
            resultsBindingSource.DataSource = FileSystemScanService.ScanResult.AllFolders;
        }

        public void Print()
        {
            resultsTreeList.ShowRibbonPrintPreview();
        }

        public void ExportToXls()
        {
            var filename = FileSystemScanService.GetTempFileName("xlsx");
            resultsTreeList.ExportToXlsx(filename);
            Helpers.ShellHelper.Open(filename);
        }

        public void ExportToPdf()
        {
            var filename = FileSystemScanService.GetTempFileName("pdf");
            resultsTreeList.ExportToPdf(filename);
            Helpers.ShellHelper.Open(filename);
        }

        public void ExpandTree()
        {
            resultsTreeList.ExpandAll();
        }

        public void ExpandTreeToLevel(int level)
        {
            CollapseTree();
            resultsTreeList.ExpandToLevel(level);
        }

        public void CollapseTree()
        {
            resultsTreeList.CollapseAll();
        }

        private void ResultsTreeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var item = resultsTreeList.GetRow(e.Node.Id) as Core.Model.WambyFileSystemItem;
            if (item == null) return;
            var exists = System.IO.Directory.Exists(item.FullName);
            barButtonItemOpenFolder.Enabled = exists;
            barButtonItemOpenTerminal.Enabled = exists;
            barButtonItemOpenInNewWamby.Enabled = exists;
            barButtonItemCopyPath.Enabled = exists;
            barButtonItemShowProperties.Enabled = exists;
            barButtonItemDelete.Enabled = exists;
        }

        //private void BarButtonItemOpenFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
        //    if (filename == null) return;
        //    if (System.IO.Directory.Exists(filename))
        //        Helpers.ShellHelper.Open(filename);
        //}

        //private void BarButtonItemOpenInNewWamby_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
        //    if (filename == null) return;
        //    if (System.IO.Directory.Exists(filename))
        //        Helpers.ShellHelper.OpenWamby(filename);
        //}

        private void BarButtonItemOpenFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename)) Helpers.ShellHelper.Open(filename);
        }

        private void BarButtonItemOpenTerminal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename)) Helpers.ShellHelper.OpenTerminal(filename);
        }

        private void BarButtonItemOpenInNewWamby_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename)) Helpers.ShellHelper.OpenWamby(filename);
        }

        private void BarButtonItemCopyPath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            Clipboard.SetText(filename);
        }

        private void BarButtonItemShowProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename))
                Helpers.ShellHelper.ShowFileSystemItemProperties(filename);
        }

        private void BarButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (resultsTreeList.GetFocusedRow() as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename))
            {
                var deleted = Helpers.ShellHelper.DeleteFileSystemItemProperties(FindForm(), filename);
                if (deleted) RequestNewScan?.Invoke(this, new EventArgs());
            }
        }
    }
}
