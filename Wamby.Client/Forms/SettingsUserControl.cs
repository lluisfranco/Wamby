using DevExpress.XtraEditors;

namespace Wamby.Client.Forms
{
    public partial class SettingsUserControl : XtraUserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            toggleSwitchShowWelcomeOnStartup.Toggled += (s, e) => SaveSettings();
            toggleSwitchStartScanAfterChangingFolder.Toggled += (s, e) => SaveSettings();
            toggleSwitchShowResultsPageAfterScan.Toggled += (s, e) => SaveSettings();
            toggleSwitchSaveFileInReadableFormat.Toggled += (s, e) => SaveSettings();
        }

        public void LoadSettings()
        {
            var settings = WambyApplication.SettingsService.LoadSettings();
            newScanPathButtonEdit.Text = settings.DefaultBaseFolderPath;
            searchPatternButtonEdit.Text = settings.DefaultSearchPattern;
            includeSubfoldersCheckEdit.IsOn = settings.DefaultIncludeSubFolders;
            imageComboBoxEditType.EditValue = settings.DefaultDetailedScanType;
            toggleSwitchShowWelcomeOnStartup.IsOn = settings.ShowWelcomeOnStartup;
            toggleSwitchStartScanAfterChangingFolder.IsOn = settings.DoScanAfterChangingBaseFolderPath;
            toggleSwitchShowResultsPageAfterScan.IsOn = settings.ShowResultsPageAfterScan;
            toggleSwitchSaveFileInReadableFormat.IsOn = settings.SaveToFileReadableFormat;
        }

        public void SaveSettings()
        {
            var settings = WambyApplication.Settings;
            settings.ShowWelcomeOnStartup = toggleSwitchShowWelcomeOnStartup.IsOn;
            settings.DoScanAfterChangingBaseFolderPath = toggleSwitchStartScanAfterChangingFolder.IsOn;
            settings.ShowResultsPageAfterScan = toggleSwitchShowResultsPageAfterScan.IsOn;
            settings.SaveToFileReadableFormat = toggleSwitchSaveFileInReadableFormat.IsOn;
            WambyApplication.SettingsService.SaveSettings(settings);
        }
    }
}
