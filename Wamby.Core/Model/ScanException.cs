using System;
using System.Linq;

namespace Wamby.Core.Model
{
    public class ScanException
    {
        public System.IO.FileSystemInfo FileSystemInfo { get; set; }
        public Exception Exception { get; set; }
        public string FileFullPath { get { return FileSystemInfo?.FullName; } }
        public string Message { get { return Exception?.Message; } }
        public string Source { get { return Exception?.Source; } }
        public string StackTrace { get { return Exception?.StackTrace; } }
        public System.Reflection.MethodBase TargetSite { get { return Exception?.TargetSite; } }
        public Exception InnerException { get { return Exception?.InnerException; } }
        public int? HResult { get { return Exception?.HResult; } }
        public string TypeName { get { return Exception?.GetType().ToString(); } }
    }
}
