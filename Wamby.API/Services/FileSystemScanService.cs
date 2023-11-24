using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Wamby.API.Args;
using Wamby.API.Enums;
using Wamby.Core.Extensions;
using Wamby.Core.Model;

namespace Wamby.API.Services
{
    public class FileSystemScanService
    {
        [JsonIgnore]
        public bool Cancelled { get; private set; }
        [JsonIgnore]
        CancellationTokenSource CancellationToken;
        public string BaseFolder { get; private set; }
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string OSVersionName { get; set; }
        public ScanDetailTypeEnum DetailType { get; set; }
        public DateTime ScanDate { get; set; }
        public ScanOptions ScanOptions { get; private set; }
        public ScanResult ScanResult { get; private set; }
        public List<LogLine> LogLines { get; private set; }
        [JsonIgnore]
        public IProgress<WambyFolderEventArgs> ScanningFolderProgress { get; set; }
        [JsonIgnore]
        public IProgress<WambyFileSystemInfoEventArgs> ErrorReadingFileSystemInfoProgress { get; set; }

        public ScanStats Statistics { get; private set; }

        public event EventHandler BeginScan;
        public event EventHandler EndScan;
        public event EventHandler CancelledScan;
        public void RaiseBeginScan() => BeginScan?.Invoke(this, new EventArgs());
        public void RaiseEndScan() => EndScan?.Invoke(this, new EventArgs());
        public void RaiseCancelledScan() => CancelledScan?.Invoke(this, new EventArgs());

        public FileSystemScanService()
        {
            ScanOptions = new ScanOptions()
            {
                BaseFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };
            Statistics = new(this);
            Clear();
        }

        public void Clear()
        {
            ScanResult = new ScanResult();
            LogLines = new List<LogLine>();
        }
                
        FileSystemInfo _CurrentFileSystemInfo;
        public async Task<ScanResult> DoScan()
        {
            RaiseBeginScan();
            Clear();
            LogLines.Add(new LogLine()
            {
                Message = $"Started scan at {DateTime.Now.ToLongTimeString()}",
                Value = string.Empty,
                LogLineType = LogLineTypeEnum.Info
            });
            BaseFolder = ScanOptions.BaseFolderPath;
            CheckBaseFolder(ScanOptions.BaseFolderPath);
            CancellationToken = new CancellationTokenSource();
            Cancelled = false;
            var clock = new Stopwatch();
            clock.Restart();
            var f = await Task.Run(() => ScanFolder(BaseFolder));
            if (!Cancelled)
            {
                ScanResult.WambyFolderInfo = f;
                ScanResult.AllFolders = ScanResult.WambyFolderInfo.Folders.
                    Where(p => p.IsFolder).SelectManyRecursive(p => p.Folders).ToList();
                ScanResult.AllFolders.Add(ScanResult.WambyFolderInfo);
                if (ScanResult.WambyFolderInfo.Files.Count > 0)
                    ScanResult.AllFolders.Add(AddCurrentFolderFileSummary(ScanResult.WambyFolderInfo));
                var allfiles = ScanResult.AllFolders.SelectMany(p => p.Files);
                ScanResult.AllFiles.AddRange(allfiles);
                var totalDeepLenght = ScanResult.WambyFolderInfo.DeepLenght;
                var totalDeepFilesCount = ScanResult.WambyFolderInfo.DeepFilesCount;
                ScanResult.AllFolders.ForEach(p =>
                {
                    p.DeepLenghtPercent = p.DeepLenght / totalDeepLenght;
                    p.DeepFilesCountPercent = p.DeepFilesCount / totalDeepFilesCount;
                });
            }
            clock.Stop();
            ScanResult.ElapsedTime = clock.Elapsed;
            LogLines.Add(new LogLine()
            {
                Message = $"Finished scan. Ellapsed time: {ScanResult.ElapsedTime.TotalSeconds:n1}s.",
                Value = string.Empty,
                LogLineType = LogLineTypeEnum.Info
            });
            RaiseEndScan();
            return ScanResult;
        }

