using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsWarranty
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;

        public Nullable<int> WarrantyID { get; set; }
        
        public  DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public string CoverageDetails { get; set; }
        
        public int CarID {  get; set; }


        public clsWarranty()
        {
            this.WarrantyID = null;
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today;
            this.CoverageDetails = "";
            this.Mode = enMode.AddNew;
        }
        
        
        private clsWarranty(int WarrantyID, DateTime StartDate, DateTime EndDate,string CoverageDetails,int CarID)
        {
            this.WarrantyID= WarrantyID;
            this.StartDate= StartDate;
            this.EndDate= EndDate;
            this.CoverageDetails = CoverageDetails;
            this.CarID = CarID;
            this.Mode = enMode.Update;

        }


/*        public static  clsWarranty Find(int WarrantyID)
        {
            DateTime StartDate = DateTime.Today;
            DateTime EndDate = DateTime.Today;
            string CoverageDetails = "";
            int CarID = -1;

            if (clsWarrantyData.GetWarrantyByID(WarrantyID, ref StartDate, ref EndDate, ref CoverageDetails, ref CarID))
            {
                return new clsWarranty(WarrantyID, StartDate, EndDate, CoverageDetails, CarID);
            

            }
            else
            {
                return null;
            }
        } 
*/        
        public static clsWarranty GetCarWarranty(int CarID)
        {
            DateTime StartDate = DateTime.Today;
            DateTime EndDate = DateTime.Today;
            string CoverageDetails = "";
            int WarrantyID = -1;

            if (clsWarrantyData.GetCarWarranty(ref WarrantyID, ref StartDate, ref EndDate, ref CoverageDetails,  CarID))
            {
                return new clsWarranty(WarrantyID, StartDate, EndDate, CoverageDetails, CarID);


            }
            else
            {
                return null;
            }
        }

        private bool _AddNewWarranty()
        {
            this.WarrantyID=clsWarrantyData.AddNewWarranty(this.StartDate,this.EndDate,this.CoverageDetails,this.CarID);

            return (this.WarrantyID != null);
        }
        
        
        private bool _UpdateWarranty()
        {
            return clsWarrantyData.UpdateWarranty((int)this.WarrantyID,this.StartDate, this.EndDate, this.CoverageDetails, this.CarID);
        }
       
        public static bool DeleteWarranty(int WarrantyID)
        {
            return clsWarrantyData.DeleteWarranty(WarrantyID);
        }

        
        public static bool IsWarrantyExist(int WarrantyID)
        {
            return clsWarrantyData.IsWarrantyExist(WarrantyID);
        }

        public static DataTable GetAllWarranties()
        {
            return clsWarrantyData.GetAllWarranties();
        }
        
        public  bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewWarranty())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateWarranty();


                default:
                    return false;
            }
        }

    }
}
