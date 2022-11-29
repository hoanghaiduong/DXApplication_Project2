using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraRichEdit.Model;
using DXApplication.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Function = DXApplication.Entity.Function;

namespace DXApplication.UI
{
    public partial class FormDetails : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        db_final_winformEntities _db_;
        public FormDetails()
        {
            InitializeComponent();
         
        }
        Function functions;
        public FormDetails(Function function)
        {
             this.functions=function;
            InitializeComponent();
        }
        private void FormDetails_Load(object sender, EventArgs e)
        {
            _db_ = new db_final_winformEntities();
          
            txbEmail.Text = functions.FunctionName;
        }
        private async void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var functionName = _db_.Functions.First(a => a.FunctionName == functions.FunctionName);
                functionName.FunctionName = functions.FunctionName = txbEmail.Text;
              
                await _db_.SaveChangesAsync();
                MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var functionName = _db_.Functions.First(a => a.FunctionName == functions.FunctionName);
                functionName.FunctionName = functions.FunctionName = txbEmail.Text;

                await _db_.SaveChangesAsync();
                MessageBox.Show("Your data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FormDetails formDetails = new FormDetails(this.functions);
            formDetails.ShowDialog();
        }
    }
}
