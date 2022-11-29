using DXApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication
{
    public class Cls_Main
    {
        private static User userInfo;
        private static bool _isLogout;

        public static User UserInfo { get => userInfo; set => userInfo = value; }
        public static bool IsLogout { get => _isLogout; set => _isLogout = value; }
    }
}
