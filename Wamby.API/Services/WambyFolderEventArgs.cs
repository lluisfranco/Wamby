using System;
using System.Linq;

namespace Wamby.API.Services
{
    public class WambyFolderEventArgs : EventArgs
    {
        public Core.Model.WambyFolderInfo WambyFolderInfo { get; set; }
    }
}
