using System.IO;
using System.Text.Json.Serialization;

namespace Wamby.Core.Model
{
    public class WambyFileInfo : WambyFileSystemItem
    {
        public string Extension { get; set; }
        [JsonIgnore]
        public FileInfo FileInfo { get; set; }
        public string ParentFullName { get; set; }
    }
}
