using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.Xpo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication.UI
{
    public partial class Uc_DashboardViewer : UserControl
    {
        public Uc_DashboardViewer()
        {
            InitializeComponent();
        }

        

        private void dashboardViewer_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
           

            if (e.DataSourceName == "SQL Data Source 1")
            {
                SqlServerConnectionParametersBase connectionParameters = (SqlServerConnectionParametersBase)e.ConnectionParameters;
                connectionParameters.DatabaseName = "dev_express_database";
                connectionParameters.UserName = "hoanghaiduong";
                connectionParameters.Password = "Yeutuan1";
                connectionParameters.ServerName = "localhost";
            }
        }

        private void dashboardViewer_Load(object sender, EventArgs e)
        {
       
            dashboardViewer.ConfigureDataConnection += dashboardViewer_ConfigureDataConnection;
            dashboardViewer.LoadDashboard(@"..\..\dashboard_XML.xml");

        }
    }
}
