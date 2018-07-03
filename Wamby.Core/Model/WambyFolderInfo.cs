using Newtonsoft.Json;
using System.Collections.Generic;

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

        [JsonIgnore]
        public System.IO.DirectoryInfo DirectoryInfo { get; set; }
        [JsonIgnore]
        public List<WambyFolderInfo> Folders { get; set; } = new List<WambyFolderInfo>();
        [JsonIgnore]
        public List<WambyFileInfo> Files { get; set; } = new List<WambyFileInfo>();
    }
}
