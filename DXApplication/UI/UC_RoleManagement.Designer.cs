namespace DXApplication.UI
{
    partial class UC_RoleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RoleManagement));
            this.gridControlRoles = new DevExpress.XtraGrid.GridControl();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgvRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionRoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRoles
            // 
            this.gridControlRoles.DataSource = this.roleBindingSource;
            this.gridControlRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRoles.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRoles.Location = new System.Drawing.Point(0, 87);
            this.gridControlRoles.MainView = this.dtgvRoles;
            this.gridControlRoles.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRoles.MenuManager = this.ribbonControl;
            this.gridControlRoles.Name = "gridControlRoles";
            this.gridControlRoles.Size = new System.Drawing.Size(1067, 651);
            this.gridControlRoles.TabIndex = 2;
            this.gridControlRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgvRoles});
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(DXApplication.Entity.Role);
            // 
            // dtgvRoles
            // 
            this.dtgvRoles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dtgvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleId,
            this.colRoleName,
            this.colFunctionRoles,
            this.colUsers});
            this.dtgvRoles.DetailHeight = 431;
            this.dtgvRoles.GridControl = this.gridControlRoles;
            this.dtgvRoles.Name = "dtgvRoles";
            this.dtgvRoles.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.dtgvRoles.OptionsBehavior.ReadOnly = true;
            // 
            // colRoleId
            // 
            this.colRoleId.FieldName = "RoleId";
            this.colRoleId.MinWidth = 25;
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.OptionsColumn.ReadOnly = true;
            this.colRoleId.Visible = true;
            this.colRoleId.VisibleIndex = 0;
            this.colRoleId.Width = 100;
            // 
            // colRoleName
            // 
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.MinWidth = 25;
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            this.colRoleName.Width = 100;
            // 
            // colFunctionRoles
            // 
            this.colFunctionRoles.FieldName = "FunctionRoles";
            this.colFunctionRoles.MinWidth = 25;
            this.colFunctionRoles.Name = "colFunctionRoles";
            this.colFunctionRoles.Width = 100;
            // 
            // colUsers
            // 
            this.colUsers.FieldName = "Users";
            this.colUsers.MinWidth = 25;
            this.colUsers.Name = "colUsers";
            this.colUsers.Width = 100;
            // 
            // ribbonControl
            // 
            this.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 440;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1067, 87);
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
            // btnAddNew
            // 
            this.btnAddNew.Caption = "Thêm";
            this.btnAddNew.Id = 16;
            this.btnAddNew.ImageOptions.ImageUri.Uri = "New";
            this.btnAddNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddNew.ImageOptions.SvgImage")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNew_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.ActAsDropDown = true;
            this.btnEdit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 17;
            this.btnEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xoá";
            this.btnDelete.Id = 18;
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm Tươi";
            this.btnRefresh.Id = 19;
            this.btnRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý Quyền";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
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
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl;
            // 
            // UC_RoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlRoles);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_RoleManagement";
            this.Size = new System.Drawing.Size(1067, 738);
            this.Load += new System.EventHandler(this.UC_RoleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgvRoles;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionRoles;
        private DevExpress.XtraGrid.Columns.GridColumn colUsers;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
    }
}
