using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using System.Reflection;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;
using Wamby.Client.DevExpressSkins;
using Wamby.Client.ViewModels;

namespace Wamby.Client
{
    public partial class MainForm : ToolbarForm
    {
        public MainFormViewModel ViewModel { get; set; } = new MainFormViewModel();
        public MainForm()
        {
            InitializeComponent();
            Text = string.Format($"{Application.ProductName} - " +
                $"{Assembly.GetExecutingAssembly().GetName().Version}");
            Shown += (s, e) =>
            {
                var settings = Properties.Settings.Default;
                DevExpressSkinHelper.SetTheme(settings.SkinName, settings.SkinPalette);
                DevExpressSkinHelper.SetCompactUI(settings.UseCompactUI, barCheckItemCompactUI);
                DevExpressSkinHelper.AddDisplayAdvancedOptions(
                    toolbarFormManager, toolbarFormControl,
                    settings.SkinAdvancedUseWindowsAppMode, settings.SkinAdvancedSystemAccentColor,
                    settings.SkinAdvancedCustomColor, settings.SkinAdvancedCustomColor2);
                DevExpressSkinHelper.RemoveSkinGroups(skinDropDownButtonItem);
                DevExpressSkinHelper.RemoveSkins(skinDropDownButtonItem);
            };
            FormClosed += (s, e) =>
            {
                MainFormViewModel.SaveSkin();
            };
            barCheckItemCompactUI.ItemClick += (s, e) =>
            {
                WindowsFormsSettings.CompactUIMode = barCheckItemCompactUI.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            };
            toolbarFormManager.Merge += (s, e) =>
            {
                
            };
            barButtonItemNewScan.ItemClick += (s, e) =>
            {
                var f = new NewScanForm();
                f.MdiParent = this;
                f.Show();
            };
        }

        public void MergeTB(ToolbarFormControl c)
        {
            toolbarFormControl.MergeToolbar(c);
        }
    }
}