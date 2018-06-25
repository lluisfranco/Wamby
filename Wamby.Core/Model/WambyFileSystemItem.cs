using System;
using System.Linq;

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
    }
}
