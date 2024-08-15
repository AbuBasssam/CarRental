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
    public partial class frmLoadingScreen : Form
    {
        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

                gunaProgressBar1.Value++;
                gunaLabel3.Text = gunaProgressBar1.Value+"%".ToString();
            
            
            
            if (gunaProgressBar1.Value == 100)
            {

                timer1.Enabled = false;
                this.Close();


            }
           
               
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
