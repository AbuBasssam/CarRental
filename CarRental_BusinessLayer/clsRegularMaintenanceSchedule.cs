using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRental_BusinessLayer.clsCarCategory;

namespace CarRental_BusinessLayer
{
    public class clsRegularMaintenanceSchedule
    {
        public enum enFilterMode {
            CarID=1,
            OilChange,
            TireRotation,
            BrakeInspection,
            AirFilter,
            SparkPlugReplacement,
            TransmissionFluidChange,
            CoolantFlush,
            BeltsAndHosesInspection
        }
        private static enFilterMode FilterMode { get; set; }
         
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;
        public Nullable<int> ID { get; set; }
        public clsRegularMaintenanceType.enRegularMaintenanceType RegularTypeID { get; set; }
        public int CarID { get; set; }
        public int NextScheduledMileage { get; set; }
        public clsRegularMaintenanceSchedule()
        {
            this.ID = null;
            this.RegularTypeID = 0;
            this.NextScheduledMileage = default(int);
            this.CarID = -1;
            this.Mode = enMode.AddNew;

        }

        private clsRegularMaintenanceSchedule(int ID, clsRegularMaintenanceType.enRegularMaintenanceType RegularTypeID, int CarID, int NextScheduledMileage)
        {
            this.ID = ID;
            this.RegularTypeID = RegularTypeID;
            this.NextScheduledMileage = NextScheduledMileage;
            this.CarID = CarID;
            this.Mode = enMode.Update;
        }

        public static clsRegularMaintenanceSchedule Find( int CarID, byte RegularTypeID)
        {
            
            int ID = -1;
            int NextScheduledMileage = 0;

            if (clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByCarID(ref ID,  RegularTypeID, CarID, ref NextScheduledMileage))
            {
                return new clsRegularMaintenanceSchedule(ID, (clsRegularMaintenanceType.enRegularMaintenanceType)RegularTypeID, CarID, NextScheduledMileage);


            }
            else
            {
                return null;
            }
        }

        private bool _AddNewRegularMaintenanceSchedule()
        {
            Nullable<int> ID = clsRegularMaintenanceScheduleData.AddNewRegularMaintenanceSchedule((byte)this.RegularTypeID, this.CarID, this.NextScheduledMileage);

            return (ID != null);
        }

        private bool _UpdateRegularMaintenanceSchedule()
        {
            return clsRegularMaintenanceScheduleData.UpdateRegularMaintenanceSchedule((int)this.ID, (byte)this.RegularTypeID, this.CarID, this.NextScheduledMileage);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewRegularMaintenanceSchedule())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateRegularMaintenanceSchedule();


                default:
                    return false;
            }
        }

        public static DataTable GetRegularMaintenanceSchedulePage(int PageNumber = 1)
        {
            return clsRegularMaintenanceScheduleData.GetAllRegularMaintenanceSchedule(PageNumber);
        }

        public static DataTable GetFullRegularMaintenanceCarSchedule(int CarID)
        {
            return clsRegularMaintenanceScheduleData.GetFullRegularMaintenanceCarSchedule(CarID);
        }

        public static int NumberOfPages()
        {
            return clsRegularMaintenanceScheduleData.NumberOfPages();
        }
        
        public static void ChangeFilter(int Mode)
        {
            FilterMode = (enFilterMode)Mode;
        }
        
        public static DataTable Filter(int Value)
        {
            switch (FilterMode)
            {
                case enFilterMode.CarID:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByCarIDSearch(Value);

                case enFilterMode.OilChange:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByOilChangeSearch(Value);
                case enFilterMode.TireRotation:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByTireRotationSearch(Value) ;
                    
                case enFilterMode.BrakeInspection:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByBrakeInspectionSearch(Value);
                    
                case enFilterMode.AirFilter:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByAirFilterSearch(Value);
                    
                case enFilterMode.SparkPlugReplacement:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleBySparkPlugReplacementSearch(Value); ;
                    
                case enFilterMode.TransmissionFluidChange:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByTransmissionFluidChangeSearch(Value); ;
                    
                case enFilterMode.CoolantFlush:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByCoolantFlushSearch(Value); ;
                    
                case enFilterMode.BeltsAndHosesInspection:
                    return clsRegularMaintenanceScheduleData.GetRegularMaintenanceScheduleByGetRegularMaintenanceScheduleByBeltsAndHosesInspectionSearch(Value); ;

                default:
                    return null;
            }
        }

        public static bool AddFullRegularMaintenanceCarSchedule(int CarID)
        {
            return clsRegularMaintenanceScheduleData.AddFullRegularMaintenanceCarSchedule(CarID);
        }
    }
}
