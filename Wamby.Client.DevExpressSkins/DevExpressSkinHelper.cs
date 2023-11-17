using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;

namespace Wamby.Client.DevExpressSkins
{
    public class DevExpressSkinHelper
    {
        public static void SetTheme(string skinname, string skinpalettename)
        {
            if (!string.IsNullOrWhiteSpace(skinname))
            {
                var category = SkinCollectionHelper.GetSkinCategory(skinname);
                if (category != SkinCategory.SVG && category != SkinCategory.Custom)
                    skinname = "WXI";
                WindowsFormsSettings.DefaultLookAndFeel.SkinName = skinname;
            }
            if (!string.IsNullOrWhiteSpace(skinpalettename))
            {
                var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
                var palette = skin.CustomSvgPalettes[skinpalettename];
                skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
                LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            }
        }

        public static void SetCompactUI(bool compactUI, BarCheckItem barCheckItemCompactUI)
        {
            barCheckItemCompactUI.Checked = compactUI;
            WindowsFormsSettings.CompactUIMode = compactUI ? DefaultBoolean.True : DefaultBoolean.False;
        }

        public static void AddDisplayAdvancedOptions(
            ToolbarFormManager manager, ToolbarFormControl control,
            bool trackWindowsAppMode = true, bool systemAccentColor = true,
            string? customAccentColor = null, string? customAccentColor2 = null)
        {
            var bciTrackWindowsAppMode = new BarCheckItem();
            var bciOriginalPalette = new BarCheckItem();
            var bciTrackWindowsAccentColor = new BarCheckItem();
            var bbiSystemAccentColor = new BarButtonItem();
            var bbiAccentCustomColor2 = new BarButtonItem();

            bciTrackWindowsAppMode.Alignment = BarItemLinkAlignment.Right;
            bciOriginalPalette.Alignment = BarItemLinkAlignment.Right;
            bciTrackWindowsAccentColor.Alignment = BarItemLinkAlignment.Right;
            bbiSystemAccentColor.Alignment = BarItemLinkAlignment.Right;
            bbiAccentCustomColor2.Alignment = BarItemLinkAlignment.Right;

            control.TitleItemLinks.Add(bbiAccentCustomColor2);
            control.TitleItemLinks.Add(bbiSystemAccentColor);
            control.TitleItemLinks.Add(bciTrackWindowsAccentColor);
            control.TitleItemLinks.Add(bciOriginalPalette);
            control.TitleItemLinks.Add(bciTrackWindowsAppMode);

            SkinHelper.InitTrackWindowsAppMode(bciTrackWindowsAppMode);
            SkinHelper.InitResetToOriginalPalette(bciOriginalPalette);
            SkinHelper.InitTrackWindowsAccentColor(bciTrackWindowsAccentColor);
            SkinHelper.InitCustomAccentColor(manager, bbiSystemAccentColor);
            SkinHelper.InitCustomAccentColor2(manager, bbiAccentCustomColor2);

            if (trackWindowsAppMode)
            {
                WindowsFormsSettings.TrackWindowsAppMode = DefaultBoolean.True;
                bciTrackWindowsAppMode.Checked = true;
            }
            else
            {
                WindowsFormsSettings.TrackWindowsAppMode = DefaultBoolean.False;
                bciTrackWindowsAppMode.Checked = false;
            }
            if (systemAccentColor)
            {
                WindowsFormsSettings.TrackWindowsAccentColor = DefaultBoolean.True;
                bciTrackWindowsAccentColor.Checked = true;
            }
            else
            {
                WindowsFormsSettings.TrackWindowsAccentColor = DefaultBoolean.False;
                bciTrackWindowsAccentColor.Checked = false;
            }
            if (customAccentColor != null)
            {
                var accentcolor = ColorTranslator.FromHtml(customAccentColor);
                if (accentcolor.R != 0 && accentcolor.G != 0 && accentcolor.B != 0)
                    WindowsFormsSettings.SetAccentColor(accentcolor);
            }
            if (customAccentColor2 != null)
            {
                var accentcolor2 = ColorTranslator.FromHtml(customAccentColor2);
                if (accentcolor2.R != 0 && accentcolor2.G != 0 && accentcolor2.B != 0)
                    WindowsFormsSettings.SetAccentColor2(accentcolor2);
            }
        }

        public static void RemoveSkinGroups(SkinDropDownButtonItem skinDropDownButtonItem, string[]? skinGroupsToRemove = null)
        {
            string[] defaultSkinGroupsToRemove = { 
                "Default", "Latest Office skins", "Visual Studio", "Previous Office skins", "Thematic" };
            skinGroupsToRemove ??= defaultSkinGroupsToRemove;
            foreach (var item in skinGroupsToRemove)
            {
                var group = skinDropDownButtonItem.DropDownGallery.Gallery.Groups.OfType<GalleryItemGroup>().
                    First(x => string.Equals(x.Caption, item));
                skinDropDownButtonItem.DropDownGallery.Gallery.Groups.Remove(group);
            }
        }

        public static void RemoveSkins(SkinDropDownButtonItem skinDropDownButtonItem, string[]? skinsToRemove = null)
        {
            string[] defaultSkinsToRemove = { 
                "WXI Compact" };
            skinsToRemove ??= defaultSkinsToRemove;
            var allItems = skinDropDownButtonItem.DropDownGallery.Gallery.GetAllItems();
            foreach (GalleryItem item in allItems)
            {
                if (skinsToRemove.Contains(item.Caption)) item.Visible = false;
            }
        }
    }
}