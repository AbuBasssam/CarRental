using CarRental_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CarRental
{
    public partial class frmAddUpdateMechanic : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _MechanicID = -1;
        clsMechanic _Mechanic;
        public frmAddUpdateMechanic()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddUpdateMechanic(int MechanicID,bool EnableMechaincPage=true)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _MechanicID = MechanicID;
            tpMechanic.Enabled = EnableMechaincPage;


        }
        private void GetWorkSchedule()
        {
           /* MatchCollection matches = Regex.Matches(_Mechanic.WorkSchedule, @"\b\d+\b");

            foreach (Match match in matches)
            {
                int digit = int.Parse(match.Value);
                if (digit > 0)
                {
                    Console.WriteLine(digit);
                }
            }*/
            
           
            for (int i = 0; i < _Mechanic.WorkSchedule.IndexOf('-'); i++)
            {
                if (char.IsDigit(_Mechanic.WorkSchedule[i]) && int.Parse(_Mechanic.WorkSchedule[i].ToString()) > 0)
                {
                    NumBegin.Value= Convert.ToInt32(_Mechanic.WorkSchedule[i]);
                }
            }
            for (int i = _Mechanic.WorkSchedule.IndexOf('-'); i < _Mechanic.WorkSchedule.Length; i++)
            {
                if (char.IsDigit(_Mechanic.WorkSchedule[i]) && int.Parse(_Mechanic.WorkSchedule[i].ToString()) > 0)
                {
                    NumEnd.Value = Convert.ToInt32(_Mechanic.WorkSchedule[i]);
                }
            }
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Mechanic";
                this.Text = "Add New Mechanic";
                _Mechanic = new clsMechanic();

                tpMechanic.Enabled = false;

                ctrlUserCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update Mechanic";
                this.Text = "Update Mechanic";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;


            }

            NumBegin.Value =8;
            NumEnd.Value = 5;
            cbSpecialization.SelectedIndex = 0;
            chkAbilityToOverTime.Checked = false;


        }
        private void _LoadData()
        {

            _Mechanic = clsMechanic.Find(_MechanicID);
            ctrlUserCardWithFilter1.FilterEnabled = false;

            if (_Mechanic == null)
            {
                MessageBox.Show("No User with ID = " + _Mechanic, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            lblMechanicID.Text = _Mechanic.MechanicID.ToString();
            GetWorkSchedule();
            cbSpecialization.SelectedIndex=(byte)(_Mechanic.AreasOfSpecialization-1);
            chkAbilityToOverTime.Checked = _Mechanic.AbilityToOverTimer;
            ctrlUserCardWithFilter1.LoadUserInfo(_Mechanic.UserID);
        }

        private void frmAddUpdateMechanic_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Mechanic.UserID = ctrlUserCardWithFilter1.UserID;
            _Mechanic.WorkSchedule = (NumBegin.Value + ":00 AM - " + NumEnd.Value + ":00 PM").ToString();
            _Mechanic.AreasOfSpecialization = (clsMechanic.enAreasOfSpecialization)(cbSpecialization.SelectedIndex+1);
            _Mechanic.AbilityToOverTimer = (chkAbilityToOverTime.Checked)?true:false;


            if (_Mechanic.Save())
            {
                lblMechanicID.Text = _Mechanic.MechanicID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Mechanic";
                this.Text = "Update Mechanic";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpMechanic.Enabled = true;
                tpLoginInfo.SelectedTab = tpLoginInfo.TabPages["tpMechanic"];
                return;
            }

            //incase of add new mode.
            if (ctrlUserCardWithFilter1.UserID != -1)
            {

                if (clsMechanic.IsUserAlreadyMechanic(ctrlUserCardWithFilter1.UserID))
                {

                    MessageBox.Show("Selected User already has a Mechanic, choose another one.", "Select another User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlUserCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tpMechanic.Enabled = true;
                    tpLoginInfo.SelectedTab = tpLoginInfo.TabPages["tpMechanic"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a User", "Select a User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlUserCardWithFilter1.FilterFocus();

            }

        }
        
       
        
    }
}
