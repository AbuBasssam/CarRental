using CarRental_BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmRentalBooking : Form
    {
        short NumberofPages,NumberOfFilterPages;
        DataTable Tempdt;
        enum enPageMode { DefaultMode,FilterMode }
        
        enPageMode PageMode;

        public frmRentalBooking()
        {
            InitializeComponent();
        }
        private void cbPageNumbersItem(int NumberOfItems)
        {
            if (cbPageNumber.Items.Count > 0) { cbPageNumber.Items.Clear(); }
            for (int i = 0; i < NumberOfItems; i++)
            {
                cbPageNumber.Items.Add(i + 1);
            }



        }
        private void _DefaultMode()
        {
             Tempdt = clsRentalBooking.GetRentalBookingsPage((int)cbPageNumber.SelectedItem);
            Tempdt = Tempdt.DefaultView.ToTable(false, "BookingID", "FullName",
                                                       "Car", "RentalStartDate", "RentalEndDate", "PickupLocation",
                                                       "DropOffLocation", "RentalRate", "RentalPrice",

                                                       "InitialTotalDueAmount", "LimitsMileage", "FulePercentage");
            dgvRentalBooking.DataSource = Tempdt;
            dgvRentalBooking.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            if (dgvRentalBooking.Rows.Count > 0)
            {

                dgvRentalBooking.Columns[0].HeaderText = "Booking ID";
                //dgvRentalBooking.Columns[0].Width = 80;

                dgvRentalBooking.Columns[1].HeaderText = " Customer Name.";
                //dgvRentalBooking.Columns[1].Width = 120;


                dgvRentalBooking.Columns[2].HeaderText = "Reservation Car";
                //dgvRentalBooking.Columns[2].Width = 120;

                dgvRentalBooking.Columns[3].HeaderText = "Start Date";
                //dgvRentalBooking.Columns[3].Width = 120;


                dgvRentalBooking.Columns[4].HeaderText = "End Date";
                // dgvRentalBooking.Columns[4].Width = 140;

                dgvRentalBooking.Columns[5].HeaderText = "PU.Location";
                //dgvRentalBooking.Columns[5].Width = 180;

                dgvRentalBooking.Columns[6].HeaderText = "Dp.Locatoin";
                //dgvRentalBooking.Columns[6].Width = 180;

                dgvRentalBooking.Columns[7].HeaderText = "Rental Rate";
                //dgvRentalBooking.Columns[7].Width = 100;

                dgvRentalBooking.Columns[8].HeaderText = "Rental Price";
                //dgvRentalBooking.Columns[8].Width = 120;


                dgvRentalBooking.Columns[9].HeaderText = "Total Amount";
                //dgvRentalBooking.Columns[9].Width = 150;

                dgvRentalBooking.Columns[10].HeaderText = "Limits Mileage";
                //dgvRentalBooking.Columns[10].Width = 120;


                dgvRentalBooking.Columns[11].HeaderText = "Fuel Persentage";
                //dgvRentalBooking.Columns[11].Width = 100;
            }
        }
        private void _FilterMode()
        {
            // Tempdt.Columns.Clear();
            int Year = cbYearFilter.SelectedItem.ToString() == "none" ? 0 : Convert.ToInt32(cbYearFilter.SelectedItem);
           Tempdt = clsRentalBooking.GetRentalBookingsFilter(Year, cbMonthFilter.SelectedIndex,(int)cbPageNumber.SelectedItem);
           Tempdt = Tempdt.DefaultView.ToTable(false, "BookingID", "FullName",
                                                           "Car", "RentalStartDate", "RentalEndDate", "PickupLocation",
                                                           "DropOffLocation", "RentalRate", "RentalPrice",
                                                          "InitialTotalDueAmount", "LimitsMileage", "FulePercentage");
            dgvRentalBooking.DataSource =Tempdt;
            dgvRentalBooking.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            if (dgvRentalBooking.Rows.Count > 0)
            {

                dgvRentalBooking.Columns[0].HeaderText = "Booking ID";
                //dgvRentalBooking.Columns[0].Width = 80;

                dgvRentalBooking.Columns[1].HeaderText = " Customer Name.";
                //dgvRentalBooking.Columns[1].Width = 120;


                dgvRentalBooking.Columns[2].HeaderText = "Reservation Car";
                //dgvRentalBooking.Columns[2].Width = 120;

                dgvRentalBooking.Columns[3].HeaderText = "Start Date";
                //dgvRentalBooking.Columns[3].Width = 120;


                dgvRentalBooking.Columns[4].HeaderText = "End Date";
                // dgvRentalBooking.Columns[4].Width = 140;

                dgvRentalBooking.Columns[5].HeaderText = "PU.Location";
                //dgvRentalBooking.Columns[5].Width = 180;

                dgvRentalBooking.Columns[6].HeaderText = "Dp.Locatoin";
                //dgvRentalBooking.Columns[6].Width = 180;

                dgvRentalBooking.Columns[7].HeaderText = "Rental Rate";
                //dgvRentalBooking.Columns[7].Width = 100;

                dgvRentalBooking.Columns[8].HeaderText = "Rental Price";
                //dgvRentalBooking.Columns[8].Width = 120;


                dgvRentalBooking.Columns[9].HeaderText = "Total Amount";
                //dgvRentalBooking.Columns[9].Width = 150;

                dgvRentalBooking.Columns[10].HeaderText = "Limits Mileage";
                //dgvRentalBooking.Columns[10].Width = 120;


                dgvRentalBooking.Columns[11].HeaderText = "Fuel Persentage";
                //dgvRentalBooking.Columns[11].Width = 100;
            }
        }
        private void FilterComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cbYearvalue = cbYearFilter.SelectedIndex;
            int cbMonthvalue = cbMonthFilter.SelectedIndex;
            if (cbYearvalue == 0 && cbMonthvalue == 0)
            {
                frmRentalBooking_Load(null, null);
                return;
            }

            PageMode = enPageMode.FilterMode;
           
            if (cbYearvalue != 0) { cbYearvalue =(int)cbYearFilter.SelectedItem; }
            if (cbMonthvalue!= 0) { cbMonthvalue = cbMonthFilter.SelectedIndex; }
            NumberOfFilterPages =(short) clsRentalBooking.NumberOfFilterPages(cbYearvalue, cbMonthvalue);
            if(NumberOfFilterPages==0)
            {
                dgvRentalBooking.Columns.Clear();
                txtPageNumber.Visible = false;
                cbPageNumber.Visible = false;
                return;
            }
            txtPageNumber.Visible = true;
            cbPageNumber.Visible = true;
            cbPageNumbersItem(NumberOfFilterPages);
            cbPageNumber.SelectedIndex = 0;

            //else
            //{
            //    dgvRentalBooking.Rows.Clear();
            //    return;
            // }
            
            

        }

        private void cbPageNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PageMode == enPageMode.DefaultMode)
            {
                _DefaultMode();
            }
            else
                _FilterMode();
        }

        private void frmRentalBooking_Load(object sender, EventArgs e)
        {
            PageMode = enPageMode.DefaultMode;
            txtPageNumber.Visible = true;
            cbPageNumber.Visible = true;
            if (cbYearFilter.Items.Count == 1)
            {
                int MinummYear =  clsRentalBooking.MniumRentalBookingYear();
                for (int i = DateTime.Now.Year; i >= MinummYear; i--)
                {
                    cbYearFilter.Items.Add(i);
                }
            }
            if (NumberofPages== 0)
            {
                NumberofPages =(short) clsRentalBooking.NumberOfPages();
            }
          
            cbPageNumbersItem(NumberofPages);
            cbPageNumber.SelectedIndex = 0;
            
            
           
            
            
            
            
            /*DataTable Tempdt = clsRentalBooking.GetRentalBookingsPage(1);
            Tempdt = Tempdt.DefaultView.ToTable(false, "BookingID", "FullName",
                                                       "Car", "RentalStartDate", "RentalEndDate", "PickupLocation",
                                                       "DropOffLocation", "RentalRate", "RentalPrice",
                                                       "InitialTotalDueAmount", "LimitsMileage", "FulePercentage");
            dgvRentalBooking.DataSource = Tempdt;
            //cbMonthFilter.SelectedIndex = 0;
            //cbYearFilter.SelectedIndex = 0;
            dgvRentalBooking.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            if (dgvRentalBooking.Rows.Count > 0)
            {

                dgvRentalBooking.Columns[0].HeaderText = "Booking ID";
                //dgvRentalBooking.Columns[0].Width = 80;

                dgvRentalBooking.Columns[1].HeaderText = " Customer Name.";
                //dgvRentalBooking.Columns[1].Width = 120;


                dgvRentalBooking.Columns[2].HeaderText = "Reservation Car";
                //dgvRentalBooking.Columns[2].Width = 120;

                dgvRentalBooking.Columns[3].HeaderText = "Start Date";
                //dgvRentalBooking.Columns[3].Width = 120;


                dgvRentalBooking.Columns[4].HeaderText = "End Date";
                // dgvRentalBooking.Columns[4].Width = 140;

                dgvRentalBooking.Columns[5].HeaderText = "PU.Location";
                //dgvRentalBooking.Columns[5].Width = 180;

                dgvRentalBooking.Columns[6].HeaderText = "Dp.Locatoin";
                //dgvRentalBooking.Columns[6].Width = 180;

                dgvRentalBooking.Columns[7].HeaderText = "Rental Rate";
                //dgvRentalBooking.Columns[7].Width = 100;

                dgvRentalBooking.Columns[8].HeaderText = "Rental Price";
                //dgvRentalBooking.Columns[8].Width = 120;


                dgvRentalBooking.Columns[9].HeaderText = "Total Amount";
                //dgvRentalBooking.Columns[9].Width = 150;

                dgvRentalBooking.Columns[10].HeaderText = "Limits Mileage";
                //dgvRentalBooking.Columns[10].Width = 120;


                dgvRentalBooking.Columns[11].HeaderText = "Fuel Persentage";
                //dgvRentalBooking.Columns[11].Width = 100;
            }
            Task.WaitAll(GetNumberOfPagesTask, GetYearTask);
            NumberofPages = (short)GetNumberOfPagesTask.Result;
            cbPageNumbersFillItems(NumberofPages);
            //_ComboBoxesItem(cbYearFilter, GetYearTask.Result);
            for (int i = DateTime.Now.Year; i >= GetYearTask.Result; i--)
            {
                cbYearFilter.Items.Add(i);
            }*/
        }

        
    }
}
