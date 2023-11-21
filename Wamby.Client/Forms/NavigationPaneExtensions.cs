using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wamby.Client.Interfaces;

namespace Wamby.Client.Forms
{
    public static class NavigationPaneExtensions
    {
        public static IModule GetCurrentModule(this NavigationPane navigationPane) =>
            navigationPane.SelectedPage != null && navigationPane.SelectedPage.Controls.Count > 0
            ? navigationPane.SelectedPage.Controls[0] as IModule : default;

        public static IEnumerable<IModule> GetModules(this NavigationPane navigationPane) =>
            navigationPane.Pages.Where(p => p.Controls.Count > 0 && p.Controls[0] is IModule).Select(p => p.Controls[0] as IModule);

        public static NavigationPane AddTabMergeModulesRibbonSupport(
            this NavigationPane tabPane, Func<Task> method = null, bool autoRefresh = false)
        {
            tabPane.RibbonAndBarsMergeStyle = RibbonAndBarsMergeStyle.Always;
            tabPane.AllowHtmlDraw = true;
            tabPane.PageProperties.ShowCollapseButton = false;
            tabPane.PageProperties.ShowExpandButton = false;
            tabPane.StateChanging += (s, e) => e.Cancel = true;
            tabPane.SelectedPageChanged += (s, e) =>
            {
                var module = tabPane.GetCurrentModule();
                if (tabPane.FindForm() is not IChildForm form ||
                    tabPane.FindForm().ParentForm is not IChildForm parentForm) return;
                if (module == null) return;
                parentForm.Bar.UnMerge();
                parentForm.Bar.Merge(form.Bar);
                //if (autoRefresh || !module.Loaded) method?.Invoke();
                if (autoRefresh) method?.Invoke();
            };
            return tabPane;
        }

    }
}
