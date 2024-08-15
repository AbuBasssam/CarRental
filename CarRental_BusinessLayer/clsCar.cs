using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CarRental_DataAccess;

namespace CarRental_BusinessLayer
{
    public class clsCar
    {
        public struct stFilterValues
        {
            public string Make;
            public string Model;
            public int Year;
            public int Mileage;
            public int CarCategory;
            public int FuleType;
            public float MinumRentalDailyPrice;
            public float MaxumRentalDailyPrice;
            public short Transmission;
            public int Status;
        }


        public enum enTransmission { Manual=0, Automatic=1}

        public enum enStatus { UnAvailable=0, Available=1, InRent=2, InMaintenance=3 }
        
        public enum enMode { AddNew = 1, Update = 2 }

        public enMode Mode = enMode.AddNew;

        public Nullable<int> CarID {  get; set; }

        public string Make {  get; set; }

        public string Model {  get; set; }

        public int Year {  get; set; }

        public int Mileage {  get; set; }

        public string Color {  get; set; }

        public clsFuleType.enFuleTypes FuelTypeID { get; set; }

        private string _PlateNumber {  get; set; }
       
        public string PlateNumber
        {
            get{ return _PlateNumber; }

            set
            {
                _PlateNumber = _PlateNumberCheck( value);
                
            
            }
        }

        public clsCarCategory. enCarCategories CarCategoryID { get; set; }

        private string _VIN { get; set; }
        public string VIN
        {
            get { return _VIN; }
            set
            {
                _VIN = _VINCheck(value);


            }
        }
        
        public enTransmission Transmission { get;set;}
        
        public float RentalPricePerDay {  get; set; }

        public float RentalPricePerWeek => (float)((RentalPricePerDay* 7) - (RentalPricePerDay* 7 * 0.20));

        public float RentalPricePerMonth => (float)((RentalPricePerDay * 30) - (RentalPricePerDay * 30 * 0.30));
        
        public enStatus Status { get; set; } 

        string _ImagePath;
        
        public string ImagePath
        {
            get { return _ImagePath; } 
            set { _ImagePath = value; }
        }
        
        public clsCarCategory CategoryInfo { get; set; }
        
        public clsFuleType FuleTypeInfo { get; set; }
        
        public clsWarranty WarrantyInfo { get; set; }
        public List<int> RegularMaintenanceScheduleSet;
        public clsCar()
        {
            this.CarID = null;
            this.Make = null;
            this.Model = null;
            this.Year = default(int);
            this.Mileage = default(int);
            this.Color = null;
            this.FuelTypeID = default(clsFuleType.enFuleTypes);
            this.PlateNumber = null;
            this.CarCategoryID = default(clsCarCategory. enCarCategories);
            this.VIN = null;
            this.Transmission = default(enTransmission);
            this.RentalPricePerDay = default(float);
            this.Status = default(enStatus);
            this.ImagePath = null;
            this.Mode = enMode.AddNew;
        }

