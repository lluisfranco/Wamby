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
    public partial class ErrorsModule : DevExpress.XtraEditors.XtraUserControl, 
        Interfaces.IModule, Interfaces.IModulePrintAndExport, Interfaces.IModuleErrors, Interfaces.IModuleRibbon
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }
        public ErrorsModule()
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
            gridViewErrors.ShowCustomization();
        }

        private void BarButtonItemSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewErrors.ShowFindPanel();
        }

        private void BarCheckItemShowFooter_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewErrors.OptionsView.ShowFooter = barCheckItemShowFooter.Checked;
        }

        public void RefreshModuleData()
        {
            errorsBindingSource.DataSource = FileSystemScanService.ScanResult.ScanExceptions;
        }

        public void Print()
        {
            gridViewErrors.ShowRibbonPrintPreview();
        }

        public void ExportToXls()
        {
            var filename = FileSystemScanService.GetTempFileName("xlsx");
            gridViewErrors.ExportToXlsx(filename);
            System.Diagnostics.Process.Start(filename);
        }

        public void ExportToPdf()
        {
            var filename = FileSystemScanService.GetTempFileName("pdf");
            gridViewErrors.ExportToPdf(filename);
            System.Diagnostics.Process.Start(filename);
        }

    }
}
