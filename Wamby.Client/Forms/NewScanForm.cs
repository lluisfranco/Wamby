using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wamby.Client
{
    public partial class NewScanForm : ToolbarForm
    {
        public NewScanForm()
        {
            InitializeComponent();
            barButtonItem1.ItemClick += (s, e) =>
            {
                var f = MdiParent as MainForm;
                f.MergeTB(toolbarFormControl1);
            };  
        }
    }
}