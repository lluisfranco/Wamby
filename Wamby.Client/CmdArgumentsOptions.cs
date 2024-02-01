using CommandLine;

namespace Wamby.Client
{
    public class CmdArgumentsOptions
    {
        [Option('p', "path", Required = false,
            HelpText = "Path to scan")]
        public string Path { get; set; } = null;

        [Option('f', "filter", Required = false,
            HelpText = "Pattern Filter, like *.*")]
        public string Pattern { get; set; } = null;

        [Option('t', "type", Required = false,
            HelpText = "Type (Detailed = 0, Fast = 1)")]
        public int? Type { get; set; } = null;

        public static bool IsSystemCommand(string[] args)
        {
            if (args.Length > 0 && (
                args[0].ToLowerInvariant().Trim() == "--help" ||
                args[0].ToLowerInvariant().Trim() == "--version")) return true;
            return false;
        }
    }

}
