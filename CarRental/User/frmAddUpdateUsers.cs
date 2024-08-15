using CarRental.Properties;
using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddUpdateUsers : Form
    {
        public delegate void DataBackEventHandler(object sender, int UserID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        

        private enMode _Mode;
        private int _ProfileID;
        private ctrlPersonInfo.stPersonInfo _Person;
        private clsUser _User;
        public frmAddUpdateUsers()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        
        public frmAddUpdateUsers(int ProfileID,bool CloseLoginInfo=true)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _ProfileID = ProfileID;
            tpLoginInfo.Enabled = CloseLoginInfo;


        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
               //ctrlPersonInfo1.SetDefalutVales();
                _User = new clsUser();
            }
            else
            {
                lblTitle.Text = "Update User";
            }
           ctrlPersonInfo1.ResetDefualtValues();


            //this will initialize the reset the defaule values


            /*_FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _Person = new ctrlPersonInfo.stPersonInfo();
            }
            else
            {
                lblTitle.Text = "Update User";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.user__1_;
            else
                pbPersonImage.Image = Resources.user__2_;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountry.SelectedIndex = cbCountry.FindString("Saudi Arabia");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtSalary.Text = "";*/



        }

        /*private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
*/

        private void _LoadData()
        {

            _User = clsUser.Find(_ProfileID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _ProfileID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            ctrlPersonInfo1.LoadData(_ProfileID, clsPersonInfoData.PersonDataOfUser);
            
            /*the following code will not be executed if the person was not found
              lblPersonID.Text = _User.PersonID.ToString();
              txtFirstName.Text = _User.FirstName;
              txtSecondName.Text = _User.SecondName;
              txtThirdName.Text = _User.ThirdName;
              txtLastName.Text = _User.LastName;
              txtNationalNo.Text = _User.NationalNo;
              dtpDateOfBirth.Value = _User.DateOfBirth;

              if (_User.Gender == 0)
                  rbMale.Checked = true;
              else
                  rbFemale.Checked = true;

              txtAddress.Text = _User.Address;
              txtPhone.Text = _User.Phone;
              txtEmail.Text = _User.Email;
              cbCountry.SelectedIndex = cbCountry.FindString(_User.CountryInfo.CountryName);


              //load person image incase it was set.
              if (_User.ImagePath != "")
              {
                  pbPersonImage.ImageLocation = _User.ImagePath;

              }

              //hide/show the remove linke incase there is no image for the person.
              llRemoveImage.Visible = (_User.ImagePath != "");
  */
           
            lblUserID.Text = _ProfileID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text= _User.Password;
            txtSalary.Text = _User.Salary.ToString();
            chkIsActive.Checked = _User.IsActive;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsUser.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.isUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!txtPassword.Enabled) { return; }
            if (txtPassword.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "The Password is required");
                return;
            }

            if (txtPassword.PasswordMode)
            {
                if (!txtPassword.IsPasswordValid())
                {
                    if (!txtPassword.LengthCondition)
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtPassword, "The Password Should between 16 and 32 characters");
                        return;
                    }

                    if (!txtPassword.NumberRequired)
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtPassword, "The Password Should Have a number");
                        return;
                    }

                    if (!txtPassword.CaptialRequired)
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtPassword, "The Password Should Have a Captial Letter");
                        return;
                    }

                }

                else
                {
                    errorProvider1.SetError(txtPassword, null);
                }
            }
        }
        
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!txtConfirmPassword.Enabled) { return; }
            
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }
      
        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues(); 

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ctrlPersonInfo1.GetPersonData(ref _Person))
            {
                return;

            }
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some User fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }





            _User.FirstName = _Person.FirstName;
            _User.SecondName = _Person.SecondName;
            _User.ThirdName =   _Person.ThirdName;
            _User.LastName = _Person.LastName;
            _User.NationalNo = _Person.NationalNo;
            _User.Email=_Person.Email;
            _User.Phone= _Person.Phone;
            _User.Address= _Person.Address;
            _User.DateOfBirth = _Person.DateOfBirth;
            _User.Gender = _Person.Gender;
            _User.NationalityCountryID = _Person.NationalityCountryID;
            _User.ImagePath = _Person.ImagePath;
            _User.UserName=txtUserName.Text;
            _User.Password=txtPassword.Text;
            _User.IsActive=chkIsActive.Checked;
            _User.Salary = Convert.ToSingle(txtSalary.Text);

           

            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                ctrlPersonInfo1.SetPersonID ((int)_User.PersonID);

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, (int)_User.UserID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
