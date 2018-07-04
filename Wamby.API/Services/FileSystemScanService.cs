using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Wamby.Core.Extensions;

namespace Wamby.API.Services
{
    public class FileSystemScanService
    {
        [JsonIgnore]
        public bool Cancelled { get; private set; }
        [JsonIgnore]
        System.Threading.CancellationTokenSource CancellationToken;
        public string BaseFolder { get; private set; }
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string OSVersionName { get; set; }
        public DateTime ScanDate { get; set; }
        public Core.Model.ScanOptions ScanOptions { get; private set; }
        public Core.Model.ScanResult ScanResult { get; private set; }
        public List<Core.Model.LogLine> LogLines { get; private set; }
        [JsonIgnore]
        public IProgress<Args.WambyFolderEventArgs> ScanningFolderProgress { get; set; }
        [JsonIgnore]
        public IProgress<Args.WambyFileSystemInfoEventArgs> ErrorReadingFileSystemInfoProgress { get; set; }
        [JsonIgnore]
        public IProgress<string> CancelledByUserProgress { get; set; }
        
        public FileSystemScanService()
        {
            ScanOptions = new Core.Model.ScanOptions();
            Clear();
        }

        public void Clear()
        {
            ScanResult = new Core.Model.ScanResult();
            LogLines = new List<Core.Model.LogLine>();
        }

        public void CopyProperties(FileSystemScanService fromScanService)
        {
            BaseFolder = fromScanService.BaseFolder;
            ComputerName = fromScanService.ComputerName;
            OSVersionName = fromScanService.OSVersionName;
            ScanDate = fromScanService.ScanDate;
            ScanOptions.BaseFolderPath = fromScanService.ScanOptions.BaseFolderPath;
            ScanOptions.IncludeSubFolders = fromScanService.ScanOptions.IncludeSubFolders;
            ScanOptions.SearchPattern = fromScanService.ScanOptions.SearchPattern;
            ScanOptions.ShowMinimumFolderLevelInLog = fromScanService.ScanOptions.ShowMinimumFolderLevelInLog;
            UserName = fromScanService.UserName;
            Clear();
            ScanResult.AllFolders.AddRange(fromScanService.ScanResult.AllFolders);
            ScanResult.AllFiles.AddRange(fromScanService.ScanResult.AllFiles);
            ScanResult.ScanExceptions.AddRange(fromScanService.ScanResult.ScanExceptions);
            LogLines.AddRange(fromScanService.LogLines);
        }

        FileSystemInfo _CurrentFileSystemInfo;
        public async Task<Core.Model.ScanResult> DoScan()
        {
            Clear();
            LogLines.Add(new Core.Model.LogLine()
            {
                Message = $"Started scan at {DateTime.Now.ToShortTimeString()}",
                Value = string.Empty,
                LogLineType = Core.Model.LogLineTypeEnum.Info
            });
            BaseFolder = ScanOptions.BaseFolderPath;
            CheckBaseFolder(ScanOptions.BaseFolderPath);
            CancellationToken = new System.Threading.CancellationTokenSource();
            Cancelled = false;
            var clock = new System.Diagnostics.Stopwatch();
            clock.Restart();
            var f = await Task.Run(() => ScanFolder(BaseFolder));
            ScanResult.WambyFolderInfo = f;
            ScanResult.AllFolders = ScanResult.WambyFolderInfo.Folders.
                Where(p => p.IsFolder).SelectManyRecursive(p => p.Folders).ToList();
            ScanResult.AllFolders.Add(ScanResult.WambyFolderInfo);
            if (ScanResult.WambyFolderInfo.Files.Count > 0)
                ScanResult.AllFolders.Add(AddCurrentFolderFileSummary(ScanResult.WambyFolderInfo));
            var allfiles = ScanResult.AllFolders.SelectMany(p => p.Files);
            ScanResult.AllFiles.AddRange(allfiles);
            clock.Stop();
            ScanResult.ElapsedTime = clock.Elapsed;
            LogLines.Add(new Core.Model.LogLine()
            {
                Message = $"Finished scan. Ellapsed time: {ScanResult.ElapsedTime.TotalSeconds.ToString("n2")} sec.",
                Value = string.Empty,
                LogLineType = Core.Model.LogLineTypeEnum.Info
            });
            return ScanResult;
        }

