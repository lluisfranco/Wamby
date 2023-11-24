using System;

namespace Wamby.Client.Args
{
    public class OpenFolderInNewTabEventArgs : EventArgs
    {
        public string Path { get; set; }
    }
}
