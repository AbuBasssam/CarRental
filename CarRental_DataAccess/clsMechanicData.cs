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
    public class clsMechanicData
    {
        //tested
        public static bool FindByIMechanicID( int MechanicID, ref int UserID, ref string WorkSchedule, ref bool AbilityToOverTimer, ref byte AreasOfSpecialization)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindMechanicByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MechanicID", MechanicID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                UserID = (int)reader["UserID"];
                                WorkSchedule = (string)reader["WorkSchedule"];
                                AbilityToOverTimer = (Convert.ToByte(reader["AbilityToOverTime"])==1)? true:false;
                                AreasOfSpecialization = Convert.ToByte(reader["AreasOfSpecialization"]);
                                
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
        
        public static bool FindByIUserID (ref int MechanicID,  int UserID, ref string WorkSchedule, ref bool AbilityToOverTimer, ref byte AreasOfSpecialization)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindMechanicByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MechanicID", MechanicID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                MechanicID = (int)reader["MechanicID"];
                                WorkSchedule = (string)reader["WorkSchedule"];
                                AbilityToOverTimer = (Convert.ToByte(reader["AbilityToOverTime"]) == 1) ? true : false;
                                AreasOfSpecialization = Convert.ToByte(reader["AreasOfSpecialization"]);

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
        public static Nullable<int> AddNewMechanic(int UserID, string WorkSchedule, bool AbilityToOverTimer, byte AreasOfSpecialization)
        {
            Nullable<int> MechanicID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewMechanic", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                       

                        command.Parameters.Add(outputIdParam);


                        
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@WorkSchedule", WorkSchedule);
                        command.Parameters.AddWithValue("@AbilityToOverTime", AbilityToOverTimer);
                        command.Parameters.AddWithValue("@AreasOfSpecialization", AreasOfSpecialization);
                       
                       
                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        MechanicID = (Nullable<int>)command.Parameters["@NewID"].Value;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return MechanicID;
        }

        //tested
        public static bool UpdateMechanic(int MechanicID ,int UserID, string WorkSchedule, bool AbilityToOverTimer, byte AreasOfSpecialization)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateMechanic", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@WorkSchedule", WorkSchedule);
                        command.Parameters.AddWithValue("@AbilityToOverTime", AbilityToOverTimer);
                        command.Parameters.AddWithValue("@AreasOfSpecialization", AreasOfSpecialization);
                        command.Parameters.AddWithValue("@MechanicID", MechanicID);

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
        public static bool DeleteMechanic(int MechanicID)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_DeleteMechanic", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MechanicID", MechanicID);

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

        public static bool IsMechanicExist(int MechanicID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckMechanicExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MechanicID", (object)MechanicID ?? DBNull.Value);

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
        
        public static bool IsUserAlreadyMechanic(int UserID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsUserAlreadyMechanic", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

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

        public static List<int> GetMechanics(int PageNumber)
        {

            List<int> MechanicePage = new List<int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_MechanicPages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int value = reader.GetInt32(0); // Assuming the first column contains the desired integer value
                                MechanicePage.Add(value);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return MechanicePage;



        }

        public static List<int> GetMechanicsIDsByFirstNameSearch(string FirstName)
        {
            List<int> MechanicsIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterMechanicsByFirstName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                MechanicsIDs.Add((int)reader["MechanicID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return MechanicsIDs;


        }

        public static List<int> GetMechanicsIDsByNationalNoSearch(string NationalNo)
        {
            List<int> MechanicsIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_FilterMechanicsByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                MechanicsIDs.Add((int)reader["MechanicID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return MechanicsIDs;


        }

        public static List<int> GetMechanicsIDsByPhoneNumberSearch(string PhoneNumber)
        {
            List<int> MechanicsIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_FilterMechanicsByPhoneNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                MechanicsIDs.Add((int)reader["MechanicID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return MechanicsIDs;


        }

    }
}
