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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication.Form
{
    public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        Uc__designDashboard uc__designDashboard;
        Uc_DashboardViewer uc__designDashboardViewer;
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void LoadDesignDashboard()
        {
            uc__designDashboard = new Uc__designDashboard();
            uc__designDashboard.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(uc__designDashboard);
            uc__designDashboard.BringToFront();
        }
        private void loadDesignDashboardViewer()
        {
            uc__designDashboardViewer = new Uc_DashboardViewer();
            uc__designDashboardViewer.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(uc__designDashboardViewer);
            uc__designDashboardViewer.BringToFront();
        }
     
        private void Frm_Main_Load(object sender, EventArgs e)
        {
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

    

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Global_WaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Loading ...");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }

      
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}