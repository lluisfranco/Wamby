using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Client.Helpers
{
    public class AppArgumentHelper
    {
        public static List<Model.AppArgument> ParseArguments(string[] args)
        {
            var argumentsList = new List<Model.AppArgument>();
            string separator = Properties.Settings.Default.AppArgumentsSeparator;
            string partsseparator = Properties.Settings.Default.AppArgumentPartsSeparator;
            var flatarguments = String.Join(" ", args);
            var arguments = flatarguments.Split(separator.ToCharArray());
            foreach (var a in arguments)
            {
                if (!string.IsNullOrWhiteSpace(a))
                {
                    var parts = a.Split(partsseparator.ToCharArray());
                    if (parts.Length > 1)
                        argumentsList.Add(new Model.AppArgument()
                        {
                            Argument = GetEnum(parts[0].Trim()),
                            Value = parts[1].Trim()
                        });
                }
            }
            return argumentsList;
        }

        public static Enums.AppArgumentsEnum GetEnum(string enumName)
        {
            return (Enums.AppArgumentsEnum)System.Enum.Parse(typeof(Enums.AppArgumentsEnum), enumName); ;
        }

        public static T GetEnum<T>(string enumName)
        {
            return (T)System.Enum.Parse(typeof(T), enumName); ;
        }
    }
}
