using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class clsProfileDetails
    {
        public static void UserDetails(int ProfileID)
        {
            frmUserInfo UserInfo=new frmUserInfo(ProfileID);
            UserInfo.ShowDialog();
        }
        public static void CustomerDetails(int ProfileID)
        {
            frmCustomerInfo CustomerInfo = new frmCustomerInfo(ProfileID);
            CustomerInfo.ShowDialog();
        }
        public static void MechanicDetails(int ProfileID)
        {
            frmMechanicInfo MechanicInfo = new frmMechanicInfo(ProfileID);
            MechanicInfo.ShowDialog();
        }
    }
}
