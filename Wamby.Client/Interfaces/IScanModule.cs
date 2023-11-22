using System;
using System.Threading.Tasks;
using Wamby.Core.Model;

namespace Wamby.Client.Interfaces
{
    public interface IScanModule
    {
        event EventHandler NewScanButtonPressed;
        event EventHandler ChangeFolderButtonPressed;
        void RaiseNewScanButtonPressed();
        void RaiseChangeFolderButtonPressed();
        Task<ScanResult> DoScan();
        void CancelScan();
    }
}
