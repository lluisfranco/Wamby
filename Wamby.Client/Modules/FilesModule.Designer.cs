namespace Wamby.Client.Modules
{
    partial class FilesModule
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar2 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            colLengthInKB = new DevExpress.XtraGrid.Columns.GridColumn();
            filesBindingSource = new System.Windows.Forms.BindingSource(components);
            gridControlFiles = new DevExpress.XtraGrid.GridControl();
            gridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            colParentFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastWriteTime = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastAccessTime = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            colOwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            colAttributes = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsArchive = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsCompressed = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsDevice = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsDirectory = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsEncrypted = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsHidden = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsIntegrityStream = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsNormal = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsNoScrubData = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsNotContentIndexed = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsOffline = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsReparsePoint = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsSparseFile = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsSystem = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsTemporary = new DevExpress.XtraGrid.Columns.GridColumn();
            popupMenu = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemShowInExplorer = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemShowInCmd = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemOpenFile = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemCopyPath = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemProperties = new DevExpress.XtraBars.BarButtonItem();
            barManager = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            svgImageCollection16 = new DevExpress.Utils.SvgImageCollection(components);
            svgImageCollection32 = new DevExpress.Utils.SvgImageCollection(components);
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)filesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // colLengthInKB
            // 
            colLengthInKB.Caption = "Size (KB)";
            colLengthInKB.DisplayFormat.FormatString = "n0";
            colLengthInKB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colLengthInKB.FieldName = "LengthInKB";
            colLengthInKB.Name = "colLengthInKB";
            colLengthInKB.OptionsColumn.ReadOnly = true;
            colLengthInKB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LengthInKB", "{0:n0}") });
            colLengthInKB.Visible = true;
            colLengthInKB.VisibleIndex = 1;
            colLengthInKB.Width = 51;
            // 
            // filesBindingSource
            // 
            filesBindingSource.DataSource = typeof(Core.Model.WambyFileInfo);
            // 
            // gridControlFiles
            // 
            gridControlFiles.DataSource = filesBindingSource;
            gridControlFiles.EmbeddedNavigator.Buttons.Append.Visible = false;
            gridControlFiles.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            gridControlFiles.EmbeddedNavigator.Buttons.Edit.Visible = false;
            gridControlFiles.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            gridControlFiles.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridControlFiles.Location = new System.Drawing.Point(12, 12);
            gridControlFiles.MainView = gridViewFiles;
            gridControlFiles.Name = "gridControlFiles";
            gridControlFiles.Size = new System.Drawing.Size(895, 372);
            gridControlFiles.TabIndex = 0;
            gridControlFiles.UseEmbeddedNavigator = true;
            gridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewFiles });
            // 
            // gridViewFiles
            // 
            gridViewFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colExtension, colParentFullName, colFullName, colName, colLength, colLengthInKB, colLastWriteTime, colLastAccessTime, colCreationTime, colOwnerName, colAttributes, colIsArchive, colIsCompressed, colIsDevice, colIsDirectory, colIsEncrypted, colIsHidden, colIsIntegrityStream, colIsNormal, colIsNoScrubData, colIsNotContentIndexed, colIsOffline, colIsReadOnly, colIsReparsePoint, colIsSparseFile, colIsSystem, colIsTemporary });
            gridFormatRule2.Column = colLengthInKB;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleDataBar2.PredefinedName = "Mint";
            gridFormatRule2.Rule = formatConditionRuleDataBar2;
            gridViewFiles.FormatRules.Add(gridFormatRule2);
            gridViewFiles.GridControl = gridControlFiles;
            gridViewFiles.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Extension", null, "({0} items)") });
            gridViewFiles.Name = "gridViewFiles";
            gridViewFiles.OptionsBehavior.Editable = false;
            gridViewFiles.OptionsMenu.ShowConditionalFormattingItem = true;
            gridViewFiles.OptionsView.ShowFooter = true;
            gridViewFiles.OptionsView.ShowGroupPanel = false;
            gridViewFiles.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            gridViewFiles.OptionsView.ShowIndicator = false;
            gridViewFiles.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colFullName, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // colExtension
            // 
            colExtension.FieldName = "Extension";
            colExtension.Name = "colExtension";
            // 
            // colParentFullName
            // 
            colParentFullName.FieldName = "ParentFullName";
            colParentFullName.Name = "colParentFullName";
            // 
            // colFullName
            // 
            colFullName.FieldName = "FullName";
            colFullName.Name = "colFullName";
            colFullName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FullName", "{0}") });
            colFullName.Visible = true;
            colFullName.VisibleIndex = 0;
            colFullName.Width = 214;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.Name = "colName";
            // 
            // colLength
            // 
            colLength.FieldName = "Length";
            colLength.Name = "colLength";
            // 
            // colLastWriteTime
            // 
            colLastWriteTime.DisplayFormat.FormatString = "g";
            colLastWriteTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colLastWriteTime.FieldName = "LastWriteTime";
            colLastWriteTime.Name = "colLastWriteTime";
            colLastWriteTime.OptionsColumn.AllowSize = false;
            colLastWriteTime.OptionsColumn.FixedWidth = true;
            colLastWriteTime.Visible = true;
            colLastWriteTime.VisibleIndex = 4;
            colLastWriteTime.Width = 100;
            // 
            // colLastAccessTime
            // 
            colLastAccessTime.DisplayFormat.FormatString = "g";
            colLastAccessTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colLastAccessTime.FieldName = "LastAccessTime";
            colLastAccessTime.Name = "colLastAccessTime";
            colLastAccessTime.OptionsColumn.AllowSize = false;
            colLastAccessTime.OptionsColumn.FixedWidth = true;
            colLastAccessTime.Visible = true;
            colLastAccessTime.VisibleIndex = 3;
            colLastAccessTime.Width = 100;
            // 
            // colCreationTime
            // 
            colCreationTime.DisplayFormat.FormatString = "g";
            colCreationTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colCreationTime.FieldName = "CreationTime";
            colCreationTime.Name = "colCreationTime";
            colCreationTime.OptionsColumn.AllowSize = false;
            colCreationTime.OptionsColumn.FixedWidth = true;
            colCreationTime.Visible = true;
            colCreationTime.VisibleIndex = 2;
            colCreationTime.Width = 100;
            // 
            // colOwnerName
            // 
            colOwnerName.FieldName = "OwnerName";
            colOwnerName.Name = "colOwnerName";
            colOwnerName.Visible = true;
            colOwnerName.VisibleIndex = 5;
            colOwnerName.Width = 54;
            // 
            // colAttributes
            // 
            colAttributes.FieldName = "Attributes";
            colAttributes.Name = "colAttributes";
            colAttributes.Visible = true;
            colAttributes.VisibleIndex = 6;
            // 
            // colIsArchive
            // 
            colIsArchive.FieldName = "IsArchive";
            colIsArchive.Name = "colIsArchive";
            // 
            // colIsCompressed
            // 
            colIsCompressed.FieldName = "IsCompressed";
            colIsCompressed.Name = "colIsCompressed";
            // 
            // colIsDevice
            // 
            colIsDevice.FieldName = "IsDevice";
            colIsDevice.Name = "colIsDevice";
            // 
            // colIsDirectory
            // 
            colIsDirectory.FieldName = "IsDirectory";
            colIsDirectory.Name = "colIsDirectory";
            // 
            // colIsEncrypted
            // 
            colIsEncrypted.FieldName = "IsEncrypted";
            colIsEncrypted.Name = "colIsEncrypted";
            // 
            // colIsHidden
            // 
            colIsHidden.FieldName = "IsHidden";
            colIsHidden.Name = "colIsHidden";
            // 
            // colIsIntegrityStream
            // 
            colIsIntegrityStream.FieldName = "IsIntegrityStream";
            colIsIntegrityStream.Name = "colIsIntegrityStream";
            // 
            // colIsNormal
            // 
            colIsNormal.FieldName = "IsNormal";
            colIsNormal.Name = "colIsNormal";
            // 
            // colIsNoScrubData
            // 
            colIsNoScrubData.FieldName = "IsNoScrubData";
            colIsNoScrubData.Name = "colIsNoScrubData";
            // 
            // colIsNotContentIndexed
            // 
            colIsNotContentIndexed.FieldName = "IsNotContentIndexed";
            colIsNotContentIndexed.Name = "colIsNotContentIndexed";
            // 
            // colIsOffline
            // 
            colIsOffline.FieldName = "IsOffline";
            colIsOffline.Name = "colIsOffline";
            // 
            // colIsReadOnly
            // 
            colIsReadOnly.FieldName = "IsReadOnly";
            colIsReadOnly.Name = "colIsReadOnly";
            // 
            // colIsReparsePoint
            // 
            colIsReparsePoint.FieldName = "IsReparsePoint";
            colIsReparsePoint.Name = "colIsReparsePoint";
            // 
            // colIsSparseFile
            // 
            colIsSparseFile.FieldName = "IsSparseFile";
            colIsSparseFile.Name = "colIsSparseFile";
            // 
            // colIsSystem
            // 
            colIsSystem.FieldName = "IsSystem";
            colIsSystem.Name = "colIsSystem";
            // 
            // colIsTemporary
            // 
            colIsTemporary.FieldName = "IsTemporary";
            colIsTemporary.Name = "colIsTemporary";
            // 
            // popupMenu
            // 
            popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemShowInExplorer), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemShowInCmd), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemOpenFile), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemCopyPath), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemProperties, true) });
            popupMenu.Manager = barManager;
            popupMenu.Name = "popupMenu";
            // 
            // barButtonItemShowInExplorer
            // 
            barButtonItemShowInExplorer.Caption = "Open Folder (Explorer)";
            barButtonItemShowInExplorer.Id = 0;
            barButtonItemShowInExplorer.ImageOptions.ImageIndex = 4;
            barButtonItemShowInExplorer.ImageOptions.LargeImageIndex = 4;
            barButtonItemShowInExplorer.Name = "barButtonItemShowInExplorer";
            // 
            // barButtonItemShowInCmd
            // 
            barButtonItemShowInCmd.Caption = "Open Folder (Cmd)";
            barButtonItemShowInCmd.Id = 1;
            barButtonItemShowInCmd.ImageOptions.ImageIndex = 3;
            barButtonItemShowInCmd.ImageOptions.LargeImageIndex = 3;
            barButtonItemShowInCmd.Name = "barButtonItemShowInCmd";
            // 
            // barButtonItemOpenFile
            // 
            barButtonItemOpenFile.Caption = "Open/Run File";
            barButtonItemOpenFile.Id = 5;
            barButtonItemOpenFile.ImageOptions.ImageIndex = 5;
            barButtonItemOpenFile.ImageOptions.LargeImageIndex = 5;
            barButtonItemOpenFile.Name = "barButtonItemOpenFile";
            // 
            // barButtonItemCopyPath
            // 
            barButtonItemCopyPath.Caption = "Copy Path";
            barButtonItemCopyPath.Id = 2;
            barButtonItemCopyPath.ImageOptions.ImageIndex = 0;
            barButtonItemCopyPath.ImageOptions.LargeImageIndex = 0;
            barButtonItemCopyPath.Name = "barButtonItemCopyPath";
            // 
            // barButtonItemProperties
            // 
            barButtonItemProperties.Caption = "Properties";
            barButtonItemProperties.Id = 3;
            barButtonItemProperties.ImageOptions.ImageIndex = 2;
            barButtonItemProperties.ImageOptions.LargeImageIndex = 2;
            barButtonItemProperties.Name = "barButtonItemProperties";
            // 
            // barManager
            // 
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.Form = this;
            barManager.Images = svgImageCollection16;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemShowInExplorer, barButtonItemShowInCmd, barButtonItemCopyPath, barButtonItemProperties, barButtonItemOpenFile });
            barManager.LargeImages = svgImageCollection32;
            barManager.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager;
            barDockControlTop.Size = new System.Drawing.Size(919, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 396);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(919, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(919, 0);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // svgImageCollection16
            // 
            svgImageCollection16.Add("CopyPath", "Wamby.Resources.Images.Results.CopyPath.svg", "Wamby.Resources");
            svgImageCollection16.Add("Delete", "Wamby.Resources.Images.Results.Delete.svg", "Wamby.Resources");
            svgImageCollection16.Add("Properties", "Wamby.Resources.Images.Results.Properties.svg", "Wamby.Resources");
            svgImageCollection16.Add("ShowInCmd", "Wamby.Resources.Images.Results.ShowInCmd.svg", "Wamby.Resources");
            svgImageCollection16.Add("ShowInExplorer", "Wamby.Resources.Images.Results.ShowInExplorer.svg", "Wamby.Resources");
            svgImageCollection16.Add("weather_lightning", "image://svgimages/icon builder/weather_lightning.svg");
            // 
            // svgImageCollection32
            // 
            svgImageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            svgImageCollection32.Add("CopyPath", "Wamby.Resources.Images.Results.CopyPath.svg", "Wamby.Resources");
            svgImageCollection32.Add("Delete", "Wamby.Resources.Images.Results.Delete.svg", "Wamby.Resources");
            svgImageCollection32.Add("Properties", "Wamby.Resources.Images.Results.Properties.svg", "Wamby.Resources");
            svgImageCollection32.Add("ShowInCmd", "Wamby.Resources.Images.Results.ShowInCmd.svg", "Wamby.Resources");
            svgImageCollection32.Add("ShowInExplorer", "Wamby.Resources.Images.Results.ShowInExplorer.svg", "Wamby.Resources");
            svgImageCollection32.Add("weather_lightning", "image://svgimages/icon builder/weather_lightning.svg");
            // 
            // layoutControl
            // 
            layoutControl.AllowCustomization = false;
            layoutControl.Controls.Add(gridControlFiles);
            layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new System.Drawing.Size(919, 396);
            layoutControl.TabIndex = 2;
            layoutControl.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(919, 396);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlFiles;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(899, 376);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // FilesModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FilesModule";
            Size = new System.Drawing.Size(919, 396);
            ((System.ComponentModel.ISupportInitialize)filesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection16).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.BindingSource filesBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiles;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colParentFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colLengthInKB;
        private DevExpress.XtraGrid.Columns.GridColumn colLastWriteTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLastAccessTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationTime;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerName;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colAttributes;
        private DevExpress.XtraGrid.Columns.GridColumn colIsArchive;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCompressed;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDirectory;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEncrypted;
        private DevExpress.XtraGrid.Columns.GridColumn colIsHidden;
        private DevExpress.XtraGrid.Columns.GridColumn colIsIntegrityStream;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNormal;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNoScrubData;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNotContentIndexed;
        private DevExpress.XtraGrid.Columns.GridColumn colIsOffline;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReparsePoint;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSparseFile;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSystem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTemporary;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection16;
        private DevExpress.Utils.SvgImageCollection svgImageCollection32;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowInExplorer;
        private DevExpress.XtraBars.BarButtonItem barButtonItemShowInCmd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCopyPath;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProperties;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenFile;
    }
}
