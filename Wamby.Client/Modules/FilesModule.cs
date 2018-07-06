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
        Interfaces.IModule, Interfaces.IModulePrintAndExport, Interfaces.IModuleFiles, Interfaces.IModuleRibbon
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }

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

        private void setEventHandlers()
        {
            barButtonItemShowColumnList.ItemClick += BarButtonItemShowColumnList_ItemClick;
            barButtonItemSearch.ItemClick += BarButtonItemSearch_ItemClick;
            barCheckItemShowFooter.CheckedChanged += BarCheckItemShowFooter_CheckedChanged;
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
            filesBindingSource.DataSource = FileSystemScanService.ScanResult.AllFiles;
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

    }
}
