using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRental_BusinessLayer.clsFuleType;

namespace CarRental_BusinessLayer
{
    public class clsRenralTransaction
    {
        public enum enMode { AddNew = 1, Update = 2 }
        
        public enMode Mode = enMode.AddNew;

        public Nullable< int> TransactionID { get; set; }
        public int BookingID { get; set; }
        public Nullable<int> ReturnID { get; set; }
        public string PaymentDetails { get; set; }
        public float PaidIntialTotalDueAmount { get; set; }
        public Nullable< float> ActualTotalDueAmount { get; set; }
        public Nullable<float> TotalRemaining { get; set; }
        public Nullable<float> TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime UpdateTransactionDate { get; set; }
        public clsRenralTransaction()
        {
            this.TransactionID = null;
            this.BookingID = -1;
            this.ReturnID = -1;
            this.PaymentDetails = null;
            this.PaidIntialTotalDueAmount = 0;
            this.ActualTotalDueAmount = null;
            this.TotalRemaining = null;
            this.TotalRefundedAmount = null;
            this.TransactionDate = DateTime.Today;
            this.UpdateTransactionDate = DateTime.Today;

        }

        private clsRenralTransaction(int TransactionID,  int BookingID, Nullable<int> ReturnID,  string PaymentDetails,
             float PaidIntialTotalDueAmount, Nullable<float> ActualTotalDueAmount, Nullable<float> TotalRemaining,
             Nullable<float> TotalRefundedAmount,  DateTime TransactionDate,  DateTime UpdateTransactionDate)
        {
            this.TransactionID = TransactionID;
            this.BookingID = BookingID;
            this.ReturnID = ReturnID;
            this.PaymentDetails = PaymentDetails;
            this.PaidIntialTotalDueAmount = PaidIntialTotalDueAmount;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TotalRemaining = TotalRemaining;
            this.TotalRefundedAmount = TotalRefundedAmount;
            this.TransactionDate = TransactionDate;
            this.UpdateTransactionDate = UpdateTransactionDate;
        }
        public static clsRenralTransaction Find(int TransactionID)
        {

            int BookingID = -1;
            Nullable<int> ReturnID = null;
            string PaymentDetails = "";
            float PaidIntialTotalDueAmount = 0;
            Nullable<float> ActualTotalDueAmount = null;
            Nullable<float> TotalRemaining = null;
            Nullable<float> TotalRefundedAmount = null;
            DateTime TransactionDate = DateTime.Now;
            DateTime UpdateTransactionDate = DateTime.Now;

            if (clsRenralTransactionData.GetTransactionInfoByID(TransactionID, ref BookingID,ref ReturnID, ref PaymentDetails, ref PaidIntialTotalDueAmount,
                ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdateTransactionDate))

                return new clsRenralTransaction( TransactionID,  BookingID,ReturnID,  PaymentDetails,
              PaidIntialTotalDueAmount, ActualTotalDueAmount, TotalRemaining,
             TotalRefundedAmount, TransactionDate, UpdateTransactionDate);
            else
                return null;

        }
        private bool _AddNewTransaction()
        {
            this.TransactionID = clsRenralTransactionData.AddNewTransaction(this.BookingID, this.PaymentDetails, this.PaidIntialTotalDueAmount);

            return (TransactionID != null);
        }
        private bool _UpdatTransaction()
        {
            return clsRenralTransactionData.UpdateTransaction((int)this.TransactionID,this.BookingID,(int)this.ReturnID, this.PaymentDetails,
                this.PaidIntialTotalDueAmount,(float)this.ActualTotalDueAmount, (float)this.TotalRemaining, (float)this.TotalRefundedAmount,this.TransactionDate);
        }
        public static int NumberOfPages()
        {
            return clsRenralTransactionData.NumberOfPages();
        }
        public static int NumberOfFilterPages(int Year, int Month)
        { 
            return clsRenralTransactionData.NumberOfFilterPages(Year, Month); 
        }
        public static DataTable GetTransactionsFilter(int Year,int Month,int PageNumber)
        {
            return clsRenralTransactionData.GetTransactionsFilter(Year, Month, PageNumber);
        }


            public static DataTable GetTransactionPage(int PageNumber)
        {
            return clsRenralTransactionData.GetTransactionPage(PageNumber);

        }

            public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdatTransaction();


                default:
                    return false;
            }
        }

    }
}
