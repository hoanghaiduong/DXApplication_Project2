using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DXApplication.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication.UI
{
    public partial class UC_UserManagement : DevExpress.XtraEditors.XtraUserControl
    {

        public UC_UserManagement()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlUsers.ShowRibbonPrintPreview();
        }



        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            User user = new User();
            userBindingSource.Add(user);
            userBindingSource.MoveLast();
            _db_.Users.Add(user);
        }

        private async void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                userBindingSource.EndEdit();
                await _db_.SaveChangesAsync();
                dtgvUsers.RefreshData();
                MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }
        db_final_winformEntities _db_;
        private void loadUserData()
        {
            _db_ = new db_final_winformEntities();
            userBindingSource.DataSource = _db_.Users.ToList();
            if(Cls_Main.UserInfo.RoleId==1)
            {
                dtgvUsers.OptionsBehavior.Editable = true;
                dtgvUsers.OptionsBehavior.ReadOnly = false;
                dtgvUsers.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplaceHideCurrentRow;

            }
            else
            {
                dtgvUsers.OptionsBehavior.Editable = false;
                dtgvUsers.OptionsBehavior.ReadOnly = true;
                MessageBox.Show("Bạn không có quyền chỉnh sửa !");
            }    
        }
        private void UC_UserManagement_Load(object sender, EventArgs e)
        {
            loadUserData();
        }

        private async void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                userBindingSource.EndEdit();
                await _db_.SaveChangesAsync();
                dtgvUsers.RefreshData();
                MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xoá người dùng này không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _db_.Users.Remove(userBindingSource.Current as User);
                userBindingSource.RemoveCurrent();
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

            loadUserData();
        }

        private void btnDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDetails formDetails = new FormDetails(userBindingSource.Current as User);
            formDetails.ShowDialog();
        }
    }
}
