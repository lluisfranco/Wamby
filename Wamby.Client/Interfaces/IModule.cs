using Wamby.API.Services;

namespace Wamby.Client.Interfaces
{
    public interface IModule : IFileSystemScanService
    {
        bool Initialized { get; }
        void InitializeControl(MainForm mainform, FileSystemScanService scanService);
        void RefreshModuleData();
        void SetFocus();
    }
}
