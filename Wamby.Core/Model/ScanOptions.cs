using System;
using System.Linq;

namespace Wamby.Core.Model
{
    public class ScanOptions
    {
        public string BaseFolderPath { get; set; }
        public bool IncludeSubFolders { get; set; }
        public string SearchPattern { get; set; }
        public int ShowMinimumFolderLevelInLog { get; set; }
    }
}
