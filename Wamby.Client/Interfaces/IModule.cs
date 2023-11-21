using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Client.Interfaces
{
    public interface IModule : IFileSystemScanService
    {
        bool Initialized { get; }
        void InitializeControl(MainForm mainform, API.Services.FileSystemScanService scanService);
        void RefreshModuleData();
        void SetFocus();
    }
}
