using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Client.Interfaces
{
    public interface IModule
    {
        bool Initialized { get; set; }
        void InitializeControl();
        Task RefreshDataAsync();
    }
}
