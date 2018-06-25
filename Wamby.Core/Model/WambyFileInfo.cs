using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Core.Model
{
    public class WambyFileInfo : WambyFileSystemItem
    {
        public string Extension { get; set; }
        public System.IO.FileInfo FileInfo { get; set; }
        public string ParentFullName { get; set; }
    }
}
