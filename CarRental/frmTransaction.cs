using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmTransaction : Form
    {
        private clsRentalBooking _PaymentBooking;
        public frmTransaction(clsRentalBooking Booking)
        {
            InitializeComponent();
            _PaymentBooking = Booking;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_PaymentBooking.Save())
            {
                lblBookingID.Text = _PaymentBooking.BookingID.ToString();
                _PaymentBooking.CarInfo.Status = clsCar.enStatus.InRent;
                _PaymentBooking.CarInfo.Save();
                clsRenralTransaction ReservatoinTransactoin = new clsRenralTransaction();
                ReservatoinTransactoin.BookingID = _PaymentBooking.BookingID;
                ReservatoinTransactoin.PaymentDetails = txtPaymentDetails.Text.Trim();
                ReservatoinTransactoin.PaidIntialTotalDueAmount = _PaymentBooking.InitialTotalDueAmount;
                ReservatoinTransactoin.TransactionDate = DateTime.Now;
                if (ReservatoinTransactoin.Save())
                {
                    MessageBox.Show($"Transaction Saved Successfully with Amount {ReservatoinTransactoin.PaidIntialTotalDueAmount}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // SendingEmail(_PaymentBooking);

                }
            }
            else
            {
                MessageBox.Show("Error: Reservation Is not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void SendingEmail(clsRentalBooking RentalBooking)
        {
            try
            {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                string From = "";// must be Company Email
                string Body = $"Hi {(_PaymentBooking.CustomerInfo=clsCustomer.Find(_PaymentBooking.CustomerID)).FirstName} thank you to work with us your reservation end at {RentalBooking.RentalEndDate.Date.ToShortDateString()}";
                mm.From = new MailAddress(From);
                mm.To.Add("");//Customer Email
                mm.Subject = "New Car Reservation";
                mm.Body = Body;
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(From, "vtmq lnys hplq lnuv");
                sc.EnableSsl = true;
                sc.Send(mm);
                MessageBox.Show(" the Reservation Email has been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmTransaction_Load(object sender, EventArgs e)
        {
            lblPaymentDate.Text = DateTime.Now.ToShortDateString();
            //lblBookingID.Text = _PaymentBooking.BookingID.ToString();
            lblPaymentAmount.Text = _PaymentBooking.InitialTotalDueAmount.ToString();

        }
    }
}
