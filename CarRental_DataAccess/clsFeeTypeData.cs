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
    public class clsFeeTypeData
    {
        public static bool GetFeeTypeByID(int FeeTypeID, ref string FeeTypeName, ref string FeeDescription, ref float FeeAmount)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindFeeTypeByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FeeTypeID", FeeTypeID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                FeeTypeName = (string)(reader["FeeTypeName"]);
                                FeeDescription = (string)reader["FeeDescription"];
                                FeeAmount = Convert.ToSingle(reader["FeeAmount"]); ;
                               



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

        public static Nullable<int> AddNewFeeType(string FeeTypeName, string FeeDescription, float FeeAmount)
        {
            Nullable<int> FeeTypeID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewFeeType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        // Person Information
                        command.Parameters.AddWithValue("@FeeTypeName", FeeTypeName);
                        command.Parameters.AddWithValue("@FeeDescription", FeeDescription);
                        command.Parameters.AddWithValue("@FeeAmount", FeeAmount);

                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        FeeTypeID = (Nullable<int>)command.Parameters["@NewID"].Value;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return FeeTypeID;
        }

        public static bool UpdateFeeType(int FeeTypeID, string FeeTypeName, string FeeDescription, float FeeAmount)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateCarFeeType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FeeTypeName", FeeTypeName);
                        command.Parameters.AddWithValue("@FeeDescription", FeeDescription);
                        command.Parameters.AddWithValue("@FeeAmount", FeeAmount);
                        command.Parameters.AddWithValue("@FeeTypeID", FeeTypeID);

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

        public static DataTable GetAllFeeTypes()
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
