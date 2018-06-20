using System;
using System.Linq;

namespace Wamby.API.Services
{
    public class FolderEventArgs : EventArgs
    {
        public Core.Model.FolderInfo FolderInfo { get; set; }
    }
}
