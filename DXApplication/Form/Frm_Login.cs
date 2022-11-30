using DevExpress.Utils.Design;
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
using System.Xml.Schema;

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
             
                if (Properties.Settings.Default.UserName != string.Empty)
                {
                    txbUsername.Text = Properties.Settings.Default.UserName;
                    txbPassword.Text = Properties.Settings.Default.Password;
                    switchToggleRemember.IsOn = true;
                }
               
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
            for (int i = 0; i < 50; i++)
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
            var sql = db.Users.Where(
                p=>
                p.UserName.Equals(txbUsername.Text)&&p.Password.Equals(txbPassword.Text)
                
            ).SingleOrDefault();
            if (sql != null)
            {

                Cls_Main.UserInfo = sql;
                this.Hide();
                Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
                frm_Dashboard.ShowDialog();
            }    
         
          else
            {
                MessageBox.Show("Your username or Email and password don't match","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
         
        }

        private void switchToggleRemember_Toggled(object sender, EventArgs e)
        {
            if(switchToggleRemember.IsOn)
            {
             
                Properties.Settings.Default.UserName = txbUsername.Text;
                Properties.Settings.Default.Password = txbPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
            }
    
        }

        private void txbPassword_EditValueChanged(object sender, EventArgs e)
        {
             txbPassword.Properties.ContextImageOptions.Alignment = ContextImageAlignment.Far;
            string error = "";

            if (string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                lblPassError.Text = "";
                txbPassword.Properties.ContextImageOptions.ImageUri.Uri = "";
            }
            else if (Cls_Main.ValidatePassword(txbPassword.Text, out error))
            {
                lblPassError.Text = "";
                txbPassword.Properties.ContextImageOptions.ImageUri.Uri = "Apply;Size16x16;Svg";
            }
            else
            {
                lblPassError.Text = error;
                txbPassword.Properties.ContextImageOptions.ImageUri.Uri = "Cancel;Size16x16;Svg";
            }    
        }
    }
}