﻿using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public abstract class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode ;
        public Nullable<int> PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }

        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public byte NationalityCountryID { set; get; }

        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public clsCountry CountryInfo;
        
        
        
        /*public clsPerson()
        {
            PersonID = null;
            NationalNo = null;
            FirstName = null;
            SecondName = null;
            ThirdName = default(string);
            LastName = null;
            DateOfBirth = DateTime.Today;
            Gender = default(int);
            Address = default(string);
            Phone = default(string);
            Email = default(string);
            NationalityCountryID = default(int);
            ImagePath = default(string);
            Mode = enMode.AddNew;
        }

         public clsPerson(Nullable<int> PersonID, string NationalNo, string FirstName, string SecondName
             , string ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
             string Address, string Phone, string Email, byte NationalityCountryID, string ImagePath)
         {
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
             this.CountryInfo = clsCountry.Find(NationalityCountryID);
             this.Mode = enMode.Update;
         }

        public static bool Find(string NationalNo)
        {
            Nullable<int> PersonID = null;
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

            if (clsPeopleData.FindByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName
              , ref ThirdName, ref LastName, ref DateOfBirth, ref Gender,
             ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {

                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool Find(int PersonID)
        {
            string NationalNo = default(string);
            string FirstName = default(string);
            string SecondName = default(string);
            string ThirdName = default(string);
            string LastName = default(string);
            DateTime DateOfBirth = default(DateTime);
            byte Gender = default(int);
            string Address = default(string);
            string Phone = default(string);
            string Email = default(string);
            byte NationalityCountryID = default(int);
            string ImagePath = default(string);


            if (clsPeopleData.FindByID(PersonID, ref NationalNo, ref FirstName, ref SecondName
              , ref ThirdName, ref LastName, ref DateOfBirth, ref Gender,
             ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {


                return true;

            }

            else
            {
                return false;
            }
        }

        /* public virtual bool Save()
         {
             switch (Mode)
             {
                 case enMode.AddNew:

                     if (_AddNewPerson())
                     {
                         Mode = enMode.Update;
                         return true;
                     }
                     else return false;


                 case enMode.Update:

                     return _UpdatePerson();


                 default:
                     return false;

             }
         }

         private bool _AddNewPerson()
         {
             this.PersonID = clsPeopleData.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
             return (PersonID != null);
         }

         private bool _UpdatePerson()
         {
             return (clsPeopleData.UpdatePerson((int)PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath));
         }

         public static bool DeletePerson(int PersonID)
         {
             return clsPeopleData.DeletePerson(PersonID);
         }

         public static bool DeletePerson(string NationalNo)
         {
             return clsPeopleData.DeletePerson(NationalNo);

         }

         public static bool IsPersonExist(int ID)
         {
             return clsPeopleData.IsPersonExist(ID);
         }

         public static bool IsPersonExist(string NationalNo)
         {
             return clsPeopleData.IsPersonExist(NationalNo);
         }

         public static DataTable GetAllPersons()
         {
             return clsPeopleData.GetPeople();
         }
 */
    }


}

