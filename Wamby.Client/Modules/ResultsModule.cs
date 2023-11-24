using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Wamby.API.Services;
using Wamby.Client.Args;
using Wamby.Client.Interfaces;

namespace Wamby.Client.Modules
{
    public partial class ResultsModule : XtraUserControl, IModule, IResultsModule
    {
        [Browsable(false)]
        public FileSystemScanService FileSystemScanService { get; private set; }
        public MainForm MainForm { get; private set; }
        public bool Initialized { get; private set; }

        public event EventHandler<OpenFolderInNewTabEventArgs> OpenFolderInNewTabClick;

        public void RaiseOpenFolderInNewTabEvent(string path) =>
            OpenFolderInNewTabClick?.Invoke(this, new OpenFolderInNewTabEventArgs() { Path = path });

        public ResultsModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService scanService)
        {
            MainForm = mainform;
            FileSystemScanService = scanService;
            resultsTreeList.StateImageList = Helpers.UIHelper.GetResultsItemTypeImageCollection();
            Initialized = true;
            SetEventHandlers();
        }

        public void SetFocus()
        {
            resultsTreeList.Focus();
        }

        private void SetEventHandlers()
        {
            resultsTreeList.GetStateImage += ResultsTreeList_GetStateImage;
            resultsTreeList.FocusedNodeChanged += ResultsTreeList_FocusedNodeChanged;
            resultsTreeList.PopupMenuShowing += ResultsTreeList_PopupMenuShowing;
        }

        private void ResultsTreeList_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            var resources = new ComponentResourceManager(typeof(ResultsModule));
            var hitInfo = (sender as TreeList).CalcHitInfo(e.Point);
            if (hitInfo.HitInfoType == HitInfoType.Cell)
            {
                var menuItemOpenInNewTab = new DXMenuItem(barButtonItemOpenInNewTab.Caption,
                    (s, e) => OpenCurrentItemInNewTab());
                menuItemOpenInNewTab.ImageOptions.SvgImage = svgImageCollection32[5];
                e.Menu.Items.Add(menuItemOpenInNewTab);
                var menuItemOpenInExplorer = new DXMenuItem(barButtonItemShowInExplorer.Caption,
                    (s, e) => OpenCurrentItemInExplorer());
                menuItemOpenInExplorer.ImageOptions.SvgImage = svgImageCollection32[4];
                e.Menu.Items.Add(menuItemOpenInExplorer);
                var menuItemOpenInTerminal = new DXMenuItem(barButtonItemShowInCmd.Caption,
                    (s, e) => OpenCurrentItemInTerminal());
                menuItemOpenInTerminal.ImageOptions.SvgImage = svgImageCollection32[3];
                e.Menu.Items.Add(menuItemOpenInTerminal);
                var menuItemCopyPath = new DXMenuItem(barButtonItemCopyPath.Caption,
                    (s, e) => CopyCurrentItemPath());
                menuItemCopyPath.ImageOptions.SvgImage = svgImageCollection32[0];
                menuItemCopyPath.BeginGroup = true;
                e.Menu.Items.Add(menuItemCopyPath);
                var menuItemShowProperties = new DXMenuItem(barButtonItemProperties.Caption,
                    (s, e) => ShowCurrentItemProperties());
                menuItemShowProperties.ImageOptions.SvgImage = svgImageCollection32[2];
                e.Menu.Items.Add(menuItemShowProperties);
            }
        }

        private void ResultsTreeList_GetStateImage(object sender, GetStateImageEventArgs e)
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

        private void ResultsTreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            var item = resultsTreeList.GetRow(e.Node.Id) as Core.Model.WambyFileSystemItem;
            if (item == null) return;
            var exists = System.IO.Directory.Exists(item.FullName);
            barButtonItemDelete.Enabled = exists;
        }

        private void OpenCurrentItemInNewTab()
        {
            if (resultsTreeList.GetFocusedRow() is not Core.Model.WambyFolderInfo item) return;
            RaiseOpenFolderInNewTabEvent(item?.DirectoryInfo.FullName);
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
    }
}
