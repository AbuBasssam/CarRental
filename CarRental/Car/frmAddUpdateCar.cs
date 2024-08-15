using CarRental.Properties;
using CarRental_BusinessLayer;
using Guna.UI.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//using Guna.UI2.HtmlRenderer.Adapters;

namespace CarRental
{
    public partial class frmAddUpdateCar : Form
    {
        public delegate void DataBackEventHandler(object sender, int CarID);
        public delegate void SendNotificatoin(object sender, int CarID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public event SendNotificatoin Notification;

        public enum enMode { AddNew = 0, Update = 1 };


        private enMode _Mode;
        private int _CarID;
        private clsCar _Car;
        public frmAddUpdateCar()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddUpdateCar(int CarID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _CarID = CarID;

        }

        

        /* private void _FillCategoriesInComboBox()
         {
             try
             {
                 // Clear the current items in the ComboBox
                // cbCategory.Items.Clear();

                 // Run the database call on a background thread
                 DataTable dtCategories = clsCarCategory.GetAllCategories();

                 // Update the ComboBox on the UI thread

                     cbCategory.Items.Clear();
                     foreach (DataRow row in dtCategories.Rows)
                     {
                         cbCategory.Items.Add(row["CategoryName"]);
                     }
                     cbCategory.SelectedIndex = 0;


             }
             catch (Exception ex)
             {
                 MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
         private void _FillMakeModelsInComboBox()
         {
             try
             {
                 // Clear the current items in the ComboBox
                 cbModel.Items.Clear();

                 // Run the database call on a background thread
                 DataTable dtModels = clsCar.GetMakeModels(cbMake.SelectedItem.ToString());

                 // Update the ComboBox on the UI thread

                     cbModel.Items.Clear();
                     foreach (DataRow row in dtModels.Rows)
                     {
                         cbModel.Items.Add(row["ModelName"]);
                     }
                     cbModel.SelectedIndex = 0;


             }
             catch (Exception ex)
             {
                 MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void _FillFuelTypeInComboBox()
         {
             try
             {
                 // Clear the current items in the ComboBox
                 cbFuleType.Items.Clear();

                 // Run the database call on a background thread
                 DataTable dtFuelType =  clsFuleType.GetAllFuleTypes();

                 // Update the ComboBox on the UI thread

                     cbFuleType.Items.Clear();
                     foreach (DataRow row in dtFuelType.Rows)
                     {
                         cbFuleType.Items.Add(row[1]);
                     }
                     cbFuleType.SelectedIndex = 0;


             }
             catch (Exception ex)
             {
                 MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
         private void _FillAllComboBoxes()
         {


             _FillMakeModelsInComboBox();
             _FillFuelTypeInComboBox();
             _FillCategoriesInComboBox();



         }*/

        private  void _ResetDefualtValues()
        {
            string MakeValue = cbMake.SelectedItem.ToString();
            var FuleTypeTask = Task.Run(()=> clsFuleType.GetAllFuleTypes());
            var MakeModelsTask = Task.Run(() => clsCar.GetMakeModels(MakeValue)) ;
            var CarCategoriesTask = Task.Run(() => clsCarCategory.GetAllCategories());

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Car";
                _Car = new clsCar();
            }
            else
            {
                lblTitle.Text = "Update Car";
            }
            cbStatus.SelectedIndex = 0;
            cbTransmission.SelectedIndex = 0;
             txtMileage.Text = "";
             txtYear.Text = "";
             txtVIN.Text = "";
             txtPlateNumber.Text = "";
             llRemoveImage.Visible = false;
             twAddWarranty.Checked = true;
             twAddRegularMaintenanceSchedule.Checked = true;
            Task.WaitAll(FuleTypeTask, MakeModelsTask, CarCategoriesTask);

            clsUtil.FillComboBox(FuleTypeTask.Result, cbFuleType, "FuleType");
            clsUtil.FillComboBox(CarCategoriesTask.Result, cbCategory, "CategoryName");
            clsUtil.FillComboBox(MakeModelsTask.Result, cbModel, "ModelName");

            
        }

        private string ColorToName(Color color)
        {
            // Try to find the color name in the KnownColor enum
            string colorName = Enum.GetName(typeof(KnownColor), color.ToKnownColor());
            if (colorName != null)
            {
                return colorName;
            }

            // If the color is not in the KnownColor enum, try to find the closest named color
            double minDiff = double.MaxValue;
            string closestColorName = null;

            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color knownColorValue = Color.FromKnownColor(knownColor);

                // Ignore transparent colors
                if (knownColorValue.A == 0)
                    continue;

                double diff = Math.Sqrt(Math.Pow(color.R - knownColorValue.R, 2) +
                                        Math.Pow(color.G - knownColorValue.G, 2) +
                                        Math.Pow(color.B - knownColorValue.B, 2) +
                                        Math.Pow(color.A - knownColorValue.A, 2));

                if (diff < minDiff)
                {
                    minDiff = diff;
                    closestColorName = Enum.GetName(typeof(KnownColor), knownColor);
                }
            }

