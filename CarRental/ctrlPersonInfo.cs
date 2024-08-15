using CarRental.Properties;
using CarRental_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{

    public partial class ctrlPersonInfo : UserControl
    {
        public struct stPersonInfo
        {
           public int PersonID ;
           public string NationalNo ;
           public string FirstName;
           public string SecondName;
           public string ThirdName;
           public string LastName;
           public DateTime DateOfBirth;
           public byte Gender;
           public string Address;
           public string Phone;
           public string Email;
           public byte NationalityCountryID;
           public string ImagePath;
        };

        public enum enGendor { Male = 0, Female = 1 };
        
        
        
        private stPersonInfo _Person;

        public void SetPersonID(int personID)
        {
            lblPersonID.Text = personID.ToString();
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        public void ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            /*if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _Person = new clsUser();
            }
            else
            {
                lblTitle.Text = "Update User";
            }*/

            //set default image for the person.
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.FemaleUser;
            else
                pbPersonImage.Image = Resources.MaleUser;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountry.SelectedIndex = cbCountry.FindString("Saudi Arabia");
           // cbPhoneCountry.SelectedIndex=

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
           



        }
        
        public bool GetPersonData(ref stPersonInfo personInfo)
        {
            /*if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some Person fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;

            }*/
            if (!_HandlePersonImage())
                return false;
            byte NationalityCountryID = (byte)clsCountry.Find(cbCountry.Text).ID;
           
            //personInfo.PersonID =Convert.ToInt32( lblPersonID.Text);
            personInfo.FirstName = txtFirstName.Text.Trim();
            personInfo.SecondName = txtSecondName.Text.Trim();
            personInfo.ThirdName = txtThirdName.Text.Trim();
            personInfo.LastName = txtLastName.Text.Trim();
            personInfo.NationalNo = txtNationalNo.Text.Trim();
            personInfo.Email = txtEmail.Text.Trim();
            personInfo.Phone = txtPhone.Text.Trim();
            personInfo.Address = txtAddress.Text.Trim();
            personInfo.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                personInfo.Gender = (byte)enGendor.Male;
            else
                personInfo.Gender = (byte)enGendor.Female;

                personInfo.NationalityCountryID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                personInfo.ImagePath = pbPersonImage.ImageLocation;
            else
                personInfo.ImagePath = "";

            return true;
        


        }
        
        public void SetDefalutVales()
        {

            _Person.PersonID = -1;
            _Person.FirstName = "";
            _Person.SecondName = "";
            _Person.ThirdName = "";
            _Person.LastName = "";
            _Person.DateOfBirth = DateTime.Now;
            _Person.Address = "";
            _Person.Phone = "";
            _Person.Email = "";
            _Person.NationalityCountryID = 0;
            _Person.ImagePath = "";
        }
       
        public void LoadData(int ProfileID,Func<int ,stPersonInfo> LoadProfilePersonInfo)
        {

            _Person = LoadProfilePersonInfo(ProfileID);

            if (_Person.PersonID == -1)
            {
                MessageBox.Show("No Person Info  with  ID = " + ProfileID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            //the following code will not be executed if the person was not found
            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find( _Person.NationalityCountryID).CountryName);


            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.ImagePath != "");

           



        }
        
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath !="")// the old photo change to another
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbPersonImage.ImageLocation = null;



            if (rbMale.Checked)
                pbPersonImage.Image = Resources.MaleUser;
            else
                pbPersonImage.Image = Resources.FemaleUser;

            llRemoveImage.Visible = false;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.MaleUser;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsUser.IsUserExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "This field is required!");
            }


            //validate email format
            if (!clsValidatoin.ValidateSuadiArabiaPhoneNumber(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "Invalid phone number not match Suadi Arabia Phone Format!");
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            };
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.FemaleUser;
        }
    }
}
