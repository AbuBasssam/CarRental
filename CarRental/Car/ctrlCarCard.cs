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
using System.IO;
namespace CarRental
{
    public partial class ctrlCarCard : UserControl
    {
        public ctrlCarCard()
        {
            InitializeComponent();
        }
        
        private clsCar _Car;
        public int _CarID
        {
            get { return (_Car == null) ? -1 : (int)_Car.CarID; }
        }

        public clsCar SelectedCarInfo
        {
            get { return _Car; }
        }

        public void LoadCarInfo(int CarID)
        {
           
           if(clsCarSetting.LoadCarInfo(ref _Car,CarID))
           {
               
                _FillCarInfo();

                clsCarSetting._LoadCarImage( _Car.ImagePath, pbCarImage);

           }
            else
                ResetCarInfo();
            /* _Car = clsCar.Find(CarID);
             if (_Car== null)
             {
                 ResetCarInfo();
                 MessageBox.Show("No Person with PersonID = " + CarID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/

        }

        private void _LoadCarImage()
        {
            

            string ImagePath = _Car.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbCarImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        
        private void _FuleImage()
        {
            switch (_Car.FuleTypeInfo.ID)
            {
                case clsFuleType.enFuleTypes.Gasoline:
                    pbFuleType.Image=Resources.gas_pump;
                    break;
                case clsFuleType.enFuleTypes.Diesel:
                    pbFuleType.Image = Resources.gasoline;
                    break;
                case clsFuleType.enFuleTypes.Electric:
                    pbFuleType.Image = Resources.charging;
                    break;
                case clsFuleType.enFuleTypes.Hybrid:
                    pbFuleType.Image = Resources.Haybird;
                    break;
                case clsFuleType.enFuleTypes.Plug_inHybrid:
                    pbFuleType.Image = Resources.Haybird;
                    break;

            }
        }

        private void _FillCarInfo()
        {
            lblName.Text = _Car.Make + ' ' + _Car.Model + ' ' + _Car.Year;
            lblColor.Text = _Car.Color;
            lblFuleType.Text = _Car.FuleTypeInfo.FuleType;
            _FuleImage();
            lblPlateNumber.Text = _Car.PlateNumber;
            lblCategory.Text = _Car.CategoryInfo.CategoryName;
            lblTransmission.Text = (_Car.Transmission == clsCar.enTransmission.Manual) ? "Manual" : "Automatic";
            pbTransmission.Image = (_Car.Transmission == clsCar.enTransmission.Manual) ? Resources.manual_transmission : Resources.Automatic_Transmission;
            lblRentalPerDay.Text = _Car.RentalPricePerDay.ToString();
            lblStatus.Text= (_Car.Status == clsCar.enStatus.Available) ? "Available" : (_Car.Status == clsCar.enStatus.InRent)? "InRent": "InMaintenance";
            pbStatusImage.Image = (_Car.Status == clsCar.enStatus.Available)? Resources.Green_shape : (_Car.Status == clsCar.enStatus.InRent) ? Resources.Red_shape : Resources.Yellow_shape;
           // _LoadCarImage();

        }

        public void ResetCarInfo()
        {
            lblName.Text = "[????]";
            lblColor.Text= "[????]";
            lblFuleType.Text = "[????]";
            lblCategory.Text = "[????]";
            lblTransmission.Text = "[????]";
            lblRentalPerDay.Text = "[????]";
            lblStatus.Text = "[????]";
            lblPlateNumber.Text = "[????]";



        }

        
    }
}