            // Optionally, you could add a threshold to determine if the color is "close enough"
            double threshold = 10.0; // Adjust this value as needed
            if (minDiff < threshold)
            {
                return closestColorName;
            }
            else
            {
                return "Unknown Color";
            }
        }
        private void _LoadData()
        {

            _Car = clsCar.Find(_CarID);

            if (_Car == null)
            {
                MessageBox.Show("No User with ID = " + _CarID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblCarID.Text=_Car.CarID.ToString();
            txtMileage.Text = _Car.Mileage.ToString();
            txtYear.Text = _Car.Year.ToString();
            txtVIN.Text = _Car.VIN;
            txtPlateNumber.Text = _Car.PlateNumber;
            cbMake.SelectedIndex = cbMake.FindString(_Car.Make);
            cbModel.SelectedIndex=  cbModel.FindStringExact(_Car.Model);            
            cbCategory.SelectedIndex= cbCategory.FindString(_Car.CategoryInfo.CategoryName);
            if (cbModel.SelectedIndex == -1)
            {
                cbModel.Items.Add(_Car.Model.ToString()); 
                cbModel.SelectedIndex=cbModel.Items.Count - 1;
            
            }
            cbFuleType.SelectedIndex= cbFuleType.FindString(_Car.FuleTypeInfo.FuleType);
            cbTransmission.SelectedIndex= cbTransmission.FindString(_Car.Transmission.ToString());
            cbStatus.SelectedIndex =cbStatus.FindString(_Car.Status.ToString());
            cbColors.SelectedIndex= cbColors.FindString(_Car.Color.ToString());
            txtRentalPricePerDay.Text = _Car.RentalPricePerDay.ToString();
            pbCarImage.ImageLocation=_Car.ImagePath;
            twAddWarranty.Checked = (_Car.WarrantyInfo != null);
            twAddWarranty.Enabled = !twAddWarranty.Checked;
            clsRegularMaintenanceSchedule.ChangeFilter(1);
            twAddRegularMaintenanceSchedule.Checked=( clsRegularMaintenanceSchedule.Filter((int)_Car.CarID).Rows.Count>0);
            twAddRegularMaintenanceSchedule.Enabled = !twAddRegularMaintenanceSchedule.Checked;
            cbMake.Enabled = false;
            cbModel.Enabled = false;
            txtYear.Enabled = false;
            cbTransmission.Enabled = false;
            cbCategory.Enabled = false;
            cbColors.Enabled = false;
            cbFuleType.Enabled = false;
            //twAddRegularMaintenanceSchedule
        }

        private bool _HandleCarImage()
        {
            if(pbCarImage.ImageLocation == null)
            {
                MessageBox.Show("The Image is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

           


            if (_Car.ImagePath != pbCarImage.ImageLocation )
            {
                if (_Car.ImagePath != null)
                {

                    try
                    {
                        File.Delete(_Car.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }
                

                    string SourceImageFile = pbCarImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectCarImagesFolder(ref SourceImageFile))
                    {
                        pbCarImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
            }

            
            return true;
        }

        private void frmAddUpdateCars_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private  void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Items.Clear();

           clsUtil.FillComboBox(clsCar.GetMakeModels(cbMake.SelectedItem.ToString()), cbModel, "ModelName");

        }

        private bool _OutOfRangePrices()
        {
            switch (cbCategory.SelectedItem)
            {
                case "Economy":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 30)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 60)); //Economy: $30 - $60 per day

                case "Standard":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 45)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 90)); //Standard: $45 - $90 per day

                case "Full-Size":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 50)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 100));//Full - Size: $50 - $100 per day

                case "Minivan":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 60)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 120)); /*Minivan: $60 - $120 per day*/

                case "SUV":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 60)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 150));/* SUV: $60 - $150 per day*/

                case "Luxury":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 100)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 300)); /*Luxury: $100 - $300 per day*/

                case "Specialty Sport":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 100)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 400)); /*Specialty / Sport: $100 - $400 per day*/
                
                case "Compact":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 35) ||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 70)); //Compact: $35 - $70 per day

                case "Intermediate":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 40)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 80)); //Intermediate: $40 - $80 per day

                case "MidSize":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 50)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 100)); /*Mid - Size: $50 - $100 per day*/


                case "CrossOver":
                    return ((Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) < 50)||
                            (Convert.ToInt16(txtRentalPricePerDay.Text.Trim()) > 100)); //Crossover: $50 - $100 per day
                default:
                    return false;
            }
        }
        private void Numericaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some Cars fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!_HandleCarImage())
                return;
            _Car.Make = cbMake.SelectedItem.ToString().Trim();
            _Car.Model = cbModel.SelectedItem.ToString().Trim();
            _Car.Year=Convert.ToInt32(txtYear.Text);  
            _Car.Mileage= Convert.ToInt32(txtMileage.Text);
            _Car.Color = cbColors.SelectedItem.ToString();
            _Car.FuelTypeID = (clsFuleType.enFuleTypes)(cbFuleType.SelectedIndex + 1);
            _Car.PlateNumber = txtPlateNumber.Text.Trim();
            _Car.CarCategoryID=(clsCarCategory.enCarCategories)(cbCategory.SelectedIndex + 1);
            _Car.VIN = txtVIN.Text.Trim();
            _Car.Transmission=(clsCar.enTransmission)(cbTransmission.SelectedIndex);
            _Car.RentalPricePerDay = Convert.ToSingle(txtRentalPricePerDay.Text);
            _Car.ImagePath = pbCarImage.ImageLocation;
            _Car.Status = (clsCar.enStatus)(cbStatus.SelectedIndex+1);

            if (_Car.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (twAddRegularMaintenanceSchedule.Enabled && twAddRegularMaintenanceSchedule.Checked)
                {
                    if (_Car.AddNewFullRegularMaintenanceSchedule())
                    {
                        MessageBox.Show("a new Regular Maintenance Schedule Added Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        twAddRegularMaintenanceSchedule.Checked = false;
                    }
                    else
                        MessageBox.Show("Error:Regular Maintenance Schedule Is not Added Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                if (twAddWarranty.Enabled && twAddWarranty.Checked)
                {
                        if (_Car.AddNewWarranty())
                        {
                            MessageBox.Show(" a Warranty Added Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        twAddWarranty.Enabled = false;
                        }
                        else
                            MessageBox.Show("Error:Warranty Is not Added Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }

                    

                lblCarID.Text = _Car.CarID.ToString();
               
                    
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Car";
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Trigger the event to send data back to the caller form.
            DataBack?.Invoke(this, (int)_Car.CarID);

        }

     
        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtYear, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtYear, null);
            }

            if (Convert.ToInt32(txtYear.Text) > (int)DateTime.Now.Year|| Convert.ToInt32(txtYear.Text) < 1800)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtYear, "Wrong Year");
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtYear, null);

            }
        }
        
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbCarImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbCarImage.ImageLocation = null;
            llRemoveImage.Visible = false;
        }


        private void txtPlateNumber_Validating(object sender, CancelEventArgs e)
        {
            bool NumberRequired = false;
            bool LetterRequired = false;
            if (string.IsNullOrEmpty(txtPlateNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPlateNumber, "This field is required!");
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPlateNumber, null);
            }
          
            if(_Car.PlateNumber!=txtPlateNumber.Text.Trim() && clsCar.IsCarExist(txtPlateNumber.Text.Trim()))
            {
                errorProvider1.SetError(txtPlateNumber, "This plate number is already there!, try another one");
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPlateNumber, null);
            }
           
               if (char.IsLetter(txtPlateNumber.Text[4])){ LetterRequired = true; }
               if(char.IsDigit(txtPlateNumber.Text[0])){ NumberRequired =true; }
                

           
            if (!(NumberRequired && LetterRequired))
            {
                errorProvider1.SetError(txtPlateNumber, "Plate Number shoud have at least one letter and one character!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPlateNumber, null);
            }

        }

        private void txtVIN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVIN.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtVIN, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVIN, null);
            }
            if (_Car.PlateNumber != txtPlateNumber.Text.Trim() && clsCar.IsCarExistByVIN(txtVIN.Text.Trim()))
            {
                errorProvider1.SetError(txtVIN, "This VIN is already there!, try another one");
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVIN, null);
            }
            if (!txtVIN.MaskFull)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtVIN, "The VIN should be 17 characters!");
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVIN, null);
            }
        }

        private void txtRentalPricePerDay_Validating(object sender, CancelEventArgs e)
        {
            if (_OutOfRangePrices())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRentalPricePerDay, "Wrong pirce for this category" +
                    "\nEconomy: $30 - $60 per day" +
                    "\nFullSize: $50 - $100 per day" +
                    "\nMinivan: $60 - $120 per day" +
                    "\nSUV: $60 - $150 per day" +
                    "\nLuxury: $100 - $300 per day" +
                    "\nSpecialty Sport: $100 - $400 per day" +
                    "\nCompact: $35 - $70 per day" +
                    "\nIntermediate: $40 - $80 per day" +
                    "\nMidSize: $50 - $100 per day" +
                    "\nCrossover: $50 - $100 per day" +
                    "\nStandard: $45 - $90 per day"
                    );
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRentalPricePerDay, null);
            }

        }
    }
}
