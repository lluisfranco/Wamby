using Newtonsoft.Json;
using System;

namespace Wamby.Core.Model
{
    public class ScanException
    {
        public string FileFullPath { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSiteName { get; set; }        
        public string InnerExceptionMessage { get; set; }
        public int? HResult { get; set; }
        public string TypeName { get; set; } 
    }
}
