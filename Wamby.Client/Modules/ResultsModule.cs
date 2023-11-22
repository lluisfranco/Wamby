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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils.Menu;

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

        public void InitializeControl(MainForm mainform, API.Services.FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            resultsTreeList.StateImageList = Helpers.UIHelper.GetResultsItemTypeImageCollection();
            Initialized = true;
            setEventHandlers();
        }

        public void SetFocus()
        {
            resultsTreeList.Focus();
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
            resultsTreeList.PopupMenuShowing += ResultsTreeList_PopupMenuShowing;
            barButtonItemOpenFolder.ItemClick += (s, e) => OpenCurrentItemInExplorer();
            barButtonItemOpenTerminal.ItemClick += (s, e) => OpenCurrentItemInTerminal();
            barButtonItemOpenInNewWamby.ItemClick += (s, e) => OpenCurrentItemInNewInstance();
            barButtonItemCopyPath.ItemClick += (s, e) => CopyCurrentItemPath();
            barButtonItemShowProperties.ItemClick += (s, e) => ShowCurrentItemProperties();
            barButtonItemDelete.ItemClick += BarButtonItemDelete_ItemClick;
        }

        private void ResultsTreeList_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var resources = new ComponentResourceManager(typeof(ResultsModule));
            var hitInfo = (sender as TreeList).CalcHitInfo(e.Point);
            if (hitInfo.HitInfoType == HitInfoType.Cell)
            {
                var menuItemOpenInExplorer = new DXMenuItem(barButtonItemOpenFolder.Caption,
                    (s, e) => OpenCurrentItemInExplorer());
                menuItemOpenInExplorer.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)
                    resources.GetObject("barButtonItemOpenFolder.ImageOptions.SvgImage");
                e.Menu.Items.Add(menuItemOpenInExplorer);
                var menuItemOpenInTerminal = new DXMenuItem(barButtonItemOpenTerminal.Caption,
                    (s, e) => OpenCurrentItemInTerminal());
                menuItemOpenInTerminal.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)
                    resources.GetObject("barButtonItemOpenTerminal.ImageOptions.SvgImage");
                e.Menu.Items.Add(menuItemOpenInTerminal);
                var menuItemOpenInNewWamby = new DXMenuItem(barButtonItemOpenInNewWamby.Caption,
                    (s, e) => OpenCurrentItemInNewInstance());
                menuItemOpenInNewWamby.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)
                    resources.GetObject("barButtonItemOpenInNewWamby.ImageOptions.SvgImage");
                e.Menu.Items.Add(menuItemOpenInNewWamby);
                var menuItemCopyPath = new DXMenuItem(barButtonItemCopyPath.Caption,
                    (s, e) => CopyCurrentItemPath());
                menuItemCopyPath.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)
                    resources.GetObject("barButtonItemCopyPath.ImageOptions.SvgImage");
                menuItemCopyPath.BeginGroup = true;
                e.Menu.Items.Add(menuItemCopyPath);
                var menuItemShowProperties = new DXMenuItem(barButtonItemShowProperties.Caption,
                    (s, e) => ShowCurrentItemProperties());
                menuItemShowProperties.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)
                    resources.GetObject("barButtonItemShowProperties.ImageOptions.SvgImage");
                e.Menu.Items.Add(menuItemShowProperties);
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
            var topindex = resultsTreeList.TopVisibleNodeIndex;
            resultsBindingSource.DataSource = FileSystemScanService.ScanResult.AllFolders;
            resultsTreeList.TopVisibleNodeIndex = topindex;
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

        private void ResultsTreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            var item = resultsTreeList.GetRow(e.Node.Id) as Core.Model.WambyFileSystemItem;
            if (item == null) return;
            var exists = System.IO.Directory.Exists(item.FullName);
            barButtonItemDelete.Enabled = exists;
        }

        private void OpenCurrentItemInExplorer()
        {
            if (resultsTreeList.GetFocusedRow() is not Core.Model.WambyFolderInfo item) return;
            Helpers.ShellHelper.Open(item?.DirectoryInfo.FullName);
        }

        private void OpenCurrentItemInTerminal()
        {
            if (resultsTreeList.GetFocusedRow() is not Core.Model.WambyFolderInfo item) return;
            Helpers.ShellHelper.OpenTerminal(item?.DirectoryInfo.FullName);
        }

        private void OpenCurrentItemInNewInstance()
        {
            //if (resultsTreeList.GetFocusedRow() is not Core.Model.WambyFolderInfo item) return;
            //Helpers.ShellHelper.OpenWamby(item?.DirectoryInfo.FullName);
        }

        private void CopyCurrentItemPath()
        {
            if (resultsTreeList.GetFocusedRow() is not Core.Model.WambyFolderInfo item) return;
            Clipboard.SetText(item?.DirectoryInfo.FullName);
        }

        private void ShowCurrentItemProperties()
        {
            if (resultsTreeList.GetFocusedRow() is not Core.Model.WambyFolderInfo item) return;
            Helpers.ShellHelper.ShowFileSystemItemProperties(item?.DirectoryInfo.FullName);
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
