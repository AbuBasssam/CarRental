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
    public class clsRenralTransactionData
    {
        public static bool GetTransactionInfoByID(int TransactionID, ref int BookingID,ref Nullable<int> ReturnID, ref string PaymentDetails,
            ref float PaidIntialTotalDueAmount, ref Nullable<float> ActualTotalDueAmount,ref Nullable<float> TotalRemaining,
            ref Nullable<float> TotalRefundedAmount,ref DateTime TransactionDate,ref DateTime UpdateTransactionDate )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());


            SqlCommand command = new SqlCommand("SP_FindTransactionByID", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    BookingID = reader.GetInt32(reader.GetOrdinal("BookingID"));
                    ReturnID = reader.GetInt32(reader.GetOrdinal("ReturnID"));
                    PaymentDetails = reader.GetString(reader.GetOrdinal("PaymentDetails"));
                    PaidIntialTotalDueAmount = reader.GetFloat(reader.GetOrdinal("PaidIntialTotalDueAmount"));
                    ActualTotalDueAmount = reader.GetFloat(reader.GetOrdinal("ActualTotalDueAmount"));
                    TotalRemaining = reader.GetFloat(reader.GetOrdinal("TotalRemaining"));
                    TotalRefundedAmount = reader.GetFloat(reader.GetOrdinal("TotalRefundedAmount"));
                    TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                    UpdateTransactionDate = reader.GetDateTime(reader.GetOrdinal("UpdateTransactionDate"));




                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static Nullable<int> AddNewTransaction(int BookingID,string PaymentDetails,float PaidIntialTotalDueAmount)
        {
            Nullable<int> ID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewTransaction", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        command.Parameters.AddWithValue("@BookingID", BookingID);

                        
                            command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
                            
                        command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidIntialTotalDueAmount);
                        //command.Parameters.AddWithValue("@ActualTotalDueAmount",DBNull.Value);
                       // command.Parameters.AddWithValue("@TotalRemaining", DBNull.Value);
                       // command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
                        command.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                        //command.Parameters.AddWithValue("@UpdateTransactionDate", DBNull.Value);


                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        ID = (Nullable<int>)command.Parameters["@NewID"].Value;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return ID;
        }

        public static bool UpdateTransaction(int TransactionID,  int BookingID,  int ReturnID,  string PaymentDetails,
            float PaidIntialTotalDueAmount,  float ActualTotalDueAmount,  float TotalRemaining,
             float TotalRefundedAmount,  DateTime TransactionDate)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateTransaction", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TransactionID", TransactionID);
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@ReturnID", ReturnID);
                        command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
                        command.Parameters.AddWithValue("@PaidIntialTotalDueAmount", PaidIntialTotalDueAmount);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
                        command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
                        command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                        command.Parameters.AddWithValue("@UpdateTransactionDate", DateTime.Now);

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

        public static DataTable GetTransactionPage(int PageNumber)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetTransactionPage", connection))
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

        public static int NumberOfPages()
        {

            int Pages = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string Query = "select Pages=dbo.TransactionPages()";
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

        public static DataTable GetTransactionsFilter(int Year, int Month, int PageNumber)
        {

            DataTable RentalBookingPage = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_TransactionsDurationFilter", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (Year == 0)
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
