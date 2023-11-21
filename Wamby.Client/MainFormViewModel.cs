using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using Wamby.API.Enums;
using Wamby.API.Services;

namespace Wamby.Client
{
    public class MainFormViewModel
    {
        public MainForm Form { get; }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public FileSystemStorageService FileSystemStorageService { get; private set; }
        public MainFormViewModel(MainForm form)
        {
            Form = form;
            FileSystemScanService = new FileSystemScanService()
            {
                UserName = WindowsIdentity.GetCurrent().Name,
                ComputerName = Environment.MachineName,
                OSVersionName = Environment.OSVersion.ToString(),
                ScanDate = DateTime.Now,
                DetailType = ScanDetailTypeEnum.Fast
            };
            if (Directory.Exists(Properties.Settings.Default.DefaultBaseFolderPath))
                FileSystemScanService.ScanOptions.BaseFolderPath = Properties.Settings.Default.DefaultBaseFolderPath;
            FileSystemScanService.ScanOptions.IncludeSubFolders = Properties.Settings.Default.DefaultIncludeSubFolders;
            FileSystemScanService.ScanOptions.SearchPattern = Properties.Settings.Default.DefaultSearchPattern;
            FileSystemScanService.DetailType = Properties.Settings.Default.DefaultDetailedScanType;
            FileSystemStorageService = new FileSystemStorageService();
        }

        public static void SaveSkin()
        {
            var settings = Properties.Settings.Default;
            settings.SkinName = WindowsFormsSettings.DefaultLookAndFeel.SkinName;
            settings.SkinPalette = WindowsFormsSettings.DefaultLookAndFeel.ActiveSvgPaletteName;
            settings.SkinAdvancedUseWindowsAppMode = ToBoolean(WindowsFormsSettings.TrackWindowsAppMode);
            settings.SkinAdvancedSystemAccentColor = ToBoolean(WindowsFormsSettings.TrackWindowsAccentColor);
            settings.SkinAdvancedCustomColor = ToHex(WindowsFormsSettings.GetAccentColor());
            settings.SkinAdvancedCustomColor2 = ToHex(WindowsFormsSettings.GetAccentColor2());
            settings.UseCompactUI = ToBoolean(WindowsFormsSettings.CompactUIMode);
            settings.Save();
        }

        private static bool ToBoolean(DefaultBoolean value) => 
            value == DefaultBoolean.True;
        private static string ToHex(Color c) =>
            "#FF" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");

        internal void NewScan()
        {
            Application.UseWaitCursor = true;
            var f = new NewScanForm
            {
                MdiParent = Form
            };
            f.Show();
            Application.DoEvents();
            f.ShowProgressPanel();
            f.InitializeModules(Form);
            f.InitializeControl(FileSystemScanService);
            f.HideProgressPanel();
            Application.UseWaitCursor = false;
        }
    }
}