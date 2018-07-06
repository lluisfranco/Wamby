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
    public partial class MapModule : DevExpress.XtraEditors.XtraUserControl, 
        Interfaces.IModule, Interfaces.IModulePrintAndExport, Interfaces.IModuleMap, Interfaces.IModuleRibbon
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public Enums.MapValueDataMemberEnum MapValueDataMember { get; private set; }
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get { return ribbon; } }

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
            barCheckItemMapBySize.ItemClick += BarCheckItemMapBySize_ItemClick;
            barCheckItemMapByFilesCount.ItemClick += BarCheckItemMapByFilesCount_ItemClick;
            barButtonItemLayoutAlgorithmSliceAndDice.ItemClick += BarButtonItemLayoutAlgorithmSliceAndDice_ItemClick;
            barButtonItemLayoutAlgorithmSquarified.ItemClick += BarButtonItemLayoutAlgorithmSquarified_ItemClick;
            barButtonItemLayoutAlgorithmStriped.ItemClick += BarButtonItemLayoutAlgorithmStriped_ItemClick;
            barButtonItemDirectionBottomLeftToTopRight.ItemClick += BarButtonItemDirectionBottomLeftToTopRight_ItemClick;
            barButtonItemDirectionBottomRightToTopLeft.ItemClick += BarButtonItemDirectionBottomRightToTopLeft_ItemClick;
            barButtonItemDirectionTopLeftToBottomRight.ItemClick += BarButtonItemDirectionTopLeftToBottomRight_ItemClick;
            barButtonItemDirectionTopRightToBottomLeft.ItemClick += BarButtonItemDirectionTopRightToBottomLeft_ItemClick;
        }
        
        public void RefreshModuleData()
        {
            var files = FileSystemScanService.ScanResult.AllFiles.
                GroupBy(p => p.Extension).Select(g => new Model.FileMapInfo()
                {
                    Extension = g.Key,
                    Size = g.Sum(p => p.Length / 1024),
                    FilesCount = g.Count()
                });
            var adapter = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter
            {
                DataSource = files,
                LabelDataMember = "Extension",
                ValueDataMember = MapValueDataMember.ToString()
            };
            if (MapValueDataMember == Enums.MapValueDataMemberEnum.Size)
                treeMapControl.ToolTipLeafPattern = "Extension {L}: {V:n0} KB";
            if (MapValueDataMember == Enums.MapValueDataMemberEnum.FilesCount)
                treeMapControl.ToolTipLeafPattern = "Extension {L}: {V:n0} files";
            treeMapControl.DataAdapter = adapter;
        }

        public void SetMapByDataMember(Enums.MapValueDataMemberEnum member)
        {
            MapValueDataMember = member;
            RefreshModuleData();
        }

        public void SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum layoutAlgorithm)
        {
            DevExpress.XtraTreeMap.ITreeMapLayoutAlgorithm algorithm = 
                new DevExpress.XtraTreeMap.TreeMapSquarifiedLayoutAlgorithm();
            if(layoutAlgorithm == Enums.MapLayoutAlgorithmEnum.SliceAndDice)
                algorithm = new DevExpress.XtraTreeMap.TreeMapSliceAndDiceLayoutAlgorithm();
            if (layoutAlgorithm == Enums.MapLayoutAlgorithmEnum.Squarified)
                algorithm = new DevExpress.XtraTreeMap.TreeMapSquarifiedLayoutAlgorithm();
            if (layoutAlgorithm == Enums.MapLayoutAlgorithmEnum.Striped)
                algorithm = new DevExpress.XtraTreeMap.TreeMapStripedLayoutAlgorithm();
            treeMapControl.LayoutAlgorithm = algorithm;
        }

        public void SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection layoutAlgorithmDirection)
        {
            (treeMapControl.LayoutAlgorithm as
                    DevExpress.XtraTreeMap.TreeMapLayoutAlgorithmBase).Direction = layoutAlgorithmDirection;
        }

        private void BarCheckItemMapBySize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetMapByDataMember(Enums.MapValueDataMemberEnum.Size);
        }

        private void BarCheckItemMapByFilesCount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetMapByDataMember(Enums.MapValueDataMemberEnum.FilesCount);
        }

        private void BarButtonItemLayoutAlgorithmSliceAndDice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum.SliceAndDice);
        }

        private void BarButtonItemLayoutAlgorithmSquarified_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum.Squarified);
        }

        private void BarButtonItemLayoutAlgorithmStriped_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum.Striped);
        }

        private void BarButtonItemDirectionBottomLeftToTopRight_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.BottomLeftToTopRight);
        }

        private void BarButtonItemDirectionBottomRightToTopLeft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.BottomRightToTopLeft);
        }

        private void BarButtonItemDirectionTopLeftToBottomRight_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.TopLeftToBottomRight);
        }

        private void BarButtonItemDirectionTopRightToBottomLeft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection.TopRightToBottomLeft);
        }
        public void Print()
        {
            treeMapControl.ShowRibbonPrintPreview();
        }

        public void ExportToXls()
        {
            var filename = FileSystemScanService.GetTempFileName("xlsx");
            treeMapControl.ExportToXlsx(filename);
            Helpers.ShellHelper.Open(filename);
        }

        public void ExportToPdf()
        {
            var filename = FileSystemScanService.GetTempFileName("pdf");
            treeMapControl.ExportToPdf(filename);
            Helpers.ShellHelper.Open(filename);
        }

    }

}
