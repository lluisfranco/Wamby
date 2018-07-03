namespace Wamby.Client.Modules
{
    partial class ResultsModule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            this.colDeepLength = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resultsTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeepFilesCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemExpandTree = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemExpandLevel = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemExpandLevel1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpandLevel5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenInNewWamby = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupResults = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultsTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // colDeepLength
            // 
            this.colDeepLength.Caption = "Size (KB)";
            this.colDeepLength.FieldName = "DeepLengthInKB";
            this.colDeepLength.Format.FormatString = "n0";
            this.colDeepLength.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeepLength.Name = "colDeepLength";
            this.colDeepLength.Visible = true;
            this.colDeepLength.VisibleIndex = 2;
            this.colDeepLength.Width = 181;
            // 
            // resultsTreeList
            // 
            this.resultsTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLevel,
            this.colIsFolder,
            this.colFullName,
            this.colDeepLength,
            this.colDeepFilesCount});
            this.resultsTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultsTreeList.DataSource = this.resultsBindingSource;
            this.resultsTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeListFormatRule1.Column = this.colDeepLength;
            treeListFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            treeListFormatRule1.Rule = formatConditionRuleDataBar1;
            this.resultsTreeList.FormatRules.Add(treeListFormatRule1);
            this.resultsTreeList.KeyFieldName = "FullName";
            this.resultsTreeList.Location = new System.Drawing.Point(0, 31);
            this.resultsTreeList.Name = "resultsTreeList";
            this.resultsTreeList.OptionsBehavior.Editable = false;
            this.resultsTreeList.OptionsMenu.ShowConditionalFormattingItem = true;
            this.resultsTreeList.OptionsView.ShowHorzLines = false;
            this.resultsTreeList.OptionsView.ShowIndicator = false;
            this.resultsTreeList.ParentFieldName = "ParentFullName";
            this.resultsTreeList.Size = new System.Drawing.Size(610, 365);
            this.resultsTreeList.TabIndex = 0;
            // 
            // colLevel
            // 
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Width = 122;
            // 
            // colIsFolder
            // 
            this.colIsFolder.FieldName = "IsFolder";
            this.colIsFolder.Name = "colIsFolder";
            this.colIsFolder.Width = 71;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Folder";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 347;
            // 
            // colDeepFilesCount
            // 
            this.colDeepFilesCount.Caption = "Files";
            this.colDeepFilesCount.FieldName = "DeepFilesCount";
            this.colDeepFilesCount.Format.FormatString = "n0";
            this.colDeepFilesCount.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeepFilesCount.Name = "colDeepFilesCount";
            this.colDeepFilesCount.Visible = true;
            this.colDeepFilesCount.VisibleIndex = 1;
            this.colDeepFilesCount.Width = 80;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataSource = typeof(Wamby.Core.Model.WambyFolderInfo);
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemExpandTree,
            this.barButtonItemCollapse,
            this.barSubItemExpandLevel,
            this.barButtonItemExpandLevel1,
            this.barButtonItemExpandLevel2,
            this.barButtonItemExpandLevel3,
            this.barButtonItemExpandLevel4,
            this.barButtonItemExpandLevel5,
            this.barButtonItemOpenFolder,
            this.barButtonItemOpenInNewWamby});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 34;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(610, 31);
            // 
            // barButtonItemExpandTree
            // 
            this.barButtonItemExpandTree.Caption = "Expand";
            this.barButtonItemExpandTree.Id = 7;
            this.barButtonItemExpandTree.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Expand;
            this.barButtonItemExpandTree.Name = "barButtonItemExpandTree";
            this.barButtonItemExpandTree.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemCollapse
            // 
            this.barButtonItemCollapse.Caption = "Collapse";
            this.barButtonItemCollapse.Id = 8;
            this.barButtonItemCollapse.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Compress;
            this.barButtonItemCollapse.Name = "barButtonItemCollapse";
            this.barButtonItemCollapse.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barSubItemExpandLevel
            // 
            this.barSubItemExpandLevel.Caption = "Expand level";
            this.barSubItemExpandLevel.Id = 10;
            this.barSubItemExpandLevel.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.Tree_Expand_Level;
            this.barSubItemExpandLevel.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExpandLevel5)});
            this.barSubItemExpandLevel.Name = "barSubItemExpandLevel";
            // 
            // barButtonItemExpandLevel1
            // 
            this.barButtonItemExpandLevel1.Caption = "Level 1";
            this.barButtonItemExpandLevel1.Id = 11;
            this.barButtonItemExpandLevel1.Name = "barButtonItemExpandLevel1";
            this.barButtonItemExpandLevel1.Tag = 1;
            // 
            // barButtonItemExpandLevel2
            // 
            this.barButtonItemExpandLevel2.Caption = "Level 2";
            this.barButtonItemExpandLevel2.Id = 12;
            this.barButtonItemExpandLevel2.Name = "barButtonItemExpandLevel2";
            this.barButtonItemExpandLevel2.Tag = 2;
            // 
            // barButtonItemExpandLevel3
            // 
            this.barButtonItemExpandLevel3.Caption = "Level 3";
            this.barButtonItemExpandLevel3.Id = 13;
            this.barButtonItemExpandLevel3.Name = "barButtonItemExpandLevel3";
            this.barButtonItemExpandLevel3.Tag = 3;
            // 
            // barButtonItemExpandLevel4
            // 
            this.barButtonItemExpandLevel4.Caption = "Level 4";
            this.barButtonItemExpandLevel4.Id = 14;
            this.barButtonItemExpandLevel4.Name = "barButtonItemExpandLevel4";
            this.barButtonItemExpandLevel4.Tag = 4;
            // 
            // barButtonItemExpandLevel5
            // 
            this.barButtonItemExpandLevel5.Caption = "Level 5";
            this.barButtonItemExpandLevel5.Id = 15;
            this.barButtonItemExpandLevel5.Name = "barButtonItemExpandLevel5";
            this.barButtonItemExpandLevel5.Tag = 5;
            // 
            // barButtonItemOpenFolder
            // 
            this.barButtonItemOpenFolder.Caption = "Open Folder (Explorer)";
            this.barButtonItemOpenFolder.Id = 32;
            this.barButtonItemOpenFolder.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.GoTo_Folder_Explorer;
            this.barButtonItemOpenFolder.Name = "barButtonItemOpenFolder";
            // 
            // barButtonItemOpenInNewWamby
            // 
            this.barButtonItemOpenInNewWamby.Caption = "Scan in new Wamby";
            this.barButtonItemOpenInNewWamby.Id = 33;
            this.barButtonItemOpenInNewWamby.ImageOptions.SvgImage = global::Wamby.Client.Properties.Resources.New;
            this.barButtonItemOpenInNewWamby.Name = "barButtonItemOpenInNewWamby";
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupResults,
            this.ribbonPageGroupOptions});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Main Page";
            // 
            // ribbonPageGroupResults
            // 
            this.ribbonPageGroupResults.ItemLinks.Add(this.barButtonItemExpandTree);
            this.ribbonPageGroupResults.ItemLinks.Add(this.barButtonItemCollapse);
            this.ribbonPageGroupResults.ItemLinks.Add(this.barSubItemExpandLevel, true);
            this.ribbonPageGroupResults.Name = "ribbonPageGroupResults";
            this.ribbonPageGroupResults.Text = "Results";
            // 
            // ribbonPageGroupOptions
            // 
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenFolder);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOpenInNewWamby);
            this.ribbonPageGroupOptions.Name = "ribbonPageGroupOptions";
            this.ribbonPageGroupOptions.Text = "Options";
            // 
            // popupMenu
            // 
            this.popupMenu.ItemLinks.Add(this.barButtonItemOpenFolder);
            this.popupMenu.ItemLinks.Add(this.barButtonItemOpenInNewWamby);
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbon;
            // 
            // ResultsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultsTreeList);
            this.Controls.Add(this.ribbon);
            this.Name = "ResultsModule";
            this.Size = new System.Drawing.Size(610, 396);
            ((System.ComponentModel.ISupportInitialize)(this.resultsTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList resultsTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepLength;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeepFilesCount;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandTree;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCollapse;
        private DevExpress.XtraBars.BarSubItem barSubItemExpandLevel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpandLevel5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupResults;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupOptions;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenInNewWamby;
        private DevExpress.XtraBars.PopupMenu popupMenu;
    }
}
