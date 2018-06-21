using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wamby.Core.Extensions;

namespace Wamby.API.Services
{
    public class FileSystemScanService
    {
        public event EventHandler<FolderEventArgs> ScanningFolder;
        public event EventHandler<FileSystemInfoEventArgs> ErrorReadingFileSystemInfo;
        public event EventHandler CancelledByUser;
        public bool Cancelled { get; private set; }
        System.Threading.CancellationTokenSource CancellationToken;
        public Core.Model.ScanOptions ScanOptions { get; private set; }
        public Core.Model.ScanResult ScanResult { get; private set; }
        public DirectoryInfo BaseFolder { get; private set; }

        private SynchronizationContext _context;
        public FileSystemScanService()
        {
            var existingContext = SynchronizationContext.Current;
            _context = existingContext != null ? existingContext.CreateCopy() : new SynchronizationContext();
            ScanOptions = new Core.Model.ScanOptions();
            ScanResult = new Core.Model.ScanResult();
        }

        FileSystemInfo _CurrentFileSystemInfo;
        public async Task<Core.Model.ScanResult> DoScan()
        {
            ScanResult.ScanExceptions.Clear();
            BaseFolder = CheckBaseFolder(ScanOptions.BaseFolderPath);
            CancellationToken = new System.Threading.CancellationTokenSource();
            Cancelled = false;
            var clock = new System.Diagnostics.Stopwatch();
            clock.Restart();
            ScanResult.FolderInfo = await Task.Run(() => ScanFolder(BaseFolder));
            ScanResult.FolderInfo.AllFolders = ScanResult.FolderInfo.Folders.
                Where(p => p.IsFolder).SelectManyRecursive(p => p.Folders).ToList();
            ScanResult.FolderInfo.AllFolders.Add(ScanResult.FolderInfo);
            if (ScanResult.FolderInfo.Files.Count > 0)
                ScanResult.FolderInfo.AllFolders.Add(AddCurrentFolderFileSummary(ScanResult.FolderInfo));
            clock.Stop();
            ScanResult.ElapsedTime = clock.Elapsed;
            return ScanResult;
        }

        public void Cancel()
        {
            CancellationToken.Cancel();
        }
        
        private Core.Model.FolderInfo ScanFolder(DirectoryInfo currentDirectoryInfo)
        {
            var currentFolderInfo = new Core.Model.FolderInfo()
            {
                DirectoryInfo = currentDirectoryInfo,
                FullName = currentDirectoryInfo.FullName,
                ParentFullName = currentDirectoryInfo.Parent?.FullName,
                IsFolder = true,
                Level = currentDirectoryInfo.FullName.Replace(BaseFolder.FullName, string.Empty).Split('\\').Length - 1
            };
            if (Cancelled) return currentFolderInfo;
            RaiseEventScanningFolder(currentFolderInfo);
            if (ScanOptions.IncludeSubFolders)
            {
                try
                {
                    foreach (var folder in currentDirectoryInfo.GetDirectories())
                    {
                        _CurrentFileSystemInfo = folder;                        
                        if (CheckIfCancellationRequested()) return currentFolderInfo;
                        var folderInfo = ScanFolder(folder);
                        currentFolderInfo.Folders.Add(folderInfo);
                    }
                }
                catch (Exception ex)
                {
                    if (!existsExceptionInResult(ex, _CurrentFileSystemInfo))
                    {
                        AddExceptionToResult(ex, _CurrentFileSystemInfo);
                        RaiseEventErrorReadingFileSystemInfo(_CurrentFileSystemInfo);
                    }
                }
            }
            try
            {
                foreach (var file in currentDirectoryInfo.GetFiles(ScanOptions.SearchPattern))
                {
                    _CurrentFileSystemInfo = file;
                    if (CheckIfCancellationRequested()) return currentFolderInfo;
                    currentFolderInfo.Files.Add(file);
                    currentFolderInfo.Length = currentFolderInfo.Files.Sum(p => p.Length);
                }
                if (currentFolderInfo.Files.Count > 0)
                    currentFolderInfo.Folders.Add(AddCurrentFolderFileSummary(currentFolderInfo));
                currentFolderInfo.Length = currentFolderInfo.Files.Sum(p => p.Length);
                currentFolderInfo.FilesCount = currentFolderInfo.Files.Count;
                currentFolderInfo.DeepLength = currentFolderInfo.Length + 
                    currentFolderInfo.Folders.Where(p => p.IsFolder).Sum(p => p.DeepLength);
                currentFolderInfo.DeepFilesCount = currentFolderInfo.FilesCount + 
                    currentFolderInfo.Folders.Where(p => p.IsFolder).Sum(p => p.DeepFilesCount);
                return currentFolderInfo;
            }
            catch (Exception ex)
            {
                if (!existsExceptionInResult(ex, _CurrentFileSystemInfo))
                {
                    AddExceptionToResult(ex, _CurrentFileSystemInfo);
                    RaiseEventErrorReadingFileSystemInfo(_CurrentFileSystemInfo);
                }
                return currentFolderInfo;
            }
        }

        private Core.Model.FolderInfo AddCurrentFolderFileSummary(Core.Model.FolderInfo currentFolderInfo)
        {
            var currentFolderFilesSummaryInfo = new Core.Model.FolderInfo()
            {
                DirectoryInfo = new DirectoryInfo(currentFolderInfo.FullName),
                FullName = $"Files in: {currentFolderInfo.FullName}",
                ParentFullName = currentFolderInfo.FullName,
                IsFolder = false,
                Level = currentFolderInfo.FullName.Replace(BaseFolder.FullName, string.Empty).Split('\\').Length - 1,
                Length = currentFolderInfo.Files.Sum(p => p.Length),
                FilesCount = currentFolderInfo.Files.Count,
                DeepLength = currentFolderInfo.Files.Sum(p => p.Length),
                DeepFilesCount = currentFolderInfo.Files.Count
            };
            return currentFolderFilesSummaryInfo;           
        }

        bool existsExceptionInResult(Exception ex, FileSystemInfo currentFileSystemInfo)
        {
            return ScanResult.ScanExceptions.Any(p =>
                p.Exception.Message == ex.Message &&
                p.FileSystemInfo.FullName == currentFileSystemInfo.FullName);
        }

        private void RaiseEventScanningFolder(Core.Model.FolderInfo currentFolderInfo)
        {
            if(currentFolderInfo.Level < ScanOptions.ShowMinimumFolderLevelInLog)
                ScanningFolder?.Invoke(this, new FolderEventArgs() { FolderInfo = currentFolderInfo });
        }

        private void RaiseEventErrorReadingFileSystemInfo(FileSystemInfo currentItem)
        {
            ErrorReadingFileSystemInfo?.Invoke(this, new FileSystemInfoEventArgs() { FileSystemItem = currentItem });
        }

        private bool CheckIfCancellationRequested()
        {
            if (CancellationToken.IsCancellationRequested && !Cancelled)
            {
                Cancelled = true;
                CancelledByUser?.Invoke(this, new EventArgs());
                return true;
            }
            return false;
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
            if (!Directory.Exists(baseFolderPath))
            {
                AddExceptionToResult(new DirectoryNotFoundException(), _CurrentFileSystemInfo);
                throw new DirectoryNotFoundException();
            }
            try
            {
                BaseFolder = new DirectoryInfo(baseFolderPath);
                return BaseFolder;
            }
            catch (Exception ex)
            {
                AddExceptionToResult(ex, _CurrentFileSystemInfo);
                throw;
            }
        }
    }
}
