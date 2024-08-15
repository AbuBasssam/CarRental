using CarRental_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public class clsPersonInfoData
    {
        public static ctrlPersonInfo.stPersonInfo PersonDataOfUser(int UserID)
        {
            ctrlPersonInfo.stPersonInfo PersonInfo=new ctrlPersonInfo.stPersonInfo();
            PersonInfo.PersonID = -1;
            clsUser _User = clsUser.Find(UserID);
            if (_User == null)
            {
                
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return PersonInfo;
            }
            PersonInfo.PersonID = (int)_User.PersonID;
            PersonInfo.FirstName = _User.FirstName;
            PersonInfo.SecondName = _User.SecondName;
            PersonInfo.ThirdName = _User.ThirdName;
            PersonInfo.LastName = _User.LastName;
            PersonInfo.NationalNo = _User.NationalNo;
            PersonInfo.DateOfBirth = _User.DateOfBirth;
            PersonInfo.Gender = _User.Gender;
            PersonInfo.Email = _User.Email;
            PersonInfo.Phone = _User.Phone;
            PersonInfo.Address = _User.Address;
            PersonInfo.NationalityCountryID = _User.NationalityCountryID;
            PersonInfo.ImagePath = _User.ImagePath;
            return PersonInfo;
        }
        
        public static ctrlPersonInfo.stPersonInfo PersonDataOfCustomer(int CustomerID)
        {
            ctrlPersonInfo.stPersonInfo PersonInfo = new ctrlPersonInfo.stPersonInfo();
            PersonInfo.PersonID = -1;
            clsCustomer _Customer = clsCustomer.Find(CustomerID);
            if (_Customer == null)
            {

                MessageBox.Show("No User with UserID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return PersonInfo;
            }
            PersonInfo.PersonID = (int)_Customer.PersonID;
            PersonInfo.FirstName = _Customer.FirstName;
            PersonInfo.SecondName = _Customer.SecondName;
            PersonInfo.ThirdName = _Customer.ThirdName;
            PersonInfo.LastName = _Customer.LastName;
            PersonInfo.NationalNo = _Customer.NationalNo;
            PersonInfo.DateOfBirth = _Customer.DateOfBirth;
            PersonInfo.Gender = _Customer.Gender;
            PersonInfo.Email = _Customer.Email;
            PersonInfo.Phone = _Customer.Phone;
            PersonInfo.Address = _Customer.Address;
            PersonInfo.NationalityCountryID = _Customer.NationalityCountryID;
            PersonInfo.ImagePath = _Customer.ImagePath;
            return PersonInfo;
        }
        
        /*public static ctrlPersonInfo.stPersonInfo PersonDataOfMechanic(int UserID)
        {
            ctrlPersonInfo.stPersonInfo PersonInfo = new ctrlPersonInfo.stPersonInfo();
            PersonInfo.PersonID = -1;
            clsUser _User = clsUser.FindMechanicUser(UserID);
            if (_User == null)
            {

                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return PersonInfo;
            }
            PersonInfo.PersonID = (int)_User.PersonID;
            PersonInfo.FirstName = _User.FirstName;
            PersonInfo.SecondName = _User.SecondName;
            PersonInfo.ThirdName = _User.ThirdName;
            PersonInfo.LastName = _User.LastName;
            PersonInfo.NationalNo = _User.NationalNo;
            PersonInfo.DateOfBirth = _User.DateOfBirth;
            PersonInfo.Gender = _User.Gender;
            PersonInfo.Email = _User.Email;
            PersonInfo.Phone = _User.Phone;
            PersonInfo.Address = _User.Address;
            PersonInfo.NationalityCountryID = _User.NationalityCountryID;
            PersonInfo.ImagePath = _User.ImagePath;
            return PersonInfo;
        }*/
    }
}
