using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace Wamby.Core.Model
{
    public class WambyFolderInfo : WambyFileSystemItem
    {
        public string DisplayName { get; set; }
        public string ParentFullName { get; set; }
        public int Level { get; set; }
        public bool IsFolder { get; set; }
        public double FilesCount { get; set; }
        public double DeepLenght { get; set; }
        public double DeepFilesCount { get; set; }
        public double DeepLenghtPercent { get; set; }
        public double DeepFilesCountPercent { get; set; }
        public double DeepLengthInKB { get { return DeepLenght / 1024; } }
        [JsonIgnore]
        public DirectoryInfo DirectoryInfo { get; set; }
        [JsonIgnore]
        public List<WambyFolderInfo> Folders { get; set; } = new List<WambyFolderInfo>();
        [JsonIgnore]
        public List<WambyFileInfo> Files { get; set; } = new List<WambyFileInfo>();
    }
}
