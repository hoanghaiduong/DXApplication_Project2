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
    public partial class UC_AuthenticationManager : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_AuthenticationManager()
        {
            InitializeComponent();

           
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
      
     
        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if(functionRoleBindingSource.DataSource != null)
            {
                Role role = cbRole.SelectedItem as Role;
                if (role != null)
                {
                    foreach (DataGridViewRow row in dtgvFunctionRole.SelectedRows)
                    {
                        FunctionRole functionRole = row.DataBoundItem as FunctionRole;
                        if(functionRole!=null)
                        {
                            db.FunctionRoles.Remove(functionRole);
                            functionRoleBindingSource.Remove(functionRole);
                        }    
                    }
                   await db.SaveChangesAsync();
                }    
            }    
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (functionRoleBindingSource.DataSource != null)
            {
                Role role = cbRole.SelectedItem as Role;
                if (role != null)
                {
                    foreach (DataGridViewRow row in dtgvFunction.SelectedRows)
                    {
                        Function function = row.DataBoundItem as Function;
                        if (function != null)
                        {
                            FunctionRole fr = db.FunctionRoles.Where(p => p.FunctionId == function.FunctionId && p.RoleId == role.RoleId).SingleOrDefault();
                            if(fr==null)
                            {
                                FunctionRole obj = new FunctionRole()
                                {
                                    FunctionId = function.FunctionId,
                                    RoleId = role.RoleId
                                };
                                db.FunctionRoles.Add(obj);
                            }    

                        }
                    }
                    await db.SaveChangesAsync();
                    functionRoleBindingSource.DataSource = db.FunctionRoles.Where(r => r.RoleId == role.RoleId).ToList();
                }
            }
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }
        db_final_winformEntities db;
        private void UC_AuthenticationManager_Load(object sender, EventArgs e)
        {
            db = new db_final_winformEntities();
            roleBindingSource.DataSource = db.Roles.ToList();
            functionBindingSource.DataSource = db.Functions.ToList();
            Role role = cbRole.SelectedItem as Role;
            if(role!=null)
            {
                functionRoleBindingSource.DataSource=db.FunctionRoles.Where(r=>r.RoleId==role.RoleId).ToList();
            }    
        }

        private void cbRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Role role = cbRole.SelectedItem as Role;
            if (role != null)
            {
                functionRoleBindingSource.DataSource = db.FunctionRoles.Where(r => r.RoleId == role.RoleId).ToList();
            }
        }
    }
}
