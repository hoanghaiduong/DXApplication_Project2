
using DevExpress.Utils;
using DevExpress.XtraBars.Alerter;
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
       
        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            //db = new db_final_winformEntities();

            //var sql = db.Users.Join(db.FunctionRoles,
            //    usr => usr,
            //    fr => fr,
            //    (usr, fr) => usr.RoleId.Equals(fr.RoleId)

            // );
            accordionControl1.BeginUpdate();
         
            AccordionControlElement acItemActivity = new AccordionControlElement();
            AccordionControlElement acItemNews = new AccordionControlElement();
        
            // 
            // Root Group 'Home'
            // 
            mnCollapseManagement.Elements.AddRange(new AccordionControlElement[] {
            acItemActivity,
            acItemNews});
            // 
            // Child Item 'Activity'
            // 
            acItemActivity.Name = "acItemActivity";
            acItemActivity.Style = ElementStyle.Item;
            acItemActivity.Tag = "idActivity";
            acItemActivity.Text = "Activity";
            // 
            // Child Item 'News'
            // 
            acItemNews.Name = "acItemNews";
            acItemNews.Style = ElementStyle.Item;
            acItemNews.Tag = "idNews";
            acItemNews.Text = "News";

           

            accordionControl1.EndUpdate();


            using (db_final_winformEntities db=new db_final_winformEntities())
            {
                var sql = from usr in db.Users
                          join fr in db.FunctionRoles on usr.RoleId equals fr.RoleId
                          join f in db.Functions on fr.FunctionId equals f.FunctionId
                          where usr.UserName == Cls_Main.UserInfo.UserName
                          select new
                          {
                              FunctionName = f.FormName,
                              FormName = f.FormName,
                          };
                foreach (var obj in sql.ToList())
                {
                   //
                }
            }    

            //loading Splash Screen
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
            }
            
            try
            {
              loadDesignDashboardViewer();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi nè", ex.Message);
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
    }
}
//1.Tải và cài đặt thư viện DevExpress + crack full + keygen
//2.Tạo Project DXWindowForm
//3.Sử dụng Template tùy ý (ở đây chọn Fluent)
//4.Tạo User Control(Bar manager)
//5.Tạo Grid control và dock parent in container
//6.Tạo Class kết nối đến Cơ Sở Dữ Liệu