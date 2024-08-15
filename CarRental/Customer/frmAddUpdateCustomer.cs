using CarRental_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddUpdateCustomer : Form
    {
        public delegate void DataBackEventHandler(object sender, int UserID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };


        private enMode _Mode;
        private int _ProfileID;
        private ctrlPersonInfo.stPersonInfo _Person;
        private clsCustomer _Customer;

        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

       public frmAddUpdateCustomer(int ProfileID,bool EnableCustomerInfo=true)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _ProfileID = ProfileID;
            gpCustomerInfo.Enabled = EnableCustomerInfo;
        }

       private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Customer";
                ctrlPersonInfo1.SetDefalutVales();
                _Customer = new clsCustomer();
            }
            else
            {
                lblTitle.Text = "Update Customer";
            }
            ctrlPersonInfo1.ResetDefualtValues();
            lblCustomerID.Text = "???";
            txtLicenseNo.Text = "";

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

       private void _LoadData()
        {

            _Customer = clsCustomer.Find(_ProfileID);

            if (_Customer == null)
            {
                MessageBox.Show("No Customer with ID = " + _ProfileID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            ctrlPersonInfo1.LoadData(_ProfileID, clsPersonInfoData.PersonDataOfCustomer);//

            /*the following code will not be executed if the person was not found
              lblPersonID.Text = _Customer.PersonID.ToString();
              txtFirstName.Text = _Customer.FirstName;
              txtSecondName.Text = _Customer.SecondName;
              txtThirdName.Text = _Customer.ThirdName;
              txtLastName.Text = _Customer.LastName;
              txtNationalNo.Text = _Customer.NationalNo;
              dtpDateOfBirth.Value = _Customer.DateOfBirth;

              if (_Customer.Gender == 0)
                  rbMale.Checked = true;
              else
                  rbFemale.Checked = true;

              txtAddress.Text = _Customer.Address;
              txtPhone.Text = _Customer.Phone;
              txtEmail.Text = _Customer.Email;
              cbCountry.SelectedIndex = cbCountry.FindString(_Customer.CountryInfo.CountryName);


              //load person image incase it was set.
              if (_Customer.ImagePath != "")
              {
                  pbPersonImage.ImageLocation = _Customer.ImagePath;

              }

              //hide/show the remove linke incase there is no image for the person.
              llRemoveImage.Visible = (_Customer.ImagePath != "");
  */

            lblCustomerID.Text = _ProfileID.ToString();
            txtLicenseNo.Text = _Customer.DriverLicenseNumber.ToString();
          
           

        }
       
       private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
            //ctrlPersonInfo1.LoadData(_ProfileID, clsPersonInfoData.PersonDataOfUser);
        }

       private void txtLicenseNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

       private void btnSave_Click_1(object sender, EventArgs e)
       {

            if (!ctrlPersonInfo1.GetPersonData(ref _Person))
            {
                return;
            }

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some  fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            //byte NationalityCountryID = (byte)clsCountry.Find(cbCountry.Text).ID;

            _Customer.FirstName = _Person.FirstName;
            _Customer.SecondName = _Person.SecondName;
            _Customer.ThirdName = _Person.ThirdName;
            _Customer.LastName = _Person.LastName;
            _Customer.NationalNo = _Person.NationalNo;
            _Customer.Email = _Person.Email;
            _Customer.Phone = _Person.Phone;
            _Customer.Address = _Person.Address;
            _Customer.DateOfBirth = _Person.DateOfBirth;
            _Customer.Gender = _Person.Gender;
            _Customer.NationalityCountryID = _Person.NationalityCountryID;
            _Customer.ImagePath = _Person.ImagePath;
            _Customer.DriverLicenseNumber = Convert.ToInt32(txtLicenseNo.Text);




            if (_Customer.Save())
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                ctrlPersonInfo1.SetPersonID((int)_Customer.PersonID);

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, (int)_Customer.CustomerID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtLicenseNo_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseNo, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLicenseNo, null);
            }
        }
    }
}
