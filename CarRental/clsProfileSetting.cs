using CarRental_BusinessLayer;
using Guna.UI.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CarRental.Properties;

namespace CarRental
{

   

    public static class clsProfileCardSetting
    {

        private static clsUser _LoadUserInfo(int UserID)
        {
            clsUser _User = clsUser.Find(UserID);
            if (_User == null)
            {
                //_ResetUserInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return _User;

           
        }

        private static clsCustomer _LoadCustomerInfo(int CustomerID)
        {
            clsCustomer _Customer = clsCustomer.Find(CustomerID);
            if (_Customer == null)
            {
                //_ResetUserInfo();
                MessageBox.Show("No Customer with _CustomerID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return _Customer;


        }
        
        private static clsMechanic _LoadMechanicInfo(int MechanicID)
        {
            clsMechanic _Mechanic = clsMechanic.Find(MechanicID);
            if (_Mechanic == null)
            {
                //_ResetUserInfo();
                MessageBox.Show("No _Mechanic with MechanicID = " + _Mechanic.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return _Mechanic;


        }

        public static void LoadingUserProfile(int ProfileID,GunaLabel Title, GunaLabel subTitle, PictureBox ProfilePictureBox)
        {
            clsUser _User = _LoadUserInfo(ProfileID);

            if (_User !=null)
            {
                Title.Text = _User.UserName;
                subTitle.Text = _User.CountryInfo.CountryName;
                ProfilePictureBox.Tag= _User.UserID;
                if (_User.ImagePath != null)
                {
                    if (File.Exists(_User.ImagePath))
                    {

                        ProfilePictureBox.ImageLocation=_User.ImagePath;

                    }
                   
                    else
                    {
                        ProfilePictureBox.Image = (_User.Gender == 0) ? ProfilePictureBox.Image = Resources.MaleUser : ProfilePictureBox.Image = Resources.FemaleUser;

                    }
                }
            }

        }

        public static void LoadinCustomerProfile(int ProfileID, GunaLabel Title, GunaLabel subTitle, PictureBox ProfilePictureBox)
        {
            clsCustomer _Customer = _LoadCustomerInfo(ProfileID);

            if (_Customer != null)
            {
               /* Title.Width += 25;
                subTitle.Width += 25;*/
                Title.Text = _Customer.FirstName+' '+_Customer.LastName;
                subTitle.Text = _Customer.CountryInfo.CountryName;
                ProfilePictureBox.Tag = _Customer.CustomerID;
                if (_Customer.ImagePath != null)
                {
                    if (File.Exists(_Customer.ImagePath))
                    {
                        
                        ProfilePictureBox.ImageLocation = _Customer.ImagePath;

                    }
                    else
                    {
                        ProfilePictureBox.Image=(_Customer.Gender==0)? ProfilePictureBox.Image = Resources.MaleUser: ProfilePictureBox.Image = Resources.FemaleUser;

                    }
                }

            }

        }
        
        public static void LoadingMechanicProfile(int ProfileID, GunaLabel Title, GunaLabel subTitle, PictureBox ProfilePictureBox)
        {
            clsMechanic _Mechanic = _LoadMechanicInfo(ProfileID);

            if (_Mechanic != null)
            {
                
                Title.Text = _Mechanic.UserInfo.UserName;
                subTitle.Text = clsCountry.Find(_Mechanic.UserInfo.NationalityCountryID).CountryName;
                ProfilePictureBox.Tag = _Mechanic.MechanicID;
                if (_Mechanic.UserInfo.ImagePath != null)
                {
                    if (File.Exists(_Mechanic.UserInfo.ImagePath))
                    {

                        ProfilePictureBox.ImageLocation= _Mechanic.UserInfo.ImagePath;

                    }
                    else
                    {
                        ProfilePictureBox.Image = (_Mechanic.UserInfo.Gender == 0) ? ProfilePictureBox.Image = Resources.MaleUser : ProfilePictureBox.Image = Resources.FemaleUser;

                    }
                }

            }

        }

    }
    
    
        
        
       
    
}
