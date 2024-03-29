﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using Wamby.API.Enums;
using Wamby.API.Services;
using Wamby.Client.Args;

namespace Wamby.Client
{
    public partial class WelcomeForm : XtraForm, IChildForm
    {
        public MainForm MainForm { get; private set; }
        public Bar Bar { get { return bar; } }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public FileSystemStorageService FileSystemStorageService { get; private set; } = new();
        public WelcomeForm SetParent(MainForm form) { MainForm = form; MdiParent = MainForm; return this; }

        public event EventHandler<EventArgs> NewScanClick;
        public event EventHandler<EventArgs> OpenScanClick;
        public event EventHandler<OpenPreviousScanEventArgs> OpenPreviousScanClick;
        public event EventHandler<EventArgs> OpenHistoryClick;

        public void RaiseNewScanEvent() => NewScanClick?.Invoke(this, EventArgs.Empty);
        public void RaiseOpenScanEvent() => OpenScanClick?.Invoke(this, EventArgs.Empty);
        public void OpenPreviousScanEvent(string path, string pattern, ScanDetailTypeEnum type) =>
            OpenPreviousScanClick?.Invoke(this, new OpenPreviousScanEventArgs() { Path = path, SearchPattern = pattern, DetailType = type });
        public void RaiseOpenHistoryEvent() => OpenHistoryClick?.Invoke(this, EventArgs.Empty);

        public WelcomeForm()
        {
            InitializeComponent();
            IconOptions.SvgImage = svgImageCollectionForm[0];
            Activated += (s, e) => WelcomeUserControl.RefreshPreviousScansList();
            WelcomeUserControl.NewScanClick += (s, e) => RaiseNewScanEvent();
            WelcomeUserControl.OpenScanClick += (s, e) => RaiseOpenScanEvent();
            WelcomeUserControl.OpenPreviousScanClick += (s, e) => OpenPreviousScanEvent(e.Path, e.SearchPattern, e.DetailType);
            WelcomeUserControl.OpenHistoryClick += (s, e) => RaiseOpenHistoryEvent();
        }
    }
}