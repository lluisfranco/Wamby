﻿using System;
using System.Windows.Forms;
using Wamby.API.Services;

namespace Wamby.Client
{
    public partial class MainRibbonForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ViewModels.MainFormViewModel ViewModel { get; set; }
        public MainRibbonForm()
        {
            InitializeComponent();
            tabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            Text = Application.ProductName;
            Icon = Properties.Resources.Wamby_App_Icon;
            var scanService = new FileSystemScanService()
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                ComputerName = Environment.MachineName,
                OSVersionName = Environment.OSVersion.ToString(),
                ScanDate = DateTime.Now
            };
            var storageService = new FileSystemStorageService(scanService);
            ViewModel = new ViewModels.MainFormViewModel(scanService, storageService);
            SetEventHandlers();
        }

        private void SetEventHandlers()
        {
            Shown += MainForm_Shown;
            showNewScanModule.Click += ShowNewScanModule_Click;
            showResultsModule.Click += ShowResultsModule_Click;
            showFilesModule.Click += ShowFilesModule_Click;
            showMapModule.Click += ShowMapModule_Click;
            showAnalyzeModule.Click += ShowAnalyzeModule_Click;
            showErrorsModule.Click += ShowErrorsModule_Click;
            showScheduleModule.Click += ShowScheduleModule_Click;
            showSettingsModule.Click += ShowSettingsModule_Click;
            newAppBarButtonItem.ItemClick += NewAppBarButtonItem_ItemClick;
            newScanModule.StartingScan += NewScanModule_StartingScan;
            newScanModule.EndingScan += NewScanModule_EndingScan;
            tabControl.SelectedPageChanged += TabControl_SelectedPageChanged;
            barButtonItemPrint.ItemClick += BarButtonItemPrint_ItemClick;
            barButtonItemExportXls.ItemClick += BarButtonItemExportXls_ItemClick;
            barButtonItemExportPdf.ItemClick += BarButtonItemExportPdf_ItemClick;
            newScanModule.GotoTabButtonClicked += NewScanModule_GotoTabButtonClicked;
            barButtonItemSave.ItemClick += BarButtonItemSave_ItemClick;
            barButtonItemOpen.ItemClick += BarButtonItemOpen_ItemClick;
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            ViewModel.LoadDefaultSettings();
            newScanModule.InitialFolderPath = ViewModel.InitialFolderPath;
            InitializeModules();
            ViewModel.CurrentModule = newScanModule;
            ShowCurrentModuleToolbars();
            if (ViewModel.InitialFolderPath != null) await newScanModule.DoScan();
        }

        private void InitializeModules()
        {
            newScanModule.InitializeControl(ViewModel.FileSystemScanService);
            resultsModule.InitializeControl(ViewModel.FileSystemScanService);
            filesModule.InitializeControl(ViewModel.FileSystemScanService);
            mapModule.InitializeControl(ViewModel.FileSystemScanService);
            analysisModule.InitializeControl(ViewModel.FileSystemScanService);
            errorsModule.InitializeControl(ViewModel.FileSystemScanService);
        }

        private void NewScanModule_StartingScan(object sender, EventArgs e)
        {
            EnablePages(false);
        }

        private void NewScanModule_EndingScan(object sender, EventArgs e)
        {
            EnablePages(true);
            RefreshModulesData();
        }

        private void RefreshModulesData()
        {
            resultsModule.RefreshModuleData();
            filesModule.RefreshModuleData();
            mapModule.RefreshModuleData();
            analysisModule.RefreshModuleData();
            errorsModule.RefreshModuleData();
        }

        private void EnablePages(bool enabled)
        {
            foreach (DevExpress.XtraTab.XtraTabPage tab in tabControl.TabPages)
                if (tab.Text != "New Scan") tab.PageEnabled = enabled;
        }

        private void NewAppBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewWamby();
        }

        private void OpenNewWamby()
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void TabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            SetCurrentModule(e.Page.Name);
            ShowCurrentModuleToolbars();
        }

        private void SetCurrentModule(string moduleName)
        {
            if (moduleName == tabPageNewScan.Name) ViewModel.CurrentModule = newScanModule;
            if (moduleName == tabPageResults.Name) ViewModel.CurrentModule = resultsModule;
            if (moduleName == tabPageFiles.Name) ViewModel.CurrentModule = filesModule;
            if (moduleName == tabPageMap.Name) ViewModel.CurrentModule = mapModule;
            if (moduleName == tabPageAnalysis.Name) ViewModel.CurrentModule = analysisModule;
            if (moduleName == tabPageErrors.Name) ViewModel.CurrentModule = errorsModule;
        }

        private void ShowCurrentModuleToolbars()
        {
            ribbonPageGroupPrint.Visible = false;
            if (ViewModel.CurrentModule is Interfaces.IModulePrintAndExport) ribbonPageGroupPrint.Visible = true;
            ribbon.UnMergeRibbon();
            if (ViewModel.CurrentModule is Interfaces.IModuleRibbon)
                ribbon.MergeRibbon((ViewModel.CurrentModule as Interfaces.IModuleRibbon).Ribbon);
        }

        private void NewScanModule_GotoTabButtonClicked(object sender, Args.GotoTabButtonEventArgs e)
        {
            if (e.TabName == tabPageResults.Name) tabControl.SelectedTabPage = tabPageResults;
            if (e.TabName == tabPageFiles.Name) tabControl.SelectedTabPage = tabPageFiles;
            if (e.TabName == tabPageMap.Name) tabControl.SelectedTabPage = tabPageMap;
            if (e.TabName == tabPageAnalysis.Name) tabControl.SelectedTabPage = tabPageAnalysis;
            if (e.TabName == tabPageErrors.Name) tabControl.SelectedTabPage = tabPageErrors;
        }

        private void ShowNewScanModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageNewScan;
        }

        private void ShowResultsModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageResults;
        }

        private void ShowFilesModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageFiles;
        }

        private void ShowMapModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageMap;
        }

        private void ShowAnalyzeModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageAnalysis;
        }

        private void ShowErrorsModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageErrors;
        }

        private void ShowScheduleModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageSchedule;
        }

        private void ShowSettingsModule_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabPageSettings;
        }

        private void BarButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModulePrintAndExport)?.Print();
        }

        private void BarButtonItemExportXls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModulePrintAndExport)?.ExportToXls();
        }

        private void BarButtonItemExportPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (ViewModel.CurrentModule as Interfaces.IModulePrintAndExport)?.ExportToPdf();
        }

        private async void BarButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sd = new SaveFileDialog();
            sd.Filter = "Text files (*.txt)|*.txt";
            try
            {
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.AppStarting;
                    await ViewModel.SaveScan(sd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void BarButtonItemOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sd = new OpenFileDialog();
            sd.Filter = "Text files (*.txt)|*.txt";
            try
            {
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.AppStarting;
                    await ViewModel.OpenScan(sd.FileName);
                    InitializeModules();
                    RefreshModulesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

    }
}