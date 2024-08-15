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

namespace CarRental
{
    public partial class frmCustomerInfo : Form
    {
        private int _CustomerID;
        
        public frmCustomerInfo(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            ctrlCustomerCard1.LoadCustomerInfo(_CustomerID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
