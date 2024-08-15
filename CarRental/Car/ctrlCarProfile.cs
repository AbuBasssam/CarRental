using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Guna.UI2.WinForms;
using Guna.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using CarRental.Properties;
using static CarRental_BusinessLayer.clsRegularMaintenanceType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Web.UI;

namespace CarRental
{
    
    public partial class ctrlCarProfile : UserControl
    {
        private clsCar _Car;
        /* public enum enMode { Show, Reservation }
         private enMode _Mode;
         public enMode Mode
         {
             set
             {
                 _Mode = value;

                 switch (_Mode)
                 {

                     case enMode.Show:
                         {
                             rbDaily.Visible = false;
                             rbWeekly.Visible = false;
                             rbMonthly.Visible = false;
                             if (_Car != null)
                             {
                                 gunaLabel1.Text = _Car.Make + ' ' + _Car.Model + ' ' + _Car.Year.ToString();
                             }
                             btnReservation.Visible = false;

                             break;
                         }

                     case enMode.Reservation:
                         {
                             rbDaily.Visible = true;
                             rbWeekly.Visible = true;
                             rbMonthly.Visible = true;
                             if (_Car != null)
                             {
                                 gunaLabel1.Text = "Renal Rate:";

                             }
                             btnReservation.Visible = true;
                             break;
                         }

                 }

             }
             get
             {
                 return _Mode;
             }
         }*/
        private clsRentalBooking.enRentalRate _Rate;
        public ctrlCarProfile()
        {
            InitializeComponent();
        }
        public int _CarID
        {
            get { return (_Car == null) ? -1 : (int)_Car.CarID; }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (_Car == null)
                return;

            frmCarInfo CarInfo = new frmCarInfo(_CarID);
            CarInfo.ShowDialog();
           
        }

        public void LoadCarInfo(int CarID)
        {
            if (clsCarSetting.LoadCarInfo(ref _Car, CarID))
            {
               
                clsCarSetting._LoadCarImage( _Car.ImagePath, pbCarImage);

            }
            rbDaily.Tag = _Car.RentalPricePerDay;
            rbWeekly.Tag= _Car.RentalPricePerWeek;
            rbMonthly.Tag=_Car.RentalPricePerMonth;
            

        }
        
        public void LoadCarInfo(clsCar CarInfo)
        {
            if (CarInfo != null)
            {
                _Car = CarInfo;
               clsCarSetting._LoadCarImage(_Car.ImagePath, pbCarImage);
                rbDaily.Tag = _Car.RentalPricePerDay;
                rbWeekly.Tag = _Car.RentalPricePerWeek;
                rbMonthly.Tag = _Car.RentalPricePerMonth;
                lblStatus.Text = _Car.Status.ToString();
                RadioButtons_Click(rbDaily,null);
                gunaLabel1.Text = _Car.Make + ' ' + _Car.Model + ' ' + _Car.Year.ToString();
                rbDaily.Checked = true;
                

            }
            else
                MessageBox.Show("Sorry!! This object is empty" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void _AddCbQuantityItem(int Start, int End)
        {
            for (int i = Start; i <= End; i++)
            {
                cbQuantity.Items.Add(i.ToString());
            }
            cbQuantity.SelectedIndex = 0;
        }

        private void RadioButtons_Click(object sender, EventArgs e)
        {
            if (_Car != null)
                lblRentalPrice.Text=((GunaRadioButton)sender).Tag.ToString()+"/"+ ((GunaRadioButton)sender).Name.Substring(2);
            switch(((GunaRadioButton)sender).Name)
            {
                case "rbDaily":
                    cbQuantity.Items.Clear();
                    _AddCbQuantityItem(1, 25);
                    cbQuantity.SelectedIndex = 0;
                    _Rate = clsRentalBooking.enRentalRate.Daily;
                    break;
                case "rbWeekly":
                    cbQuantity.Items.Clear();
                    _AddCbQuantityItem(1, 3);
                    cbQuantity.SelectedIndex = 0;
                    _Rate = clsRentalBooking.enRentalRate.Weekly;

                    break;
                case "rbMonthly":
                    cbQuantity.Items.Clear();
                    _AddCbQuantityItem(1, 4);
                    cbQuantity.SelectedIndex = 0;
                    _Rate = clsRentalBooking.enRentalRate.Monthly;


                    break;


            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateCar frmAddUpdateCar = new frmAddUpdateCar(_CarID);
            frmAddUpdateCar.ShowDialog();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string CarImagePath=_Car.ImagePath;

            if (clsCar.DeleteCar(_CarID))
            {
                File.Delete(CarImagePath);
                MessageBox.Show("Data Deleteing Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: This car have Data Connected with it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnRegularMaintenance_Click(object sender, EventArgs e)
        {
            frmRegularMaintenanceScheduleDetails Details = new frmRegularMaintenanceScheduleDetails(_CarID);
            Details.ShowDialog();
        }
        private bool _CheckLimits(int Mileage,DataRow row)
        {
            foreach (var item in row.ItemArray.Skip(1))
            {
                if(Mileage>(int)item)
                    return false;

            }
            return true;
        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            /*
            int expectedMileage = _Car.Mileage;
            expectedMileage += (_Rate == clsRentalBooking.enRentalRate.Daily) ? ((int)clsRentalBooking.enLimitsMileage.Daily * Convert.ToInt32(cbQuantity.SelectedItem)) : (_Rate == clsRentalBooking.enRentalRate.Weekly) ? ((int)clsRentalBooking.enLimitsMileage.Weekly * Convert.ToInt32(cbQuantity.SelectedItem)) : ((int)clsRentalBooking.enLimitsMileage.Monthly * Convert.ToInt32(cbQuantity.SelectedItem));
          
            DataTable CarRegularMaintenanceSchedule = clsRegularMaintenanceSchedule.GetFullRegularMaintenanceCarSchedule(_CarID);
            if(_Car.WarrantyInfo==null)
            {
                MessageBox.Show("Error: This car don't have Warranty you Can't Reservation it .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //return;
            }
            if (!_CheckLimits(expectedMileage, CarRegularMaintenanceSchedule.Rows[0]))
            {
                MessageBox.Show("Error: This car will be  exceed regular maintenance schedule  you Can't Reservation it .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }*/
            if (_Car.Status != clsCar.enStatus.Available)
            {
                MessageBox.Show("This Car is not abailable for rent try another one","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmReservation NewReservation = new frmReservation(_CarID, Convert.ToInt32(cbQuantity.SelectedItem), _Rate);
            NewReservation.ShowDialog();
                    
        }
    }
}
