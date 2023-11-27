using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Wamby.API.Services
{
    public class FileSystemStorageService
    {
        public const string FILENAME_DESC = "Wamby Scan File";
        public const string FILENAME_EXT = "wscan";
        public static string GetFilterDescription() => $"{FILENAME_DESC} (*.{FILENAME_EXT})|*.{FILENAME_EXT}";
        public bool SaveReadableFormat { get; set; }
        
        public async Task SaveToFile(string filename, FileSystemScanService scanService)
        {
            var serviceString = JsonSerializer.Serialize(scanService, 
                new JsonSerializerOptions { WriteIndented = SaveReadableFormat });
            await Task.Run(() => File.WriteAllText(filename, serviceString));
        }

        public static async Task<FileSystemScanService> OpenFromFile(string filename)
        {
            var jsonScanData = await Task.Run(() => File.ReadAllText(filename));
            var data = JsonSerializer.Deserialize<FileSystemScanService>(jsonScanData);
            return data;
        }
    }
}
