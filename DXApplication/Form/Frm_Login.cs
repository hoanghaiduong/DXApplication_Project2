using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DXApplication.Entity;
using DXApplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication.Form
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            _instance = this;
            db=new db_final_winformEntities();
         
            //loading Splash Screen
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
            }

            try
            {
                // loadDesignDashboardViewer();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi nè", ex.Message);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            
            Frm_Register frm_Register = new Frm_Register();
            frm_Register.Show();
            SplashScreenManager.CloseForm();



        }
        db_final_winformEntities db;
        private static Frm_Login _instance;

        public static Frm_Login Instance 
        { 
            get
            {
                if(_instance == null )
                {
                    _instance = new Frm_Login();

                }    
                return _instance;
            }
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sql = db.Users.Where(p=>p.UserName==txbUsername.Text&&p.Password==txbPassword.Text).SingleOrDefault();
            if (sql != null)
            {

                Cls_Main.UserInfo = sql;
                this.Hide();
                Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
                frm_Dashboard.ShowDialog();
            }    
         
          else
            {
                MessageBox.Show("Your username and password don't match","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
         
        }
    }
}