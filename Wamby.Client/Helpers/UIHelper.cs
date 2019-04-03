using DevExpress.Utils.Svg;
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
            var keys = DevExpress.Images.ImageResourceCache.Default.GetAllResourceKeys();
            imgscol.Add("Log_Info",
                GetSvgImageFromLibrary("svgimages/outlook%20inspired/about.svg"));
            imgscol.Add("Log_Folder",
                GetSvgImageFromLibrary("svgimages/icon%20builder/actions_folderclose.svg"));
            imgscol.Add("Errors",
                GetSvgImageFromLibrary("svgimages/icon%20builder/actions_deletecircled.svg"));
            return imgscol;
        }

        private static DevExpress.Utils.Svg.SvgImage GetSvgImageFromLibrary(string key)
        {
            var stream = DevExpress.Images.ImageResourceCache.Default.GetResource(key);
            using (stream)
            {
                return stream != null ? SvgImage.FromStream(stream) : null;
            }
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
            imgscol.Add("Log_Folder",
                GetSvgImageFromLibrary("svgimages/business%20objects/bo_folder.svg"));
            imgscol.Add("Log_Folder",
                GetSvgImageFromLibrary("svgimages/spreadsheet/multipledocuments.svg"));
            return imgscol;
        }
    }
}
