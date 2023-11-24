using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using Wamby.API.Enums;
using Wamby.API.Services;
using Wamby.Client.Args;

namespace Wamby.Client
{
    public partial class ScanHistoryForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public FileSystemStorageService FileSystemStorageService { get; private set; } = new();
        public ScanHistoryForm SetParent(MainForm form) { MainForm = form; MdiParent = MainForm; return this; }

        public event EventHandler<OpenPreviousScanEventArgs> OpenPreviousScanClick;

        public void OpenPreviousScanEvent(string path, string pattern, ScanDetailTypeEnum type) =>
            OpenPreviousScanClick?.Invoke(this, new OpenPreviousScanEventArgs() { Path = path, SearchPattern = pattern, DetailType = type });

        public ScanHistoryForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
            Activated += (s, e) => RefreshHistory();
            scanHistoryUserControl.OpenPreviousScanClick += (s, e) => OpenPreviousScanEvent(e.Path, e.SearchPattern, e.DetailType);
        }

        public void RefreshHistory()
        {
            var scans = WambyApplication.PreviousScansPersistenceService.LoadPreviousScans();
            scanHistoryUserControl.SetData(scans);
        }
    }
}