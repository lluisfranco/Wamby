using System;
using System.Linq;
using System.Windows.Forms;

namespace Wamby.Client.Helpers
{
    public class ShellHelper
    {
        public static void Open(string filename)
        {
            System.Diagnostics.Process.Start(filename);
        }

        //public static void Open(string filename, string arguments)
        //{
        //    System.Diagnostics.Process.Start(filename, arguments);
        //}

        public static void OpenWamby(string arguments)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath, arguments);
        }

        public static void OpenTerminal(string filename)
        {
            System.Diagnostics.Process.Start(filename);
        }
    }
}
