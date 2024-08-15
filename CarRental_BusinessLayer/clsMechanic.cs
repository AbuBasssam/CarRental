using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public class clsMechanic
    {
        public enum enMode { AddNew = 1, Update = 2 };
        
        public enMode Mode = enMode.AddNew;
        public enum enAreasOfSpecialization { General = 1, BrakeAndSuspension = 2 , Transmission =3, AutomotiveElectrical =4, HVAC=5,TireAndAlignment=6 };
        public Nullable<int> MechanicID { set; get; }
        public int UserID { set; get; }
        public string WorkSchedule {  set; get; }
        public bool AbilityToOverTimer {  set; get; }
        public enAreasOfSpecialization AreasOfSpecialization {  set; get; }
        public string AreasOfSpecializationText
        {
            get
            {
                return GetAreasOfSpecializationText(this.AreasOfSpecialization);
            }
        }
        public static string GetAreasOfSpecializationText(enAreasOfSpecialization AreasOfSpecialization)
        {

            switch (AreasOfSpecialization)
            {
                case enAreasOfSpecialization.General:
                    return "General";
                case enAreasOfSpecialization.BrakeAndSuspension:
                    return "BrakeAndSuspension";
                case enAreasOfSpecialization.TireAndAlignment:
                    return "TireAndAlignment";
                case enAreasOfSpecialization.AutomotiveElectrical:
                    return "AutomotiveElectrical";
                case enAreasOfSpecialization.HVAC:
                    return "HVAC";
                case enAreasOfSpecialization.Transmission:
                    return "Transmission";
                default:
                    return "General";

            }
        }
        public clsUser UserInfo { set; get; }
        public clsMechanic()

        {
            this.MechanicID = null;
            this.UserID = -1;
            this.WorkSchedule = default(string);
            this.AbilityToOverTimer = true;
            this.AreasOfSpecialization = enAreasOfSpecialization.General;
            Mode = enMode.AddNew;
        }

        private clsMechanic(int MechanicID, int UserID, string WorkSchedule,bool AbilityToOverTimer, enAreasOfSpecialization AreasOfSpecialization)
        {
            var UserTask = Task.Run(() => clsUser.Find(UserID));
            this.MechanicID = MechanicID;
            this.UserID = UserID;
            this.WorkSchedule = WorkSchedule;
            this.AbilityToOverTimer = AbilityToOverTimer;
            this.AreasOfSpecialization = AreasOfSpecialization;
            Mode = enMode.Update;
            Task.WaitAll(UserTask);
            this.UserInfo = UserTask.Result;

        }

        public static clsMechanic Find(int MechanicID)
        {
            int UserID = -1;
            string WorkSchedule = default(string);
            byte AreasOfSpecialization = 0;
            bool AbilityToOverTimer = false;


            if (clsMechanicData.FindByIMechanicID(MechanicID, ref UserID, ref WorkSchedule, ref AbilityToOverTimer, ref AreasOfSpecialization))
            {
                return new clsMechanic(MechanicID,  UserID,  WorkSchedule,  AbilityToOverTimer, (enAreasOfSpecialization) AreasOfSpecialization);



            }
            else
            {
                return null;
            }
        }
        
        public static clsMechanic FindByUserID(int UserID)
        {
            int MechanicID = -1;
            string WorkSchedule = default(string);
            byte AreasOfSpecialization = default(byte);
            bool AbilityToOverTimer = false;


            if (clsMechanicData.FindByIUserID(ref MechanicID,  UserID, ref WorkSchedule, ref AbilityToOverTimer, ref AreasOfSpecialization))
            {
                return new clsMechanic(MechanicID, UserID, WorkSchedule, AbilityToOverTimer, (enAreasOfSpecialization)AreasOfSpecialization);



            }
            else
            {
                return null;
            }
        }


        private bool _AddNewMechanic()
        {
            this.MechanicID = clsMechanicData.AddNewMechanic( UserID,  WorkSchedule,  AbilityToOverTimer,  (byte)AreasOfSpecialization);
            
            return (MechanicID != null);
        }

        private bool _UpdateMechanic()
        {
            return clsMechanicData.UpdateMechanic((int)MechanicID, UserID, WorkSchedule, AbilityToOverTimer,(byte)AreasOfSpecialization);
        }

        public static bool DeleteMechanic(int MechanicID)
        {
            return clsMechanicData.DeleteMechanic(MechanicID);
        }

        public static bool IsMechanicExist(int MechanicID)
        {
            return clsMechanicData.IsMechanicExist(MechanicID);
        }
       
        public static bool IsUserAlreadyMechanic(int UserID)

        {
            return clsMechanicData.IsUserAlreadyMechanic(UserID);
        }

        public static List<int> GetMechanicsPage(int PageNumber )
        {
            return clsMechanicData.GetMechanics(PageNumber);
        }

        public static List<int> GetMechanicsIDsByFirstNameSearch(string FirstName)
        {
            return clsMechanicData.GetMechanicsIDsByFirstNameSearch(FirstName);
        }

        public static List<int> GetMechanicsIDsByNationalNoSearch(string FirstName)
        {
            return clsMechanicData.GetMechanicsIDsByNationalNoSearch(FirstName);
        }

        public static List<int> GetMechanicsIDsByPhoneNumberSearch(string FirstName)
        {
            return clsMechanicData.GetMechanicsIDsByPhoneNumberSearch(FirstName);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewMechanic())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:

                    return _UpdateMechanic();


                default:
                    return false;
            }
        }
    }
}
