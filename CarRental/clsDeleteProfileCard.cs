using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public static  class clsDeleteProfileCard
    {
        public static bool DeleteUser(int UserID)
        {
            return clsUser.DeleteUser(UserID);
        }
        
        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomer.DeleteCustomer(CustomerID);
        }
        public static bool DeleteMechanic(int MechanicID)
        {
            return clsMechanic.DeleteMechanic(MechanicID);
        }
    }
}
