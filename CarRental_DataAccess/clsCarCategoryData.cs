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
    public class clsCarCategoryData
    {
        public static bool GetCategoryByID(int CategoryID, ref string CategoryName, ref float RefuelPrice, ref float DailySecurityDeposit, ref float WeeklySecurityDeposit, ref float MonthlySecurityDeposit)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCarCategoryByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                CategoryName = (string)(reader["CategoryName"]);
                                RefuelPrice = Convert.ToSingle(reader["RefuelPrice"]);
                                DailySecurityDeposit = Convert.ToSingle(reader["DailySecurityDeposit"]); 
                                WeeklySecurityDeposit = Convert.ToSingle(reader["WeeklySecurityDeposit"]);
                                MonthlySecurityDeposit = Convert.ToSingle(reader["MonthlySecurityDeposit"]);



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

        public static Nullable<int> AddNewCategory(string CategoryName, float RefuelPrice, float DailySecurityDeposit)
        {
            Nullable<int> CategoryID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewCarCategory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        // Person Information
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@RefuelPrice", RefuelPrice);
                        command.Parameters.AddWithValue("@DailySecurityDeposit", DailySecurityDeposit);

                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        CategoryID = (Nullable<int>)command.Parameters["@NewID"].Value;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return CategoryID;
        }
        
        public static bool UpdateCategory(int CategoryID, string CategoryName, float RefuelPrice, float DailySecurityDeposit)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateCarCategory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@RefuelPrice", RefuelPrice);
                        command.Parameters.AddWithValue("@DailySecurityDeposit", DailySecurityDeposit);
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);

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
        
        public static DataTable GetAllCategories()
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllCategories", connection))
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

        
        /*        public static bool GetCarCategory(ref int CategoryID, ref string CategoryName, ref float RefuelPrice, ref float DailySecurityDeposit, ref float WeeklySecurityDeposit, ref float MonthlySecurityDeposit, int CarID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCategoryByCarID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CarID", CategoryID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                CategoryID = (int)reader["CategoryID"];
                                CategoryName = (string)(reader["CategoryName"]);
                                RefuelPrice = Convert.ToSingle(reader["RefuelPrice"]);
                                DailySecurityDeposit = Convert.ToSingle(reader["DailySecurityDeposit"]); ;
                                WeeklySecurityDeposit = Convert.ToSingle(reader["WeeklySecurityDeposit"]);
                                MonthlySecurityDeposit = Convert.ToSingle(reader["MonthlySecurityDeposit"]);


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
*/

       
        /* public static bool DeleteCategory(int CategoryID)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_DeleteCategory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);

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
*/

        
        /*        public static bool IsCategoryExist(int CategoryID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckCarCategoryExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CategoryID", (object)CategoryID ?? DBNull.Value);

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
*/
    }
}
