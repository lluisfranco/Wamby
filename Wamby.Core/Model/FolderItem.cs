using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Core.Model
{
    public class ScanOptions
    {
        public string BaseFolderPath { get; set; }
        public bool IncludeSubFolders { get; set; }
    }

    public class ScanResult
    {
        public FolderInfo FolderInfo { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public List<ScanException> ScanExceptions { get; set; } = new List<ScanException>();
    }

    public class FolderInfo 
    {
        public string FullName { get; set; }
        public System.IO.DirectoryInfo DirectoryInfo { get; set; }
        public List<FolderInfo> Folders { get; set; } = new List<FolderInfo>();
        public List<System.IO.FileInfo> Files { get; set; } = new List<System.IO.FileInfo>();
        public List<FolderInfo> AllFolders { get; set; } = new List<FolderInfo>();
        public double Length { get; set; }
    }

    public class ScanException
    {
        public System.IO.FileSystemInfo FileSystemInfo { get; set; }
        public Exception Exception { get; set; }
    }
}
