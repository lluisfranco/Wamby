using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Wamby.Core.Model
{
    public class ScanResult
    {
        [JsonIgnore]
        public WambyFolderInfo WambyFolderInfo { get; set; } = new WambyFolderInfo();
        public TimeSpan ElapsedTime { get; set; }
        public List<ScanException> ScanExceptions { get; set; } = new List<ScanException>();
        public List<WambyFolderInfo> AllFolders { get; set; } = new List<WambyFolderInfo>();
        public List<WambyFileInfo> AllFiles { get; set; } = new List<WambyFileInfo>();

    }
}
