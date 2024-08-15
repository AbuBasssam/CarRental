using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsCarCategory
    {
        public enum enMode { AddNew = 1, Update = 2 }
        
        public enum enCarCategories {Economy = 1, Standard = 2, FullSize = 3, Minivan = 4, SUV = 5, Luxury = 6,
                                      SpecialtySport = 7, Compact = 8, Intermediate = 9, MidSize = 10, CrossOver = 11 }

        public enMode Mode = enMode.AddNew;

        public enCarCategories CategoryID { get; set; }

        public string CategoryName { get; set; }

        public float RefuelPrice { get; set; }

        public float DailySecurityDeposit { get; set; }

        public float WeeklySecurityDeposit { get;}

        public float MonthlySecurityDeposit { get;}

        public clsCarCategory()
        {
            this.CategoryID = enCarCategories.Economy;
            this.CategoryName ="";
            this.RefuelPrice =0;
            this.DailySecurityDeposit =0;
            this.Mode = enMode.AddNew;
        }

        private clsCarCategory(enCarCategories CategoryID, string CategoryName, float RefuelPrice, float DailySecurityDeposit, float WeeklySecurityDeposit, float MonthlySecurityDeposit)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.RefuelPrice = RefuelPrice;
            this.DailySecurityDeposit = DailySecurityDeposit;
            this.WeeklySecurityDeposit = WeeklySecurityDeposit;
            this.MonthlySecurityDeposit = MonthlySecurityDeposit;
            this.Mode = enMode.Update;

        }

        public static clsCarCategory Find(int CategoryID)
        {
            string  CategoryName="";
            float  RefuelPrice=0;
            float  DailySecurityDeposit=0;
            float  WeeklySecurityDeposit=0;
            float  MonthlySecurityDeposit=0;

            if (clsCarCategoryData.GetCategoryByID(CategoryID, ref CategoryName, ref RefuelPrice, ref DailySecurityDeposit, ref WeeklySecurityDeposit, ref MonthlySecurityDeposit))
            {
                return new clsCarCategory((enCarCategories) CategoryID, CategoryName, RefuelPrice, DailySecurityDeposit, WeeklySecurityDeposit, MonthlySecurityDeposit);


            }
            else
            {
                return null;
            }
        }

        private bool _AddNewCategory()
        {
            Nullable<int> CategoryID = clsCarCategoryData.AddNewCategory(this.CategoryName, this.RefuelPrice, this.DailySecurityDeposit);

            return (CategoryID != null);
        }

        private bool _UpdateCategory()
        {
            return clsCarCategoryData.UpdateCategory((int)this.CategoryID, this.CategoryName, this.RefuelPrice, this.DailySecurityDeposit);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCategory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateCategory();


                default:
                    return false;
            }
        }

        public static DataTable GetAllCategories()
        {
            return clsCarCategoryData.GetAllCategories();
        }

        /* public static bool DeleteCategory(int CategoryID)
        {
            return clsCarCategoryData.DeleteCategory(CategoryID);
        }*/

        /*        public static bool IsCategoryExist(int CategoryID)
         {
             return clsCarCategoryData.IsCategoryExist(CategoryID);
         }
 */

    }
}
