using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Client.ViewModels
{
    public class MainFormViewModel : Interfaces.IFileSystemScanService
    {
        public string InitialFolderPath { get; set; }
        public Interfaces.IModule CurrentModule { get; set; }
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public API.Services.FileSystemStorageService FileSystemStorageService { get; }
        public MainFormViewModel(
            API.Services.FileSystemScanService scanService, 
            API.Services.FileSystemStorageService storageService)
        {
            FileSystemScanService = scanService;
            FileSystemStorageService = storageService;
        }

        public void LoadDefaultSettings()
        {
            FileSystemScanService.ScanOptions.BaseFolderPath =
                string.IsNullOrWhiteSpace(Properties.Settings.Default.DefaultBaseFolderPath) ?
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) :
                Properties.Settings.Default.DefaultBaseFolderPath;
            FileSystemScanService.ScanOptions.IncludeSubFolders = Properties.Settings.Default.DefaultIncludeSubFolders;
            FileSystemScanService.ScanOptions.SearchPattern =
                string.IsNullOrWhiteSpace(Properties.Settings.Default.DefaultSearchPattern) ?
                "*" :
                Properties.Settings.Default.DefaultSearchPattern;
        }

        public async Task SaveScan(string filename)
        {
            await FileSystemStorageService.SaveToFile(filename);
        }

        public async Task OpenScan(string filename)
        {
            FileSystemScanService = await FileSystemStorageService.OpenFromFile(filename);
        }
    }
}
