using DXApplication.Entity;
using System.Net.Mail;
using System.Net;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DXApplication
{
    public class Cls_Main
    {
        private static User userInfo;
        private static bool _isLogout;

        public static User UserInfo { get => userInfo; set => userInfo = value; }
        public static bool IsLogout { get => _isLogout; set => _isLogout = value; }
        public static bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;


            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất 1 chữ thường !";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất 1 chữ hoa !";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải từ 8 đến 15 kí tự !";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất 1 số !";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất 1 kí tự đặc biệt !";
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool isEmail(string inputEmail)
        {

            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static void sendMail(string to, string subject, string body)
        {
            MailMessage mailMessage = new MailMessage("hoanghaiduong1711@gmail.com", to);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            NetworkCredential networkCredential = new NetworkCredential("hoanghaiduong1711@gmail.com", "oysgpdcgcujpmoua");
            smtp.Credentials = networkCredential;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mailMessage);
                MessageBox.Show("Send Mail successfully to " + to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
