using System;
using System.Linq;

namespace Wamby.Client.Interfaces
{
    public interface IModulePrintAndExport
    {
        void Print();
        void ExportToXls();
        void ExportToPdf();
    }
}
