using CommandLine;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
            string defaultPath = null;
            var result = CommandLine.Parser.Default.ParseArguments<CmdArgumentsOptions>(args)
                   .WithParsed(o =>
                   {
                       defaultPath = o.Path;
                   });
            if (result.Tag == ParserResultType.NotParsed && args.Length > 0 &&
                args[0].ToLowerInvariant().Trim() == "--help") return;
            var f = new MainForm();
            f.SetDefaultPath(defaultPath);
            Application.Run(f);
        }
    }
}
