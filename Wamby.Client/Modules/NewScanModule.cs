using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Wamby.Client.Modules
{
    public partial class NewScanModule : DevExpress.XtraEditors.XtraUserControl, Interfaces.IModule
    {
        public bool Initialized { get; set; }
        public NewScanModule()
        {
            InitializeComponent();            
        }

        public void InitializeControl()
        {
            newScanPathButtonEdit.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            newScanPathButtonEdit.MaskBox.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            Initialized = true;
        }

        public async Task RefreshDataAsync()
        {
            
        }
    }
}
