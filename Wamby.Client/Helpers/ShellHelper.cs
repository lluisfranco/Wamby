using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Wamby.SystemShell;

namespace Wamby.Client.Helpers
{
    public class ShellHelper
    {
        public static void Open(string filename)
        {
            try
            {
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void OpenWamby(string arguments)
        {
            try
            {
                Process.Start(Application.ExecutablePath, arguments);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void OpenTerminal(string path)
        {
            try
            {
                var processStartInfo = new ProcessStartInfo();
                processStartInfo.WorkingDirectory = path;
                processStartInfo.FileName = "cmd.exe";
                var proc = Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void ShowFileSystemItemProperties(string path)
        {
            try
            {
                SystemShell.ShellFileOperation.ShowFileProperties(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }   

        public static bool DeleteFileSystemItemProperties(Form owner, string path)
        {
            try
            {
                var fo = new ShellFileOperation();
                fo.Operation = ShellFileOperation.FileOperations.FO_DELETE;
                fo.OwnerWindow = owner.Handle;
                fo.SourceFiles = new string[] { path };
                return fo.DoOperation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }   
    }
}
