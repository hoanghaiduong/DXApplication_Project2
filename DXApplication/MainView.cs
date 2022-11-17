using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DashboardWin.Design;
using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.Utils.About;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DXApplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace DXApplication
{
    public partial class frm_Dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_Dashboard()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        UC__Users uC__Users;

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
           
            if (uC__Users==null)
            {
                uC__Users=new UC__Users();
                uC__Users.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uC__Users);
                uC__Users.BringToFront();
                SplashScreenManager.CloseForm();
            }    
            else
            {
                uC__Users.BringToFront();
                SplashScreenManager.CloseForm();
            }    
        }
   
        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            //loading Splash Screen
            for(int i=0;i<50;i++)
            {
                Thread.Sleep(100);
            }
            try
            {
               
                mainContainer.Controls.Add(new Uc_DashboardViewer() { Dock = DockStyle.Fill });
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi nè",ex.Message);
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
            mainContainer.Controls.Add(new Uc__designDashboard() { Dock = DockStyle.Fill });
        }
    }
}
//1.Tải và cài đặt thư viện DevExpress + crack full + keygen
//2.Tạo Project DXWindowForm
//3.Sử dụng Template tùy ý (ở đây chọn Fluent)
//4.Tạo User Control(Bar manager)
//5.Tạo Grid control và dock parent in container
//6.Tạo Class kết nối đến Cơ Sở Dữ Liệu