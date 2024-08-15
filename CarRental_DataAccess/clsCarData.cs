using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.CodeDom.Compiler;

namespace CarRental_DataAccess
{
    public  class clsCarData
    {
        public static bool FindByICarD(int CarID, ref string Make, ref string Model, ref int Year, ref int Mileage,
          ref string Color, ref byte FuelTypeID, ref string PlateNumber,
            ref byte CarCategoryID, ref string VIN, ref byte Transmission,
           ref float RentalPricePerDay, ref float RentalPricePerWeek,
            ref float RentalPricePerMonth, ref byte Status, ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCarByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CarID", CarID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                Make = (string)reader["Make"];
                                Model = (string)reader["Model"];
                                Year = (int)reader["Year"];
                                Mileage = (int)reader["Mileage"];
                                Color = (string)reader["Color"];
                                FuelTypeID = Convert.ToByte(reader["FuelTypeID"]);
                                PlateNumber = (string)reader["PlateNumber"];
                                CarCategoryID = Convert.ToByte(reader["CarCategoryID"]);                              
                                VIN = (string)reader["VIN"];
                                Transmission = Convert.ToByte(reader["Transmission"]);
                                ImagePath = (string)reader["ImagePath"];
                                RentalPricePerDay = Convert.ToSingle(reader["RentalPricePerDay"]);
                                RentalPricePerWeek = Convert.ToSingle(reader["RentalPricePerWeek"]);
                                RentalPricePerMonth = Convert.ToSingle(reader["RentalPricePerMonth"]);
                                Status = Convert.ToByte(reader["Status"]);
                                

                                
                                
                                

                            }

                        }


                    }



                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }


            return isFound;
        }

        public static bool FindByPlateNumber( ref int CarID, ref string Make, ref string Model, ref int Year, ref int Mileage,
          ref string Color, ref byte FuelTypeID,  string PlateNumber,
            ref byte CarCategoryID,  ref string VIN, ref byte Transmission,
           ref float RentalPricePerDay, ref float RentalPricePerWeek,
            ref float RentalPricePerMonth, ref byte Status, ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCarByPlateNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                CarID = (int)reader["CarID"];
                                Make = (string)reader["Make"];
                                Model = (string)reader["Model"];
                                Year = (int)reader["Year"];
                                Mileage = (int)reader["Mileage"];
                                Color = (string)reader["Color"];
                                FuelTypeID = Convert.ToByte(reader["FuelTypeID"]);
                                CarCategoryID = Convert.ToByte(reader["CarCategoryID"]);
                                VIN = (string)reader["VIN"];
                                Transmission = Convert.ToByte(reader["Transmission"]);
                                ImagePath = (string)reader["ImagePath"];
                                RentalPricePerDay = Convert.ToSingle(reader["RentalPricePerDay"]);
                                RentalPricePerWeek = Convert.ToSingle(reader["RentalPricePerWeek"]);
                                RentalPricePerMonth = Convert.ToSingle(reader["RentalPricePerMonth"]);
                                Status = Convert.ToByte(reader["Status"]);

                            }

                        }


                    }



                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }


            return isFound;
        }

        public static bool FindByVIN(ref int CarID, ref string Make, ref string Model, ref int Year, ref int Mileage,
          ref string Color, ref byte FuelTypeID,ref string PlateNumber,
            ref byte CarCategoryID,  string VIN, ref byte Transmission,
           ref float RentalPricePerDay, ref float RentalPricePerWeek,
            ref float RentalPricePerMonth, ref byte Status, ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCarByVIN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@VIN", VIN);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                CarID = (int)reader["CarID"];
                                Make = (string)reader["Make"];
                                Model = (string)reader["Model"];
                                Year = (int)reader["Year"];
                                Mileage = (int)reader["Mileage"];
                                Color = (string)reader["Color"];
                                FuelTypeID = Convert.ToByte(reader["FuelTypeID"]);
                                CarCategoryID = Convert.ToByte(reader["CarCategoryID"]);
                                PlateNumber = (string)reader["PlateNumber"];
                                Transmission = Convert.ToByte(reader["Transmission"]);
                                ImagePath = (string)reader["ImagePath"];
                                RentalPricePerDay = Convert.ToSingle(reader["RentalPricePerDay"]);
                                RentalPricePerWeek = Convert.ToSingle(reader["RentalPricePerWeek"]);
                                RentalPricePerMonth = Convert.ToSingle(reader["RentalPricePerMonth"]);
                                Status = Convert.ToByte(reader["Status"]);

                            }

                        }


                    }



                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }


            return isFound;
        }


        public static Nullable<int> AddNewCar( string Make,  string Model,  int Year,  int Mileage,
           string Color,  byte FuelTypeID,  string PlateNumber,
             byte CarCategoryID,  string VIN,  byte Transmission,
            float RentalPricePerDay,  byte Status,  string ImagePath)
        {
            Nullable<int> CarID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewCar", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        command.Parameters.AddWithValue("@Make", Make);
                        command.Parameters.AddWithValue("@Model", Model);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@Mileage", Mileage);
                        command.Parameters.AddWithValue("@Color", Color);
                        command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                        command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);
                        command.Parameters.AddWithValue("@VIN", VIN);
                        command.Parameters.AddWithValue("@Transmission", Transmission);
                        command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);

                       
                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        CarID = (Nullable<int>)command.Parameters["@NewID"].Value;


                    }
                   

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return CarID;
        }
        public static DataTable CarFilter(string Make, string Model, int Year, int Mileage,
          byte FuelTypeID,byte CarCategoryID, short Transmission,
           float MinumRentalDailyPrice, float MaxumRentalDailyPrice, short Status)
        {
            DataTable Result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterCars", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                       
                        if(Make!="")
                            command.Parameters.AddWithValue("@Make", Make);
                       
                        if (Model!="")
                            command.Parameters.AddWithValue("@Model", Model);
                        
                        if (Year != 0)
                            command.Parameters.AddWithValue("@Year", Year);
                        
                        if (Mileage != 0)
                            command.Parameters.AddWithValue("@Mileage", Mileage);
                        
                        if (CarCategoryID != 0)
                            command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);

                        
                        if (FuelTypeID != 0)
                            command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);

                        
                        if (MinumRentalDailyPrice != 0)
                            command.Parameters.AddWithValue("@MinumRentalDailyPrice", MinumRentalDailyPrice);

                        if (MaxumRentalDailyPrice != 0)
                            command.Parameters.AddWithValue("@MaxumRentalDailyPrice", MaxumRentalDailyPrice);

                        if (Transmission != -1)
                            command.Parameters.AddWithValue("@Transmission", Transmission);
                       
                        if (Status != 0)
                            command.Parameters.AddWithValue("@Status", Status);


                        // Execute
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)

                            {
                                Result.Load(reader);
                            }

                        }


                    }


                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return Result;
        }


        public static bool UpdateCar(int CarID, string Make, string Model, int Year, int Mileage,
           string Color, byte FuelTypeID, string PlateNumber,
             byte CarCategoryID, string VIN, byte Transmission,
            float RentalPricePerDay, byte Status, string ImagePath)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateCar", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CarID", CarID);
                        command.Parameters.AddWithValue("@Make", Make);
                        command.Parameters.AddWithValue("@Model", Model);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@Mileage", Mileage);
                        command.Parameters.AddWithValue("@Color", Color);
                        command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                        command.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);
                        command.Parameters.AddWithValue("@VIN", VIN);
                        command.Parameters.AddWithValue("@Transmission", Transmission);
                        command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        
                        //Excute
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }



                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }



            return (rowsAffected > 0);
        }

        public static bool DeleteCar(int CarID)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_DeleteCar", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CarID", CarID);
                        
                        //Execute
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }


                }


            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return (rowsAffected > 0);

        }

        public static bool IsCarExist(int CarID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckCarExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CarID", (object)CarID ?? DBNull.Value);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnParameter);
                        command.ExecuteNonQuery();

                        isFound = (int)returnParameter.Value == 1;


                    }




                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static bool IsCarExist(string PlateNumber)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckCarExistsByPlateNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PlateNumber", (object)PlateNumber ?? DBNull.Value);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnParameter);
                        command.ExecuteNonQuery();

                        isFound = (int)returnParameter.Value == 1;


                    }




                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }
        
        public static bool IsCarExistByVIN(string VIN)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckCarExistsByVIN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VIN", (object)VIN ?? DBNull.Value);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnParameter);
                        command.ExecuteNonQuery();

                        isFound = (int)returnParameter.Value == 1;


                    }




                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static DataTable GetCarPage(int Page)
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_CarPages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PageNumber", Page);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)

                            {
                                dt.Load(reader);
                            }

                        }
                    }


                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return dt;

        }

        public static DataTable GetMakeModels(string Make)
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection2"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_GetMakeCarModels", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Make", Make);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)

                            {
                                dt.Load(reader);
                            }

                        }
                    }


                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return dt;

        }

        public static int NumberOfPages()
        {

            int Pages = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string Query = "select Pages=dbo.CarPages()";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {


                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Pages = (int)reader[0];
                            }


                        }




                    }





                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }


            return Pages;

        }

    }
}
