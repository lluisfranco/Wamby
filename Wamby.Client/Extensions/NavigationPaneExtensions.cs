using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wamby.Client.Interfaces;

namespace Wamby.Client
{
    public static class NavigationPaneExtensions
    {
        public static IModule GetCurrentModule(this NavigationPane navigationPane) =>
            navigationPane.SelectedPage != null && navigationPane.SelectedPage.Controls.Count > 0
            ? navigationPane.SelectedPage.Controls[0] as IModule : default;

        public static IEnumerable<IModule> GetModules(this NavigationPane navigationPane) =>
            navigationPane.Pages.Where(p => p.Controls.Count > 0 && p.Controls[0] is IModule).Select(p => p.Controls[0] as IModule);

        public static IModule GetPageModule(this NavigationPage navigationPage) =>
            navigationPage != null && navigationPage.Controls.Count > 0
            ? navigationPage.Controls[0] as IModule : default;

        public static void InitializeModule(this NavigationPage navigationPage, 
            XtraUserControl module, IProgressMessage progress, string progressMessage, int progressValue)
        {
            progress?.SetMessage($"Loading {progressMessage} module").SetProgress(progressValue);
            Application.DoEvents();
            navigationPage.SuspendLayout();
            module.Dock = DockStyle.Fill;
            module.Name = "newScanModule";
            navigationPage.Controls.Add(module);
            navigationPage.ResumeLayout();
        }

        public static NavigationPane AddTabMergeModulesRibbonSupport(
            this NavigationPane tabPane, Func<Task> method = null, bool autoRefresh = false)
        {
            tabPane.RibbonAndBarsMergeStyle = RibbonAndBarsMergeStyle.Always;
            tabPane.AllowHtmlDraw = true;
            tabPane.PageProperties.ShowCollapseButton = false;
            tabPane.PageProperties.ShowExpandButton = false;
            tabPane.StateChanging += (s, e) => e.Cancel = true;
            return tabPane;
        }

    }
}
