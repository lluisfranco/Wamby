using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Linq;
using Wamby.Client.Args;
using Wamby.PreviousScansPersistence;

namespace Wamby.Client.Forms
{
    public partial class WelcomeUserControl : XtraUserControl
    {
        public event EventHandler<EventArgs> NewScanClick;
        public event EventHandler<EventArgs> OpenScanClick;
        public event EventHandler<OpenPreviousScanEventArgs> OpenPreviousScanClick;

        public void RaiseNewScanEvent() => NewScanClick?.Invoke(this, EventArgs.Empty);
        public void RaiseOpenScanEvent() => OpenScanClick?.Invoke(this, EventArgs.Empty);
        public void RaiseOpenPreviousScanEvent(string path) => 
            OpenPreviousScanClick?.Invoke(this, new OpenPreviousScanEventArgs() { Path = path });

        public WelcomeUserControl()
        {
            InitializeComponent();
            pictureEdit.Image = imageCollection.Images[0];
            hyperlinkLabelControlNew.HyperlinkClick += (s, e) => RaiseNewScanEvent();
            hyperlinkLabelControlOpen.HyperlinkClick += (s, e) => RaiseOpenScanEvent();
            hyperlinkLabelControlScan1.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEvent((s as HyperlinkLabelControl)?.ToolTip);
            hyperlinkLabelControlScan2.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEvent((s as HyperlinkLabelControl)?.ToolTip);
            hyperlinkLabelControlScan3.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEvent((s as HyperlinkLabelControl)?.ToolTip);
            hyperlinkLabelControlScan4.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEvent((s as HyperlinkLabelControl)?.ToolTip);
            hyperlinkLabelControlScan5.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEvent((s as HyperlinkLabelControl)?.ToolTip);
            hyperlinkLabelControlScan6.HyperlinkClick += (s, e) => RaiseOpenPreviousScanEvent((s as HyperlinkLabelControl)?.ToolTip);
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
                foreach (var item in scans.Take(5))
                {
                    if (i == 0) SetLinkLabelScanInfo(hyperlinkLabelControlScan1, item);
                    if (i == 1) SetLinkLabelScanInfo(hyperlinkLabelControlScan2, item);
                    if (i == 2) SetLinkLabelScanInfo(hyperlinkLabelControlScan3, item);
                    if (i == 3) SetLinkLabelScanInfo(hyperlinkLabelControlScan4, item);
                    if (i == 4) SetLinkLabelScanInfo(hyperlinkLabelControlScan5, item);
                    i++;
                }
            }
        }

        private void SetLinkLabelScanInfo(HyperlinkLabelControl label, PreviousScan item)
        {
            var file = new DirectoryInfo(item.BaseFolderPath);
            label.Text = $"{file.Name} ({item.ScanDate:dd/MM/yyy HH:mm})";
            label.ToolTip = item.BaseFolderPath;
            label.Visible = true;
        }
    }
}
