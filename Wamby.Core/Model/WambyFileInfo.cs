using Newtonsoft.Json;

namespace Wamby.Core.Model
{
    public class WambyFileInfo : WambyFileSystemItem
    {
        public string Extension { get; set; }
        [JsonIgnore]
        public System.IO.FileInfo FileInfo { get; set; }
        public string ParentFullName { get; set; }
    }
}
