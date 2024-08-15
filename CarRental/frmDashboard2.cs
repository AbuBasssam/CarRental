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
    public partial class frmDashboard2 : Form
    {
        private Form ActiveForm=null;
        public frmDashboard2()
        {
            InitializeComponent();
        }
        
        private void OpenChildForm(Form ChilidForm)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
                ActiveForm = null;
            }
                
            ActiveForm = ChilidForm;
            ChilidForm.TopLevel = false;
            ChilidForm.Dock = DockStyle.Fill;
            ChilidForm.FormBorderStyle = FormBorderStyle.None;
            ChildFormPanel.Controls.Add(ActiveForm);
            ChilidForm.BringToFront();
            ChilidForm.Show();

        }
        
        private void btnUser_Click(object sender, EventArgs e)
        {
            clsSettingLoader UserSetting = new clsSettingLoader(clsProfileCardSetting.LoadingUserProfile,clsAddProfileCard.AddUserProfile,clsDeleteProfileCard.DeleteUser,clsEditProfileCard.EditUserProfile,
                                                                clsUser.GetUsersPage,clsProfileDetails.UserDetails,clsUser.GetUsersIDsByFirstNameSearch,
                                                                clsUser.GetUsersIDsByNationalNoSearch,clsUser.GetUsersIDsByPhoneNumberSearch);
            OpenChildForm(new frmProfiles(UserSetting));

        }

        private void frmDashboard2_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            clsSettingLoader CustomerSetting = new clsSettingLoader(clsProfileCardSetting.LoadinCustomerProfile, clsAddProfileCard.AddCustomerProfile, clsDeleteProfileCard.DeleteCustomer,clsEditProfileCard.EditCustomerProfile,
                                                               clsCustomer.GetCustomersPage, clsProfileDetails.CustomerDetails,clsCustomer.GetCustomersIDsByFirstNameSearch,
                                                               clsCustomer.GetCustomersIDsByNationalNoSearch,clsCustomer.GetCustomersIDsByPhoneNumberSearch);
            OpenChildForm(new frmProfiles(CustomerSetting));

        }

        private void btnmechanice_Click(object sender, EventArgs e)
        {
            clsSettingLoader MechaniceSetting = new clsSettingLoader(clsProfileCardSetting.LoadingMechanicProfile,clsAddProfileCard.AddMechanicProfile, clsDeleteProfileCard.DeleteMechanic, clsEditProfileCard.EditMechanicProfile,
                                                                clsMechanic.GetMechanicsPage, clsProfileDetails.MechanicDetails,clsMechanic.GetMechanicsIDsByFirstNameSearch,
                                                                clsMechanic.GetMechanicsIDsByNationalNoSearch,clsMechanic.GetMechanicsIDsByPhoneNumberSearch);
            OpenChildForm(new frmProfiles(MechaniceSetting));

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            PLogin.Visible=(PLogin.Visible)? PLogin.Visible = false : PLogin.Visible = true;
            
            if(PLogin.Visible)
                PLogin.BringToFront();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCarList());
           
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRentalBooking());

        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTransactionList());
            
        }
    }
}
