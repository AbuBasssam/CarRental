using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsUser:clsPerson
    {
       
        
        public Nullable<int> UserID { get; set; }

        public string UserName { get; set; }
        
        public string Password
        {
            get
            {
                return _Password;
            }
            
            set
            {
                if(Mode == enMode.AddNew)
                _Password =_ComputeHash(value);
                
                else
                    _Password =value;
            }
        }
        
        private string _Password;

        public float Salary { get; set; }

        public bool IsActive { get; set; }
        
        public clsUser()
        {
            this.UserID = null;
            this.PersonID =null;
            this.UserName = null;
            this.Password = null;
            this.Salary = 0;
            this.IsActive = false;
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
           
            this.Mode = enMode.AddNew;  
        }
        
        private clsUser(int UserID, int PersonID,string UserName, string Password,float Salary, bool IsActive,
            string NationalNo, string FirstName, string SecondName
            , string ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
            string Address, string Phone, string Email, byte NationalityCountryID, string ImagePath)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.Salary = Salary;
            this.IsActive = IsActive;
            
            //Person Info
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
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            this.ImagePath = ImagePath;
            this.Mode = enMode.Update;


        }
        
        public static clsUser Find(int UserID)
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
            string UserName = default(string);
            string Password = default(string);
            float Salary = 0;
            bool IsActive = false;


            if (clsUserData.FindByIUserID( UserID,ref PersonID, ref UserName, ref Password, ref Salary, ref IsActive
                ,ref NationalNo,ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone,ref Email,ref NationalityCountryID, ref ImagePath))
            {
                return new clsUser( UserID,  PersonID,  UserName,  Password,  Salary, IsActive,
             NationalNo,  FirstName,  SecondName
            ,ThirdName,LastName,  DateOfBirth,  Gender,
             Address,  Phone,  Email,  NationalityCountryID,  ImagePath);



            }
            else
            {
                return null;
            }
        }

        //done
        public static clsUser Find( string UserName, string Password)
        {
           Nullable< int> UserID = null;
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
            float Salary = 0;
            bool IsActive = false;
            Password=_ComputeHash(Password);


            if (clsUserData.Find(ref UserID, ref PersonID,   UserName,  Password, ref Salary, ref IsActive
                , ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {

                return new clsUser((int)UserID, PersonID, UserName, Password, Salary, IsActive,
                                        NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender,
                                        Address, Phone, Email, NationalityCountryID, ImagePath);



            }
            else
            {
                return null;
            }
        }

        //done
        private bool _AddNewUser()
        {
            int PersonID =-1;
            this.UserID = clsUserData.AddNewUser( NationalNo,  FirstName,  SecondName,  ThirdName,  LastName
                                               ,  DateOfBirth,  Gender,  Address,  Phone,  Email
                                               ,  NationalityCountryID,  ImagePath, ref PersonID,  UserName
                                               ,  Password,  Salary,  IsActive);
            this.PersonID = PersonID;
            return (UserID != null && this.PersonID!=-1);
        }

        //done
        private bool _UpdateUser()
        {
            return (clsUserData.UpdateUser((int)UserID, NationalNo, FirstName, SecondName, ThirdName, LastName
                                               , DateOfBirth, Gender, Address, Phone, Email
                                               , NationalityCountryID, ImagePath, (int)PersonID, UserName
                                               , Password, Salary, IsActive));
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static List<int> GetUsersPage(int PageNumber)
        {
            return clsUserData.GetUsersPage(PageNumber);
        }

        public static List<int> GetUsersIDsByFirstNameSearch(string FirstName)
        {
            return clsUserData.GetUsersIDsByFirstNameSearch(FirstName);
        }
       
        public static List<int> GetUsersIDsByNationalNoSearch(string FirstName)
        {
            return clsUserData.GetUsersIDsByNationalNoSearch(FirstName);
        }
        
        public static List<int> GetUsersIDsByPhoneNumberSearch(string FirstName)
        {
            return clsUserData.GetUsersIDsByPhoneNumberSearch(FirstName);
        }

        public static bool IsUserExist(string NatinalNo)
        {
            return clsUserData.IsUserExist(NatinalNo);
        }
        
        public  static bool isUserExist(string UserName)
        {
            return clsUserData.isUserExist(UserName);
        }
        
        public  bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateUser();


                default:
                    return false;
            }
        }

        private static string _ComputeHash(string Password)
        {
            if(Password== null) { return null; }
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


    }
}
