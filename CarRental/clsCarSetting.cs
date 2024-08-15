using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarRental
{
    public static class clsCarSetting
    {
        public  static bool LoadCarInfo( ref clsCar Car, int CarID)
        {
            Car = clsCar.Find(CarID);
            if (Car == null)
            {
                MessageBox.Show("No Car with this ID = " + CarID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

            
        }
        

        public static void _LoadCarImage( string ImagePath, PictureBox pbCarImage)
        {

            if (ImagePath != ""||ImagePath!=null)
                if (File.Exists(ImagePath))
                    pbCarImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
       



    }
}
