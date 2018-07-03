using Newtonsoft.Json;
using System;
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
        [JsonIgnore]
        public IProgress<Args.WambyFolderEventArgs> ScanningFolderProgress { get; set; }
        [JsonIgnore]
        public IProgress<Args.WambyFileSystemInfoEventArgs> ErrorReadingFileSystemInfoProgress { get; set; }
        [JsonIgnore]
        public IProgress<string> CancelledByUserProgress { get; set; }
        
        public FileSystemScanService()
        {
            ScanOptions = new Core.Model.ScanOptions();
            ScanResult = new Core.Model.ScanResult();
        }

        FileSystemInfo _CurrentFileSystemInfo;
        public async Task<Core.Model.ScanResult> DoScan()
        {
            ScanResult.ScanExceptions.Clear();
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
                //Level = currentDirectoryInfo.Parent.FullName.Replace(
                //    basefolderpath, string.Empty).Split(Path.DirectorySeparatorChar).Length
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
                        //if (_CurrentFileSystemInfo == null) _CurrentFileSystemInfo = currentDirectoryInfo;
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
                p.Exception.Message == ex.Message &&
                p.FileSystemInfo.FullName == currentFileSystemInfo.FullName);
        }

        private void UpdateProgressScanningFolder(Core.Model.WambyFolderInfo currentFolderInfo)
        {
            if (currentFolderInfo.Level <= ScanOptions.ShowMinimumFolderLevelInLog && !Cancelled)
                ScanningFolderProgress?.Report(new Args.WambyFolderEventArgs() { WambyFolderInfo = currentFolderInfo });
        }

        private void UpdateProgressErrorReadingFileSystemInfo(FileSystemInfo currentItem)
        {
            if (!Cancelled)
                ErrorReadingFileSystemInfoProgress?.Report(new Args.WambyFileSystemInfoEventArgs() { WambyFileSystemItem = currentItem });
        }

        private bool CheckIfCancellationRequested()
        {
            if (CancellationToken.IsCancellationRequested && !Cancelled)
            {
                Cancelled = true;
                CancelledByUserProgress?.Report(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
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
