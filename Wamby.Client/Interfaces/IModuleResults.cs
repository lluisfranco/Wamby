using System;
using System.Linq;

namespace Wamby.Client.Interfaces
{
    public interface IModuleResults
    {
        void ExpandTree();
        void ExpandTreeToLevel(int level);
        void CollapseTree();
    }
}
