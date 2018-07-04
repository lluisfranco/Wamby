using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.API.Services
{
    public class FileSystemStorageService
    {
        public bool SaveReadableFormat { get; set; }
        
        public async Task SaveToFile(string filename, FileSystemScanService scanService)
        {
            var jsonScanData = JsonConvert.SerializeObject(scanService, 
                SaveReadableFormat ? Formatting.Indented : Formatting.None);
            await Task.Run(() => File.WriteAllText(filename, jsonScanData));
        }

        public async Task<FileSystemScanService> OpenFromFile(string filename, FileSystemScanService scanService)
        {
            var jsonScanData = await Task.Run(() => File.ReadAllText(filename));
            var ss = JsonConvert.DeserializeObject<FileSystemScanService>(jsonScanData);
            scanService.CopyProperties(ss);
            return scanService;
        }
    }
}
