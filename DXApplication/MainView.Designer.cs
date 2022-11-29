namespace DXApplication
{
    partial class Frm_Dashboard
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DXApplication.SplashScreenApp), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnCollapseManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLSV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnClasses = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLRole = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLFunctions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLFunctionRole = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnBU = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnRes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mngrSetting = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.alertControlGlobal = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 100;
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(360, 41);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1330, 709);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Click += new System.EventHandler(this.mainContainer_Click);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.MaxItemId = 4;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnDashboard,
            this.mnCollapseManagement,
            this.accordionControlElement5,
            this.mngrSetting});
            this.accordionControl1.Location = new System.Drawing.Point(0, 41);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(360, 709);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnDashboard
            // 
            this.mnDashboard.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.mnDashboard.Appearance.Hovered.Options.UseFont = true;
            this.mnDashboard.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnDashboard.Appearance.Normal.Options.UseFont = true;
            this.mnDashboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDashboard.ImageOptions.Image")));
            this.mnDashboard.Name = "mnDashboard";
            this.mnDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDashboard.Text = "Trang chủ";
            this.mnDashboard.Click += new System.EventHandler(this.mnDashboard_Click);
            // 
            // mnCollapseManagement
            // 
            this.mnCollapseManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQLTK,
            this.mnQLSV,
            this.mnClasses,
            this.mnQLRole,
            this.mnQLFunctions,
            this.mnQLFunctionRole});
            this.mnCollapseManagement.Expanded = true;
            this.mnCollapseManagement.Name = "mnCollapseManagement";
            this.mnCollapseManagement.Text = "Quản Lí";
            this.mnCollapseManagement.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // mnQLTK
            // 
            this.mnQLTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLTK.ImageOptions.Image")));
            this.mnQLTK.Name = "mnQLTK";
            this.mnQLTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLTK.Text = "Quản Lí Tài Khoản";
            this.mnQLTK.Click += new System.EventHandler(this.mnQLND_Click);
            // 
            // mnQLSV
            // 
            this.mnQLSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLSV.ImageOptions.Image")));
            this.mnQLSV.Name = "mnQLSV";
            this.mnQLSV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLSV.Text = "Quản Lí Sinh Viên";
            // 
            // mnClasses
            // 
            this.mnClasses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnClasses.ImageOptions.Image")));
            this.mnClasses.Name = "mnClasses";
            this.mnClasses.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnClasses.Text = "Quản Lí Danh Sách Lớp";
            // 
            // mnQLRole
            // 
            this.mnQLRole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLRole.ImageOptions.Image")));
            this.mnQLRole.Name = "mnQLRole";
            this.mnQLRole.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLRole.Text = "Quản Lí Quyền";
            this.mnQLRole.Click += new System.EventHandler(this.mnQLRole_Click);
            // 
            // mnQLFunctions
            // 
            this.mnQLFunctions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLFunctions.ImageOptions.Image")));
            this.mnQLFunctions.Name = "mnQLFunctions";
            this.mnQLFunctions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLFunctions.Text = "Quản Lí Chức Năng Hệ Thống";
            this.mnQLFunctions.Click += new System.EventHandler(this.mnQLFunctions_Click);
            // 
            // mnQLFunctionRole
            // 
            this.mnQLFunctionRole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLFunctionRole.ImageOptions.Image")));
            this.mnQLFunctionRole.Name = "mnQLFunctionRole";
            this.mnQLFunctionRole.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLFunctionRole.Text = "Quản Lí Quyền Sử Dụng Chức Năng";
            this.mnQLFunctionRole.Click += new System.EventHandler(this.mnQLFunctionRole_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnBU,
            this.mnRes,
            this.mnExit});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Hệ Thống";
            // 
            // mnBU
            // 
            this.mnBU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnBU.ImageOptions.Image")));
            this.mnBU.Name = "mnBU";
            this.mnBU.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnBU.Text = "Backup";
            this.mnBU.Click += new System.EventHandler(this.mnBU_Click);
            // 
            // mnRes
            // 
            this.mnRes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnRes.ImageOptions.Image")));
            this.mnRes.Name = "mnRes";
            this.mnRes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnRes.Text = "Restore";
            // 
            // mnExit
            // 
            this.mnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnExit.ImageOptions.Image")));
            this.mnExit.Name = "mnExit";
            this.mnExit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnExit.Text = "Exit";
            // 
            // mngrSetting
            // 
            this.mngrSetting.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2});
            this.mngrSetting.Expanded = true;
            this.mngrSetting.Name = "mngrSetting";
            this.mngrSetting.Text = "Cài Đặt";
            this.mngrSetting.Click += new System.EventHandler(this.mngrSetting_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Sửa DashBoard";
            this.accordionControlElement2.Click += new System.EventHandler(this.mniSettingDashboard_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1690, 41);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.Click += new System.EventHandler(this.fluentDesignFormControl1_Click);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(DXApplication.MainViewModel);
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 750);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Frm_Dashboard.IconOptions.SvgImage")));
            this.Name = "Frm_Dashboard";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Trị Hệ Thống";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnCollapseManagement;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLTK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLSV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnClasses;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnBU;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnRes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnExit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mngrSetting;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDashboard;
        private DevExpress.XtraBars.Alerter.AlertControl alertControlGlobal;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLRole;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLFunctions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLFunctionRole;
    }
}

