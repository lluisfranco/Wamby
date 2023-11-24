using System;
using Wamby.Client.Args;

namespace Wamby.Client.Interfaces
{
    public interface IResultsModule
    {
        public event EventHandler<OpenFolderInNewTabEventArgs> OpenFolderInNewTabClick;
        void RaiseOpenFolderInNewTabEvent(string path);
    }
}
