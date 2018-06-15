using System;
using System.Windows.Forms;
using Wamby.API.Extensions;
using DevExpress.XtraBars.FluentDesignSystem;

namespace Wamby.Client
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            var wambyapiService = new API.Services.FileSystemScanService(
                new Core.Model.ScanOptions()
                {
                    IncludeSubFolders = true, BaseFolderPath = @"D:\DabetSec"
                });
            var result = await wambyapiService.DoScan();
            MessageBox.Show(
                $"Size: {result.TotalSize()}\n" +
                $"In:   {result.TotalFilesCount()} files\n" +
                $"Time: {result.ElapsedTime.TotalMilliseconds.ToString("n2")} ms.");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

    }
}