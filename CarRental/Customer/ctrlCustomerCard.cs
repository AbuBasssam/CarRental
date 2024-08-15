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

namespace CarRental
{
    public partial class ctrlCustomerCard : UserControl
    {
        private clsCustomer _Customer;

        public int CustomerID
        {
            get { return (_Customer == null) ? -1 : (int)_Customer.CustomerID; }
        }
        public clsCustomer SelectedCustomer { get {  return _Customer; } }
        public ctrlCustomerCard()
        {
            InitializeComponent();
            ctrlPersonCard1.SetPersonCardSetting(clsPersonInfoData.PersonDataOfCustomer, clsEditProfileCard.EditCustomerProfile);

        }
        public void LoadCustomerInfo(int CustomerID)
        {
            _Customer = clsCustomer.Find(CustomerID);
            if (_Customer == null)
            {
                _ResetCustomerInfo();
                MessageBox.Show("No Customer with UserID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillCustomerInfo();
        }
       
        public void LoadCustomerInfo(string NationalNo)
        {
            _Customer = clsCustomer.Find(NationalNo);
            if (_Customer == null)
            {
                _ResetCustomerInfo();
                MessageBox.Show("No Customer with UserID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillCustomerInfo();
        }

        private void _FillCustomerInfo()
        {
            ctrlPersonCard1.ProfileID = CustomerID;
            ctrlPersonCard1.LoadPersonInfo((int)CustomerID);
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            lblLicenseNo.Text = _Customer.DriverLicenseNumber.ToString();

        }

        private void _ResetCustomerInfo()
        {

            ctrlPersonCard1.ResetPersonInfo();
            lblCustomerID.Text = "[???]";
            lblLicenseNo.Text = "[???]";
           
        }
        
    }
}
