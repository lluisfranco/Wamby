using Wamby.API.Enums;

namespace Wamby.Settings
{
    public class Settings
    {
        public const string FILENAME = "Wamby.Settings.json";
        public string DefaultBaseFolderPath { get; set; } = string.Empty;
        public string DefaultSearchPattern { get; set; } = "*.*";
        public bool DefaultIncludeSubFolders { get; set; } = true;
        public ScanDetailTypeEnum DefaultDetailedScanType { get; set; } = ScanDetailTypeEnum.Fast;
        public int ShowMinimumFolderLevelInLog { get; set; } = 3;
        public int SavePreviousScansMaxCount { get; set; } = 100;
        public bool DoScanAfterChangingBaseFolderPath { get; set; } = true;
        public bool Layouts_SaveOnExit { get; set; } = true;
        public bool Layouts_LoadOnStart { get; set; } = true;
        public bool SaveToFileReadableFormat { get; set; } = true;
        public bool ShowWelcomeOnStartup { get; set; } = true;
        public bool ShowResultsPageAfterScan { get; set; } = true;
        public SkinSettings Skin { get; set; } = new();
        public class SkinSettings
        {
            public string SkinName { get; set; } = string.Empty;
            public string SkinPalette { get; set; } = string.Empty;
            public bool SkinAdvancedUseWindowsAppMode { get; set; } = true;
            public bool SkinAdvancedSystemAccentColor { get; set; } = true;
            public string SkinAdvancedCustomColor { get; set; } = string.Empty;
            public string SkinAdvancedCustomColor2 { get; set; } = string.Empty;
            public bool UseCompactUI { get; set; } = false;
        }
    }
}