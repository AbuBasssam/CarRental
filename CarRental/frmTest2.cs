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

namespace CarRental
{
    public partial class frmTest2 : Form
    {
        public frmTest2()
        {
            InitializeComponent();
        }

        private void frmTest2_Load(object sender, EventArgs e)
        {
            ctrlShows1.LoadSetting(clsListSetting.ListRegularMaintenanceSchedule_Load,clsListSetting.ListRegularMaintenanceSchedule_cbPageNumberSelectedIndexChanged, clsListSetting.txtRegularMaintenanceScheduleFiltertValue_TextChanged ,clsListSetting.cbRegularMaintenanceScheduleFilterBy_SelectedIndexChanged, clsListSetting.RegularMaintenanceScheduleShowDetailsToolStripMenuItem_Click);
            
        }

        
    }
}
