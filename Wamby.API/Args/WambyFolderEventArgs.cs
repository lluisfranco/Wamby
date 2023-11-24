using System;
using Wamby.Core.Model;

namespace Wamby.API.Args
{
    public class WambyFolderEventArgs : EventArgs
    {
        public WambyFolderInfo WambyFolderInfo { get; set; }
    }
}
