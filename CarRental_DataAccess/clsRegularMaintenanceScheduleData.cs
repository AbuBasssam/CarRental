using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsRegularMaintenanceScheduleData
    {
        public static bool GetRegularMaintenanceScheduleByCarID(ref int RegularMaintenanceScheduleID,  byte RegularTypeID,  int CarID, ref int NextScheduledMileage)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCarRegularMaintenanceScheduleByCarIDAndRegularType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CarID", CarID);
                        command.Parameters.AddWithValue("@RegularTypeID", RegularTypeID);



                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                RegularMaintenanceScheduleID = (int)reader["ID"];
                                NextScheduledMileage = (int)reader["NextScheduledMileage"] ;
                               



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

        public static Nullable<int> AddNewRegularMaintenanceSchedule(byte RegularTypeID, int CarID, int NextScheduledMileage)
        {
            Nullable<int> RegularMaintenanceScheduleID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewCarRegularMaintenanceSchedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        // Person Information
                        command.Parameters.AddWithValue("@RegularTypeID", RegularTypeID);
                        command.Parameters.AddWithValue("@CarID", CarID);
                        command.Parameters.AddWithValue("@NextScheduledMileage", NextScheduledMileage);

                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        RegularMaintenanceScheduleID = (Nullable<int>)command.Parameters["@NewID"].Value;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return RegularMaintenanceScheduleID;
        }

        public static bool UpdateRegularMaintenanceSchedule(int RegularMaintenanceScheduleID, byte RegularTypeID, int CarID, int NextScheduledMileage)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateRegularMaintenanceScheduleType", connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RegularTypeID", RegularTypeID);
                        command.Parameters.AddWithValue("@CarID", CarID);
                        command.Parameters.AddWithValue("@NextScheduledMileage", NextScheduledMileage);
                        command.Parameters.AddWithValue("@ID", RegularMaintenanceScheduleID);

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

        public static DataTable GetAllRegularMaintenanceSchedule(int PageNumber=1)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetRegularMaintenanceSchedulePage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

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
        
        public static DataTable GetFullRegularMaintenanceCarSchedule(int CarID )
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByCarID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CarID", CarID);

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
                    string Query = "select Pages=dbo.RegularMaintenanceSchedulePages()";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Pages=(int)reader[0];
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
        
        public static DataTable GetRegularMaintenanceScheduleByOilChangeSearch(int OilChange)
        {
            DataTable dt= new DataTable() ;


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByOilChange", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@OilChange", OilChange);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if(reader.HasRows)
                               dt.Load(reader);

                            
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
        
        public static DataTable GetRegularMaintenanceScheduleByTireRotationSearch(int TireRotation)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByTireRotation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TireRotation", TireRotation);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            if (reader.HasRows)
                                dt.Load(reader);

                            
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
        
        public static DataTable GetRegularMaintenanceScheduleByBrakeInspectionSearch(int BrakeInspection)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByBrakeInspection", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BrakeInspection", BrakeInspection);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            if (reader.HasRows)

                                dt.Load(reader);

                            
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
        
        public static DataTable GetRegularMaintenanceScheduleByAirFilterSearch(int AirFilter)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByAirFilter", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AirFilter", AirFilter);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                dt.Load(reader);

                            
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
        
        public static DataTable GetRegularMaintenanceScheduleBySparkPlugReplacementSearch(int SparkPlugReplacement)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleBySparkPlugReplacement", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SparkPlugReplacement", SparkPlugReplacement);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                dt.Load(reader);

                            
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
        
        public static DataTable GetRegularMaintenanceScheduleByTransmissionFluidChangeSearch(int TransmissionFluidChange)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByTransmissionFluidChange", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TransmissionFluidChange", TransmissionFluidChange);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)

                                dt.Load(reader);

                            
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
        
        public static DataTable GetRegularMaintenanceScheduleByCoolantFlushSearch(int CoolantFlush)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByCoolantFlush", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CoolantFlush", CoolantFlush);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if(reader.HasRows)

                                dt.Load(reader);

                            
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

        public static DataTable GetRegularMaintenanceScheduleByGetRegularMaintenanceScheduleByBeltsAndHosesInspectionSearch(int BeltsAndHosesInspection)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByBeltsAndHosesInspection", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BeltsAndHosesInspection", BeltsAndHosesInspection);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if(reader.HasRows)

                                dt.Load(reader);

                            
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
       
        public static DataTable GetRegularMaintenanceScheduleByCarIDSearch(int CarID)
        {
            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterRegularMaintenanceScheduleByCarID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CarID", CarID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            
                            if( reader.HasRows) 
                                dt.Load(reader);

                            
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

        public static bool AddFullRegularMaintenanceCarSchedule(int CarID)
        {

            byte ReturnValue = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddFullRegularMaintenanceSchedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CarID", CarID);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        command.Parameters.Add(returnParameter);

                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();





                         ReturnValue=Convert.ToByte(returnParameter.Value) ;


                    }





                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }


            return (ReturnValue==8);

        }

    }
}
