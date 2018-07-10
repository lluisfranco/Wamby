using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Client.Model
{
    public class AppArgument
    {
        public Enums.AppArgumentsEnum Argument { get; set; }
        public string Value { get; set; }
    }
}
