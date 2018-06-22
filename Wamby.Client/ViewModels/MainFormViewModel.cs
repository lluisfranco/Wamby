using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Client.ViewModels
{
    public class MainFormViewModel : Interfaces.IFileSystemScanService
    {
        public Interfaces.IModule CurrentModule { get; set; }
        public API.Services.FileSystemScanService FileSystemScanService { get; }
        public MainFormViewModel(API.Services.FileSystemScanService scanService)
        {
            FileSystemScanService = scanService;
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


    }
}
