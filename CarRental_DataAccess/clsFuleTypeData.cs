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
    public class clsFuleTypeData
    {
        public static bool GetFuleInfoByID(int ID, ref string FuleType)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());


            SqlCommand command = new SqlCommand("SP_FindFuletypeByID", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    FuleType = (string)reader["FuleType"];

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

        public static bool GetFuleInfoByType(string FuleType, ref int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());


            SqlCommand command = new SqlCommand("SP_FindFuleTypeByFuleType", connection);
            command.CommandType= CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FuleType", FuleType);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ID = (int)reader["FuleID"];

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

        public static Nullable<int> AddNewFuleType(string FuleType)
        {
            Nullable<int> ID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewFuleType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        // Person Information
                        command.Parameters.AddWithValue("@FuleType", FuleType);
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
        
        public static bool UpdateFuleType(int ID, string FuleType)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateFuleType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FuleType", FuleType);
                        command.Parameters.AddWithValue("@ID", ID);

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

        public static DataTable GetAllFuleTypes()
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllFuleTypes", connection))
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


        /*        public static bool IsFuleExist(int ID)
         {
             bool isFound = false;

             SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());

             string query = "SELECT Found=1 FROM Countries WHERE FuleID = @FuleID";

             SqlCommand command = new SqlCommand(query, connection);

             command.Parameters.AddWithValue("@FuleID", ID);

             try
             {
                 connection.Open();
                 SqlDataReader reader = command.ExecuteReader();

                 isFound = reader.HasRows;

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
 */

        
        /*        public static bool IsFuleExist(string FuleType)
         {
             bool isFound = false;

             SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());

             string query = "SELECT Found=1 FROM Countries WHERE FuleName = @FuleType";

             SqlCommand command = new SqlCommand(query, connection);

             command.Parameters.AddWithValue("@FuleType", FuleType);

             try
             {
                 connection.Open();
                 SqlDataReader reader = command.ExecuteReader();

                 isFound = reader.HasRows;

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
 */
    }

}
