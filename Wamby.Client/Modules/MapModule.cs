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
    public partial class MapModule : DevExpress.XtraEditors.XtraUserControl, Interfaces.IModule
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }

        public MapModule()
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
            
        }

        public void RefreshModuleData()
        {
            var files = FileSystemScanService.ScanResult.FolderInfo.AllFiles.
                GroupBy(p => p.Extension).Select(g => new FileMapInfo()
                {
                    Extension = g.Key,
                    Size = g.Sum(p => p.Length),
                    Count = g.Count()
                });
            var adapter = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter
            {
                DataSource = files,
                LabelDataMember = "Extension",
                ValueDataMember = "Size"
            };
            //adapter.GroupDataMembers.Add("Residence");
            treeMapControl.DataAdapter = adapter;
        }        
    }

    public class FileMapInfo
    {
        public string Extension { get; set; }
        public double Size { get; set; }
        public double Count { get; set; }

    }
}
