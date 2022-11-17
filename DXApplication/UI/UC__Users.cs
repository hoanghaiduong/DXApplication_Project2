using DevExpress.XtraSplashScreen;
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
    public partial class UC__Users : UserControl
    {
        public UC__Users()
        {
            InitializeComponent();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void UC__Users_Load(object sender, EventArgs e)
        {
           
            gcDanhSach.DataSource = cls_ConnectSQL.getData("SELECT * From Persons");
        }
    }
}