        private clsCar(int CarID, string Make, string Model, int Year, int Mileage,
            string Color, clsFuleType.enFuleTypes FuleTypeID, string PlateNumberr,
            clsCarCategory.enCarCategories CarCategoryID, string VIN, enTransmission Transmission,
            float RentalPricePerDay, enStatus Status, string ImagePath)
        {
            var categoryTask = Task.Run(() => clsCarCategory.Find((int)CarCategoryID));
            var fuelTypeTask = Task.Run(() => clsFuleType.Find((int)FuleTypeID));
            var warrantyTask = Task.Run(() => clsWarranty.GetCarWarranty(CarID));
            var RegularMaintenanceScheduleTask = Task.Run(() => clsRegularMaintenanceSchedule.GetFullRegularMaintenanceCarSchedule(CarID));
            this.CarID = CarID;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Mileage = Mileage;
            this.Color = Color;
            this.FuelTypeID = FuleTypeID;
            this.PlateNumber = PlateNumberr;
            this.CarCategoryID = CarCategoryID;
            this.VIN = VIN;
            this.Transmission = Transmission;
            this.RentalPricePerDay = RentalPricePerDay;
            this.Status = Status;
            this.ImagePath = ImagePath;
            // Start tasks to find additional information
            Task.WaitAll(categoryTask, fuelTypeTask, warrantyTask, RegularMaintenanceScheduleTask);
            this.CategoryInfo = categoryTask.Result;
            this.FuleTypeInfo = fuelTypeTask.Result;
            this.WarrantyInfo = warrantyTask.Result;
            RegularMaintenanceScheduleSet = new List<int>();
            RegularMaintenanceScheduleSet.Add((int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[1]);
            RegularMaintenanceScheduleSet.Add((int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[2]);
            RegularMaintenanceScheduleSet.Add((int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[3]);
            RegularMaintenanceScheduleSet.Add((int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[4]);
            RegularMaintenanceScheduleSet.Add((int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[5]);
            RegularMaintenanceScheduleSet.Add( (int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[6]);
            RegularMaintenanceScheduleSet.Add((int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[7]);
            RegularMaintenanceScheduleSet.Add((int)RegularMaintenanceScheduleTask.Result.Rows[0].ItemArray[8]);

            this.Mode = enMode.Update;

           



        }

        public static clsCar Find(int CarID)
        {
            string Make = null, Model = null, Color = null, PlateNumber = null, VIN = null, ImagePath=null;
            int Year= default(int),Mileage = default(int);
            byte FuleTypeID = default(byte), CarCategoryID = default(byte), Transmission = default(byte),Status = default(byte);

            float RentalPricePerDay= default(float), RentalPricePerWeek= default(float), RentalPricePerMonth= default(float);
            
            if (clsCarData.FindByICarD(CarID, ref Make, ref Model, ref Year, ref Mileage, ref Color
                , ref FuleTypeID, ref PlateNumber, ref CarCategoryID, ref VIN, ref Transmission, ref RentalPricePerDay, ref RentalPricePerWeek, ref RentalPricePerMonth, ref Status , ref ImagePath))
            {
                return new clsCar(CarID,  Make,  Model,  Year,  Mileage,
               Color, (clsFuleType.enFuleTypes) FuleTypeID,  PlateNumber,
               (clsCarCategory.enCarCategories) CarCategoryID,  VIN,(enTransmission) Transmission,
             RentalPricePerDay, (enStatus) Status,  ImagePath);



            }
            else
            {
                return null;
            }
        }

        public static clsCar Find(string PlateNumber)
        {
            string Make = null, Model = null, Color = null, VIN = null, ImagePath = null;
            int Year = default(int), Mileage = default(int), CarID= default(int);
            byte FuleTypeID = default(byte), CarCategoryID = default(byte), Transmission = default(byte),Status = default(byte);

            float RentalPricePerDay = default(float), RentalPricePerWeek = default(float), RentalPricePerMonth = default(float);
            


            if (clsCarData.FindByPlateNumber(ref CarID, ref Make, ref Model, ref Year, ref Mileage, ref Color
                , ref FuleTypeID, PlateNumber, ref CarCategoryID,ref VIN, ref Transmission, ref RentalPricePerDay, ref RentalPricePerWeek, ref RentalPricePerMonth, ref Status, ref ImagePath))
            {

                return new clsCar(CarID, Make, Model, Year, Mileage,
             Color, (clsFuleType.enFuleTypes)FuleTypeID, PlateNumber,
             (clsCarCategory.enCarCategories)CarCategoryID, VIN, (enTransmission)Transmission,
             RentalPricePerDay,(enStatus)Status, ImagePath);



            }
            else
            {
                return null;
            }
        }

        public static clsCar FindByVIN(string VIN)
        {
            string Make = null, Model = null, Color = null, PlateNumber = null, ImagePath = null;
            int Year = default(int), Mileage = default(int), CarID = default(int);
            byte FuleTypeID = default(byte), CarCategoryID = default(byte), Transmission = default(byte), Status = default(byte);

            float RentalPricePerDay = default(float), RentalPricePerWeek = default(float), RentalPricePerMonth = default(float);



            if (clsCarData.FindByVIN(ref CarID, ref Make, ref Model, ref Year, ref Mileage, ref Color
                , ref FuleTypeID, ref PlateNumber, ref CarCategoryID,  VIN, ref Transmission, ref RentalPricePerDay, ref RentalPricePerWeek, ref RentalPricePerMonth, ref Status, ref ImagePath))
            {

                return new clsCar(CarID, Make, Model, Year, Mileage,
             Color, (clsFuleType.enFuleTypes)FuleTypeID, PlateNumber,
             (clsCarCategory.enCarCategories)CarCategoryID, VIN, (enTransmission)Transmission,
             RentalPricePerDay, (enStatus)Status, ImagePath);



            }
            else
            {
                return null;
            }
        }


        private bool _AddNewCar()
        {
            this.CarID = clsCarData.AddNewCar(this.Make, this.Model, this.Year, this.Mileage, this.Color, (byte)this.FuelTypeID, this.PlateNumber, (byte)this.CarCategoryID, this.VIN, (byte)this.Transmission, this.RentalPricePerDay
                                               ,  (byte)this.Status, this.ImagePath);

            return (CarID != null);
        }                                              

        private bool _UpdateCar()
        {                                        
            return clsCarData.UpdateCar((int)this.CarID,this.Make, this.Model, this.Year,
                                             this.Mileage, this.Color, (byte)this.FuelTypeID,
                                             this.PlateNumber, (byte)this.CarCategoryID, this.VIN,
                                             (byte)this.Transmission, this.RentalPricePerDay,
                                             (byte)this.Status, this.ImagePath);
                                                 
        }
        
        public static bool DeleteCar(int CarID)
        {                                        
            return clsCarData.DeleteCar(CarID);
        }
        
        public bool AddNewFullRegularMaintenanceSchedule()
        {
            return clsRegularMaintenanceSchedule.AddFullRegularMaintenanceCarSchedule((int)this.CarID);
        }
        
        public bool AddNewWarranty()
        {
            return clsWarrantyData.AddNewWarranty((int)this.CarID);
        }

        public static bool IsCarExist(int CarID)
        {
            return clsCarData.IsCarExist(CarID);
        }
        
        public static bool IsCarExist(string PlateNumber)
        {
            return clsCarData.IsCarExist(PlateNumber);
        }
        
        public static bool IsCarExistByVIN(string VIN)
        {
            return clsCarData.IsCarExistByVIN(VIN);
        }

        public static List <clsCar> GetCarPage( int Page)
        {
            List<clsCar> Carslist = new List <clsCar>();
            DataTable temp= clsCarData.GetCarPage(Page);
            foreach (DataRow row in temp.Rows)
            {
                var categoryTask = Task.Run(() => clsCarCategory.Find((int)row["CarID"]));
                var fuelTypeTask = Task.Run(() => clsFuleType.Find((int)row["CarID"]));
                var warrantyTask = Task.Run(() => clsWarranty.GetCarWarranty((int)row["CarID"]));
                clsCar CarItem = new clsCar();
                CarItem.CarID = (int)row["CarID"];
                CarItem.CarCategoryID = (clsCarCategory.enCarCategories)row["CarCategoryID"];
                CarItem.Make = (string)row["Make"];
                CarItem.Model = (string)row["Model"];
                CarItem.Year = (int)row["Year"];
                CarItem.Mileage = (int)row["Mileage"];
                CarItem.Color = (string)row["Color"];
                CarItem.FuelTypeID = (clsFuleType.enFuleTypes)row["FuelTypeID"];
                CarItem.VIN = (string)row["VIN"];
                CarItem.PlateNumber = (string)row["PlateNumber"];
                CarItem.Transmission = ((bool)row["Transmission"]) ? enTransmission.Automatic : enTransmission.Manual;
                CarItem.RentalPricePerDay = Convert.ToSingle(row["RentalPricePerDay"]);
                CarItem.Status = (enStatus)Convert.ToByte(row["Status"]);
                CarItem.ImagePath = (row["ImagePath"] == DBNull.Value) ? "" : (string)(row["ImagePath"]);
                Task.WaitAll(categoryTask, fuelTypeTask, warrantyTask);
                CarItem.CategoryInfo = categoryTask.Result;
                CarItem.FuleTypeInfo = fuelTypeTask.Result;
                CarItem.WarrantyInfo = warrantyTask.Result;
                Carslist.Add(CarItem);

            }
            return Carslist;
        }
        
        public static DataTable GetMakeModels(string Make)
        {
            return clsCarData.GetMakeModels(Make); 
        }
       
        public  static List<clsCar>  CarFilter(stFilterValues FilterValues)
        {
            List<clsCar> Carslist = new List<clsCar>();
            DataTable temp = clsCarData.CarFilter(FilterValues.Make, FilterValues.Model, FilterValues.Year, FilterValues.Mileage, (byte)FilterValues.FuleType, (byte)FilterValues.CarCategory, FilterValues.Transmission, FilterValues.MinumRentalDailyPrice, FilterValues.MaxumRentalDailyPrice, (short)FilterValues.Status);
                                               
            foreach (DataRow row in temp.Rows)
            {
                clsCar CarItem = new clsCar();
                CarItem.CarID = (int)row["CarID"];
                CarItem.CarCategoryID = (clsCarCategory.enCarCategories)row["CarCategoryID"];
                CarItem.Make = (string)row["Make"];
                CarItem.Model = (string)row["Model"];
                CarItem.Year = (int)row["Year"];
                CarItem.Mileage = (int)row["Mileage"];
                CarItem.Color = (string)row["Color"];
                CarItem.FuelTypeID = (clsFuleType.enFuleTypes)row["FuelTypeID"];
                CarItem.VIN = (string)row["VIN"];
                CarItem.PlateNumber = (string)row["PlateNumber"];
                CarItem.Transmission = ((bool)row["Transmission"])? enTransmission.Automatic:enTransmission.Manual;
                CarItem.RentalPricePerDay = Convert.ToSingle(row["RentalPricePerDay"]);
                CarItem.Status = (enStatus)Convert.ToByte(row["Status"]);
                CarItem.ImagePath=(row["ImagePath"]==DBNull.Value)?"": (string)(row["ImagePath"]);
                Carslist.Add(CarItem);

            }
            return Carslist;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCar())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                        return false;



                case enMode.Update:

                    return _UpdateCar();


                default:
                    return false;
            }
        }
       
        private string _PlateNumberCheck(  string PlateNumber)
        {
            if (PlateNumber == null) { return null; }
            bool NumberRequired=false;
            bool LetterRequired=false;
            PlateNumber= PlateNumber.Replace(" ","");
           
            if (PlateNumber.Length > 6 )
            {
                throw new ArgumentException("out of range Plate number must be 6 characters.");

            }

            for (int i = 0; i < 3; i++)
            {
                if (char.IsDigit(PlateNumber[i]))
                {
                    NumberRequired = true;
                    break;
                }
            }

            for(int i = PlateNumber.Length/2; i <= PlateNumber.Length - 1; i++) 
            { 
                if (char.IsLetter(PlateNumber[i]))
                {
                    LetterRequired=true;
                    break;
                }
                 
                
            }
            if (!NumberRequired)
            {
                throw new ArgumentException("Formating erorr Plate number must have at least 1 number.");
            }
            if (!LetterRequired)
            {
                throw new ArgumentException("Formating erorr Plate number must have at least 1 Letter.");
            }
           return PlateNumber.Insert(PlateNumber.Length/2, " ");
        }

        private string _VINCheck(string VIN)
        {
            if (VIN == null) { return null; }
           
            if (VIN.Length != 17)
            {
                throw new ArgumentException(" The VIN must be 17 characters.");

            }

            for (int i = 11; i <= 16; i++)
            {
                if (!char.IsDigit(VIN[i]))
                {
                    throw new ArgumentException("Formating erorr Last 6 Characters must be a number.");
                }
            }

            
            return VIN;
        }
        public static int NumberOfPages()
        {
            return clsCarData.NumberOfPages();
        }

    }
}
