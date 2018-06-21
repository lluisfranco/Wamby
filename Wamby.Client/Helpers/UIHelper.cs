using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Client.Helpers
{
    public class UIHelper
    {
       public static DevExpress.Utils.SvgImageCollection GetLogImageCollection()
        {
            var imgscol = new DevExpress.Utils.SvgImageCollection();
            imgscol.Add("Errors", "Errors", typeof(Properties.Resources));
            imgscol.Add("Log_Info", "Log_Info", typeof(Properties.Resources));
            imgscol.Add("Log_Folder", "Log_Folder", typeof(Properties.Resources));
            return imgscol;
        }

        public static DevExpress.Utils.SvgImageCollection GetResultsItemTypeImageCollection()
        {
            var imgscol = new DevExpress.Utils.SvgImageCollection();
            imgscol.Add("Log_Folder", "Log_Folder", typeof(Properties.Resources));
            imgscol.Add("Files_Summary", "Files_Summary", typeof(Properties.Resources));
            return imgscol;
        }
    }
}
