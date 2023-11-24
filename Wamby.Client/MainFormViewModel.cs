using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wamby.API.Enums;
using Wamby.API.Services;
using Wamby.PreviousScansPersistence;

namespace Wamby.Client
{
    public class MainFormViewModel
    {
        public MainForm Form { get; }
        int docsCount = 1;
        public MainFormViewModel(MainForm form)
        {
            Form = form;
        }

        public Settings.Settings LoadSettings()
        {
            WambyApplication.Settings = WambyApplication.SettingsService.LoadSettings();
            return WambyApplication.Settings;
        }

        public List<PreviousScan> LoadPreviousScans()
        {
            WambyApplication.PreviousScans = WambyApplication.PreviousScansPersistenceService.LoadPreviousScans();
            return WambyApplication.PreviousScans;
        }

        public static void SaveSettings()
        {
            SaveSkinSettings();
            WambyApplication.SettingsService.SaveSettings(WambyApplication.Settings);
        }

        private static void SaveSkinSettings()
        {
            WambyApplication.Settings.Skin.SkinName = WindowsFormsSettings.DefaultLookAndFeel.SkinName;
            WambyApplication.Settings.Skin.SkinPalette = WindowsFormsSettings.DefaultLookAndFeel.ActiveSvgPaletteName;
            WambyApplication.Settings.Skin.SkinAdvancedUseWindowsAppMode = ToBoolean(WindowsFormsSettings.TrackWindowsAppMode);
            WambyApplication.Settings.Skin.SkinAdvancedSystemAccentColor = ToBoolean(WindowsFormsSettings.TrackWindowsAccentColor);
            WambyApplication.Settings.Skin.SkinAdvancedCustomColor = ToHex(WindowsFormsSettings.GetAccentColor());
            WambyApplication.Settings.Skin.SkinAdvancedCustomColor2 = ToHex(WindowsFormsSettings.GetAccentColor2());
            WambyApplication.Settings.Skin.UseCompactUI = ToBoolean(WindowsFormsSettings.CompactUIMode);
        }

        private static bool ToBoolean(DefaultBoolean value) => 
            value == DefaultBoolean.True;
        private static string ToHex(Color c) =>
            "#FF" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");

        public async Task NewScan(string path)
        {
            var scanService = GetScanServiceFromFolderPath(path);
            await NewScan(scanService);
        }

        public async Task NewScan(FileSystemScanService service = null)
        {
            Application.UseWaitCursor = true;
            var f = new NewScanForm
            {
                Text = $"New Scan: #{docsCount++}"
            };
            f.SetParent(Form).Show();
            if (service != null) f.SetFileSystemScanService(service);
            Application.DoEvents();
            f.ShowProgressPanel().InitializeModules().InitializeControl().HideProgressPanel();
            if (service != null) await f.StartScan();
            Application.UseWaitCursor = false;
        }

        private static FileSystemScanService GetScanServiceFromFolderPath(string path)
        {
            var scanService = new FileSystemScanService()
            {
                UserName = WindowsIdentity.GetCurrent().Name,
                ComputerName = Environment.MachineName,
                OSVersionName = Environment.OSVersion.ToString(),
                ScanDate = DateTime.Now,
                DetailType = ScanDetailTypeEnum.Fast
            };
            scanService.ScanOptions.BaseFolderPath = path;
            return scanService;
        }

        public async Task OpenScan()
        {

        }

        public async Task OpenPreviousScan(string path)
        {
            var scanService = GetScanServiceFromFolderPath(path);
            await NewScan(scanService);
        }

        public void Welcome()
        {
            Application.UseWaitCursor = true;
            var f = new WelcomeForm();
            f.SetParent(Form).Show();
            f.NewScanClick += async (s, e) => await NewScan();  
            f.OpenScanClick += async (s, e) => await OpenScan();
            f.OpenPreviousScanClick += async (s, e) =>
            {
                if (string.IsNullOrEmpty(e.Path)) await NewScan(); else await OpenPreviousScan(e.Path);
            };
            Application.DoEvents();
            Application.UseWaitCursor = false;
        }

        public async Task ScanDroppedFolders(IDataObject data)
        {
            if (!data.GetDataPresent(DataFormats.FileDrop)) return;
            var files = (string[])data.GetData(DataFormats.FileDrop);
            foreach (var item in files)
            {
                var folder = new DirectoryInfo(item);
                if (folder.Exists) await NewScan(folder.FullName);
            }
        }
    }
}