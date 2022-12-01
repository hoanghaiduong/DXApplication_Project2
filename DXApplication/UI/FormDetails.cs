using DXApplication.Entity;
using System;
using System.Linq;
using System.Windows.Forms;


namespace DXApplication.UI
{
    public partial class FormDetails : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        db_final_winformEntities _db_;
        public FormDetails()
        {
            InitializeComponent();

        }
        User user;
        Person person;
        public FormDetails(User user)
        {
            this.user = user;
           
          
            InitializeComponent();
        }
        private void FormDetails_Load(object sender, EventArgs e)
        {
            _db_ = new db_final_winformEntities();
            var sql = _db_.Persons.Where(item => item.UserId.Equals(user.UserId)).SingleOrDefault();
            txbEmail.Text = user.Email;
            txbFirstName.Text = sql.Profile.FirstName;
            txbLastName.Text = sql.Profile.LastName;
            txbPhone.Text = sql.Profile.PhoneNumber;
            dateOfBirthEdit.DateTime= sql.Profile.DateOfBirth.Value;
            cbLookUpGender.Properties.DataSource = sql.Profile.Gender.Value;

        }
        private async void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //var functionName = _db_.Functions.First(a => a.FunctionName == functions.FunctionName);
                //functionName.FunctionName = functions.FunctionName = txbEmail.Text;

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
                //var functionName = _db_.Functions.First(a => a.FunctionName == functions.FunctionName);
                //functionName.FunctionName = functions.FunctionName = txbEmail.Text;

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
            FormDetails formDetails = new FormDetails(this.user);
            formDetails.ShowDialog();
        }
    }
}
