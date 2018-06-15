using System;
using System.Linq;

namespace Wamby.Core.Model
{
    public class ScanException
    {
        public System.IO.FileSystemInfo FileSystemInfo { get; set; }
        public Exception Exception { get; set; }
    }
}
