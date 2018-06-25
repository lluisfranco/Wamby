using System;
using System.Collections.Generic;
using System.Linq;

namespace Wamby.Core.Model
{
    public class WambyFolderInfo : WambyFileSystemItem
    {
        public string ParentFullName { get; set; }
        public int Level { get; set; }
        public bool IsFolder { get; set; }
        public double FilesCount { get; set; }
        public double DeepLength { get; set; }
        public double DeepFilesCount { get; set; }
        public double DeepLengthInKB { get { return DeepLength / 1024; } }
        public System.IO.DirectoryInfo DirectoryInfo { get; set; }
        public List<WambyFolderInfo> Folders { get; set; } = new List<WambyFolderInfo>();
        public List<WambyFileInfo> Files { get; set; } = new List<WambyFileInfo>();
        public List<WambyFolderInfo> AllFolders { get; set; } = new List<WambyFolderInfo>();
        public List<WambyFileInfo> AllFiles { get; set; } = new List<WambyFileInfo>();
    }
}
