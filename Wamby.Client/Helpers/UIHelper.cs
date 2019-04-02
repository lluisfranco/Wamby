using DevExpress.XtraEditors.Repository;
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
            //imgscol.Add("Log_Info", "Log_Info", typeof(Properties.Resources.));
            //imgscol.Add("Log_Folder", "Log_Folder", typeof(Properties.Resources));
            //imgscol.Add("Errors", "Errors", typeof(Properties.Resources));
            return imgscol;
        }

        public static RepositoryItemImageComboBox GetLogTypesCombo()
        {
            var imgscol = GetLogImageCollection();
            var combo = new RepositoryItemImageComboBox() { SmallImages = imgscol };
            combo.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem()
            {
                Value = Core.Model.LogLineTypeEnum.Info,
                Description = Core.Model.LogLineTypeEnum.Info.ToString(),
                ImageIndex = 0
            });
            combo.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem()
            {
                Value = Core.Model.LogLineTypeEnum.ReadingFolder,
                Description = Core.Model.LogLineTypeEnum.ReadingFolder.ToString(),
                ImageIndex = 1
            });
            combo.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem()
            {
                Value = Core.Model.LogLineTypeEnum.Error,
                Description = Core.Model.LogLineTypeEnum.Error.ToString(),
                ImageIndex = 2
            });
            return combo;
        }

        public static DevExpress.Utils.SvgImageCollection GetResultsItemTypeImageCollection()
        {
            var imgscol = new DevExpress.Utils.SvgImageCollection();
            //imgscol.Add("Log_Folder", "Log_Folder", typeof(Properties.Resources));
            //imgscol.Add("Files_Summary", "Files_Summary", typeof(Properties.Resources));
            return imgscol;
        }
    }
}
