using CarRental_DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CarRental_BusinessLayer.clsCarCategory;

namespace CarRental_BusinessLayer
{
    public class clsRegularMaintenanceType
    {
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;
        
        public enum enRegularMaintenanceType
        {
            OilChange = 1,
            TireRotation,
            BrakeInspection,
            AirFilter,
            SparkPlugReplacement,
            TransmissionFluidChange,
            CoolantFlush,
            BeltsandHosesInspection

        }

        public enRegularMaintenanceType TypeID {  get; set; }
        
        public string TypeName {  get; set; }
        
        public int ScheduledInterval {  get; set; }
        public clsRegularMaintenanceType()
        {
            this.TypeID = enRegularMaintenanceType.BrakeInspection;
            this.TypeName = "";
            this.ScheduledInterval = 0;
        }
        
        public clsRegularMaintenanceType(enRegularMaintenanceType TypeID, string TypeName, int ScheduledInterval)
        {
            this.TypeID = TypeID;
            this.TypeName = TypeName;
            this.ScheduledInterval = ScheduledInterval;
        }

        public static clsRegularMaintenanceType Find(int TypeID)
        {
            string TypeName = "";
            int ScheduledInterval = 0;
           

            if(clsRegularMaintenanceTypeData.GetRegularMaintenanceTypeByID(TypeID, ref TypeName, ref ScheduledInterval))
            {
                return new clsRegularMaintenanceType((enRegularMaintenanceType)TypeID, TypeName, ScheduledInterval);


            }
            else
            {
                return null;
            }
        }

        private bool _AddNewCategory()
        {
            Nullable<int> TypeID = clsRegularMaintenanceTypeData.AddNewtRegularMaintenanceType(this.TypeName, this.ScheduledInterval);

            return (TypeID != null);
        }

        private bool _UpdateCategory()
        {
            return clsRegularMaintenanceTypeData.UpdatetRegularMaintenanceType((int)this.TypeID, this.TypeName, this.ScheduledInterval);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCategory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateCategory();


                default:
                    return false;
            }
        }

        public static DataTable GetAllRegularMaintenanceType()
        {
            return clsRegularMaintenanceTypeData.GetAllRegularMaintenanceType();
        }


    }
}
