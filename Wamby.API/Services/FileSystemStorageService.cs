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
        public FileSystemScanService ScanService { get; private set; }
        public FileSystemStorageService(FileSystemScanService scanService)
        {
            ScanService = scanService;
        }

        public async Task SaveToFile(string filename)
        {
            var jsonScanData = JsonConvert.SerializeObject(ScanService, Formatting.Indented);
            await Task.Run(() => File.WriteAllText(filename, jsonScanData));
        }

        public async Task<FileSystemScanService> OpenFromFile(string filename)
        {
            var jsonScanData = await Task.Run(() => File.ReadAllText(filename));
            ScanService = JsonConvert.DeserializeObject<FileSystemScanService>(jsonScanData);
            return ScanService;
        }
    }
}
