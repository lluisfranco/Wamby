using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Wamby.API.Services;
using Wamby.Client.Enums;
using Wamby.Client.Interfaces;

namespace Wamby.Client.Modules
{
    public partial class AnalysisModule : XtraUserControl, IModule
    {
        [Browsable(false)]
        public FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public MapValueDataMemberEnum MapValueDataMember { get; private set; }

        public AnalysisModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            Initialized = true;
            pivotGridControl.CustomizationFormBounds = new Rectangle(0, 0, 300, 200);
            SetEventHandlers();
        }

        public void SetFocus()
        {
            pivotGridControl.Focus();
        }

        private void SetEventHandlers()
        {
            columnsImageComboBoxEdit.SelectedIndexChanged += ColumnsImageComboBoxEdit_SelectedIndexChanged;
        }

        private void BarButtonItemShowFieldList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl.ShowCustomization();
        }

        public void RefreshModuleData()
        {
            resultsBindingSource.DataSource = FileSystemScanService.ScanResult.AllFiles;
            AddColumnsToPropertiesList();
        }

        private void AddColumnsToPropertiesList()
        {
            columnsImageComboBoxEdit.Properties.Items.Clear();
            foreach (DevExpress.XtraPivotGrid.PivotGridField f in pivotGridControl.Fields)
            {
                columnsImageComboBoxEdit.Properties.Items.Add(f.Caption, f.Name, 0);
            }
            if (columnsImageComboBoxEdit.Properties.Items.Count > 0)
                columnsImageComboBoxEdit.SelectedIndex = 0;
        }

        private void ColumnsImageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var f = pivotGridControl.Fields[columnsImageComboBoxEdit.SelectedIndex];
            propertyGridControl.SelectedObject = f;
        }
    }

}
