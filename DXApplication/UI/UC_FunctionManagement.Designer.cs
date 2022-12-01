namespace DXApplication.UI
{
    partial class UC_FunctionManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FunctionManagement));
            this.gridControlFunctions = new DevExpress.XtraGrid.GridControl();
            this.functionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgvFunctions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFunctionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupEditFormName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFunctionRoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btnFAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnFEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnFDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnFRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditFormName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlFunctions
            // 
            this.gridControlFunctions.DataSource = this.functionBindingSource;
            this.gridControlFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFunctions.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlFunctions.Location = new System.Drawing.Point(0, 202);
            this.gridControlFunctions.MainView = this.dtgvFunctions;
            this.gridControlFunctions.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlFunctions.MenuManager = this.ribbonControl;
            this.gridControlFunctions.Name = "gridControlFunctions";
            this.gridControlFunctions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupEditFormName});
            this.gridControlFunctions.Size = new System.Drawing.Size(1067, 536);
            this.gridControlFunctions.TabIndex = 2;
            this.gridControlFunctions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgvFunctions});
            this.gridControlFunctions.Click += new System.EventHandler(this.gridControlFunctions_Click);
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(DXApplication.Entity.Function);
            // 
            // dtgvFunctions
            // 
            this.dtgvFunctions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dtgvFunctions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFunctionId,
            this.colFunctionName,
            this.colFormName,
            this.colFunctionRoles});
            this.dtgvFunctions.DetailHeight = 431;
            this.dtgvFunctions.GridControl = this.gridControlFunctions;
            this.dtgvFunctions.Name = "dtgvFunctions";
            this.dtgvFunctions.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            // 
            // colFunctionId
            // 
            this.colFunctionId.FieldName = "FunctionId";
            this.colFunctionId.MinWidth = 25;
            this.colFunctionId.Name = "colFunctionId";
            this.colFunctionId.Visible = true;
            this.colFunctionId.VisibleIndex = 0;
            this.colFunctionId.Width = 100;
            // 
            // colFunctionName
            // 
            this.colFunctionName.FieldName = "FunctionName";
            this.colFunctionName.MinWidth = 25;
            this.colFunctionName.Name = "colFunctionName";
            this.colFunctionName.Visible = true;
            this.colFunctionName.VisibleIndex = 1;
            this.colFunctionName.Width = 100;
            // 
            // colFormName
            // 
            this.colFormName.ColumnEdit = this.lookupEditFormName;
            this.colFormName.FieldName = "FormName";
            this.colFormName.MinWidth = 25;
            this.colFormName.Name = "colFormName";
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 2;
            this.colFormName.Width = 100;
            // 
            // lookupEditFormName
            // 
            this.lookupEditFormName.AutoHeight = false;
            this.lookupEditFormName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupEditFormName.Name = "lookupEditFormName";
            // 
            // colFunctionRoles
            // 
            this.colFunctionRoles.FieldName = "FunctionRoles";
            this.colFunctionRoles.MinWidth = 25;
            this.colFunctionRoles.Name = "colFunctionRoles";
            this.colFunctionRoles.Width = 100;
            // 
            // ribbonControl
            // 
            this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.btnFAddNew,
            this.btnFEdit,
            this.btnFDelete,
            this.btnFRefresh,
            this.btnDetails});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 440;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1067, 202);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl.Click += new System.EventHandler(this.ribbonControl_Click);
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // btnFAddNew
            // 
            this.btnFAddNew.Caption = "Thêm";
            this.btnFAddNew.Id = 16;
            this.btnFAddNew.ImageOptions.ImageUri.Uri = "New";
            this.btnFAddNew.Name = "btnFAddNew";
            this.btnFAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFAddNew_ItemClick);
            // 
            // btnFEdit
            // 
            this.btnFEdit.Caption = "Sửa";
            this.btnFEdit.Id = 17;
            this.btnFEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.btnFEdit.Name = "btnFEdit";
            this.btnFEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFEdit_ItemClick);
            // 
            // btnFDelete
            // 
            this.btnFDelete.Caption = "Xoá";
            this.btnFDelete.Id = 18;
            this.btnFDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnFDelete.Name = "btnFDelete";
            this.btnFDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFDelete_ItemClick);
            // 
            // btnFRefresh
            // 
            this.btnFRefresh.Caption = "Làm Tươi";
            this.btnFRefresh.Id = 19;
            this.btnFRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnFRefresh.Name = "btnFRefresh";
            this.btnFRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFRefresh_ItemClick);
            // 
            // btnDetails
            // 
            this.btnDetails.Caption = "Chi tiết";
            this.btnDetails.Id = 20;
            this.btnDetails.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDetails.ImageOptions.SvgImage")));
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetails_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage1.ImageOptions.SvgImage")));
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "FUNCTION_ROLE";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFAddNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 693);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1067, 45);
            // 
            // UC_FunctionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControlFunctions);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_FunctionManagement";
            this.Size = new System.Drawing.Size(1067, 738);
            this.Load += new System.EventHandler(this.UC_FunctionRoleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditFormName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlFunctions;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgvFunctions;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnFAddNew;
        private DevExpress.XtraBars.BarButtonItem btnFEdit;
        private DevExpress.XtraBars.BarButtonItem btnFDelete;
        private DevExpress.XtraBars.BarButtonItem btnFRefresh;
        private System.Windows.Forms.BindingSource functionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionId;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionName;
        private DevExpress.XtraGrid.Columns.GridColumn colFormName;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionRoles;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupEditFormName;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
    }
}
