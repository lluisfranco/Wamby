﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;
using Wamby.API.Enums;
using Wamby.API.Services;

namespace Wamby.Client
{
    public class MainFormViewModel
    {
        public MainForm Form { get; }
        public FileSystemScanService FileSystemScanService { get; private set; }
        public FileSystemStorageService FileSystemStorageService { get; private set; }
        public MainFormViewModel(MainForm form)
        {
            Form = form;
            FileSystemScanService = new FileSystemScanService()
            {
                UserName = WindowsIdentity.GetCurrent().Name,
                ComputerName = Environment.MachineName,
                OSVersionName = Environment.OSVersion.ToString(),
                ScanDate = DateTime.Now,
                DetailType = ScanDetailTypeEnum.Fast
            };
            FileSystemStorageService = new FileSystemStorageService();
        }

        public static void SaveSkin()
        {
            var settings = Properties.Settings.Default;
            settings.SkinName = WindowsFormsSettings.DefaultLookAndFeel.SkinName;
            settings.SkinPalette = WindowsFormsSettings.DefaultLookAndFeel.ActiveSvgPaletteName;
            settings.SkinAdvancedUseWindowsAppMode = ToBoolean(WindowsFormsSettings.TrackWindowsAppMode);
            settings.SkinAdvancedSystemAccentColor = ToBoolean(WindowsFormsSettings.TrackWindowsAccentColor);
            settings.SkinAdvancedCustomColor = ToHex(WindowsFormsSettings.GetAccentColor());
            settings.SkinAdvancedCustomColor2 = ToHex(WindowsFormsSettings.GetAccentColor2());
            settings.UseCompactUI = ToBoolean(WindowsFormsSettings.CompactUIMode);
            settings.Save();
        }

        private static bool ToBoolean(DefaultBoolean value) => 
            value == DefaultBoolean.True;
        private static string ToHex(Color c) =>
            "#FF" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");

        internal void NewScan()
        {
            var f = new NewScanForm();
            f.MdiParent = Form as Form;
            f.InitializeControl(Form, FileSystemScanService);
            f.Show();
        }
    }
}