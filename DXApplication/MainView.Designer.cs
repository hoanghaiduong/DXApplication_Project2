namespace DXApplication
{
    partial class frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLND = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLSP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLPB = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnBU = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnRes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.mngrSetting = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.mainContainer.Location = new System.Drawing.Point(306, 39);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(5);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1124, 670);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Click += new System.EventHandler(this.mainContainer_Click);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.MaxItemId = 1;
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
            this.accordionControlElement1,
            this.accordionControlElement5,
            this.mngrSetting});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(5);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(306, 670);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQLND,
            this.mnQLSP,
            this.mnQLPB});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Quản Lí";
            // 
            // mnQLND
            // 
            this.mnQLND.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLND.ImageOptions.Image")));
            this.mnQLND.Name = "mnQLND";
            this.mnQLND.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLND.Text = "Quản Lí Người Dùng";
            this.mnQLND.Click += new System.EventHandler(this.mnQLND_Click);
            // 
            // mnQLSP
            // 
            this.mnQLSP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLSP.ImageOptions.Image")));
            this.mnQLSP.Name = "mnQLSP";
            this.mnQLSP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLSP.Text = "Quản Lí Sản Phẩm";
            // 
            // mnQLPB
            // 
            this.mnQLPB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLPB.ImageOptions.Image")));
            this.mnQLPB.Name = "mnQLPB";
            this.mnQLPB.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLPB.Text = "Quản Lí Phòng Ban";
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
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1430, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(DXApplication.MainViewModel);
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
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 709);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_Dashboard.IconOptions.SvgImage")));
            this.Name = "frm_Dashboard";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Trị Hệ Thống";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLND;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLSP;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLPB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnBU;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnRes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnExit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mngrSetting;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
    }
}

