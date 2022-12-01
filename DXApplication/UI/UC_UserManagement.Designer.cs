namespace DXApplication.UI
{
    partial class UC_UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UserManagement));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.dtgvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerifiedEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).BeginInit();
            this.SuspendLayout();
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
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.btnSave,
            this.btnDetails});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 23;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 440;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1067, 182);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl.Click += new System.EventHandler(this.ribbonControl_Click);
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Xem và In";
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
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNew.ImageOptions.SvgImage")));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Sửa";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEdit.ImageOptions.SvgImage")));
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Làm Tươi";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu Lại";
            this.btnSave.Id = 20;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDetails
            // 
            this.btnDetails.Caption = "Chi Tiết Người Dùng";
            this.btnDetails.Id = 22;
            this.btnDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.ImageOptions.Image")));
            this.btnDetails.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.ImageOptions.LargeImage")));
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetails_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lí Người Dùng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao Tác";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "In và Xuất";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDetails);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thông Tin";
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
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DXApplication.Entity.User);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(DXApplication.Entity.Role);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(DXApplication.Entity.User);
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.DataSource = this.userBindingSource;
            this.gridControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUsers.Location = new System.Drawing.Point(0, 182);
            this.gridControlUsers.MainView = this.dtgvUsers;
            this.gridControlUsers.MenuManager = this.ribbonControl;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(1067, 511);
            this.gridControlUsers.TabIndex = 7;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgvUsers});
            // 
            // dtgvUsers
            // 
            this.dtgvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserId,
            this.colRoleId,
            this.colUserName,
            this.colDisabled,
            this.colOtp,
            this.colEmail,
            this.colPassword,
            this.colVerifiedEmail,
            this.colPersons,
            this.colRole});
            this.dtgvUsers.GridControl = this.gridControlUsers;
            this.dtgvUsers.Name = "dtgvUsers";
            this.dtgvUsers.OptionsBehavior.Editable = false;
            this.dtgvUsers.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.MinWidth = 25;
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.AllowEdit = false;
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 0;
            this.colUserId.Width = 94;
            // 
            // colRoleId
            // 
            this.colRoleId.FieldName = "Role.RoleName";
            this.colRoleId.MinWidth = 25;
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.Visible = true;
            this.colRoleId.VisibleIndex = 1;
            this.colRoleId.Width = 94;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            this.colUserName.Width = 94;
            // 
            // colDisabled
            // 
            this.colDisabled.FieldName = "Disabled";
            this.colDisabled.MinWidth = 25;
            this.colDisabled.Name = "colDisabled";
            this.colDisabled.Visible = true;
            this.colDisabled.VisibleIndex = 3;
            this.colDisabled.Width = 94;
            // 
            // colOtp
            // 
            this.colOtp.FieldName = "Otp";
            this.colOtp.MinWidth = 25;
            this.colOtp.Name = "colOtp";
            this.colOtp.Visible = true;
            this.colOtp.VisibleIndex = 4;
            this.colOtp.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 94;
            // 
            // colVerifiedEmail
            // 
            this.colVerifiedEmail.FieldName = "VerifiedEmail";
            this.colVerifiedEmail.MinWidth = 25;
            this.colVerifiedEmail.Name = "colVerifiedEmail";
            this.colVerifiedEmail.Visible = true;
            this.colVerifiedEmail.VisibleIndex = 6;
            this.colVerifiedEmail.Width = 94;
            // 
            // colPersons
            // 
            this.colPersons.FieldName = "Persons";
            this.colPersons.MinWidth = 25;
            this.colPersons.Name = "colPersons";
            this.colPersons.Width = 94;
            // 
            // colRole
            // 
            this.colRole.FieldName = "Role";
            this.colRole.MinWidth = 25;
            this.colRole.Name = "colRole";
            this.colRole.Width = 94;
            // 
            // UC_UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlUsers);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_UserManagement";
            this.Size = new System.Drawing.Size(1067, 738);
            this.Load += new System.EventHandler(this.UC_UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgvUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisabled;
        private DevExpress.XtraGrid.Columns.GridColumn colOtp;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colVerifiedEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPersons;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}
