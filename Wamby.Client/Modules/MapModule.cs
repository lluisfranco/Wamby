using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeMap;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Wamby.API.Services;
using Wamby.Client.Enums;
using Wamby.Client.Interfaces;
using Wamby.Client.Model;

namespace Wamby.Client.Modules
{
    public partial class MapModule : XtraUserControl, IModule
    {
        [Browsable(false)]
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public bool Initialized { get; private set; }
        public MapValueDataMemberEnum MapValueDataMember { get; private set; }

        public MapModule()
        {
            InitializeComponent();
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
            Initialized = true;
            SetEventHandlers();
        }

        public void SetFocus()
        {
            treeMapControl.Focus();
        }

        private void SetEventHandlers()
        {
            treeMapControl.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                    popupMenu.ShowPopup(MousePosition);
            };
            barCheckItemBySize.ItemClick += BarCheckItemMapBySize_ItemClick;
            barCheckItemShowByCount.ItemClick += BarCheckItemMapByFilesCount_ItemClick;
            barCheckItemSliceAndDice.ItemClick += BarButtonItemLayoutAlgorithmSliceAndDice_ItemClick;
            barCheckItemSquarified.ItemClick += BarButtonItemLayoutAlgorithmSquarified_ItemClick;
            barCheckItemStriped.ItemClick += BarButtonItemLayoutAlgorithmStriped_ItemClick;
            barCheckItemBottomLeftToTopRight.ItemClick += BarButtonItemDirectionBottomLeftToTopRight_ItemClick;
            barCheckItemBottomRightToTopLeft.ItemClick += BarButtonItemDirectionBottomRightToTopLeft_ItemClick;
            barCheckItemTopLeftToBottomRight.ItemClick += BarButtonItemDirectionTopLeftToBottomRight_ItemClick;
            barCheckItemTopRightToBottomLeft.ItemClick += BarButtonItemDirectionTopRightToBottomLeft_ItemClick;
        }

        public void RefreshModuleData()
        {
            var files = FileSystemScanService.ScanResult.AllFiles.
                GroupBy(p => p.Extension).Select(g => new FileMapInfo()
                {
                    Extension = g.Key,
                    Size = g.Sum(p => p.Length / 1024),
                    FilesCount = g.Count()
                });
            var adapter = new TreeMapFlatDataAdapter
            {
                DataSource = files,
                LabelDataMember = "Extension",
                ValueDataMember = MapValueDataMember.ToString()
            };
            if (MapValueDataMember == MapValueDataMemberEnum.Size)
                treeMapControl.ToolTipLeafPattern = "Extension {L}: {V:n0} KB";
            if (MapValueDataMember == MapValueDataMemberEnum.FilesCount)
                treeMapControl.ToolTipLeafPattern = "Extension {L}: {V:n0} files";
            treeMapControl.DataAdapter = adapter;
        }

        public void SetMapByDataMember(MapValueDataMemberEnum member)
        {
            MapValueDataMember = member;
            RefreshModuleData();
        }

        public void SetLayoutAlgorithm(MapLayoutAlgorithmEnum layoutAlgorithm)
        {
            ITreeMapLayoutAlgorithm algorithm =
                new TreeMapSquarifiedLayoutAlgorithm();
            if (layoutAlgorithm == MapLayoutAlgorithmEnum.SliceAndDice)
                algorithm = new TreeMapSliceAndDiceLayoutAlgorithm();
            if (layoutAlgorithm == Enums.MapLayoutAlgorithmEnum.Squarified)
                algorithm = new TreeMapSquarifiedLayoutAlgorithm();
            if (layoutAlgorithm == Enums.MapLayoutAlgorithmEnum.Striped)
                algorithm = new TreeMapStripedLayoutAlgorithm();
            treeMapControl.LayoutAlgorithm = algorithm;
        }

        public void SetLayoutAlgorithmDirection(TreeMapLayoutDirection layoutAlgorithmDirection)
        {
            (treeMapControl.LayoutAlgorithm as TreeMapLayoutAlgorithmBase).Direction = layoutAlgorithmDirection;
        }

        private void BarCheckItemMapBySize_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetMapByDataMember(MapValueDataMemberEnum.Size);
        }

        private void BarCheckItemMapByFilesCount_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetMapByDataMember(MapValueDataMemberEnum.FilesCount);
        }

        private void BarButtonItemLayoutAlgorithmSliceAndDice_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetLayoutAlgorithm(MapLayoutAlgorithmEnum.SliceAndDice);
        }

        private void BarButtonItemLayoutAlgorithmSquarified_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetLayoutAlgorithm(MapLayoutAlgorithmEnum.Squarified);
        }

        private void BarButtonItemLayoutAlgorithmStriped_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetLayoutAlgorithm(MapLayoutAlgorithmEnum.Striped);
        }

        private void BarButtonItemDirectionBottomLeftToTopRight_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(TreeMapLayoutDirection.BottomLeftToTopRight);
        }

        private void BarButtonItemDirectionBottomRightToTopLeft_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(TreeMapLayoutDirection.BottomRightToTopLeft);
        }

        private void BarButtonItemDirectionTopLeftToBottomRight_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(TreeMapLayoutDirection.TopLeftToBottomRight);
        }

        private void BarButtonItemDirectionTopRightToBottomLeft_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetLayoutAlgorithmDirection(TreeMapLayoutDirection.TopRightToBottomLeft);
        }
    }
}
