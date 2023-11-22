using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;
using Wamby.API.Services;

namespace Wamby.Client
{
    public class MainFormViewModel
    {
        public MainForm Form { get; }
        public FileSystemStorageService FileSystemStorageService { get; private set; }
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

        internal void NewScan()
        {
            Application.UseWaitCursor = true;
            var f = new NewScanForm
            {
                Text = $"New Scan: #{docsCount++}"
            };
            f.SetParent(Form).Show();
            Application.DoEvents();
            f.ShowProgressPanel().InitializeModules().InitializeControl().HideProgressPanel();
            Application.UseWaitCursor = false;
        }
    }
}