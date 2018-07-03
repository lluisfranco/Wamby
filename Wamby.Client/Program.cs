using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wamby.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
            var mainform = new MainRibbonForm();
            var path = String.Join(" ", args);
            if (System.IO.Directory.Exists(path))
                mainform.ViewModel.InitialFolderPath = path;
            Application.Run(mainform);
        }
    }
}
