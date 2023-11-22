using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Wamby.Core.Model;

namespace Wamby.Client.Helpers
{
    public class UIHelper
    {
        public static SvgImageCollection GetLogImageCollection()
        {
            return new SvgImageCollection
            {
                { "Log_Info", "image://svgimages/outlook%20inspired/about.svg" },
                { "Log_Folder", "image://svgimages/icon%20builder/actions_folderclose.svg" },
                { "Errors", "image://svgimages/icon%20builder/actions_deletecircled.svg" }
            };
        }
        
        public static RepositoryItemImageComboBox GetLogTypesCombo()
        {
            var imgscol = GetLogImageCollection();
            var combo = new RepositoryItemImageComboBox() { SmallImages = imgscol };
            combo.Items.Add(new ImageComboBoxItem()
            {
                Value = LogLineTypeEnum.Info,
                Description = LogLineTypeEnum.Info.ToString(),
                ImageIndex = 0
            });
            combo.Items.Add(new ImageComboBoxItem()
            {
                Value = LogLineTypeEnum.ReadingFolder,
                Description = LogLineTypeEnum.ReadingFolder.ToString(),
                ImageIndex = 1
            });
            combo.Items.Add(new ImageComboBoxItem()
            {
                Value = LogLineTypeEnum.Error,
                Description = LogLineTypeEnum.Error.ToString(),
                ImageIndex = 2
            });
            return combo;
        }

        public static SvgImageCollection GetResultsItemTypeImageCollection()
        {
            return new SvgImageCollection
            {
                { "Log_Folder", "image://svgimages/icon%20builder/actions_folderclose.svg" },
                { "Log_File", "image://svgimages/spreadsheet/multipledocuments.svg" }
            };
        }
    }
}
