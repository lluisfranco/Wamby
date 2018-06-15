using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.API.Extensions
{
    public static class ScanResultExtensions
    {
        public static double TotalSize(this Core.Model.ScanResult scanResult)
        {
            return scanResult.FolderInfo.Files.Sum(p => p.Length) + scanResult.FolderInfo.AllFolders.Sum(p => p.Length);
        }

        public static double TotalFilesCount(this Core.Model.ScanResult scanResult)
        {
            return scanResult.FolderInfo.Files.Count + scanResult.FolderInfo.AllFolders.Sum(p => p.Files.Count);
        }
    }
}
