using System;
using System.Linq;

namespace Wamby.API.Services
{
    public class FileSystemInfoEventArgs : EventArgs
    {
        public System.IO.FileSystemInfo FileSystemItem { get; set; }
    }
}