        public void Cancel()
        {
            CancellationToken.Cancel();
        }
        
        private Core.Model.WambyFolderInfo ScanFolder(string basefolderpath)
        {
            var currentDirectoryInfo = new DirectoryInfo(basefolderpath);
            var currentFolderInfo = new Core.Model.WambyFolderInfo()
            {
                DirectoryInfo = currentDirectoryInfo,
                FullName = currentDirectoryInfo.FullName,
                Name = currentDirectoryInfo.Name,
                ParentFullName = currentDirectoryInfo.Parent?.FullName,
                IsFolder = true,
                CreationTime = currentDirectoryInfo.CreationTime,
                LastAccessTime = currentDirectoryInfo.LastAccessTime,
                LastWriteTime = currentDirectoryInfo.LastWriteTime,
                OwnerName = GetOwner(currentDirectoryInfo),
                Level = basefolderpath.Replace(
                    BaseFolder, string.Empty).Split(Path.DirectorySeparatorChar).Length 
            };
            if (Cancelled) return currentFolderInfo;
            UpdateProgressScanningFolder(currentFolderInfo);
            if (ScanOptions.IncludeSubFolders)
            {
                try
                {
                    foreach (var folder in currentDirectoryInfo.GetDirectories())
                    {
                        _CurrentFileSystemInfo = folder;                        
                        if (CheckIfCancellationRequested()) return currentFolderInfo;
                        var folderInfo = ScanFolder(folder.FullName);
                        currentFolderInfo.Folders.Add(folderInfo);
                    }
                }
                catch (Exception ex)
                {
                    if (!existsExceptionInResult(ex, _CurrentFileSystemInfo))
                    {
                        AddExceptionToResult(ex, _CurrentFileSystemInfo);
                        UpdateProgressErrorReadingFileSystemInfo(_CurrentFileSystemInfo);
                    }
                }
            }
            try
            {
                foreach (var file in currentDirectoryInfo.GetFiles(ScanOptions.SearchPattern))
                {
                    _CurrentFileSystemInfo = file;
                    if (CheckIfCancellationRequested()) return currentFolderInfo;
                    var wambyfile = new Core.Model.WambyFileInfo()
                    {
                        FullName = file.FullName,
                        Name = file.Name,
                        Length = file.Length,
                        CreationTime = file.CreationTime,
                        LastAccessTime = file.LastAccessTime,
                        LastWriteTime = file.LastWriteTime,
                        Extension = file.Extension.ToLower(),
                        ParentFullName = file.DirectoryName,
                        FileInfo = file,
                        OwnerName = GetOwner(file)
                    };
                    currentFolderInfo.Files.Add(wambyfile);
                    currentFolderInfo.Length = currentFolderInfo.Files.Sum(p => p.Length);
                    var on = GetOwner(file);
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
                    UpdateProgressErrorReadingFileSystemInfo(_CurrentFileSystemInfo);
                }
                return currentFolderInfo;
            }
        }

        private Core.Model.WambyFolderInfo AddCurrentFolderFileSummary(Core.Model.WambyFolderInfo currentFolderInfo)
        {
            var currentFolderFilesSummaryInfo = new Core.Model.WambyFolderInfo()
            {
                DirectoryInfo = new DirectoryInfo(currentFolderInfo.FullName),
                FullName = $"Files in: {currentFolderInfo.FullName}",
                ParentFullName = currentFolderInfo.FullName,
                Name = currentFolderInfo.Name,
                IsFolder = false,
                Level = currentFolderInfo.FullName.Replace(BaseFolder, string.Empty).Split('\\').Length - 1,
                Length = currentFolderInfo.Files.Sum(p => p.Length),
                FilesCount = currentFolderInfo.Files.Count,
                DeepLength = currentFolderInfo.Files.Sum(p => p.Length),
                DeepFilesCount = currentFolderInfo.Files.Count,
                CreationTime = currentFolderInfo.CreationTime,
                LastAccessTime = currentFolderInfo.LastAccessTime,
                LastWriteTime = currentFolderInfo.LastWriteTime,
                OwnerName = GetOwner(currentFolderInfo.DirectoryInfo),
            };
            return currentFolderFilesSummaryInfo;           
        }

