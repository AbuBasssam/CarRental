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
    public class clsRentalBookingData
    {
        public static bool FindByIRentalBookingD(int BookingID, int CustomerID, int CarID, DateTime RentalStartDate, DateTime RentalEndDate, string PickUpLocation, string DropOffLocation, byte RentalRateType, float RentalPrice, float InitialTotalDueAmount, int LimitsMileage, string InitialCheckNote, byte InitialFulePercentage, int AddByUserID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindRentalBookingByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RentalBookingID", BookingID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                //RentalBookingID = (int)reader["RentalBookingID"];
                                CustomerID = (int)reader["CustomerID"];
                                RentalStartDate = Convert.ToDateTime(reader["RentalStartDate"]);
                                RentalEndDate = Convert.ToDateTime(reader["RentalEndDate"]);
                                PickUpLocation = (string)reader["PickUpLocation"];
                                DropOffLocation = (string)reader["DropOffLocation"];
                                RentalRateType = Convert.ToByte(reader["RentalRateType"]);
                                InitialTotalDueAmount = Convert.ToSingle(reader["InitialTotalDueAmount"]);
                                LimitsMileage = (int)reader["LimitsMileage"];
                                InitialCheckNote = (string)reader["InitialCheckNote"];
                                InitialFulePercentage = Convert.ToByte(reader["FulePercentage"]);
                                AddByUserID = (int)reader["AddByUserID"];
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


        //tested
        public static Nullable<int> AddNewRentalBooking(int CustomerID, int CarID,
            DateTime RentalStartDate, DateTime RentalEndDate, string PickUpLocation, string DropOffLocation,
            byte RentalRateType, float RentalPrice, float InitialTotalDueAmount, int LimitsMileage, string InitialCheckNotes,
            byte InitialFulePercentage, int AddByUserID)
        {
            Nullable<int> RentalBookingID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewRentalBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };


                        command.Parameters.Add(outputIdParam);


                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@CarID", CarID);
                        command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
                        command.Parameters.AddWithValue("@PickUpLocation", PickUpLocation);
                        command.Parameters.AddWithValue("@DropOffLocation", DropOffLocation);
                        command.Parameters.AddWithValue("@RentalRateType", RentalRateType);
                        command.Parameters.AddWithValue("@RentalPrice", RentalPrice);
                        command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
                        command.Parameters.AddWithValue("@LimitsMileage", LimitsMileage);
                        command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);
                        command.Parameters.AddWithValue("@FulePercentage", InitialFulePercentage);
                        command.Parameters.AddWithValue("@AddByUserID", AddByUserID);
                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        RentalBookingID = (Nullable<int>)command.Parameters["@NewID"].Value;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return RentalBookingID;
        }


        //tested
        public static bool UpdateRentalBooking(int BookingID, int CustomerID, int CarID, DateTime RentalStartDate, DateTime RentalEndDate, string PickUpLocation, string DropOffLocation, byte RentalRateType, float RentalPrice, float InitialTotalDueAmount, int LimitsMileage, string InitialCheckNotes, byte InitialFulePercentage, int AddByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateRentalBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@CarID", CarID);
                        command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
                        command.Parameters.AddWithValue("@PickUpLocation", PickUpLocation);
                        command.Parameters.AddWithValue("@DropOffLocation", DropOffLocation);
                        command.Parameters.AddWithValue("@RentalRateType", RentalRateType);
                        command.Parameters.AddWithValue("@RentalPrice", RentalPrice);
                        command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
                        command.Parameters.AddWithValue("@LimitsMileage", LimitsMileage);
                        command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);
                        command.Parameters.AddWithValue("@InitialFulePercentage", InitialFulePercentage);
                        command.Parameters.AddWithValue("@AddByUserID", AddByUserID);
                        command.Parameters.AddWithValue("@BookingID", BookingID);

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

        //tested
        public static bool DeleteRentalBooking(int BookingID)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_DeleteRentalBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookingID", BookingID);

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

        public static bool IsRentalBookingExist(int BookingID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckRentalBookingExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RentalBookingID", (object)BookingID ?? DBNull.Value);

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
            }

            return isFound;
        }

        public static DataTable GetRentalBookingsPage(int PageNumber)
        {

            DataTable RentalBookingPage = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_BookingList", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                               
                                RentalBookingPage.Load(reader);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return RentalBookingPage;

        }

        public static int NumberOfPages()
        {

            int Pages = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string Query = "select Pages=dbo.RentalBookingPages()";
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
        public static int NumberOfFilterPages(int Year, int Month)
        {

            int Pages = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string Query = "select Pages=dbo.RentalBookingFilterPages(@Year,@Month)";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        if (Year == 0)
                            command.Parameters.AddWithValue("@Year", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Year", Year);

                        if (Month == 0)
                            command.Parameters.AddWithValue("@Month", DBNull.Value);

                        else
                            command.Parameters.AddWithValue("@Month", Month);
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
        public static int MniumRentalBookingYear()
        {
            int Pages = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string Query = "select MinumYear=dbo.MniumRentalBookingYear()";
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
        
        public static DataTable GetRentalBookingsFilter(int Year,int Month,int PageNumber)
        {

            DataTable RentalBookingPage = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_RentalBookingDurationFilter", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if(Year==0)
                            command.Parameters.AddWithValue("@Year", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Year", Year);

                        if (Month == 0)
                            command.Parameters.AddWithValue("@Month", DBNull.Value);

                        else
                            command.Parameters.AddWithValue("@Month", Month);

                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                RentalBookingPage.Load(reader);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return RentalBookingPage;

        }
    }
}
