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

        public async Task<FileSystemScanService> OpenFromFile(string filename, FileSystemScanService scanService)
        {
            return null;
            //var jsonScanData = await Task.Run(() => File.ReadAllText(filename));
            //var ss = JsonConvert.DeserializeObject<FileSystemScanService>(jsonScanData);
            //scanService.CopyProperties(ss);
            //return scanService;
        }
    }
}
