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
    public partial class FilesModule : DevExpress.XtraEditors.XtraUserControl, 
        Interfaces.IModule, Interfaces.IModulePrintAndExport, Interfaces.IModuleFiles, 
        Interfaces.IModuleRibbon, Interfaces.IModuleNewScanRequested
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }
        public event EventHandler RequestNewScan;

        public FilesModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(API.Services.FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            Initialized = true;
            setEventHandlers();
        }

        public void SetFocus()
        {
            gridControlFiles.Focus();
        }

        private void setEventHandlers()
        {
            barButtonItemShowColumnList.ItemClick += BarButtonItemShowColumnList_ItemClick;
            barButtonItemSearch.ItemClick += BarButtonItemSearch_ItemClick;
            barCheckItemShowFooter.CheckedChanged += BarCheckItemShowFooter_CheckedChanged;
            gridViewFiles.FocusedRowObjectChanged += GridViewFiles_FocusedRowObjectChanged;
            gridControlFiles.MouseDown += GridViewFiles_MouseDown;
            barButtonItemOpenFolder.ItemClick += BarButtonItemOpenFolder_ItemClick;
            barButtonItemOpenTerminal.ItemClick += BarButtonItemOpenTerminal_ItemClick;
            barButtonItemOpenInNewWamby.ItemClick += BarButtonItemOpenInNewWamby_ItemClick;
            barButtonItemCopyPath.ItemClick += BarButtonItemCopyPath_ItemClick;
            barButtonItemShowProperties.ItemClick += BarButtonItemShowProperties_ItemClick;
            barButtonItemDelete.ItemClick += BarButtonItemDelete_ItemClick;
            barButtonItemOpenRunFile.ItemClick += BarButtonItemOpenRunFile_ItemClick;
        }

        private void GridViewFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) popupMenu.ShowPopup(MousePosition);
        }

        private void GridViewFiles_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            var item = gridViewFiles.GetRow(e.RowHandle) as Core.Model.WambyFileInfo;
            if (item == null) return;
            var existsfile = System.IO.File.Exists(item.FullName);
            var existsfolder = System.IO.Directory.Exists(item.ParentFullName);
            barButtonItemOpenFolder.Enabled = existsfolder;
            barButtonItemOpenTerminal.Enabled = existsfolder;
            barButtonItemOpenInNewWamby.Enabled = existsfolder;
            barButtonItemOpenRunFile.Enabled = existsfile;
            barButtonItemCopyPath.Enabled = existsfile;
            barButtonItemShowProperties.Enabled = existsfile;
            barButtonItemDelete.Enabled = existsfile;
        }

        private void BarButtonItemShowColumnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewFiles.ShowCustomization();
        }

        private void BarButtonItemSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewFiles.ShowFindPanel();
        }

        private void BarCheckItemShowFooter_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewFiles.OptionsView.ShowFooter = barCheckItemShowFooter.Checked;
        }

        public void RefreshModuleData()
        {
            var topindex = gridViewFiles.TopRowIndex;
            var rowindex = gridViewFiles.FocusedRowHandle;
            filesBindingSource.DataSource = FileSystemScanService.ScanResult.AllFiles;
            gridViewFiles.TopRowIndex = topindex;
            gridViewFiles.FocusedRowHandle = rowindex;
        }

        public void Print()
        {
            gridControlFiles.ShowRibbonPrintPreview();
        }

        public void ExportToXls()
        {
            var filename = FileSystemScanService.GetTempFileName("xlsx");
            gridControlFiles.ExportToXlsx(filename);
            Helpers.ShellHelper.Open(filename);
        }

        public void ExportToPdf()
        {
            var filename = FileSystemScanService.GetTempFileName("pdf");
            gridControlFiles.ExportToPdf(filename);
            Helpers.ShellHelper.Open(filename);
        }

        private void BarButtonItemOpenFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as Core.Model.WambyFileInfo)?.ParentFullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename)) Helpers.ShellHelper.Open(filename);
        }

        private void BarButtonItemOpenRunFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.File.Exists(filename)) Helpers.ShellHelper.Open(filename);
        }

        private void BarButtonItemOpenTerminal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as Core.Model.WambyFileInfo)?.ParentFullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename)) Helpers.ShellHelper.OpenTerminal(filename);
        }

        private void BarButtonItemOpenInNewWamby_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as Core.Model.WambyFileInfo)?.ParentFullName;
            if (filename == null) return;
            if (System.IO.Directory.Exists(filename)) Helpers.ShellHelper.OpenWamby(filename);
        }

        private void BarButtonItemCopyPath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            Clipboard.SetText(filename);
        }

        private void BarButtonItemShowProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.File.Exists(filename))
                Helpers.ShellHelper.ShowFileSystemItemProperties(filename);
        }

        private void BarButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filename = (gridViewFiles.GetRow(gridViewFiles.FocusedRowHandle) as Core.Model.WambyFileSystemItem)?.FullName;
            if (filename == null) return;
            if (System.IO.File.Exists(filename))
            {
                var deleted = Helpers.ShellHelper.DeleteFileSystemItemProperties(FindForm(), filename);
                if (deleted) RequestNewScan?.Invoke(this, new EventArgs());
            }
        }
    }
}
