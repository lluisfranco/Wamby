using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wamby.Core.Extensions;

namespace Wamby.API.Services
{
    public class FileSystemScanService
    {
        public Core.Model.ScanOptions ScanOptions { get; private set; }
        public Core.Model.ScanResult ScanResult { get; private set; }
        public DirectoryInfo BaseFolder { get; private set; }
        public FileSystemScanService(Core.Model.ScanOptions scanOptions)
        {
            ScanOptions = scanOptions;
            ScanResult = new Core.Model.ScanResult();
            BaseFolder = CheckBaseFolder(ScanOptions.BaseFolderPath);
        }

        FileSystemInfo _CurrentFileSystemInfo;
        public async Task<Core.Model.ScanResult> DoScan()
        {
            var clock = new System.Diagnostics.Stopwatch();
            clock.Restart();
            ScanResult.FolderInfo = await Task.Run(() => ScanFolder(BaseFolder));
            ScanResult.FolderInfo.AllFolders = ScanResult.FolderInfo.Folders.SelectManyRecursive(p => p.Folders).ToList();
            var size = ScanResult.FolderInfo.Files.Sum(p => p.Length) + ScanResult.FolderInfo.AllFolders.Sum(p => p.Length);
            var numfiles = ScanResult.FolderInfo.Files.Count + ScanResult.FolderInfo.AllFolders.Sum(p => p.Files.Count);
            clock.Stop();
            ScanResult.ElapsedTime = clock.Elapsed;
            return ScanResult;
        }

        private Core.Model.FolderInfo ScanFolder(DirectoryInfo currentFolder)
        {
            var currentFolderInfo = new Core.Model.FolderInfo() { DirectoryInfo = currentFolder };
            if (ScanOptions.IncludeSubFolders)
            {
                try
                {
                    foreach (var folder in currentFolder.GetDirectories())
                    {
                        _CurrentFileSystemInfo = folder;
                        var folderInfo = ScanFolder(folder);
                        currentFolderInfo.Folders.Add(folderInfo);
                    }
                }
                catch (Exception ex)
                {
                    AddExceptionToResult(ex, _CurrentFileSystemInfo);
                }
            }
            try
            {
                foreach (var file in currentFolder.GetFiles())
                {
                    _CurrentFileSystemInfo = file;
                    currentFolderInfo.Files.Add(file);
                    currentFolderInfo.Length = currentFolderInfo.Files.Sum(p => p.Length);
                }
                return currentFolderInfo;
            }
            catch (Exception ex)
            {
                AddExceptionToResult(ex, _CurrentFileSystemInfo);
                return currentFolderInfo;
            }
        }

        private void AddExceptionToResult(Exception ex, FileSystemInfo currentFileSystemInfo)
        {
            ScanResult.ScanExceptions.Add(new Core.Model.ScanException()
            {
                Exception = ex,
                FileSystemInfo = currentFileSystemInfo
            });
        }

        private DirectoryInfo CheckBaseFolder(string baseFolderPath)
        {
            if (baseFolderPath == null) throw new ArgumentNullException(nameof(baseFolderPath));
            if (!Directory.Exists(baseFolderPath)) throw new DirectoryNotFoundException();
            try
            {
                BaseFolder = new DirectoryInfo(baseFolderPath);
                return BaseFolder;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
