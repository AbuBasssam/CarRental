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
    public partial class ctrlMechanicCard : UserControl
    {
        private clsMechanic _Mechanic;
        

        public int MechanicID
        {
            get { return (_Mechanic == null) ? -1 : (int)_Mechanic.MechanicID; }
        }
        public clsMechanic SelectedMechanicInfo
        {
            get { return _Mechanic; }
        }


        public void LoadMechanicInfo(int MechanicID)
        {
            _Mechanic = clsMechanic.Find(MechanicID);
            if (_Mechanic == null)
            {
                _ResetMechanicInfo();
                MessageBox.Show("No Mechanic with MechanicID = " + MechanicID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillMechanicInfo();
        }

        public ctrlMechanicCard()
        {
            InitializeComponent();
        }
        private void _FillMechanicInfo()
        {
           
            ctrlUserCard1.LoadUserInfo(_Mechanic.UserID);
            lblMechanicID.Text = _Mechanic.MechanicID.ToString();
            lblWorkSchedule.Text=_Mechanic.WorkSchedule;
            lblAreasOfSpecialization.Text = _Mechanic.AreasOfSpecializationText;
            if (_Mechanic.AbilityToOverTimer) 
                lblAbilityToOverTime.Text = "Yes";
            else
                lblAbilityToOverTime.Text = "No";


        }

        private void _ResetMechanicInfo()
        {

            ctrlUserCard1.ResetUserInfo();
            lblMechanicID.Text = "[???]";
            lblWorkSchedule.Text = "[???]";
            lblAbilityToOverTime.Text = "[???]";
          
        }
    }
}
