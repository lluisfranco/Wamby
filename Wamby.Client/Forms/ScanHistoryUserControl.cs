using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using Wamby.API.Enums;
using Wamby.Client.Args;
using Wamby.PreviousScansPersistence;

namespace Wamby.Client.Forms
{
    public partial class ScanHistoryUserControl : XtraUserControl
    {
        public event EventHandler<OpenPreviousScanEventArgs> OpenPreviousScanClick;
        public void RaiseOpenPreviousScanEvent(string path, string pattern, ScanDetailTypeEnum type) =>
            OpenPreviousScanClick?.Invoke(this, new OpenPreviousScanEventArgs() { Path = path, SearchPattern = pattern, DetailType = type });

        public ScanHistoryUserControl()
        {
            InitializeComponent();
            gridView.DoubleClick += (s, e) =>
            {
                if (gridView.GetFocusedRow() is PreviousScan scan)
                    RaiseOpenPreviousScanEvent(scan.BaseFolderPath, scan.SearchPattern, scan.DetailType);
            };
        }

        public void SetData(List<PreviousScan> data)
        {
            bindingSource.DataSource = data;
        }
    }
}
