using System;
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
            var asm = typeof(DevExpress.UserSkins.WinterJoy).Assembly;
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
            //var mainform = new MainRibbonForm();
            //mainform.ViewModel.LoadDefaultSettings();
            //mainform.ViewModel.ApplyAppArguments(args);
            //Application.Run(mainform);
            Application.Run(new MainForm());
        }
    }
}
