using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsFeeType
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enum enFeeTypes
        {
            LateReturns = 1, Speeding = 2, ParkingViolations = 3, SmokingInCar = 4, UnauthorizedDrivers = 5, FailuretoReturnCar = 6,
            WeeklyExceedingMileageLimits = 7, MonthlyExceedingMileageLimits = 8, DailyExceedingMileageLimits = 9
        }

        public enMode Mode = enMode.AddNew;

        public enFeeTypes FeeTypeID { get; set; }

        public string FeeTypeName { get; set; }

        public string FeeDescription { get; set; }

        public float FeeAmount { get; set; }

       
       
        public clsFeeType()
        {
            this.FeeTypeID = enFeeTypes.LateReturns;
            this.FeeTypeName = "";
            this.FeeDescription = "";
            this.FeeAmount = 0;
            this.Mode = enMode.AddNew;
        }

        private clsFeeType(enFeeTypes FeeTypeID, string FeeTypeName, string FeeDescription, float FeeAmount)
        {
            this.FeeTypeID = FeeTypeID;
            this.FeeTypeName = FeeTypeName;
            this.FeeDescription = FeeDescription;
            this.FeeAmount = FeeAmount;
            this.Mode = enMode.Update;

        }

        public static clsFeeType Find(int FeeTypeID)
        {
            string FeeTypeName = "";
            string FeeDescription = "";
            float FeeAmount = 0;
            

            if (clsFeeTypeData.GetFeeTypeByID(FeeTypeID, ref FeeTypeName, ref FeeDescription, ref FeeAmount))
            {
                return new clsFeeType((enFeeTypes)FeeTypeID, FeeTypeName, FeeDescription, FeeAmount);


            }
            else
            {
                return null;
            }
        }

        private bool _AddNewFeeType()
        {
            Nullable<int> FeeTypeID = clsFeeTypeData.AddNewFeeType(this.FeeTypeName, this.FeeDescription, this.FeeAmount);

            return (FeeTypeID != null);
        }

        private bool _UpdateFeeType()
        {
            return clsFeeTypeData.UpdateFeeType((int)this.FeeTypeID, this.FeeTypeName, this.FeeDescription, this.FeeAmount);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewFeeType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateFeeType();


                default:
                    return false;
            }
        }

        public static DataTable GetAllFeeTypes()
        {
            return clsFeeTypeData.GetAllFeeTypes();
        }


    }
}
