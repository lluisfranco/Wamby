using System;
using System.Collections.Generic;
using System.Linq;

namespace Wamby.Core.Model
{
    public class ScanResult
    {
        public WambyFolderInfo WambyFolderInfo { get; set; } = new WambyFolderInfo();
        public TimeSpan ElapsedTime { get; set; }
        public List<ScanException> ScanExceptions { get; set; } = new List<ScanException>();
    }
}