        bool existsExceptionInResult(Exception ex, FileSystemInfo currentFileSystemInfo)
        {
            if (currentFileSystemInfo == null) return false;
            return ScanResult.ScanExceptions.Any(p =>
                p.Message == ex.Message &&
                p.FileFullPath == currentFileSystemInfo.FullName);
        }

        private void UpdateProgressScanningFolder(Core.Model.WambyFolderInfo currentFolderInfo)
        {
            if (currentFolderInfo.Level <= ScanOptions.ShowMinimumFolderLevelInLog && !Cancelled)
            {
                LogLines.Add(new Core.Model.LogLine()
                {
                    Message = $"Reading: {currentFolderInfo.FullName}",
                    Value = currentFolderInfo.FullName,
                    LogLineType = Core.Model.LogLineTypeEnum.ReadingFolder
                });
                ScanningFolderProgress?.Report(new Args.WambyFolderEventArgs() { WambyFolderInfo = currentFolderInfo });
            }
        }

        private void UpdateProgressErrorReadingFileSystemInfo(FileSystemInfo currentItem)
        {
            if (!Cancelled)
            {
                LogLines.Add(new Core.Model.LogLine()
                {
                    Message = $"ERROR: {currentItem.FullName}",
                    Value = currentItem.FullName,
                    LogLineType = Core.Model.LogLineTypeEnum.Error
                });
                ErrorReadingFileSystemInfoProgress?.Report(new Args.WambyFileSystemInfoEventArgs() { WambyFileSystemItem = currentItem });
            }
        }

        private void AddExceptionToResult(Exception ex, FileSystemInfo currentFileSystemInfo)
        {
            ScanResult.ScanExceptions.Add(new Core.Model.ScanException()
            {
                FileFullPath = currentFileSystemInfo.FullName,
                Message = ex.Message,
                Source = ex.Source,
                StackTrace = ex.StackTrace,
                TargetSiteName = ex.TargetSite.ToString(),
                InnerExceptionMessage = ex.InnerException?.Message,
                HResult = ex.HResult,
                TypeName = ex.GetType().ToString()
            });
        }

        private bool CheckIfCancellationRequested()
        {
            if (CancellationToken.IsCancellationRequested && !Cancelled)
            {
                Cancelled = true;
                var username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                LogLines.Add(new Core.Model.LogLine()
                {
                    Message = $"** Scan cancelled by user {username} **".ToUpper(),
                    Value = string.Empty,
                    LogLineType = Core.Model.LogLineTypeEnum.Error
                });
                CancelledByUserProgress?.Report(username);
                return true;
            }
            return false;
        }

        private bool CheckBaseFolder(string baseFolderPath)
        {
            if (baseFolderPath == null) throw new ArgumentNullException(nameof(baseFolderPath));
            if (!Directory.Exists(baseFolderPath))
            {
                AddExceptionToResult(new DirectoryNotFoundException(), _CurrentFileSystemInfo);
                throw new DirectoryNotFoundException();
            }
            try
            {
                var folder = new DirectoryInfo(baseFolderPath);
                return true;
            }
            catch (Exception ex)
            {
                AddExceptionToResult(ex, _CurrentFileSystemInfo);
                throw;
            }
        }

        public string GetOwner(FileInfo file)
        {
            var fs = file.GetAccessControl();
            var sid = fs.GetOwner(typeof(System.Security.Principal.SecurityIdentifier));
            var ntAccount = sid.Translate(typeof(System.Security.Principal.NTAccount));
            return ntAccount.ToString();
        }

        public string GetOwner(DirectoryInfo folder)
        {
            var fs = folder.GetAccessControl();
            var sid = fs.GetOwner(typeof(System.Security.Principal.SecurityIdentifier));
            var ntAccount = sid.Translate(typeof(System.Security.Principal.NTAccount));
            return ntAccount.ToString();
        }

        public string GetTempFileName(string extension)
        {
            return System.IO.Path.GetTempFileName().Replace("tmp", extension);
        }
    }
}
