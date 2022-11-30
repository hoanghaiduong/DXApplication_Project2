
using DevExpress.Utils;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DXApplication.Entity;
using DXApplication.Form;
using DXApplication.Global;
using DXApplication.UI;
using NETWORKLIST;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication
{
    public partial class Frm_Dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        CheckerInternetHelper helper;
       
        public Frm_Dashboard()
        {
            InitializeComponent();
           
            helper = new CheckerInternetHelper(this);
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
      
        UC_UserManagement uC__UserManagement;
        Uc__designDashboard uc__designDashboard;
        Uc_DashboardViewer uc__designDashboardViewer;
        UC_RoleManagement uC__RoleManagement;
        UC_FunctionManagement uC__FunctionRoleManagement;
        UC_AuthenticationManager UC_AuthenticationManager;
        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void mnQLND_Click(object sender, EventArgs e)
        {

            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }

     
                mainContainer.Controls.Clear();
                uC__UserManagement = new UC_UserManagement();
                uC__UserManagement.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uC__UserManagement);
                uC__UserManagement.BringToFront();
                SplashScreenManager.CloseForm();
          
        }
       private void loadMenuItemForSQL()
        {

            using (db_final_winformEntities db = new db_final_winformEntities())
            {
                var sql = from usr in db.Users
                          join fr in db.FunctionRoles on usr.RoleId equals fr.RoleId
                          join f in db.Functions on fr.FunctionId equals f.FunctionId
                          where usr.UserName == Cls_Main.UserInfo.UserName
                          select new
                          {
                              FunctionName = f.FunctionName,
                              FormName = f.FormName,
                          };
                accordionControl1.BeginUpdate();

                foreach (var obj in sql.ToList())
                {
                    AccordionControlElement item = new AccordionControlElement();

                    // 
                    // Child Item 
                    // 
                    item.Name = "item" + obj.FormName;
                    item.Style = ElementStyle.Item;
                    item.Tag = obj.FormName;
                    item.Click += Item_Click;
                    item.Text = obj.FunctionName;
                    mnCollapseManagement.Elements.AddRange(new AccordionControlElement[]
                  {item});
                    MessageBox.Show(obj.ToString()+" | "+obj.FunctionName + " | " + obj.FormName);
                }

                AccordionControlElement acRootAccount = new AccordionControlElement();
                AccordionControlElement acViewAccount = new AccordionControlElement();
                AccordionControlElement acLogout= new AccordionControlElement();
                // 
                // Root Group 
                // 

                acRootAccount.Expanded = true;
                acRootAccount.ImageOptions.ImageUri.Uri = "Home;Office2013";
                acRootAccount.Name = "acRootAccount";
                acRootAccount.Text = "Tài Khoản";

                // 
                // Child Item 
                // 
                acViewAccount.Name = "acViewAccount";
                acViewAccount.Style = ElementStyle.Item;
                acViewAccount.Tag = "idAcViewAccount";
                acViewAccount.Text = "Thông tin tài khoản";
                acLogout.ImageOptions.ImageUri.Uri = "Customization;Office2013";
                // 
                // Child Item
                // 
                acLogout.Name = "acLogout";
                acLogout.Style = ElementStyle.Item;
                acLogout.Tag = "idAcLogout";
                acLogout.Text = "Đăng Xuất";
                acLogout.ImageOptions.ImageUri.Uri = "Customization;Office2013";
                acLogout.Click += AcLogout_Click;
                // 
                // Root Item 'Settings' with ContentContainer
                // 

                //add item to group
                acRootAccount.Elements.AddRange(new AccordionControlElement[] 
                {
                    acViewAccount,
                    acLogout});
                //add group to control
                accordionControl1.Elements.Add(acRootAccount);

                accordionControl1.EndUpdate();
                
            }
        }

        private void AcLogout_Click(object sender, EventArgs e)
        {
            Cls_Main.IsLogout = true;
            Frm_Login.Instance.Show();
            this.Hide();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            
            //loading Splash Screen
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(10);
            }
            try
            {
             
                loadMenuItemForSQL();
                loadDesignDashboardViewer();
             
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi nè", ex.Message);
            }

        }

        private void Item_Click(object sender, EventArgs e)
        {
            try
            {
                AccordionControlElement item = sender as AccordionControlElement;
                if(item != null)
                {
                    Type type = Type.GetType(item.Tag.ToString());
                   
                    string str1=type.ToString().ToUpper();
                    string str2 = "UC_";
                    bool checkExists = str1.Contains(str2);
                    if(checkExists)
                    {
                        //MessageBox.Show("DAy la usercontrol");
                        var uc_ = (XtraUserControl)Activator.CreateInstance(type);
                        if (uc_ != null)
                        {
                            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
                            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
                            for (int i = 0; i < 50; i++)
                            {
                                Thread.Sleep(10);
                            }
                            mainContainer.Controls.Clear();
                            uc_.Dock = DockStyle.Fill;
                            mainContainer.Controls.Add(uc_);
                            uc_.BringToFront();
                            SplashScreenManager.CloseForm();


                        }
                    }
                    else
                    {
                        //  MessageBox.Show("DAy la Form");
                        var xtraform = (XtraForm)Activator.CreateInstance(type);
                        if(xtraform!=null)
                        {
                            xtraform.ShowDialog();
                        }    
                    }
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mainContainer_Click(object sender, EventArgs e)
        {

        }

        private void mngrSetting_Click(object sender, EventArgs e)
        {

        }

        private void mniSettingDashboard_Click(object sender, EventArgs e)
        {
            loadDesignDashboard();

        }
        private void loadDesignDashboard()
        {
            uc__designDashboard = new Uc__designDashboard();
            uc__designDashboard.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(uc__designDashboard);
            uc__designDashboard.BringToFront();
        }
        private void loadDesignDashboardViewer()
        {
            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(10);
            }

       
                mainContainer.Controls.Clear();
                uc__designDashboardViewer = new Uc_DashboardViewer();
                uc__designDashboardViewer.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc__designDashboardViewer);
                uc__designDashboardViewer.BringToFront();
                SplashScreenManager.CloseForm();
    
          
        }
        private void mnDashboard_Click(object sender, EventArgs e)
        {
            loadDesignDashboardViewer();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
          
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            helper.UnAdviseforNetworklistManager();
            Application.Exit();
        }

        private void mnBU_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Đăng kí kiểm tra kết nối mạng thành công.");
            helper.AdviseforNetworklistManager();
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void mnQLRole_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }

          
                mainContainer.Controls.Clear();
                uC__RoleManagement = new UC_RoleManagement();
                uC__RoleManagement.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uC__RoleManagement);
                uC__RoleManagement.BringToFront();
                SplashScreenManager.CloseForm();
         
            
        }

        private void mnQLFunctions_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }

                mainContainer.Controls.Clear();
                uC__FunctionRoleManagement = new UC_FunctionManagement();
                uC__FunctionRoleManagement.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uC__FunctionRoleManagement);
                uC__FunctionRoleManagement.BringToFront();
                SplashScreenManager.CloseForm();
            
        }

        private void mnQLFunctionRole_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }

            mainContainer.Controls.Clear();
            UC_AuthenticationManager = new UC_AuthenticationManager();
            UC_AuthenticationManager.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(UC_AuthenticationManager);
            UC_AuthenticationManager.BringToFront();
            SplashScreenManager.CloseForm();

        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
            frm_Dashboard.ShowDialog();
            

        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
//1.Tải và cài đặt thư viện DevExpress + crack full + keygen
//2.Tạo Project DXWindowForm
//3.Sử dụng Template tùy ý (ở đây chọn Fluent)
//4.Tạo User Control(Bar manager)
//5.Tạo Grid control và dock parent in container
//6.Tạo Class kết nối đến Cơ Sở Dữ Liệu