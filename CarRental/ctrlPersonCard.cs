using CarRental.Properties;
using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static CarRental.ctrlPersonCard;
using System.Runtime.CompilerServices;

namespace CarRental
{
    
    public partial class ctrlPersonCard : UserControl
    {
       public delegate  ctrlPersonInfo.stPersonInfo PersonDetalis(int ID) ;
       PersonDetalis _personDetalis;
        public int ProfileID {  get; set; }


        clsSettingLoader.Edit _EditionForm;
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        private ctrlPersonInfo.stPersonInfo _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public ctrlPersonInfo.stPersonInfo SelectedPersonInfo
        {
            get { return _Person; }
        }

      

        public void LoadPersonInfo(int ProfileID)
        {
            _Person = _personDetalis(ProfileID);
            if (_Person.PersonID == -1)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + ProfileID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        /*public void LoadPersonInfo(string NationalNo)
        {
            _Person = 
            if (_Person.PersonID == -1)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }*/

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
            
              pbPersonImage.Image = Resources.MaleUser;
            
            else
              pbPersonImage.Image = Resources.FemaleUser;
           
            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FirstName+' '+_Person.SecondName+' '+ _Person.ThirdName+' '+ _Person.LastName;
            lblGendor.Text = _Person.Gender == 0 ? "Male" : "Female";
           pbGendor.Image = _Person.Gender == 0 ? Resources.Male_Gendar : pbGendor.Image = Resources.FemaleGendar;
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblAddress.Text = _Person.Address;
            _LoadPersonImage();




        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
           pbGendor.Image = Resources.Male_Gendar;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.MaleUser;

        }
        
        public void SetPersonCardSetting(PersonDetalis detalis, clsSettingLoader.Edit EditionForm)
        {
            this._personDetalis = detalis;
            this._EditionForm = EditionForm;
        }
        
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _EditionForm(ProfileID,false);
            //refresh
            LoadPersonInfo(ProfileID);
        }
    }
}
