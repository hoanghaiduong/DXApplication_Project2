using DXApplication.Entity;
using System.Text.RegularExpressions;

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
    }
}