        public void Cancel()
        {
            CancellationToken.Cancel();
        }
        
        private WambyFolderInfo ScanFolder(string basefolderpath)
        {
            var currentDirectoryInfo = new DirectoryInfo(basefolderpath);
            var wambyFolder = new WambyFolderInfo()
            {
                DirectoryInfo = currentDirectoryInfo,
                DisplayName = basefolderpath == BaseFolder ? currentDirectoryInfo.FullName : currentDirectoryInfo.Name,
                FullName = currentDirectoryInfo.FullName,
                Name = currentDirectoryInfo.Name,
                ParentFullName = currentDirectoryInfo.Parent?.FullName,
                IsFolder = true,
                CreationTime = currentDirectoryInfo.CreationTime,
                LastAccessTime = currentDirectoryInfo.LastAccessTime,
                LastWriteTime = currentDirectoryInfo.LastWriteTime,
                OwnerName = GetOwner(currentDirectoryInfo),
                Attributes = GetAttributes(currentDirectoryInfo),
                Level = basefolderpath.Replace(
                    BaseFolder, string.Empty).Split(Path.DirectorySeparatorChar).Length 
            };
            ApplyFileAttributes(wambyFolder);
            if (Cancelled) return wambyFolder;
            UpdateScanningFolderProgress(wambyFolder);
            if (ScanOptions.IncludeSubFolders)
            {
                try
                {
                    foreach (var folder in currentDirectoryInfo.GetDirectories().OrderBy(p =>p.Name))
                    {
                        _CurrentFileSystemInfo = folder;                        
                        if (CheckIfCancellationRequested()) return wambyFolder;
                        var folderInfo = ScanFolder(folder.FullName);
                        wambyFolder.Folders.Add(folderInfo);
                    }
                }
                catch (Exception ex)
                {
                    if (!ExistsExceptionInResult(ex, _CurrentFileSystemInfo))
                    {
                        AddExceptionToResult(ex, _CurrentFileSystemInfo);
                        UpdateErrorReadingFileSystemInfoProgress(_CurrentFileSystemInfo);
                    }
                }
            }
            try
            {
                foreach (var file in currentDirectoryInfo.GetFiles(ScanOptions.SearchPattern).OrderBy(p => p.Name))
                {
                    _CurrentFileSystemInfo = file;
                    if (CheckIfCancellationRequested()) return wambyFolder;
                    var wambyfile = new WambyFileInfo()
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
                        OwnerName = GetOwner(file),
                        Attributes = GetAttributes(file),
                    };
                    ApplyFileAttributes(wambyfile);
                    wambyFolder.Files.Add(wambyfile);
                    wambyFolder.Length = wambyFolder.Files.Sum(p => p.Length);
                    var on = GetOwner(file);
                }
                if (wambyFolder.Files.Count > 0)
                    wambyFolder.Folders.Add(AddCurrentFolderFileSummary(wambyFolder));
                wambyFolder.Length = wambyFolder.Files.Sum(p => p.Length);
                wambyFolder.FilesCount = wambyFolder.Files.Count;
                wambyFolder.DeepLenght = wambyFolder.Length + 
                    wambyFolder.Folders.Where(p => p.IsFolder).Sum(p => p.DeepLenght);
                wambyFolder.DeepFilesCount = wambyFolder.FilesCount + 
                    wambyFolder.Folders.Where(p => p.IsFolder).Sum(p => p.DeepFilesCount);
                return wambyFolder;
            }
            catch (Exception ex)
            {
                if (!ExistsExceptionInResult(ex, _CurrentFileSystemInfo))
                {
                    AddExceptionToResult(ex, _CurrentFileSystemInfo);
                    UpdateErrorReadingFileSystemInfoProgress(_CurrentFileSystemInfo);
                }
                return wambyFolder;
            }
        }

