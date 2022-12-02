using DevExpress.XtraEditors;
using DXApplication.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
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
      
        public FormDetails(User user)
        {
            this.user = user;
           
          
            InitializeComponent();
        }
        public static List<T> EnumToList<T>(Enum someEnum)
        {
            List<T> list = new List<T>();

            foreach (var it in Enum.GetValues(someEnum.GetType()))
            {
                if ((Convert.ToByte(it) & Convert.ToInt32(someEnum)) != 0)
                {
                    list.Add((T)it);
                }
            }

            return list;
        }
     
        private void FormDetails_Load(object sender, EventArgs e)
        {

            try
            {
                _db_ = new db_final_winformEntities();
                List<GioiTinh> genders = new List<GioiTinh>();
                genders.Add(new GioiTinh()
                {

                    Gender = "1",
                    Id1 = "Nam",

                });
                genders.Add(new GioiTinh()
                {
                    Gender = "2",
                    Id1 = "Nữ",

                });

                var sql = _db_.Profiles.Where(item => item.ProfileId.Equals(user.ProfileId)).FirstOrDefault();
                var sql2= _db_.Profiles.SingleOrDefault(item => item.ProfileId.Equals(user.ProfileId));
                MessageBox.Show(sql2.ToString());
                MessageBox.Show(sql.ToString());
                cbLookUpGender.Properties.DataSource = genders;
                cbLookUpGender.Properties.DisplayMember = "Id1";
                cbLookUpGender.Properties.ValueMember = "Gender";
                txbEmail.Text = user.Email;
                searchLookUpDepartment.Properties.DataSource = _db_.Departments.ToList();
                searchLookUpDepartment.Properties.DisplayMember = "DepartmentName";
                searchLookUpDepartment.Properties.ValueMember = "DepartmentId";
                searchLookUpClasses.Properties.DataSource = _db_.Classes.ToList();
                searchLookUpClasses.Properties.DisplayMember = "ClassesName";
                searchLookUpClasses.Properties.ValueMember = "ClassId";

                searchLookUpType.Properties.DataSource = _db_.TypeAccountUsers.ToList();

                searchLookUpType.Properties.DisplayMember = "TypeName";
                searchLookUpType.Properties.ValueMember = "TypeId";


                searchLookUpDepartment.Properties.PopulateViewColumns();
                searchLookUpClasses.Properties.PopulateViewColumns();
                searchLookUpDepartment.Properties.PopupView.Columns["Profiles"].Visible = false;
                searchLookUpClasses.Properties.PopupView.Columns["Profiles"].Visible = false;
                if (sql != null)//if có person
                {

                    txbFirstName.Text = sql.FirstName;
                    txbLastName.Text = sql.LastName;
                    txbPhone.Text = sql.PhoneNumber;
                    dateOfBirthEdit.DateTime = sql.DateOfBirth.Value;


                    searchLookUpDepartment.EditValue = sql.Department;
                    searchLookUpClasses.EditValue = sql.Class;


                    //  searchLookUpType.Properties.PopupView.Columns["Persons"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Chưa có profile này vui lòng tạo");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
      
        Profile personProfile;
    
        private  void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                personProfile = new Profile();
                personProfile.DepartmentId = 1;
                personProfile.ClassId =1;
                personProfile.FirstName = txbFirstName.Text;
                personProfile.LastName = txbLastName.Text;
                personProfile.PhoneNumber = txbPhone.Text;
                personProfile.Gender = cbLookUpGender.Text == "Nam" ? 1 : 2;
                personProfile.DateOfBirth = dateOfBirthEdit.DateTime;
                personProfile.About = txbAbout.Text;
                personProfile.Addresses = txbAddress.Text;
                personProfile.Image = pictureEdit1.EditValue.ToString();
             
                // Convert.ToInt32(searchLookUpType.Properties.GetDisplayValueByKeyValue(searchLookUpDepartment.EditValue));
                _db_.Profiles.AddOrUpdate(personProfile);
                
                _db_.SaveChanges();
        
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
        public class GioiTinh
        {
            private string Id;
            private string Name;

            public string Id1 { get => Id; set => Id = value; }
            public string Gender { get => Name; set => Name = value; }
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

        private void cbLookUpGender_EditValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbLookUpGender.EditValue.ToString());
            MessageBox.Show(cbLookUpGender.Text);
        }
        private readonly string[] AllowableFileTypes = { ".jpg", ".jpeg", ".png", ".bmp" };
        private void pictureEdit1_DragOver(object sender, DragEventArgs e)
        {
            string fileType = "";
            string[] dropFiles = e.Data.GetData(DataFormats.FileDrop) as string[];

            //Don't allow multiple files  
            if (dropFiles?.Length > 1)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            //Don't allow non-files (ie directories) or non-image files  
            FileAttributes fileAttributes = File.GetAttributes(dropFiles[0]);
            fileType = Path.GetExtension(dropFiles[0]).ToLower();

            if (fileAttributes.HasFlag(FileAttributes.Directory) || !AllowableFileTypes.Contains(fileType))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.Copy;
        }

        private void pictureEdit1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropFiles = e.Data.GetData(DataFormats.FileDrop) as string[];

            //Just handle a single file  
            pictureEdit1.LoadAsync(dropFiles[0]);
        }
    }
}
