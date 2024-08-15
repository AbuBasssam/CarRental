using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsFuleType
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;
        public enum enFuleTypes {Gasoline = 1, Diesel = 2, Hybrid = 3, Electric = 4, Plug_inHybrid = 5 }
        public enFuleTypes ID { set; get; }
        public string FuleType { set; get; }

        public clsFuleType()
        {
            this.ID = enFuleTypes.Gasoline;
            this.FuleType = "";

        }

        private clsFuleType(int ID, string FuleType)
        {
            this.ID = (enFuleTypes) ID;
            this.FuleType = FuleType;

        }

        public static clsFuleType Find(int ID)
        {

            string FuleType = "";

            if (clsFuleTypeData.GetFuleInfoByID(ID, ref FuleType))

                return new clsFuleType(ID, FuleType);
            else
                return null;

        }

        public static clsFuleType Find(string FuleType)
        {

            int ID = -1;



            if (clsFuleTypeData.GetFuleInfoByType(FuleType, ref ID))

                return new clsFuleType(ID, FuleType);
            else
                return null;

        }

        private bool _AddNewFuleType()
        {
            Nullable< int> ID = clsFuleTypeData.AddNewFuleType(this.FuleType);

            return (ID !=null); 
        }

        private bool _UpdatFuleType()
        {
            return clsFuleTypeData.UpdateFuleType((int)this.ID,this.FuleType);
        }

        public static DataTable GetAllFuleTypes()
        {
            return clsFuleTypeData.GetAllFuleTypes();

        }
        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewFuleType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdatFuleType();


                default:
                    return false;
            }
        }

        /*public static bool isFuleTypeExist(int ID)
        {
            return clsFuleTypeData.IsFuleExist(ID);
        }*/

       
        /*        public static bool isFuleTypeExist(string FuleType)
        {
            return clsFuleTypeData.IsFuleExist(FuleType);
        }
*/
    }

}