        private void ApplyFileAttributes(WambyFileSystemItem wambyFileSystemItem)
        {
            if (DetailType == Enums.ScanDetailTypeEnum.Fast) return;
            wambyFileSystemItem.IsArchive = (wambyFileSystemItem.Attributes & FileAttributes.Archive) == FileAttributes.Archive;
            wambyFileSystemItem.IsCompressed = (wambyFileSystemItem.Attributes & FileAttributes.Compressed) == FileAttributes.Compressed;
            wambyFileSystemItem.IsDevice = (wambyFileSystemItem.Attributes & FileAttributes.Device) == FileAttributes.Device;
            wambyFileSystemItem.IsDirectory = (wambyFileSystemItem.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
            wambyFileSystemItem.IsEncrypted = (wambyFileSystemItem.Attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted;
            wambyFileSystemItem.IsHidden = (wambyFileSystemItem.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
            wambyFileSystemItem.IsIntegrityStream = (wambyFileSystemItem.Attributes & FileAttributes.IntegrityStream) == FileAttributes.IntegrityStream;
            wambyFileSystemItem.IsNormal = (wambyFileSystemItem.Attributes & FileAttributes.Normal) == FileAttributes.Normal;
            wambyFileSystemItem.IsNoScrubData = (wambyFileSystemItem.Attributes & FileAttributes.NoScrubData) == FileAttributes.NoScrubData;
            wambyFileSystemItem.IsNotContentIndexed = (wambyFileSystemItem.Attributes & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed;
            wambyFileSystemItem.IsOffline = (wambyFileSystemItem.Attributes & FileAttributes.Offline) == FileAttributes.Offline;
            wambyFileSystemItem.IsReadOnly = (wambyFileSystemItem.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
            wambyFileSystemItem.IsReparsePoint = (wambyFileSystemItem.Attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint;
            wambyFileSystemItem.IsSparseFile = (wambyFileSystemItem.Attributes & FileAttributes.SparseFile) == FileAttributes.SparseFile;
            wambyFileSystemItem.IsSystem = (wambyFileSystemItem.Attributes & FileAttributes.System) == FileAttributes.System;
            wambyFileSystemItem.IsTemporary = (wambyFileSystemItem.Attributes & FileAttributes.Temporary) == FileAttributes.Temporary;
        }

        private WambyFolderInfo AddCurrentFolderFileSummary(WambyFolderInfo currentFolderInfo)
        {
            var currentFolderFilesSummaryInfo = new WambyFolderInfo()
            {
                DirectoryInfo = new DirectoryInfo(currentFolderInfo.FullName),
                FullName = $"Files in: {currentFolderInfo.FullName}",
                DisplayName = $"Files in: {currentFolderInfo.DisplayName}",
                ParentFullName = currentFolderInfo.FullName,
                Name = currentFolderInfo.Name,
                IsFolder = false,
                Level = currentFolderInfo.FullName.Replace(BaseFolder, string.Empty).Split('\\').Length - 1,
                Length = currentFolderInfo.Files.Sum(p => p.Length),
                FilesCount = currentFolderInfo.Files.Count,
                DeepLenght = currentFolderInfo.Files.Sum(p => p.Length),
                DeepFilesCount = currentFolderInfo.Files.Count,
                CreationTime = currentFolderInfo.CreationTime,
                LastAccessTime = currentFolderInfo.LastAccessTime,
                LastWriteTime = currentFolderInfo.LastWriteTime,
                OwnerName = GetOwner(currentFolderInfo.DirectoryInfo),
                Attributes = FileAttributes.Normal
            };
            return currentFolderFilesSummaryInfo;           
        }

        bool ExistsExceptionInResult(Exception ex, FileSystemInfo currentFileSystemInfo)
        {
            if (currentFileSystemInfo == null) return false;
            return ScanResult.ScanExceptions.Any(p =>
                p.Message == ex.Message &&
                p.FileFullPath == currentFileSystemInfo.FullName);
        }

        private void UpdateScanningFolderProgress(WambyFolderInfo currentFolderInfo)
        {
            if (Cancelled) return;
            if (DetailType == ScanDetailTypeEnum.Detailed)
            {
                if (currentFolderInfo.Level <= ScanOptions.ShowMinimumFolderLevelInLog)
                {
                    LogLines.Add(new LogLine()
                    {
                        Message = $"Reading: {currentFolderInfo.FullName}",
                        Value = currentFolderInfo.FullName,
                        LogLineType = LogLineTypeEnum.ReadingFolder
                    });
                    ScanningFolderProgress?.Report(new WambyFolderEventArgs() { WambyFolderInfo = currentFolderInfo });
                }
            }
            else if(currentFolderInfo.Level <= 2)
            {
                LogLines.Add(new LogLine()
                {
                    Message = $"Reading: {currentFolderInfo.FullName}",
                    Value = currentFolderInfo.FullName,
                    LogLineType = LogLineTypeEnum.ReadingFolder
                });
                ScanningFolderProgress?.Report(new WambyFolderEventArgs() { WambyFolderInfo = currentFolderInfo });
            }
        }

        private void UpdateErrorReadingFileSystemInfoProgress(FileSystemInfo currentItem)
        {
            if (Cancelled) return;
            LogLines.Add(new LogLine()
            {
                Message = $"ERROR: {currentItem.FullName}",
                Value = currentItem.FullName,
                LogLineType = LogLineTypeEnum.Error
            });
            ErrorReadingFileSystemInfoProgress?.Report(new WambyFileSystemInfoEventArgs() { WambyFileSystemItem = currentItem });
        }

        private void AddExceptionToResult(Exception ex, FileSystemInfo currentFileSystemInfo)
        {
            ScanResult.ScanExceptions.Add(new ScanException()
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
                var username = WindowsIdentity.GetCurrent().Name;
                LogLines.Add(new LogLine()
                {
                    Message = $"** Scan cancelled by user {username} **".ToUpper(),
                    Value = string.Empty,
                    LogLineType = LogLineTypeEnum.Error
                });
                RaiseCancelledScan();
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

        private FileAttributes GetAttributes(FileInfo file)
        {
            if (DetailType == ScanDetailTypeEnum.Fast) return FileAttributes.Normal;
            try
            {
                var fa = File.GetAttributes(file.FullName);
                return fa;
            }
            catch (Exception)
            {
                return FileAttributes.Normal;
            }
        }

        private FileAttributes GetAttributes(DirectoryInfo folder)
        {
            if (DetailType == ScanDetailTypeEnum.Fast) return FileAttributes.Normal;
            try
            {
                var fa = folder.Attributes;
                return fa;
            }
            catch (Exception)
            {
                return FileAttributes.Normal;
            }
        }

        public string GetOwner(FileInfo file)
        {
            if (DetailType == ScanDetailTypeEnum.Fast) return "(Owner)";
            try
            {
                var fs = file.GetAccessControl();
                var sid = fs.GetOwner(typeof(SecurityIdentifier));
                var ntAccount = sid.Translate(typeof(NTAccount));
                return ntAccount.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetOwner(DirectoryInfo folder)
        {
            if (DetailType == ScanDetailTypeEnum.Fast) return "(Owner)";
            try
            {
                var fs = folder.GetAccessControl();
                var sid = fs.GetOwner(typeof(SecurityIdentifier));
                var ntAccount = sid.Translate(typeof(NTAccount));
                return ntAccount.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetSummary()
        {
            var folder = new DirectoryInfo(ScanOptions.BaseFolderPath);
            return $"Scaned '{folder.Name}' in {(ScanResult.ElapsedTime.TotalMilliseconds / 1000):n1}s. Found: " +
                $"{ScanResult.AllFiles.Count:n0} file(s) in {ScanResult.AllFolders.Count:n0} folder(s)" +
                (ScanResult.ScanExceptions.Count > 0 ? $". {ScanResult.ScanExceptions.Count} error(s)" : string.Empty);
        }
    }
}
