using System;
using System.Linq;

namespace Wamby.API.Args
{
    public class WambyFolderEventArgs : EventArgs
    {
        public Core.Model.WambyFolderInfo WambyFolderInfo { get; set; }
    }
}
