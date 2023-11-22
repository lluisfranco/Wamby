using System.Text.Json;

namespace Wamby.Settings
{
    public class SettingsService
    {
        public void SaveSettings(Settings settings)
        {
            var content = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Settings.FILENAME, content);
        }

        public Settings? LoadSettings()
        {
            if (File.Exists(Settings.FILENAME))
            {
                var content = File.ReadAllText(Settings.FILENAME);
                return JsonSerializer.Deserialize<Settings>(content);
            }
            else
            {
                return new Settings();
            }
        }
    }
}