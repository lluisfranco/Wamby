using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Linq;
using Wamby.API.Enums;
using Wamby.Client.Args;
using Wamby.PreviousScansPersistence;

namespace Wamby.Client.Forms
{
    public partial class WelcomeUserControl : XtraUserControl
    {
        public event EventHandler<EventArgs> NewScanClick;
        public event EventHandler<EventArgs> OpenScanClick;
        public event EventHandler<OpenPreviousScanEventArgs> OpenPreviousScanClick;
        public event EventHandler<EventArgs> OpenHistoryClick;

        public void RaiseNewScanEvent() => NewScanClick?.Invoke(this, EventArgs.Empty);
        public void RaiseOpenScanEvent() => OpenScanClick?.Invoke(this, EventArgs.Empty);
        public void RaiseOpenPreviousScanEvent(string path, string pattern, ScanDetailTypeEnum type) => 
            OpenPreviousScanClick?.Invoke(this, new OpenPreviousScanEventArgs() { Path = path, SearchPattern = pattern, DetailType = type });
        public void RaiseOpenHistoryEvent() => OpenHistoryClick?.Invoke(this, EventArgs.Empty);

        public WelcomeUserControl()
        {
            InitializeComponent();
            pictureEdit.Image = imageCollection.Images[0];
            hyperlinkLabelControlNew.HyperlinkClick += (s, e) => RaiseNewScanEvent();
            hyperlinkLabelControlOpen.HyperlinkClick += (s, e) => RaiseOpenScanEvent();
            hyperlinkLabelControlScan1.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEventFromLabel((s as HyperlinkLabelControl));
            hyperlinkLabelControlScan2.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEventFromLabel((s as HyperlinkLabelControl));
            hyperlinkLabelControlScan3.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEventFromLabel((s as HyperlinkLabelControl));
            hyperlinkLabelControlScan4.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEventFromLabel((s as HyperlinkLabelControl));
            hyperlinkLabelControlScan5.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEventFromLabel((s as HyperlinkLabelControl));
            hyperlinkLabelControlScan6.HyperlinkClick += (s, e) => RaiseOpenHistoryEvent();
        }

        private void RaiseOpenPreviousScanEventFromLabel(HyperlinkLabelControl label)
        {
            if (label.Tag is not PreviousScan scan)
                RaiseOpenPreviousScanEvent(null, "*.*", ScanDetailTypeEnum.Fast);
            else
                RaiseOpenPreviousScanEvent(scan.BaseFolderPath, scan.SearchPattern, scan.DetailType);
        }

        public void InitializeControl()
        {
        }

        public void RefreshPreviousScansList()
        {
            var scans = WambyApplication.PreviousScansPersistenceService.LoadPreviousScans();
            if (scans.Count == 0)
            {
                hyperlinkLabelControlScan1.Text = "No scans yet. Start a new one :)";
                hyperlinkLabelControlScan1.ToolTip = null;  
            }
            else
            {
                int i = 0;
                foreach (var item in scans.Take(10))
                {
                    if (i == 0) SetLinkLabelScanInfo(hyperlinkLabelControlScan1, item);
                    if (i == 1) SetLinkLabelScanInfo(hyperlinkLabelControlScan2, item);
                    if (i == 2) SetLinkLabelScanInfo(hyperlinkLabelControlScan3, item);
                    if (i == 3) SetLinkLabelScanInfo(hyperlinkLabelControlScan4, item);
                    if (i == 4) SetLinkLabelScanInfo(hyperlinkLabelControlScan5, item);
                    if (i > 4) SetLinkLabelHistory(hyperlinkLabelControlScan6);
                    i++;
                }
            }
        }

        private void SetLinkLabelScanInfo(HyperlinkLabelControl label, PreviousScan item)
        {
            var file = new DirectoryInfo(item.BaseFolderPath);
            label.Text = $"{file.Name} ({item.ScanDate:dd/MM/yyy HH:mm}) - {item.DetailType}";
            label.ToolTip = item.BaseFolderPath;
            label.Tag = item;
            label.Visible = true;
        }

        private void SetLinkLabelHistory(HyperlinkLabelControl label)
        {
            if (label.Visible) return;
            label.Text = $"More...";
            label.Visible = true;
        }
    }
}
