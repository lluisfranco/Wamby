using System;
using System.Linq;

namespace Wamby.API.Args
{
    public class WambyFileSystemInfoEventArgs : EventArgs
    {
        public System.IO.FileSystemInfo WambyFileSystemItem { get; set; }
    }
}
