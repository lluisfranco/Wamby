using Newtonsoft.Json;
using System.IO;

namespace Wamby.Core.Model
{
    public class WambyFileInfo : WambyFileSystemItem
    {
        public string Extension { get; set; }
        [JsonIgnore]
        public System.IO.FileInfo FileInfo { get; set; }
        public string ParentFullName { get; set; }
        public FileAttributes Attributes { get; set; }
        public bool IsArchive { get; set; }
        public bool IsCompressed { get; set; }
        public bool IsDevice { get; set; }
        public bool IsDirectory { get; set; }
        public bool IsEncrypted { get; set; }
        public bool IsHidden { get; set; }
        public bool IsIntegrityStream { get; set; }
        public bool IsNormal { get; set; }
        public bool IsNoScrubData { get; set; }
        public bool IsNotContentIndexed { get; set; }
        public bool IsOffline { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsReparsePoint { get; set; }
        public bool IsSparseFile { get; set; }
        public bool IsSystem { get; set; }
        public bool IsTemporary { get; set; }
    }
}
