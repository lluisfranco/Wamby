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
        public bool AutoStartScan { get; set; }
        public Interfaces.IModule CurrentModule { get; set; }
        public API.Services.FileSystemScanService FileSystemScanService { get; private set; }
        public API.Services.FileSystemStorageService FileSystemStorageService { get; private set; }
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

        public async Task SaveScan(string filename, bool readable)
        {
            FileSystemStorageService.SaveReadableFormat = readable;
            await FileSystemStorageService.SaveToFile(filename, FileSystemScanService);
        }

        public async Task<API.Services.FileSystemScanService> OpenScan(string filename)
        {
            FileSystemScanService = await FileSystemStorageService.OpenFromFile(filename, FileSystemScanService);
            return FileSystemScanService;
        }

        public void ApplyAppArguments(string[] args)
        {
            try
            {
                var arguments = Helpers.AppArgumentHelper.ParseArguments(args);
                if (arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.InitialFolder))
                {
                    var initialfolder = arguments.First(p => p.Argument == Enums.AppArgumentsEnum.InitialFolder).Value;
                    if (System.IO.Directory.Exists(initialfolder)) this.InitialFolderPath = initialfolder;
                }
                if (arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.AutoStartScan))
                {
                    var autostart = Convert.ToBoolean(arguments.First(p => p.Argument == Enums.AppArgumentsEnum.AutoStartScan).Value);
                    this.AutoStartScan = autostart;
                }
            }
            catch
            {

            }
        }
    }
}
