using CarRental.Properties;
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
using static CarRental_BusinessLayer.clsRegularMaintenanceType;

namespace CarRental
{
    public partial class ctrlRegularMaintenanceSchedule : UserControl
    {
        private DataTable _Schedule;
        
        /*        clsCar _Car;
                public int _CarID
                {
                    get { return (_Car == null) ? -1 : (int)_Car.CarID; }
                }

                public clsCar SelectedCarInfo
                {
                    get { return _Car; }
                }*/
        
        private int _CarID;

        public ctrlRegularMaintenanceSchedule()
        {
            InitializeComponent();
        }
        public bool EnableUpdatMode
        {
            get
            {
                return (
                      (ctrlOilChange.EnableUpdate) ?
                      (ctrlTireRotation.EnableUpdate) ?
                      (ctrlBrakeInspection.EnableUpdate) ?
                      (ctrlAirFilter.EnableUpdate) ?
                      (ctrlSparkPlugReplacement.EnableUpdate) ?
                      (ctrlTransmissionFluidChange.EnableUpdate) ?
                      (ctrlCoolantFlush.EnableUpdate) ?
                      (ctrlBeltsandHosesInspection.EnableUpdate) ?
                      true :
                      false :
                      false :
                      false :
                      false :
                      false :
                      false :
                      false :
                      false
                      );
            }
            set
            {
                ctrlOilChange.EnableUpdate = value;
                ctrlTireRotation.EnableUpdate = value;
                ctrlBrakeInspection.EnableUpdate = value;
                ctrlAirFilter.EnableUpdate = value;
                ctrlSparkPlugReplacement.EnableUpdate = value;
                ctrlTransmissionFluidChange.EnableUpdate = value;
                ctrlCoolantFlush.EnableUpdate = value;
                ctrlBeltsandHosesInspection.EnableUpdate = value;

            }
        }
        public void LoadScheduleInfo(int CarID)
        {
            _Schedule = clsRegularMaintenanceSchedule.GetFullRegularMaintenanceCarSchedule(CarID);
            if (_Schedule == null)
            {
                //ResetRegularMaintenanceTypeRecordInfo();
                MessageBox.Show("No Schedule for  CarID = " + CarID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _CarID = CarID;
            _FillRegularMaintenanceTypeInfo();
        }

        /*public void ResetRegularMaintenanceTypeRecordInfo()
        {

            lblRegularMaintenenceType.Text = "Regular Maintenence Type";
            txtNextScheduledMileage.Text = "";
            pbRegularMaintenenceType.Image = Resources.Oil_Change;
        }*/

        private void _FillRegularMaintenanceTypeInfo()
        {
            /*DataRow row = _Schedule.Rows[0];
            ctrlOilChange.NextScheduledMileage = (int)row["OilChange"];
            ctrlTireRotation.NextScheduledMileage = (int)row["TireRotation"];
            ctrlBrakeInspection.NextScheduledMileage = (int)row["BrakeInspection"];
            ctrlAirFilter.NextScheduledMileage = (int)row["AirFilter"];
            ctrlSparkPlugReplacement.NextScheduledMileage = (int)row["SparkPlugReplacement"];
            ctrlTransmissionFluidChange.NextScheduledMileage = (int)row["TransmissionFluidChange"];
            ctrlCoolantFlush.NextScheduledMileage = (int)row["CoolantFlush"];
            ctrlBeltsandHosesInspection.NextScheduledMileage = (int)row["BeltsandHosesInspection"];*/
            
            
            ctrlOilChange.LoadRegularMaintenanceTypeInfo(_CarID, 1);
            ctrlTireRotation.LoadRegularMaintenanceTypeInfo(_CarID, 2);
            ctrlBrakeInspection.LoadRegularMaintenanceTypeInfo(_CarID, 3);
            ctrlAirFilter.LoadRegularMaintenanceTypeInfo(_CarID, 4);
            ctrlSparkPlugReplacement.LoadRegularMaintenanceTypeInfo(_CarID, 5);
            ctrlTransmissionFluidChange.LoadRegularMaintenanceTypeInfo(_CarID, 6);
            ctrlCoolantFlush.LoadRegularMaintenanceTypeInfo(_CarID, 7);
            ctrlBeltsandHosesInspection.LoadRegularMaintenanceTypeInfo(_CarID, 8);
            lblCarID.Text = _CarID.ToString();
            clsCar _Car = clsCar.Find(ctrlBeltsandHosesInspection.SelectedRegularMaintenanceType.CarID);
            string Name = _Car.Make + " " + _Car.Model+" " + _Car.Year;
            lblName.Text = Name;
            lblMileage.Text=      _Car.Mileage.ToString();
            lblStatus.Text =      _Car.Status.ToString();
            lblPlateNumber.Text=  _Car.PlateNumber.ToString();
            lblCarCategory.Text = _Car.CategoryInfo.CategoryName;






            //RegularMaintenanceType = _RegularMaintenanceTypeRecord.RegularTypeID;
            //txtNextScheduledMileage.Text = _RegularMaintenanceTypeRecord.NextScheduledMileage.ToString();

        }
    }
}
           