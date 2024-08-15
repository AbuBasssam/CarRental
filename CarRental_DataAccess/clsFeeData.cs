using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace CarRental_DataAccess
{
    public class clsFeeData
    {
        public static bool GetFeeByID(int FeeID, ref byte FeeTypeID, ref DateTime FeeDate, ref float FeeAmount, ref int NumberOfTimes, ref string Notes, ref byte Status, ref int BookingID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindFeeByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FeeID", FeeID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                FeeTypeID = Convert.ToByte(reader["FeeTypeID"]);
                                FeeDate = Convert.ToDateTime(reader["FeeDate"]);
                                FeeAmount = Convert.ToSingle(reader["FeeAmount"]);
                                NumberOfTimes =(int)reader["NumberOfTimes"];
                                Notes = (string)reader["Notes"];
                                Status = Convert.ToByte(reader["Status"]);
                                BookingID = (int)reader["BookingID"];







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

        public static Nullable<int> AddNewFee(  byte FeeTypeID,  DateTime FeeDate,  float FeeAmount,  int NumberOfTimes,  string Notes,  int BookingID)
        {
            Nullable<int> FeeID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewFee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        // Person Information
                        command.Parameters.AddWithValue("@FeeTypeID", FeeTypeID);
                        command.Parameters.AddWithValue("@FeeDate", FeeDate);
                        command.Parameters.AddWithValue("@FeeAmount", FeeAmount);
                        command.Parameters.AddWithValue("@NumberOfTimes", NumberOfTimes);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.Parameters.AddWithValue("@BookingID", BookingID);

                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        FeeID = (Nullable<int>)command.Parameters["@NewID"].Value;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return FeeID;
        }

        public static bool UpdateFee(int FeeID,  byte FeeTypeID,  DateTime FeeDate,  float FeeAmount,  int NumberOfTimes,  string Notes,  byte Status,  int BookingID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateCarFee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FeeTypeID", FeeTypeID);
                        command.Parameters.AddWithValue("@FeeDate", FeeDate);
                        command.Parameters.AddWithValue("@FeeAmount", FeeAmount);
                        command.Parameters.AddWithValue("@NumberOfTimes", NumberOfTimes);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@FeeID", FeeID);

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

        public static DataTable GetAllFees()
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllFees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

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



    }
}
