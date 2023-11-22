namespace Wamby.Client
{
    public static class WambyApplication
    {
        public static Settings.Settings Settings { get; set; } = new();
        public static Settings.SettingsService SettingsService { get; set; } = new();
    }
}