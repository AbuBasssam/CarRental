using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsFee
    {
        public enum enMode { AddNew = 1, Update = 2 }

      public enum enStatus { NotPayed,Payed}

        public enMode Mode = enMode.AddNew;

        public Nullable<int> FeeID { get; set; }
        public clsFeeType.enFeeTypes FeeTypeID { get; set; }

        public DateTime FeeDate { get; set; }

        public float FeeAmount { get;}
        public int NumberOfTimes {  get; set; }
        public string Notes { get; set; }
        public int BookingID {  get; set; }
        public enStatus Status { get; set; }
        public clsRentalBooking BookingInfo { get; set; }
        public clsFeeType FeeTypeInfo { get; set; }



        public clsFee()
        {
            this.FeeID = 0;
            this.FeeTypeID = clsFeeType.enFeeTypes.Speeding;
            this.FeeDate = DateTime.Today;
            this.NumberOfTimes = 0;
            this.Notes = "";
            this.Status = enStatus.NotPayed;
            this.BookingID = -1;
            this.Mode = enMode.AddNew;
        }

        private clsFee(int FeeID, clsFeeType.enFeeTypes FeeTypeID, DateTime FeeDate, float FeeAmount,int NumberOfTimes,string Notes,enStatus Status, int BookingID)
        {
            this.FeeID = FeeID;
            this.FeeTypeID = FeeTypeID;
            this.FeeDate = FeeDate;
            this.NumberOfTimes = NumberOfTimes;
            this.Notes = Notes;
            this.Status= Status;
            this.BookingID = -BookingID;
            this.FeeTypeInfo =clsFeeType.Find((int)FeeTypeID);
            this.BookingInfo=clsRentalBooking.Find(BookingID);
            this.Mode = enMode.Update;

        }

        public static clsFee Find(int FeeID)
        {
            byte FeeTypeID = 0;
            DateTime FeeDate=DateTime.Today;
            float FeeAmount = 0;
            int NumberOfTimes = 0;
            string Notes = "";
            byte Status = 0;
            int BookingID = -1;


            if (clsFeeData.GetFeeByID(FeeID, ref FeeTypeID, ref FeeDate, ref FeeAmount, ref NumberOfTimes, ref Notes, ref Status, ref BookingID))
            {
                return new clsFee(FeeID, (clsFeeType.enFeeTypes) FeeTypeID,  FeeDate,  FeeAmount,  NumberOfTimes,  Notes, (enStatus) Status,  BookingID);


            }
            else
            {
                return null;
            }
        }

        private bool _AddNewFee()
        {
            Nullable<int> FeeID = clsFeeData.AddNewFee((byte)this.FeeTypeID, this.FeeDate, this.FeeAmount, this.NumberOfTimes, this.Notes, BookingID);

            return (FeeID != null);
        }

        private bool _UpdateFee()
        {
            return clsFeeData.UpdateFee((int)this.FeeID,(byte)this.FeeTypeID ,this.FeeDate, this.FeeAmount, this.NumberOfTimes, this.Notes, (byte)this.Status, BookingID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewFee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateFee();


                default:
                    return false;
            }
        }

        public static DataTable GetAllFees()
        {
            return clsFeeData.GetAllFees();
        }
    }
}
