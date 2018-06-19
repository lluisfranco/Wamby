using System;
using System.Linq;

namespace Wamby.API.Services
{
    public class ScanningFolderEventArhs : EventArgs
    {
        public Core.Model.FolderInfo FolderInfo { get; set; }
    }
}
