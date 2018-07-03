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
        Interfaces.IModule, Interfaces.IModulePrintAndExport, Interfaces.IModuleAnalysis, Interfaces.IModuleRibbon
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public Enums.MapValueDataMemberEnum MapValueDataMember { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }

        public AnalysisModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(API.Services.FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            Initialized = true;
            pivotGridControl.CustomizationFormBounds = new Rectangle(0, 0, 300, 200);
            setEventHandlers();
        }

        private void setEventHandlers()
        {
            barButtonItemSelectAll.ItemClick += BarButtonItemSelectAll_ItemClick;
            columnsImageComboBoxEdit.SelectedIndexChanged += ColumnsImageComboBoxEdit_SelectedIndexChanged;
            barButtonItemSelectNone.ItemClick += BarButtonItemSelectNone_ItemClick;
            barCheckItemShowProperties.CheckedChanged += BarCheckItemShowProperties_CheckedChanged;
            barCheckItemShowChart.CheckedChanged += BarCheckItemShowChart_CheckedChanged;
            dockPanelProperties.VisibilityChanged += DockPanelProperties_VisibilityChanged;
            dockPanelChart.VisibilityChanged += DockPanelChart_VisibilityChanged;
            barButtonItemShowFieldList.ItemClick += BarButtonItemShowFieldList_ItemClick;
        }

        private void BarButtonItemShowFieldList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl.ShowCustomization();
        }

        private void BarCheckItemShowProperties_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockPanelProperties.Visibility = barCheckItemShowProperties.Checked ?
                DevExpress.XtraBars.Docking.DockVisibility.Visible :
                DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }

        private void BarCheckItemShowChart_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockPanelChart.Visibility = barCheckItemShowChart.Checked ?
                DevExpress.XtraBars.Docking.DockVisibility.Visible :
                DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }

        private void DockPanelProperties_VisibilityChanged(object sender, DevExpress.XtraBars.Docking.VisibilityChangedEventArgs e)
        {
            barCheckItemShowProperties.Checked = 
                dockPanelProperties.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        private void DockPanelChart_VisibilityChanged(object sender, DevExpress.XtraBars.Docking.VisibilityChangedEventArgs e)
        {
            barCheckItemShowChart.Checked =
                   dockPanelChart.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        private void BarButtonItemSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectAll();
        }

        public void SelectAll()
        {
            pivotGridControl.Cells.Selection = new Rectangle(0, 0,
                pivotGridControl.Cells.ColumnCount, pivotGridControl.Cells.RowCount);
        }

        private void BarButtonItemSelectNone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectNone();
        }

        public void SelectNone()
        {
            pivotGridControl.Cells.Selection = new Rectangle(0, 0, 0, 0);
        }

        public void RefreshModuleData()
        {
            resultsBindingSource.DataSource = FileSystemScanService.ScanResult.AllFiles;
            AddColumnsToPropertiesList();
            SelectAll();
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
