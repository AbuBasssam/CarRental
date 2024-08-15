using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class clsAddProfileCard
    {
        public static void AddUserProfile()
        {
            frmAddUpdateUsers AddUserForm = new frmAddUpdateUsers();
            AddUserForm.ShowDialog();
        }

        public static void AddCustomerProfile()
        {
            frmAddUpdateCustomer AddCustomer = new frmAddUpdateCustomer();
            AddCustomer.ShowDialog();
        }

        public static void AddMechanicProfile()
        {
            frmAddUpdateMechanic AddMechanic = new frmAddUpdateMechanic();
            AddMechanic.ShowDialog();
        }




    }
}
