using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wamby.Client.ViewModels
{
    public class MainFormViewModel : Interfaces.IFileSystemScanService
    {
        public List<Model.AppArgument> Arguments { get; set; }
        public bool AutoStartScan { get; set; }
        public bool SaveToFile { get; set; }
        public string SaveFolderPath { get; set; }
        public string SaveFileName { get; set; }
        public bool CloseOnFinish { get; set; }
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
                this.Arguments = Helpers.AppArgumentHelper.ParseArguments(args);
                if (this.Arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.InitialFolder))
                {
                    var value = this.Arguments.First(p => p.Argument == Enums.AppArgumentsEnum.InitialFolder).Value;
                    if (System.IO.Directory.Exists(value)) FileSystemScanService.ScanOptions.BaseFolderPath = value;
                }
                if (this.Arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.AutoStartScan))
                {
                    var value = Convert.ToBoolean(this.Arguments.First(p => p.Argument == Enums.AppArgumentsEnum.AutoStartScan).Value);
                    this.AutoStartScan = value;
                }
                if (this.Arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.SaveToFile))
                {
                    var value = Convert.ToBoolean(this.Arguments.First(p => p.Argument == Enums.AppArgumentsEnum.SaveToFile).Value);
                    this.SaveToFile = value;
                }
                if (this.Arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.SaveFolderPath))
                {
                    var value = this.Arguments.First(p => p.Argument == Enums.AppArgumentsEnum.SaveFolderPath).Value;
                    if (System.IO.Directory.Exists(value)) this.SaveFolderPath = value;
                }
                if (this.Arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.SaveFileName))
                {
                    var value = this.Arguments.First(p => p.Argument == Enums.AppArgumentsEnum.SaveFileName).Value;
                    this.SaveFileName = value;
                }
                if (this.Arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.CloseOnFinish))
                {
                    var value = Convert.ToBoolean(this.Arguments.First(p => p.Argument == Enums.AppArgumentsEnum.CloseOnFinish).Value);
                    this.CloseOnFinish = value;
                }
                if (this.Arguments.Any(p => p.Argument == Enums.AppArgumentsEnum.ScanDetailType))
                {
                    var value = Helpers.AppArgumentHelper.GetEnum<API.Enums.ScanDetailTypeEnum>(
                        this.Arguments.First(p => p.Argument == Enums.AppArgumentsEnum.ScanDetailType).Value);
                    FileSystemScanService.DetailType = value;
                }
            }
            catch
            {

            }
        }

        public async Task SaveScanToFile()
        {
            var foldername = this.SaveFolderPath;
            if (!System.IO.Directory.Exists(foldername))
                foldername = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scanfilename = 
                $"Scan_{FileSystemScanService.ScanResult.WambyFolderInfo.Name}_" +
                $"{FileSystemScanService.ComputerName}_" +
                $"{FileSystemScanService.ScanDate.ToString("dd-MM-yyyy-HH-mm")}.wamby";
            var filename = this.SaveFileName ?? scanfilename;
            var filenamepath = System.IO.Path.Combine(foldername, filename);
            await this.SaveScan(filenamepath, Properties.Settings.Default.SaveToFileReadableFormat);
        }
    }
}
