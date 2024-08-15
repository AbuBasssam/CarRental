using CarRental.Properties;
using CarRental_BusinessLayer;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public  class clsListSetting
    {

        public static  Guna2DataGridView dgvList;
        public static Guna2TextBox txtFilterBy;
        public static Guna2ComboBox cbFilterBy;
        public static Guna2PictureBox pictureBox;
        public static Guna2ComboBox cbPageNumber;
         private static bool FirstTime = true;

        private clsListSetting() { }
        private static void _RegularMaintenanceFilterItem()
        {  
           if(cbFilterBy.Items.Count > 0) { cbFilterBy.Items.Clear(); }
            cbFilterBy.Items.Add("None");
            cbFilterBy.Items.Add("CarID");
            cbFilterBy.Items.Add("OilChange");
            cbFilterBy.Items.Add("TireRotation");
            cbFilterBy.Items.Add("Brake Inspection");
            cbFilterBy.Items.Add("AirFilter");
            cbFilterBy.Items.Add("SparkPlugReplacement");
            cbFilterBy.Items.Add("TransmissionFluidChange");
            cbFilterBy.Items.Add("CoolantFlush");
            cbFilterBy.Items.Add("BeltsAndHosesInspection");

        }
        
        private static void _PageNumbereFilterItem()
        {
            if (cbPageNumber.Items.Count > 0) { cbPageNumber.Items.Clear(); }
            int NumberofPages = clsRegularMaintenanceSchedule.NumberOfPages();
            for (int i = 0; i < NumberofPages; i++)
            {
                cbPageNumber.Items.Add(i+1);
            }



        }
        
        private static void _ListRegularMaintenanceScheduleSetting(DataTable List)
        {
            if (List.Rows.Count > 0)
            {
                dgvList.Columns[0].HeaderText = "Car ID";
                dgvList.Columns[0].Width = 100;

                dgvList.Columns[1].HeaderText = "Oil Change";
                dgvList.Columns[1].Width = 130;

                dgvList.Columns[2].HeaderText = "Tire Rotation";
                dgvList.Columns[2].Width = 130;

                dgvList.Columns[3].HeaderText = "Brake Inspection";
                dgvList.Columns[3].Width = 150;

                dgvList.Columns[4].HeaderText = "Air Filter";
                dgvList.Columns[4].Width = 110;

                dgvList.Columns[5].HeaderText = "Spark Plug Replacement";
                dgvList.Columns[5].Width = 210;

                dgvList.Columns[6].HeaderText = "Transmission Fluid Change";
                dgvList.Columns[6].Width = 210;

                dgvList.Columns[7].HeaderText = "Coolant Flush";
                dgvList.Columns[7].Width = 150;

                dgvList.Columns[8].HeaderText = "Belts And Hoses Inspection";
                dgvList.Columns[8].Width = 220;
            }
        }
       
        public static void ListRegularMaintenanceSchedule_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Resources.Regular_maintenance;
            dgvList.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            _RegularMaintenanceFilterItem();
            _PageNumbereFilterItem();
            cbFilterBy.SelectedIndex = 0;
            cbPageNumber.SelectedIndex = 0;

            DataTable _dtAllRegularMaintenanceSchedule = clsRegularMaintenanceSchedule.GetRegularMaintenanceSchedulePage((int)cbPageNumber.SelectedItem);
            dgvList.DataSource = _dtAllRegularMaintenanceSchedule;
           
                _ListRegularMaintenanceScheduleSetting(_dtAllRegularMaintenanceSchedule);

                FirstTime = false;
            
          

        }
        
        public static void ListRegularMaintenanceSchedule_cbPageNumberSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.TextLength > 0)
            {
                txtFilterBy.Text = "";
                return;
            }
           
            if (!FirstTime)
            {
                DataTable _dtAllRegularMaintenanceSchedule = clsRegularMaintenanceSchedule.GetRegularMaintenanceSchedulePage((int)cbPageNumber.SelectedItem);
                dgvList.DataSource = _dtAllRegularMaintenanceSchedule;
                _ListRegularMaintenanceScheduleSetting(_dtAllRegularMaintenanceSchedule);
               

            }

        }

        public static void txtRegularMaintenanceScheduleFiltertValue_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.TextLength > 0 && cbFilterBy.SelectedIndex!=0)
            {
                DataTable _dtAllRegularMaintenanceSchedule = clsRegularMaintenanceSchedule.Filter((Convert.ToInt32(txtFilterBy.Text)));
               
                    dgvList.DataSource = _dtAllRegularMaintenanceSchedule;

                    _ListRegularMaintenanceScheduleSetting(_dtAllRegularMaintenanceSchedule);



            }
            else
            {
                DataTable _dtAllRegularMaintenanceSchedule = clsRegularMaintenanceSchedule.GetRegularMaintenanceSchedulePage((int)cbPageNumber.SelectedItem);

                dgvList.DataSource = _dtAllRegularMaintenanceSchedule;
                _ListRegularMaintenanceScheduleSetting(_dtAllRegularMaintenanceSchedule);




            }

        }

        public static void cbRegularMaintenanceScheduleFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsRegularMaintenanceSchedule.ChangeFilter(cbFilterBy.SelectedIndex);


        }
        
        public static void RegularMaintenanceScheduleShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegularMaintenanceScheduleDetails Details=new frmRegularMaintenanceScheduleDetails((int)dgvList.CurrentRow.Cells[0].Value);
            Details.ShowDialog();
            DataTable _dtAllRegularMaintenanceSchedule = clsRegularMaintenanceSchedule.GetRegularMaintenanceSchedulePage((int)cbPageNumber.SelectedItem);
            _ListRegularMaintenanceScheduleSetting(_dtAllRegularMaintenanceSchedule);
            dgvList.DataSource = _dtAllRegularMaintenanceSchedule;

        }
        
        
       

    }
}
