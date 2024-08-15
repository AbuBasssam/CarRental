using CarRental.Properties;
using CarRental_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRental.ctrlPersonInfo;

namespace CarRental
{
    public partial class ctrlRegularMaintenanceTypeRecord : UserControl
    {
        private clsRegularMaintenanceSchedule _Record;

        private clsRegularMaintenanceType.enRegularMaintenanceType _RegularMaintenanceType = clsRegularMaintenanceType.enRegularMaintenanceType.OilChange;
        
        private clsRegularMaintenanceSchedule _RegularMaintenanceTypeRecord;
        
        public clsRegularMaintenanceSchedule SelectedRegularMaintenanceType
        {
            get { return _RegularMaintenanceTypeRecord; }
        }
        public int RegularMaintenanceTypeRecordID
        {
            get { return (_RegularMaintenanceTypeRecord == null) ? -1 : (int)_RegularMaintenanceTypeRecord.ID; }
        }
        
        public void LoadRegularMaintenanceTypeInfo(int CarID, byte RegularMaintenanceTypeID)
        {
            _RegularMaintenanceTypeRecord = clsRegularMaintenanceSchedule.Find(CarID,RegularMaintenanceTypeID);
            if (_RegularMaintenanceTypeRecord == null)
            {
                ResetRegularMaintenanceTypeRecordInfo();
                MessageBox.Show("No Type with ID = " + RegularMaintenanceTypeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillRegularMaintenanceTypeInfo();
        }
       

        public void ResetRegularMaintenanceTypeRecordInfo()
        {

            lblRegularMaintenenceType.Text = "Regular Maintenence Type";
            txtNextScheduledMileage.Text = "";
            pbRegularMaintenenceType.Image= Resources.Oil_Change;

        }
       
        private void _FillRegularMaintenanceTypeInfo()
        {
            RegularMaintenanceType = _RegularMaintenanceTypeRecord.RegularTypeID;
            txtNextScheduledMileage.Text = _RegularMaintenanceTypeRecord.NextScheduledMileage.ToString();

        }


        public clsRegularMaintenanceType.enRegularMaintenanceType RegularMaintenanceType
        { set
            {
                _RegularMaintenanceType = value;

                switch (_RegularMaintenanceType)
                {

                    case clsRegularMaintenanceType.enRegularMaintenanceType.OilChange:
                        {
                            lblRegularMaintenenceType.Text = "Oil Change";
                            pbRegularMaintenenceType.Image = Resources.Oil_Change;
                            break;
                        }

                    case clsRegularMaintenanceType.enRegularMaintenanceType.TireRotation:
                        {
                            lblRegularMaintenenceType.Text = "Tire Rotation";
                            pbRegularMaintenenceType.Image = Resources.Tire_Rotation;
                            break;
                        }
                    case clsRegularMaintenanceType.enRegularMaintenanceType.BrakeInspection:
                        {
                            lblRegularMaintenenceType.Text = "Brake Inspection";
                            pbRegularMaintenenceType.Image = Resources.Brake_Inspection;
                            break;


                        }
                    case clsRegularMaintenanceType.enRegularMaintenanceType.AirFilter:
                        {
                            lblRegularMaintenenceType.Text = "Air Filter";
                            pbRegularMaintenenceType.Image = Resources.Air_Filter;
                            break;
                        }

                    case clsRegularMaintenanceType.enRegularMaintenanceType.TransmissionFluidChange:
                        {
                            lblRegularMaintenenceType.Text = "Transmission Fluid Change";
                            pbRegularMaintenenceType.Image = Resources.Transmission_Fluid_Change;
                            break;
                        }
                    case clsRegularMaintenanceType.enRegularMaintenanceType.SparkPlugReplacement:
                        {
                            lblRegularMaintenenceType.Text = "Spark Plug Replacement";
                            pbRegularMaintenenceType.Image = Resources.Spark_Plug_Replacement;
                            break;


                        }
                    case clsRegularMaintenanceType.enRegularMaintenanceType.CoolantFlush:
                        {
                            lblRegularMaintenenceType.Text = "Coolant Flush";
                            pbRegularMaintenenceType.Image = Resources.Coolant_Flush;
                            break;
                        }

                    case clsRegularMaintenanceType.enRegularMaintenanceType.BeltsandHosesInspection:
                        {
                            lblRegularMaintenenceType.Text = "Belts and Hoses Inspection";
                            pbRegularMaintenenceType.Image = Resources.Belts_And_Hoses_Inspection;
                            break;
                        }
                    
                }

            }
            get
            {
                return _RegularMaintenanceType;
            }
                    
                
            
        }

        public ctrlRegularMaintenanceTypeRecord()
        {
            InitializeComponent();
        }
       
        public  bool EnableUpdate
        {
            get
            {
                return (btnUpdate.Visible && txtNextScheduledMileage.Enabled);
            }
            set
            {
               
                btnUpdate.Visible = value;
                txtNextScheduledMileage.Enabled = value;
            }
        }

        private void txtNextScheduledMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _RegularMaintenanceTypeRecord.NextScheduledMileage=Convert.ToInt32(txtNextScheduledMileage.Text.Trim());
            if (_RegularMaintenanceTypeRecord.Save())
            { 
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LoadRegularMaintenanceTypeInfo((int)_RegularMaintenanceTypeRecord.ID, (byte)RegularMaintenanceType);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
