using CommandLine;
using System;
using System.Windows.Forms;
using Wamby.API.Enums;

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
            string path = null;
            string filter = null;
            int? type = null;
            var result = Parser.Default.ParseArguments<CmdArgumentsOptions>(args)
                   .WithParsed(o =>
                   {
                       path = o.Path;
                       filter = o.Pattern ?? WambyApplication.Settings.DefaultSearchPattern;
                       type = o.Type;
                   });
            if (result.Tag == ParserResultType.NotParsed && args.Length > 0 &&
                args[0].ToLowerInvariant().Trim() == "--help") return;
            var f = new MainForm();
            if (path != null) f.SetPath(path);
            if (filter != null) f.SetFilter(filter);
            if (type.HasValue)
                f.SetType((ScanDetailTypeEnum)type);
            else 
                f.SetType(WambyApplication.Settings.DefaultDetailedScanType);
            Application.Run(f);
        }
    }
}
