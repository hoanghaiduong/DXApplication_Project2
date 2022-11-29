using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DXApplication.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication.UI
{
    public partial class UC_RoleManagement : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_RoleManagement()
        {
            InitializeComponent();
        }
        db_final_winformEntities _db_;
        private void loadData()
        {
            _db_ = new db_final_winformEntities();
            roleBindingSource.DataSource = _db_.Roles.ToList();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlRoles.ShowRibbonPrintPreview();
        }
    
      
        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void UC_RoleManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Role role = new Role();
            roleBindingSource.Add(role);
            roleBindingSource.MoveLast();
            _db_.Roles.Add(role);
        }

        private async void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                roleBindingSource.EndEdit();
            await _db_.SaveChangesAsync();
            dtgvRoles.RefreshData();
            MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xoá quyền này không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _db_.Roles.Remove(roleBindingSource.Current as Role);
                roleBindingSource.RemoveCurrent();
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
