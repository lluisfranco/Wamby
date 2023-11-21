using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Wamby.Client.DevExpressSkins;
using Wamby.Client.Interfaces;

namespace Wamby.Client
{
    public partial class MainForm : ToolbarForm, IProgressMessage
    {
        public MainFormViewModel ViewModel { get; set; }
        public IProgressMessage SetMessage(string message) {
            barStaticItemMessage.Caption = message; return this; }
        public IProgressMessage ClearMessage() {
            barStaticItemMessage.Caption = "Ready"; return this; }
        public IProgressMessage SetMessageLastScan(string message) {
            barStaticItemMessageLastScan.Caption = message; return this; }        
        public IProgressMessage ClearMessageLastScan() {
            barStaticItemMessageLastScan.Caption = "Ready"; return this; }
        public IProgressMessage SetProgress(int value) { 
            barEditItemProgress.EditValue = value; barEditItemProgress.Visibility = BarItemVisibility.Always; return this; }
        public IProgressMessage ClearProgress() { 
            barEditItemProgress.EditValue = 0; barEditItemProgress.Visibility = BarItemVisibility.Never; return this; }
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new MainFormViewModel(this);
            IconOptions.SvgImage = svgImageCollectionForm[0];
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
                var form = e.ChildManager.Form as IChildForm;
                var bar = form?.Bar;
                var items = bar?.ItemLinks;
                toolbarFormControl.TitleItemLinks.Merge(items);
            };
            toolbarFormManager.UnMerge += (s, e) =>
            {
                toolbarFormControl.TitleItemLinks.UnMerge();
            };
            tabbedView.DocumentAdded += (s, e) => e.Document.ImageOptions.SvgImageSize = new Size(16, 16);
            barButtonItemNewScan.ItemClick += (s, e) =>
            {
                ViewModel.NewScan();
            };
        }
    }
}