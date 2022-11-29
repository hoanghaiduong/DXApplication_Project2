using DevExpress.Utils.MVVM;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
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
using DevExpress.XtraExport.Helpers;
using System.Data.Entity;

namespace DXApplication.UI
{
    public partial class UC_FunctionManagement : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_FunctionManagement()
        {
            InitializeComponent();

          
        }
        db_final_winformEntities _db_;
        private void loadData()
        {
            _db_ = new db_final_winformEntities();
           
            functionBindingSource.DataSource = _db_.Functions.ToList();
            List<AppForm> appForms = new List<AppForm>();
            appForms.Add(new AppForm()
            {
                Id= "DXApplication.UI.UC_RoleManagement",
                FormName="Role"
            });
            appForms.Add(new AppForm()
            {
                Id = "DXApplication.UI.UC_UserManagement",
                FormName = "User"
            });
            appForms.Add(new AppForm()
            {
                Id = "DXApplication.UI.UC_FunctionManagement",
                FormName = "Function"
            });
            appForms.Add(new AppForm()
            {
                Id = "DXApplication.Frm_Module1",
                FormName = "Module 1"
            });
            appForms.Add(new AppForm()
            {
                Id = "DXApplication.Frm_Module2",
                FormName = "Module 2"
            });
            lookupEditFormName.DataSource = appForms;
            lookupEditFormName.ValueMember = "Id";
            lookupEditFormName.DisplayMember = "FormName";
            lookupEditFormName.PopulateColumns();
            lookupEditFormName.Columns["Id"].Visible = false;
            
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlFunctions.ShowRibbonPrintPreview();
        }
      

        private void btnFAddNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Function function = new Function();
            functionBindingSource.Add(function);
            functionBindingSource.MoveLast();
            _db_.Functions.Add(function);
        }

        private async void btnFEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                functionBindingSource.EndEdit();
                await _db_.SaveChangesAsync();
                dtgvFunctions.RefreshData();
                MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xoá mục này không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _db_.Functions.Remove(functionBindingSource.Current as Function);
                functionBindingSource.RemoveCurrent();
            }
        }

        private void btnFRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadData();
        }

        private void gridControlFunctions_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void UC_FunctionRoleManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }
      
     
        private void btnDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            MessageBox.Show(dtgvFunctions.GetRowCellValue(dtgvFunctions.FocusedRowHandle, "FormName").ToString());
            MessageBox.Show(dtgvFunctions.GetRowCellValue(dtgvFunctions.FocusedRowHandle, "FunctionId").ToString());
            FormDetails formDetails = new FormDetails(functionBindingSource.Current as Function);
            formDetails.ShowDialog();
        }
    }
}
