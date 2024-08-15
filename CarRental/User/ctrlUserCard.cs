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
using static CarRental.ctrlPersonCard;

namespace CarRental
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;
        //private int _UserID = -1;

        public int UserID
        {
            get { return (_User==null)?-1:(int)_User.UserID; }
        }
        public clsUser SelectedUserInfo
        {
            get { return _User; }
        }


        public ctrlUserCard()
        {
            InitializeComponent();
            ctrlPersonCard1.SetPersonCardSetting(clsPersonInfoData.PersonDataOfUser, clsEditProfileCard.EditUserProfile);
            
        }
        
        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);
            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }
       
        /* public void LoadMechanicUserInfo(int UserID)
        {
            _User = clsUser.FindMechanicUser(UserID);
            if (_User == null)
            {
                _ResetUserInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }*/

        private void _FillUserInfo()
        {
            ctrlPersonCard1.ProfileID = UserID;
            ctrlPersonCard1.LoadPersonInfo(UserID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();

            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
            lblSalary.Text = _User.Salary.ToString();


        }
      
        public void ResetUserInfo()
        {

            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblSalary.Text = "[???]";
        }
       
    }
}
