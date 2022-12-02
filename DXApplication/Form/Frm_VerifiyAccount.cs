using DevExpress.XtraEditors;
using DXApplication.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication.Form
{
    public partial class Frm_VerifiyAccount : DevExpress.XtraEditors.XtraForm
    {
        User userThis;
        int otpThis;

        public Frm_VerifiyAccount(User user,int otp)
        {
            this.userThis = user;
            this.otpThis = otp;
            InitializeComponent();
        }
        db_final_winformEntities db;
        private void Frm_VerifiyAccount_Load(object sender, EventArgs e)
        {
            db = new db_final_winformEntities();
         
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {

                if (txbVerifiedCode.Text.Equals(otpThis.ToString()))
                {
                    db.Users.Add(userThis);
                  
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký người dùng thành công");
                    this.Close();
                    Frm_Login frm_Login = new Frm_Login();
                    frm_Login.Show();

                }
                else
                {
                    MessageBox.Show("Mã xác thực sai vui lòng kiểm tra lại!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}