using System;
using System.Linq;

namespace Wamby.Client.Interfaces
{
    public interface IModuleMap
    {
        void SetMapByDataMember(Enums.MapValueDataMemberEnum member);
        void SetLayoutAlgorithm(Enums.MapLayoutAlgorithmEnum layoutAlgorithm);
        void SetLayoutAlgorithmDirection(DevExpress.XtraTreeMap.TreeMapLayoutDirection layoutAlgorithmDirection);
    }
    }
