using System.Linq;

namespace Wamby.API.Services
{
    public class ScanStats
    {
        public FileSystemScanService Service { get; private set; }
        public ScanStats(FileSystemScanService service)
        {
            Service = service;
        }

        public void Calculate()
        {
            TotalFoldersCount = GetTotalFoldersCount();
            TotalFilesCount = GetTotalFilesCount();
            TotalErrorsCount = GetTotalErrorsCount();
            TotalFilesSize = GetTotalFilesSize();
            AverageFileSize = GetAverageFileSize();
            GreatestFile = GetGreatestFile();
        }

        public int TotalFoldersCount { get; set; }
        public int TotalFilesCount { get; set; }
        public int TotalErrorsCount { get; set; }
        public int TotalFoldersCount2 { get; set; }
        public double TotalFilesSize { get; set; }
        public double AverageFileSize { get; set; }
        public FileInfoStat GreatestFile { get; set; }

        public int GetTotalFoldersCount() => Service?.ScanResult?.AllFolders?.Count ?? 0;
        public int GetTotalFilesCount() => Service?.ScanResult?.AllFiles?.Count ?? 0;
        public int GetTotalErrorsCount() => Service?.ScanResult.ScanExceptions?.Count ?? 0;
        public double GetTotalFilesSize() => Service?.ScanResult?.AllFiles?.Sum(p => p.Length) ?? 0;
        public double GetAverageFileSize()
        {
            return (TotalFilesSize / TotalFilesCount);
        }

        public double GetAverageFileSizeInKb() => GetAverageFileSize() / 1024;

        public FileInfoStat GetGreatestFile()
        {
            var prev = new FileInfoStat();
            if (Service?.ScanResult?.AllFiles?.Count == 0) return null;
            foreach (var item in Service?.ScanResult?.AllFiles)
            {
                if(item.Length > prev.Lenght)
                {
                    prev.FileName = item.FullName;
                    prev.Name = item.Name;
                    prev.Lenght = item.Length;
                }   
            }
            return prev;
        }
    }

    public class FileInfoStat
    {
        public string FileName { get; set; }
        public string Name { get; set; }
        public double Lenght { get; set; }
    }
}
