using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Wamby.API.Extensions;

namespace Wamby.Client
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
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
    }
}