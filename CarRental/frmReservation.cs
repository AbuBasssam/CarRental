using CarRental_BusinessLayer;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmReservation : Form
    {

         private int _Quntity;
         private clsRentalBooking.enRentalRate _Rate;
        private  bool _Open=false;
        private int _LimitsMileage;
        public frmReservation( int CarID,int Quntity,clsRentalBooking.enRentalRate Rate)
        {
            InitializeComponent();
            ctrlCarCard1.LoadCarInfo(CarID);
            this._Quntity = Quntity;
            this._Rate = Rate;
           
            if (ctrlCarCard1.SelectedCarInfo.WarrantyInfo == null)
            {
                MessageBox.Show("Error: This car don't have Warranty you Can't Reservation it .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

               return;

            }
            int expectedMileage =ctrlCarCard1.SelectedCarInfo.Mileage +Convert.ToInt32( (_Rate == clsRentalBooking.enRentalRate.Daily) ? (Convert.ToInt32(clsRentalBooking.enLimitsMileage.Daily) * Quntity) : (_Rate == clsRentalBooking.enRentalRate.Weekly) ? ((int)clsRentalBooking.enLimitsMileage.Weekly * Quntity) : Convert.ToInt32(clsRentalBooking.enLimitsMileage.Monthly) * Quntity);
           if(ctrlCarCard1.SelectedCarInfo.RegularMaintenanceScheduleSet.Any(n=> n< expectedMileage))
            {
                MessageBox.Show("Error: This car will be  exceed regular maintenance schedule  you Can't Reservation it .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //_LimitsMileage = expectedMileage;
            _Open = true;


        }
        public frmReservation(int ReservationID)
        {
            InitializeComponent();
           
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            ctrlCustomerCard1.LoadCustomerInfo(txtNationalNo.Text);
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void cbRentalRat_SelectedIndexChanage(object sender, EventArgs e)
        {
            //if (_Car != null)
            //    lblRentalPrice.Text = ((GunaRadioButton)sender).Tag.ToString() + "/" + ((GunaRadioButton)sender).Name.Substring(2);
            switch (cbRentalRate.SelectedIndex)
            {
                case 0:
                    cbQuantity.Items.Clear();
                    _AddCbQuantityItem(1, 20);
                    cbQuantity.SelectedIndex = 0;
                    
                    
                    break;
                    case 1:
                    cbQuantity.Items.Clear();
                    _AddCbQuantityItem(1, 3);
                    cbQuantity.SelectedIndex = 0;
                    

                    break;
                case 2:
                    cbQuantity.Items.Clear();
                    _AddCbQuantityItem(1, 4);
                    cbQuantity.SelectedIndex = 0;
                    


                    break;


            }

        }*/
        private void frmReservation_Load(object sender, EventArgs e)
        {
          /*  cbRentalRate.SelectedIndex=(_Rate==clsRentalBooking.enRentalRate.Daily)? 0: _Rate==(clsRentalBooking.enRentalRate.Weekly)?1:2;
            cbQuantity.SelectedIndex = _Quntity -1;*/
            if(!_Open)
                this.Close();
            float RentalPrice = (_Rate == clsRentalBooking.enRentalRate.Daily) ? ctrlCarCard1.SelectedCarInfo.RentalPricePerDay : (_Rate == clsRentalBooking.enRentalRate.Weekly) ? ctrlCarCard1.SelectedCarInfo.RentalPricePerWeek : ctrlCarCard1.SelectedCarInfo.RentalPricePerMonth;
            lblQuantity.Text = _Quntity.ToString();
            lblRentalRate.Text = _Rate.ToString();
            _LimitsMileage = _Rate == clsRentalBooking.enRentalRate.Daily ? (_Quntity * Convert.ToInt32(clsRentalBooking.enLimitsMileage.Daily)) : _Rate == clsRentalBooking.enRentalRate.Weekly ? (_Quntity * Convert.ToInt32(clsRentalBooking.enLimitsMileage.Weekly)) : (_Quntity * Convert.ToInt32(clsRentalBooking.enLimitsMileage.Monthly));
            lblLimitsMileage.Text = _LimitsMileage.ToString();        //_LimitsMileage.ToString();
            lblSecurityDeposit.Text = ctrlCarCard1.SelectedCarInfo.CategoryInfo.WeeklySecurityDeposit.ToString();
            gunaLabel9.Text= (ctrlCarCard1.SelectedCarInfo.CategoryInfo.WeeklySecurityDeposit + ((float)_Quntity * RentalPrice)).ToString();
            

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some User fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (ctrlCustomerCard1.CustomerID == -1)
            {
                MessageBox.Show("Error: Please Choose a Customer .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //var CustomerTask = Task.Run(() => clsCustomer.Find((int)ctrlCustomerCard1.CustomerID));
            //var CarTask = Task.Run(() => clsCar.Find((int)ctrlCarCard1._CarID));
            float RentalPrice = (_Rate == clsRentalBooking.enRentalRate.Daily) ? ctrlCarCard1.SelectedCarInfo.RentalPricePerDay : (_Rate == clsRentalBooking.enRentalRate.Weekly) ? ctrlCarCard1.SelectedCarInfo.RentalPricePerWeek : ctrlCarCard1.SelectedCarInfo.RentalPricePerMonth;
          //  int LimitsMileage = _Rate == clsRentalBooking.enRentalRate.Daily ? (_Quntity * Convert.ToInt32(clsRentalBooking.enLimitsMileage.Daily)) : _Rate == clsRentalBooking.enRentalRate.Weekly ? (_Quntity * Convert.ToInt32(clsRentalBooking.enLimitsMileage.Weekly)) : (_Quntity * Convert.ToInt32(clsRentalBooking.enLimitsMileage.Monthly));

            clsRentalBooking NewRentalBooking = new clsRentalBooking();
            NewRentalBooking.RentalStartDate = DateTime.Today;
            NewRentalBooking.RentalEndDate = (_Rate == clsRentalBooking.enRentalRate.Daily) ? DateTime.Today.AddDays(_Quntity) : (_Rate == clsRentalBooking.enRentalRate.Weekly) ? DateTime.Today.AddDays((7*_Quntity)) : DateTime.Today.AddMonths(_Quntity);
            NewRentalBooking.PickUpLocation = cbPickupLocation.SelectedItem.ToString();
            NewRentalBooking.DropOffLocation=cbDropOffLocation.SelectedItem.ToString();
            NewRentalBooking.RentalRateType = _Rate;
            NewRentalBooking.InitialTotalDueAmount = Convert.ToSingle(gunaLabel9.Text.Trim());// ctrlCarCard1.SelectedCarInfo.CategoryInfo.WeeklySecurityDeposit + ((float)_Quntity * RentalPrice);
            NewRentalBooking.LimitsMileage = _LimitsMileage;
            NewRentalBooking.PickUpLocation = cbPickupLocation.SelectedItem.ToString();
            NewRentalBooking.RentalPrice = ((float)_Quntity * RentalPrice);
            NewRentalBooking.InitialCheckNote=txtCheckNotes.Text;
            NewRentalBooking.InitialFulePercentage = Convert.ToByte(txtFulePercentage.Text);
            //Task.WaitAll(CustomerTask, CarTask);
            NewRentalBooking.CustomerID =ctrlCustomerCard1.CustomerID;
            NewRentalBooking.CarID = (int)ctrlCarCard1.SelectedCarInfo.CarID;
            NewRentalBooking.AddByUserID = (int)clsGlobal.CurrentUser.UserID;
            NewRentalBooking.CarInfo = clsCar.Find(NewRentalBooking.CarID);
            NewRentalBooking.CustomerInfo=clsCustomer.Find(NewRentalBooking.CustomerID);
            frmTransaction BookingTransactoni=new frmTransaction(NewRentalBooking);
            BookingTransactoni.ShowDialog();

/*            if (NewRentalBooking.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsRenralTransaction ReservatoinTransactoin = new clsRenralTransaction();
                ReservatoinTransactoin.BookingID = NewRentalBooking.BookingID;
                ReservatoinTransactoin.PaymentDetails = "";
                ReservatoinTransactoin.PaidIntialTotalDueAmount = NewRentalBooking.InitialTotalDueAmount;
                ReservatoinTransactoin.TransactionDate = DateTime.Now;
                if (ReservatoinTransactoin.Save())
                {
                    MessageBox.Show($"Transaction Saved Successfully with Amount {ReservatoinTransactoin.PaidIntialTotalDueAmount}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SendingEmail(NewRentalBooking);

                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/


        }

        private void txtFulePercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFulePercentage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFulePercentage.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFulePercentage, "this filed is required !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFulePercentage, null);
            };
            if ( Convert.ToByte(txtFulePercentage.Text)<0|| Convert.ToByte(txtFulePercentage.Text) > 100)
            {

                e.Cancel = true;
                errorProvider1.SetError(txtFulePercentage, "Wrong Percentage!, Percentage should be between 0 and 100");
                return;

            }
            else
            {
                errorProvider1.SetError(txtFulePercentage, null);
            };
        
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer NewCustomer = new frmAddUpdateCustomer();
            NewCustomer.DataBack += LoadNewCustomerData;
            NewCustomer.ShowDialog();
        }

        
        
        private void LoadNewCustomerData(object sender, int CustomerID)
        {
            ctrlCustomerCard1.LoadCustomerInfo(CustomerID);
        }

    }
}
