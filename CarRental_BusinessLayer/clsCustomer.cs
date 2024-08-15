using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsCustomer : clsPerson
    {   
        public Nullable<int> CustomerID { get; set; }
        public int DriverLicenseNumber { get; set; }
        public clsCustomer()
        {
            this.CustomerID = null;
            this.PersonID = null;
            this.NationalNo = null;
            this.FirstName = null;
            this.SecondName = null;
            this.ThirdName = default(string);
            this.LastName = null;
            this.DateOfBirth = DateTime.Today;
            this.Gender = default(int);
            this.Address = default(string);
            this.Phone = default(string);
            this.Email = default(string);
            this.NationalityCountryID = default(int);
            this.ImagePath = default(string);
            this.DriverLicenseNumber= default(int);
            this.Mode = enMode.AddNew;
        }

        private clsCustomer(int CustomerID, int PersonID,
            string NationalNo, string FirstName, string SecondName
            , string ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
            string Address, string Phone, string Email, byte NationalityCountryID, string ImagePath , int DriverLicenseNumber)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            this.Mode = enMode.Update;


        }

     
        public  static clsCustomer Find(int CustomerID)
        {
            int PersonID = -1;
            string NationalNo = default(string);
            string FirstName = default(string);
            string SecondName = default(string);
            string ThirdName = default(string);
            string LastName = default(string);
            DateTime DateOfBirth = default(DateTime);
            byte Gender = default(byte);
            string Address = default(string);
            string Phone = default(string);
            string Email = default(string);
            byte NationalityCountryID = default(byte);
            string ImagePath = default(string);
            int DriverLicenseNumber = default(int);



            if (clsCustomerData.FindCustomerByID(CustomerID, ref PersonID,
                ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath, ref DriverLicenseNumber))
            {
                return new clsCustomer(CustomerID, PersonID,
             NationalNo, FirstName, SecondName
            , ThirdName, LastName, DateOfBirth, Gender,
             Address, Phone, Email, NationalityCountryID, ImagePath,DriverLicenseNumber);



            }
            else
            {
                return null;
            }
        }
        
        public  static clsCustomer Find(string NationalNo)
        {
            int PersonID = -1;
            int CustomerID = -1;
            string FirstName = default(string);
            string SecondName = default(string);
            string ThirdName = default(string);
            string LastName = default(string);
            DateTime DateOfBirth = default(DateTime);
            byte Gender = default(byte);
            string Address = default(string);
            string Phone = default(string);
            string Email = default(string);
            byte NationalityCountryID = default(byte);
            string ImagePath = default(string);
            int DriverLicenseNumber = default(int);



            if (clsCustomerData.FindCustomerByINationalNo(ref CustomerID, ref PersonID,
                 NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath, ref DriverLicenseNumber))
            {
                return new clsCustomer(CustomerID, PersonID,
             NationalNo, FirstName, SecondName
            , ThirdName, LastName, DateOfBirth, Gender,
             Address, Phone, Email, NationalityCountryID, ImagePath, DriverLicenseNumber);



            }
            else
            {
                return null;
            }
        }

        private bool _AddNewCustomer()
        {
            int PersonID = -1;
            this.CustomerID = clsCustomerData.AddNewCustomer(NationalNo, FirstName, SecondName, ThirdName, LastName
                                               , DateOfBirth, Gender, Address, Phone, Email
                                               , NationalityCountryID, ImagePath, ref PersonID, DriverLicenseNumber);
            this.PersonID = PersonID;
            return (CustomerID != null && this.PersonID != -1);
        }

        private bool _UpdateCustomer()
        {
            return (clsCustomerData.UpdateCustomer((int)CustomerID, NationalNo, FirstName, SecondName, ThirdName, LastName
                                               , DateOfBirth, Gender, Address, Phone, Email
                                               , NationalityCountryID, ImagePath, (int)PersonID, DriverLicenseNumber));
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomerData.DeleteCustomer(CustomerID);
        }

        public static bool IsCustomerExist(int CustomerID)
        {
            return clsCustomerData.IsCustomerExist(CustomerID);
        }

        public static List<int> GetCustomersPage(int PageNumber)
        {
            return clsCustomerData.GetCustomersPage(PageNumber);
        }

        public static List<int> GetCustomersIDsByFirstNameSearch(string FirstName)
        {
            return clsCustomerData.GetCustomersIDsByFirstNameSearch(FirstName);
        }

        public static List<int> GetCustomersIDsByNationalNoSearch(string FirstName)
        {
            return clsCustomerData.GetCustomersIDsByNationalNoSearch(FirstName);
        }

        public static List<int> GetCustomersIDsByPhoneNumberSearch(string FirstName)
        {
            return clsCustomerData.GetCustomersIDsByPhoneNumberSearch(FirstName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCustomer())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateCustomer();


                default:
                    return false;
            }
        }

        


    }
}
