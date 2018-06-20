using DevExpress.XtraSplashScreen;
using System.Windows.Forms;

namespace Wamby.Client.Extensions
{
    public static class OverlayExtensions
    {

        public static IOverlaySplashScreenHandle ShowProgressPanel(Control control)
        {
            return SplashScreenManager.ShowOverlayForm(control);
        }

        public static void CloseProgressPanel(IOverlaySplashScreenHandle handle)
        {
            if (handle != null) SplashScreenManager.CloseOverlayForm(handle);
        }
    }
}
