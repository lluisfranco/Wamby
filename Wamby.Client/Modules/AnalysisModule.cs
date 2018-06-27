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
    public partial class AnalysisModule : DevExpress.XtraEditors.XtraUserControl, 
        Interfaces.IModule, Interfaces.IModulePrintAndExport, Interfaces.IAnalysisMap
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public Enums.MapValueDataMemberEnum MapValueDataMember { get; private set; }

        public AnalysisModule()
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
            columnsImageComboBoxEdit.SelectedIndexChanged += ColumnsImageComboBoxEdit_SelectedIndexChanged;
        }

        public void RefreshModuleData()
        {
            resultsBindingSource.DataSource = FileSystemScanService.ScanResult.WambyFolderInfo.AllFiles;
            AddColumnsToPropertiesList();
        }

        private void AddColumnsToPropertiesList()
        {
            columnsImageComboBoxEdit.Properties.Items.Clear();
            foreach (DevExpress.XtraPivotGrid.PivotGridField f in pivotGridControl.Fields)
            {
                columnsImageComboBoxEdit.Properties.Items.Add(f.Caption, f.Name, 0);
            }
            if(columnsImageComboBoxEdit.Properties.Items.Count > 0)
                columnsImageComboBoxEdit.SelectedIndex = 0;
        }

        private void ColumnsImageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var f = pivotGridControl.Fields[columnsImageComboBoxEdit.SelectedIndex];
            propertyGridControl.SelectedObject = f;
        }

        public void Print()
        {
            pivotGridControl.ShowRibbonPrintPreview();
        }

        public void ExportToXls()
        {
            var filename = FileSystemScanService.GetTempFileName("xlsx");
            pivotGridControl.ExportToXlsx(filename);
            System.Diagnostics.Process.Start(filename);
        }

        public void ExportToPdf()
        {
            var filename = FileSystemScanService.GetTempFileName("pdf");
            pivotGridControl.ExportToPdf(filename);
            System.Diagnostics.Process.Start(filename);
        }

    }

}
