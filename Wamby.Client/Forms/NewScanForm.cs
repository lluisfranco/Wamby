using DevExpress.Mvvm.Native;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Linq;
using Wamby.API.Services;
using Wamby.Client.Forms;

namespace Wamby.Client
{
    public partial class NewScanForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public NewScanForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
            navigationPane.AddTabMergeModulesRibbonSupport();
        }

        public void InitializeControl(MainForm mainform, FileSystemScanService fileSystemScanService)
        {
            MainForm = mainform;
            FileSystemScanService = fileSystemScanService;
            FileSystemScanService.BeginScan+=(s, e) => { 
            }; 
            navigationPane.Pages.ForEach(p => p.PageText = p.Caption.ToUpper());
            navigationPane.Pages.Where(
                p => p.PageText != navigationPane.Pages[0].PageText).ForEach(p => p.PageEnabled = false);
            //var module = navigationPane.GetCurrentModule();
            //module.InitializeControl(mainform, FileSystemScanService);
            var modules = navigationPane.GetModules();
            foreach (var module in modules)
            {
                module.InitializeControl(mainform, FileSystemScanService);
            }
        }
    }
}