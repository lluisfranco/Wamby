using System;
using System.IO;

namespace Wamby.API.Args
{
    public class WambyFileSystemInfoEventArgs : EventArgs
    {
        public FileSystemInfo WambyFileSystemItem { get; set; }
    }
}
