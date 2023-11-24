using System;
using Wamby.API.Enums;

namespace Wamby.Client.Args
{
    public class OpenPreviousScanEventArgs : EventArgs
    {
        public string Path { get; set; }
        public string SearchPattern { get; set; }
        public ScanDetailTypeEnum DetailType { get; set; }
    }
}
