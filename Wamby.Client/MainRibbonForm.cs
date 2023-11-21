using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using System;
using System.Reflection;
using System.Windows.Forms;
using Wamby.API.Services;
using Wamby.Client.Extensions;

namespace Wamby.Client
{
    public partial class MainRibbonForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ViewModels.MainFormViewModel ViewModel { get; set; }
        DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle handle = null;

        public MainRibbonForm()
        {
            InitializeComponent();
            tabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            Text = string.Format($"{Application.ProductName} - " +
                $"{Assembly.GetExecutingAssembly().GetName().Version}");
            var scanService = new FileSystemScanService()
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                ComputerName = Environment.MachineName,
                OSVersionName = Environment.OSVersion.ToString(),
                ScanDate = DateTime.Now,
                DetailType = API.Enums.ScanDetailTypeEnum.Fast
            };
            var storageService = new FileSystemStorageService();
            ViewModel = new ViewModels.MainFormViewModel(scanService, storageService);
            SetEventHandlers();
            LoadSkin();
        }

        private void SetEventHandlers()
        {
            Shown += MainForm_Shown;
            FormClosed += MainRibbonForm_FormClosed;
            showNewScanModule.Click += ShowNewScanModule_Click;
            showResultsModule.Click += ShowResultsModule_Click;
            showFilesModule.Click += ShowFilesModule_Click;
            showMapModule.Click += ShowMapModule_Click;
            showAnalyzeModule.Click += ShowAnalyzeModule_Click;
            showErrorsModule.Click += ShowErrorsModule_Click;
            showScheduleModule.Click += ShowScheduleModule_Click;
            showSettingsModule.Click += ShowSettingsModule_Click;
            newAppBarButtonItem.ItemClick += NewAppBarButtonItem_ItemClick;
            tabControl.SelectedPageChanged += TabControl_SelectedPageChanged;
            barButtonItemPrint.ItemClick += BarButtonItemPrint_ItemClick;
            barButtonItemExportXls.ItemClick += BarButtonItemExportXls_ItemClick;
            barButtonItemExportPdf.ItemClick += BarButtonItemExportPdf_ItemClick;
            barButtonItemSave.ItemClick += BarButtonItemSave_ItemClick;
            barButtonItemOpen.ItemClick += BarButtonItemOpen_ItemClick;
            barButtonItemDoScan.ItemClick += BarButtonItemDoScan_ItemClick;
            barButtonItemCancelScan.ItemClick += BarButtonItemCancelScan_ItemClick;
            barButtonItemGoToResultsModule.ItemClick += BarButtonItemGoToResultsModule_ItemClick;
            barButtonItemGoToErrorsModule.ItemClick += BarButtonItemGoToErrorsModule_ItemClick;
            //newScanModule.StartingScan += NewScanModule_StartingScan;
            //newScanModule.EndingScan += NewScanModule_EndingScan;
            newScanModule.RequestNewScan += NewScanModule_RequestNewScan;
            resultsModule.RequestNewScan += ResultsModule_RequestNewScan;
            filesModule.RequestNewScan += FilesModule_RequestNewScan;
        }

        private void MainRibbonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSkin();
        }

        private void LoadSkin()
        {
            WindowsFormsSettings.DefaultLookAndFeel.SkinName = Properties.Settings.Default.SkinName;
            var paletteName = Properties.Settings.Default.SkinPalette;
            if (!string.IsNullOrWhiteSpace(paletteName))
            {
                var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
                DevExpress.Utils.Svg.SvgPalette palette = skin.CustomSvgPalettes[paletteName];
                skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
                LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            }
        }

        private void SaveSkin()
        {
            Properties.Settings.Default.SkinName = WindowsFormsSettings.DefaultLookAndFeel.SkinName;
            Properties.Settings.Default.SkinPalette = WindowsFormsSettings.DefaultLookAndFeel.ActiveSvgPaletteName;
            Properties.Settings.Default.Save();
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                InitializeModules();
                ViewModel.CurrentModule = newScanModule;
                ShowCurrentModuleToolbars();
                if (ViewModel.AutoStartScan) await newScanModule.DoScan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeModules()
        {
            //newScanModule?.InitializeControl(ViewModel.FileSystemScanService);
            //resultsModule?.InitializeControl(ViewModel.FileSystemScanService);
            //filesModule?.InitializeControl(ViewModel.FileSystemScanService);
            //mapModule?.InitializeControl(ViewModel.FileSystemScanService);
            //analysisModule?.InitializeControl(ViewModel.FileSystemScanService);
            //errorsModule?.InitializeControl(ViewModel.FileSystemScanService);
        }

        private async void BarButtonItemDoScan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await newScanModule.DoScan();
        }

        private void BarButtonItemCancelScan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            newScanModule.CancelScan();
        }

        private void BarButtonItemGoToResultsModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GotoTab(tabPageResults.Name);
        }

        private void BarButtonItemGoToErrorsModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GotoTab(tabPageErrors.Name);
        }

        private void NewScanModule_StartingScan(object sender, EventArgs e)
        {
            handle = OverlayFormExtensions.ShowProgressPanel(tabControl);
            barStaticItemStatusMessage.Caption = "Scaning...";
            EnablePages(false);
        }

        private async void NewScanModule_EndingScan(object sender, EventArgs e)
        {
            EnablePages(true);
            if (!ViewModel.FileSystemScanService.Cancelled) RefreshModulesData();
            if (handle != null) OverlayFormExtensions.CloseProgressPanel(handle);
            barStaticItemStatusMessage.Caption = "Ready";
            UpdateResults();
            if (ViewModel.SaveToFile) await ViewModel.SaveScanToFile();
            if (ViewModel.CloseOnFinish) this.Close();
        }

        private void UpdateResults()
        {
            var resultsSummary =
                $"{ViewModel.FileSystemScanService.ScanResult.WambyFolderInfo.DeepLengthInKB.ToString("n0")} KB in " +
                $"{ViewModel.FileSystemScanService.ScanResult.AllFolders.Count.ToString("n0")} folders and " +
                $"{ViewModel.FileSystemScanService.ScanResult.WambyFolderInfo.DeepFilesCount.ToString("n0")} files";
            var errorsSummary =
                ViewModel.FileSystemScanService.ScanResult.ScanExceptions.Count == 0 ?
                "No errors" :
                $"Check {ViewModel.FileSystemScanService.ScanResult.ScanExceptions.Count} errors";
            barButtonItemGoToErrorsModule.Visibility = ViewModel.FileSystemScanService.ScanResult.ScanExceptions.Count != 0 ?
                 DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            barButtonItemGoToResultsModule.Caption = resultsSummary;
            barButtonItemGoToErrorsModule.Caption = errorsSummary;

        }

        private void RefreshModulesData()
        {
            newScanModule.RefreshModuleData();
            resultsModule.RefreshModuleData();
            filesModule.RefreshModuleData();
            mapModule.RefreshModuleData();
            analysisModule.RefreshModuleData();
            errorsModule.RefreshModuleData();
        }

        private void EnablePages(bool enabled)
        {
            barButtonItemOpen.Enabled = enabled;
            barButtonItemSave.Enabled = enabled;
            barButtonItemDoScan.Visibility = enabled ?
                DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            barButtonItemCancelScan.Visibility = enabled ?
                DevExpress.XtraBars.BarItemVisibility.Never : DevExpress.XtraBars.BarItemVisibility.Always;
            barButtonItemGoToResultsModule.Visibility = enabled ?
                DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            barButtonItemGoToErrorsModule.Visibility = enabled ?
                DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void NewAppBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewWamby();
        }

        private void OpenNewWamby()
        {
            Helpers.ShellHelper.OpenWamby(null);
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
            (ViewModel.CurrentModule as Interfaces.IModule)?.SetFocus();
        }

        private void ShowCurrentModuleToolbars()
        {
            ribbonPageGroupPrint.Visible = false;
            if (ViewModel.CurrentModule is Interfaces.IModulePrintAndExport) ribbonPageGroupPrint.Visible = true;
            ribbon.UnMergeRibbon();
            if (ViewModel.CurrentModule is Interfaces.IModuleRibbon)
                ribbon.MergeRibbon((ViewModel.CurrentModule as Interfaces.IModuleRibbon).Ribbon);
        }

        private void GotoTab(string tabName)
        {
            if (tabName == tabPageResults.Name) tabControl.SelectedTabPage = tabPageResults;
            if (tabName == tabPageFiles.Name) tabControl.SelectedTabPage = tabPageFiles;
            if (tabName == tabPageMap.Name) tabControl.SelectedTabPage = tabPageMap;
            if (tabName == tabPageAnalysis.Name) tabControl.SelectedTabPage = tabPageAnalysis;
            if (tabName == tabPageErrors.Name) tabControl.SelectedTabPage = tabPageErrors;
        }

        private async void NewScanModule_RequestNewScan(object sender, EventArgs e)
        {
            await newScanModule.DoScan();
        }

        private async void ResultsModule_RequestNewScan(object sender, EventArgs e)
        {
            await newScanModule.DoScan();
        }

        private async void FilesModule_RequestNewScan(object sender, EventArgs e)
        {
            await newScanModule.DoScan();
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
            sd.Filter = "Wamby results files (*.wamby)|*.wamby";
            try
            {
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.AppStarting;
                    await ViewModel.SaveScan(sd.FileName, Properties.Settings.Default.SaveToFileReadableFormat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void BarButtonItemOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sd = new OpenFileDialog();
            sd.Filter = "Wamby results files (*.wamby)|*.wamby";
            try
            {
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.AppStarting;
                    await ViewModel.OpenScan(sd.FileName);
                    newScanModule.RefreshScanOptionsControls();
                    RefreshModulesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}