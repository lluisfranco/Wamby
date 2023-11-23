using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Wamby.API.Services;
using Wamby.Client.Interfaces;
using Wamby.Core.Model;

namespace Wamby.Client.Modules
{
    public partial class FilesModule : XtraUserControl, IModule
    {
        [Browsable(false)]
        public FileSystemScanService FileSystemScanService { get; private set; }
        public MainForm MainForm { get; private set; }
        public bool Initialized { get; private set; }

        public FilesModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService scanService)
        {
            MainForm = mainform;
            FileSystemScanService = scanService;
            Initialized = true;
            SetEventHandlers();
        }

        public void SetFocus()
        {
            gridControlFiles.Focus();
        }

        private void SetEventHandlers()
        {
            gridViewFiles.FocusedRowObjectChanged += GridViewFiles_FocusedRowObjectChanged;
            gridControlFiles.MouseDown += GridViewFiles_MouseDown;
            barButtonItemShowInExplorer.ItemClick += BarButtonItemOpenFolder_ItemClick;
            barButtonItemShowInCmd.ItemClick += BarButtonItemOpenTerminal_ItemClick;
            barButtonItemOpenFile.ItemClick += BarButtonItemOpenRunFile_ItemClick;
            barButtonItemProperties.ItemClick += BarButtonItemShowProperties_ItemClick;
            barButtonItemCopyPath.ItemClick += BarButtonItemCopyPath_ItemClick;
        }

        private void GridViewFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) popupMenu.ShowPopup(MousePosition);
        }

        private void GridViewFiles_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            var item = gridViewFiles.GetRow(e.RowHandle) as WambyFileInfo;
            if (item == null) return;
            var existsfile = File.Exists(item.FullName);
            var existsfolder = Directory.Exists(item.ParentFullName);
            barButtonItemOpenFile.Enabled = existsfolder;
            barButtonItemShowInExplorer.Enabled = existsfolder;
            barButtonItemShowInCmd.Enabled = existsfolder;
            barButtonItemOpenFile.Enabled = existsfile;
            barButtonItemCopyPath.Enabled = existsfile;
            barButtonItemProperties.Enabled = existsfile;
        }

        public void RefreshModuleData()
        {
            var topindex = gridViewFiles.TopRowIndex;
            var rowindex = gridViewFiles.FocusedRowHandle;
            filesBindingSource.DataSource = FileSystemScanService.ScanResult.AllFiles;
            gridViewFiles.TopRowIndex = topindex;
            gridViewFiles.FocusedRowHandle = rowindex;
        }

        private void BarButtonItemOpenFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as WambyFileInfo)?.ParentFullName;
            if (filename == null) return;
            if (Directory.Exists(filename)) Helpers.ShellHelper.Open(filename);
        }

        private void BarButtonItemOpenRunFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (File.Exists(filename)) Helpers.ShellHelper.Open(filename);
        }

        private void BarButtonItemOpenTerminal_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as WambyFileInfo)?.ParentFullName;
            if (filename == null) return;
            if (Directory.Exists(filename)) Helpers.ShellHelper.OpenTerminal(filename);
        }

        private void BarButtonItemCopyPath_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            Clipboard.SetText(filename);
        }

        private void BarButtonItemShowProperties_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.File.Exists(filename))
                Helpers.ShellHelper.ShowFileSystemItemProperties(filename);
        }
    }
}
