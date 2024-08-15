using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public static class clsEditProfileCard
    {
        public static void EditUserProfile(int ProfileID,bool EnableLoginPage=true)
        {
            frmAddUpdateUsers EditUserForm=new frmAddUpdateUsers(ProfileID, EnableLoginPage);
            EditUserForm.ShowDialog();
        }
       
        public static void EditCustomerProfile(int ProfileID,bool EnableCustomerInfo=true)
        {
            frmAddUpdateCustomer EditCustomer=new frmAddUpdateCustomer(ProfileID, EnableCustomerInfo);
            EditCustomer.ShowDialog();
        }
        
        public static void EditMechanicProfile(int ProfileID, bool EnableMechanicPage = true)
        {
            frmAddUpdateMechanic EditMechanic = new frmAddUpdateMechanic(ProfileID,EnableMechanicPage);
            EditMechanic.ShowDialog();
        }

    }
}
