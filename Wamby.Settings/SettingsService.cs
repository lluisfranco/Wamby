using System.Text.Json;

namespace Wamby.Settings
{
    public class SettingsService
    {
        public void SaveSettings(Settings settings)
        {
            var settingsString = JsonSerializer.Serialize(settings);
            File.WriteAllText(Settings.FILENAME, settingsString);
        }

        public Settings? LoadSettings()
        {
            if (File.Exists(Settings.FILENAME))
            {
                var settingsString = File.ReadAllText(Settings.FILENAME);
                return JsonSerializer.Deserialize<Settings>(settingsString);
            }
            else
            {
                return new Settings();
            }
        }
    }
}