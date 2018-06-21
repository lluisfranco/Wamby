﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wamby.Core.Model
{
    public class FolderInfo 
    {
        public string FullName { get; set; }
        public string ParentFullName { get; set; }
        public int Level { get; set; }
        public bool IsFolder { get; set; }
        public System.IO.DirectoryInfo DirectoryInfo { get; set; }
        public List<FolderInfo> Folders { get; set; } = new List<FolderInfo>();
        public List<System.IO.FileInfo> Files { get; set; } = new List<System.IO.FileInfo>();
        public List<FolderInfo> AllFolders { get; set; } = new List<FolderInfo>();
        public double Length { get; set; }
        public double FilesCount { get; set; }
        public double DeepLength { get; set; }
        public double DeepFilesCount { get; set; }
        public double DeepLengthInKB { get { return DeepLength / 1024; } }
    }
}
