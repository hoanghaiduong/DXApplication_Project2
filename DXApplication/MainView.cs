using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DXApplication.Entity;
using DXApplication.Form;
using DXApplication.Global;
using DXApplication.UI;
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
        private void addControlToMain(XtraUserControl control)
        {
            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }

            mainContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(control);
            control.BringToFront();
            SplashScreenManager.CloseForm();
        }
        private void mnQLND_Click(object sender, EventArgs e)
        {


            uC__UserManagement = new UC_UserManagement();
            addControlToMain(uC__UserManagement);


        }
        private void createDynamicMenu(AccordionControlElement item,Boolean root,String name,ElementStyle style,String tag,String Text,String imageURI)
        {
            item.Expanded = root;
            item.Name = name;
            item.Style = style;
            item.Tag = tag;
            item.Text =Text;
            item.ImageOptions.ImageUri.Uri = imageURI;
            item.Click += Item_Click1;
       
        }

        private void Item_Click1(object sender, EventArgs e)
        {
            try
            {
                AccordionControlElement item = sender as AccordionControlElement;
                if (item != null)
                {
                    Type type = Type.GetType(item.Tag.ToString());

                    string str1 = type.ToString().ToUpper();
                    string str2 = "UC_";
                    bool checkExists = str1.Contains(str2);
                    if (checkExists)
                    {
                        //MessageBox.Show("DAy la usercontrol");
                        var uc_ = (XtraUserControl)Activator.CreateInstance(type);
                        if (uc_ != null)
                        {

                            addControlToMain(uc_);

                        }
                    }
                    else
                    {
                        //  MessageBox.Show("DAy la Form");
                        var xtraform = (XtraForm)Activator.CreateInstance(type);
                        if (xtraform != null)
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
                    //MessageBox.Show(obj.ToString() + " | " + obj.FunctionName + " | " + obj.FormName);
                }
               
                AccordionControlElement acRootAccount = new AccordionControlElement();
                AccordionControlElement acViewAccount = new AccordionControlElement();
                AccordionControlElement acLogout = new AccordionControlElement();
          
                createDynamicMenu(acRootAccount,true, "acRootAccount",ElementStyle.Group,"", "Tài Khoản", "");
             
                createDynamicMenu(acViewAccount, false, "acViewAccount", ElementStyle.Item, "idAcViewAccount", "Thông tin tài khoản", "Settings;Office2013");
      
                createDynamicMenu(acLogout, false, "acLogout", ElementStyle.Item, "idAcLogout", "Đăng Xuất", "Settings;Office2013");
          
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
                if (item != null)
                {
                    Type type = Type.GetType(item.Tag.ToString());

                    string str1 = type.ToString().ToUpper();
                    string str2 = "UC_";
                    bool checkExists = str1.Contains(str2);
                    if (checkExists)
                    {
                        //MessageBox.Show("DAy la usercontrol");
                        var uc_ = (XtraUserControl)Activator.CreateInstance(type);
                        if (uc_ != null)
                        {
                  
                            addControlToMain(uc_);

                        }
                    }
                    else
                    {
                        //  MessageBox.Show("DAy la Form");
                        var xtraform = (XtraForm)Activator.CreateInstance(type);
                        if (xtraform != null)
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
            addControlToMain(uc__designDashboard);
        }
        private void loadDesignDashboardViewer()
        { 
            uc__designDashboardViewer = new Uc_DashboardViewer();
            addControlToMain(uc__designDashboardViewer);
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
            uC__RoleManagement = new UC_RoleManagement();
            addControlToMain(uC__RoleManagement);
        }

        private void mnQLFunctions_Click(object sender, EventArgs e)
        {

        
            uC__FunctionRoleManagement = new UC_FunctionManagement();
            addControlToMain(uC__FunctionRoleManagement);

        }

        private void mnQLFunctionRole_Click(object sender, EventArgs e)
        {
     
            UC_AuthenticationManager = new UC_AuthenticationManager();
            addControlToMain(UC_AuthenticationManager);
 

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