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
        public event EventHandler<ScanningFolderEventArhs> ScanningFolder;
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
            BaseFolder = CheckBaseFolder(ScanOptions.BaseFolderPath);
            CancellationToken = new System.Threading.CancellationTokenSource();
            Cancelled = false;
            var clock = new System.Diagnostics.Stopwatch();
            clock.Restart();
            ScanResult.FolderInfo = await Task.Run(() => ScanFolder(BaseFolder));
            ScanResult.FolderInfo.AllFolders = ScanResult.FolderInfo.Folders.SelectManyRecursive(p => p.Folders).ToList();
            clock.Stop();
            ScanResult.ElapsedTime = clock.Elapsed;
            return ScanResult;
        }

        public void Cancel()
        {
            CancellationToken.Cancel();
        }
        
        private Core.Model.FolderInfo ScanFolder(DirectoryInfo currentFolder)
        {
            var currentFolderInfo = new Core.Model.FolderInfo()
            {
                DirectoryInfo = currentFolder,
                FullName = currentFolder.FullName,
                Level = currentFolder.FullName.Replace(BaseFolder.FullName, string.Empty).Split('\\').Length - 1
            };
            if (Cancelled) return currentFolderInfo;
            RaiseEventScanningFolder(currentFolderInfo);
            if (ScanOptions.IncludeSubFolders)
            {
                try
                {
                    foreach (var folder in currentFolder.GetDirectories())
                    {
                        _CurrentFileSystemInfo = folder;                        
                        if (CheckIfCancellationRequested()) return currentFolderInfo;
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
                foreach (var file in currentFolder.GetFiles(ScanOptions.SearchPattern))
                {
                    _CurrentFileSystemInfo = file;
                    if (CheckIfCancellationRequested()) return currentFolderInfo;
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

        private void RaiseEventScanningFolder(Core.Model.FolderInfo currentFolderInfo)
        {
            if(currentFolderInfo.Level < 3)
                ScanningFolder?.Invoke(this, new ScanningFolderEventArhs() { FolderInfo = currentFolderInfo });
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
