using System;
using System.Linq;

namespace Wamby.API.Services
{
    public class WambyFileSystemInfoEventArgs : EventArgs
    {
        public System.IO.FileSystemInfo WambyFileSystemItem { get; set; }
    }
}
