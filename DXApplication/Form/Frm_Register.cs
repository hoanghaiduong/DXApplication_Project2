using DXApplication.Entity;
using System;
using System.Windows.Forms;

namespace DXApplication.Form
{
    public partial class Frm_Register : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Register()
        {
            InitializeComponent();
        }

        private void Frm_Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            //db = new db_final_winformEntities();
            
            
        }
        //db_final_winformEntities db;
        User user;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txbUsername.Text))
                {
                    if (!string.IsNullOrEmpty(txbPassword.Text))
                    {
                        if (!string.IsNullOrEmpty(txbRepeatPass.Text))
                        {

                            if (txbPassword.Text.Equals(txbRepeatPass.Text))
                            {
                                if (!string.IsNullOrEmpty(txbEmail.Text))
                                {
                                    if (Cls_Main.isEmail(txbEmail.Text))
                                    {
                                        int num = new Random().Next(100000, 999999);
                                        user = new User();
                                        user.UserName = txbUsername.Text;
                                        user.Password = txbPassword.Text;
                                        user.RoleId = 2;
                                        user.Email = txbEmail.Text;
                                        user.Disabled = false;
                                        user.Otp = num;
                                        user.VerifiedEmail = false;

                                        Cls_Main.sendMail(txbEmail.Text, "Xác minh email của bạn", "Mã OTP của bạn là :" + num);
                                        Frm_VerifiyAccount frm_VerifiyAccount = new Frm_VerifiyAccount(user,num);
                                        frm_VerifiyAccount.ShowDialog();
                                       
                                    }
                                    else
                                    {
                                        //txb email
                                        //repeat pass
                                        MessageBox.Show("Chưa đúng định dạng Email \n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txbEmail.Focus();
                                    }
                                }
                                else
                                {
                                    //txb email
                                    //repeat pass
                                    MessageBox.Show("Chưa nhập Email \n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txbEmail.Focus();
                                }
                            }
                            else
                            {
                                //repeat pass
                                MessageBox.Show("Mật khẩu nhập lại không khớp\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txbRepeatPass.Focus();
                            }
                        }
                        else
                        {
                            //repeat pass
                            MessageBox.Show("Mật khẩu nhập lại không được trống\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbRepeatPass.Focus();
                        }
                    }
                    else
                    {
                        //password
                        MessageBox.Show("Chưa nhập mật khẩu\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbPassword.Focus();
                    }
                }
                else
                {
                    //Username
                    MessageBox.Show("Chưa nhập tài khoản\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }   
        
            
        }
    }
}