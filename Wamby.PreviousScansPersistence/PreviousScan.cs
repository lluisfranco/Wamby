using Wamby.API.Enums;

namespace Wamby.PreviousScansPersistence
{
    public class PreviousScan
    {
        public const string FILENAME = "Wamby.PreviousScans.json";
        public string BaseFolderPath { get; set; } = string.Empty;
        public bool IncludeSubFolders { get; set; } = true;
        public string SearchPattern { get; set; } = "*.*";
        public int ShowMinimumFolderLevelInLog { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string ComputerName { get; set; } = string.Empty;
        public string OSVersionName { get; set; } = string.Empty;
        public ScanDetailTypeEnum DetailType { get; set; }
        public DateTime ScanDate { get; set; }
        public int FolderCount { get; set; }
        public int FileCount { get; set; }
        public int ErrorCount { get; set; }
    }
}