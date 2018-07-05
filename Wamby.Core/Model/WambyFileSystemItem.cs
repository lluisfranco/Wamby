using System;

namespace Wamby.Core.Model
{
    public class WambyFileSystemItem
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public double LengthInKB { get { return Length / 1024; } }
        public DateTime LastWriteTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime CreationTime { get; set; }
        public string OwnerName { get; set; }
        public System.IO.FileAttributes Attributes { get; set; }
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
