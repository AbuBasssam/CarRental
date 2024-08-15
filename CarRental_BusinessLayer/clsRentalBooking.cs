using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsRentalBooking
    {
        public enum enRentalRate { Daily = 1, Weekly = 2, Monthly = 3 }
        public enum enLimitsMileage { Daily = 200, Weekly = 1000, Monthly = 3000 }
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;
        private Nullable<int> _BookingID { get; set; }
        public int BookingID { get { return _BookingID.Value; } }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public string PickUpLocation { get; set; }
        public string DropOffLocation { get; set; }
        public enRentalRate RentalRateType { get; set; }
        public float RentalPrice { get; set; }
        public float InitialTotalDueAmount { get; set; }
        public int LimitsMileage { get; set; }
        public string InitialCheckNote { get; set; }
        public byte InitialFulePercentage { get; set; }
        public int AddByUserID { get; set; }

        public clsCustomer CustomerInfo { get; set; }
        public clsCar CarInfo { get; set; }
        public clsUser UserInfo { get; set; }

        public clsRentalBooking()
        {
            _BookingID = null;
            CarID = -1;
            CustomerID = -1;
            RentalStartDate = DateTime.Today;
            RentalEndDate = DateTime.Today;
            PickUpLocation = "";
            DropOffLocation = "";
            RentalRateType = enRentalRate.Daily;
            RentalPrice = 0;
            InitialTotalDueAmount = 0;
            LimitsMileage = 0;
            InitialCheckNote = "";
            InitialFulePercentage = 0;
            AddByUserID = -1;


        }

        public clsRentalBooking(int BookingID, int CustomerID, int CarID, DateTime RentalStartDate, DateTime RentalEndDate, string PickUpLocation, string DropOffLocation, enRentalRate RentalRateType, float RentalPrice, float InitialTotalDueAmount, int LimitsMileage, string InitialCheckNote, byte InitialFulePercentage, int AddByUserID)
        {
            this._BookingID = BookingID;
            this.CarID = CarID;
            this.CustomerID = CustomerID;
            this.RentalStartDate = RentalStartDate;
            this.RentalEndDate = RentalStartDate;
            this.PickUpLocation = PickUpLocation;
            this.DropOffLocation = DropOffLocation;
            this.RentalRateType = RentalRateType;
            this.RentalPrice = RentalPrice;
            this.InitialTotalDueAmount = InitialTotalDueAmount;
            this.LimitsMileage = LimitsMileage;
            this.InitialCheckNote = InitialCheckNote;
            this.InitialFulePercentage = InitialFulePercentage;
            this.AddByUserID = AddByUserID;
            this.CustomerInfo = clsCustomer.Find(CustomerID);
            this.CarInfo = clsCar.Find(CarID);
            this.UserInfo = clsUser.Find(AddByUserID);


        }

        public static clsRentalBooking Find(int BookingID)
        {
            int CustomerID = -1;
            int CarID = 1;
            DateTime RentalStartDate = DateTime.Today;
            DateTime RentalEndDate = DateTime.Now;
            string PickUpLocation = "";
            string DropOffLocation = "";
            byte RentalRateType = 0;
            float RentalPrice = 0;
            float InitialTotalDueAmount = 0;
            int LimitsMileage = 0;
            string InitialCheckNote = "";
            byte InitialFulePercentage = 0;
            int AddByUserID = -1;
            return null;

        }

        private bool _AddNewRentalBooking()
        {

            this._BookingID = clsRentalBookingData.AddNewRentalBooking((int)this.CustomerID, (int)this.CarID, this.RentalStartDate, this.RentalEndDate, this.PickUpLocation,
                this.DropOffLocation, (byte)this.RentalRateType, this.RentalPrice, this.InitialTotalDueAmount, this.LimitsMileage,
                this.InitialCheckNote, this.InitialFulePercentage, (int)this.AddByUserID);

            return (this._BookingID != null);
        }

        private bool _UpdateRentalBooking()
        {
            return (clsRentalBookingData.UpdateRentalBooking((int)this.BookingID, (int)this.CustomerInfo.CustomerID, (int)this.CarInfo.CarID,
                this.RentalStartDate, this.RentalEndDate, this.PickUpLocation,
                this.DropOffLocation, (byte)this.RentalRateType, this.RentalPrice, this.InitialTotalDueAmount, this.LimitsMileage,
                this.InitialCheckNote, this.InitialFulePercentage, (int)UserInfo.UserID));
        }

        public static bool DeleteRentalBooking(int RentalBookingID)
        {
            return clsRentalBookingData.DeleteRentalBooking(RentalBookingID);
        }

        public static bool IsRentalBookingExist(int RentalBookingID)
        {
            return clsRentalBookingData.IsRentalBookingExist(RentalBookingID);
        }

        public static DataTable GetRentalBookingsPage(int PageNumber)
        {
            return clsRentalBookingData.GetRentalBookingsPage(PageNumber);
        }
        public static DataTable GetRentalBookingsFilter(int Year, int Month,int PageNumber)
        {
            return clsRentalBookingData.GetRentalBookingsFilter(Year, Month, PageNumber);
        }

            public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewRentalBooking())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateRentalBooking();


                default:
                    return false;
            }
        }


        public static int NumberOfPages()
        {
            return clsRentalBookingData.NumberOfPages();

        }
        public static int NumberOfFilterPages(int Year, int Month)
        {
           return clsRentalBookingData.NumberOfFilterPages(Year, Month);
        }
        public static int MniumRentalBookingYear()
        {
            return clsRentalBookingData.MniumRentalBookingYear();
        }
    }
}
