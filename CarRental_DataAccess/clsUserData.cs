using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.Security.Policy;

namespace CarRental_DataAccess
{
    public class clsUserData
    {
        
        public static bool FindByIUserID( int UserID,  ref int PersonID, ref string UserName, ref string Password
                                       , ref float Salary, ref bool IsActive, ref string NationalNo, ref string FirstName, ref string SecondName
                                       , ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender
                                       , ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindUserByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                UserName = (string)reader["UserName"];
                                Password = (string)reader["Password"];
                                Salary = Convert.ToSingle(reader["Salary"]);
                                IsActive = (bool)reader["IsActive"];
                                
                                //Person Info
                                NationalNo = (string)reader["NationalNO"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                //ThirdName: allows null in database so we should handle null
                                if (reader["ThirdName"] != DBNull.Value)
                                {
                                    ThirdName = (string)reader["ThirdName"];
                                }
                                else
                                {
                                    ThirdName = "";
                                }

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = Convert.ToByte(reader["Gender"]);
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryID = Convert.ToByte(reader["NationalityCountryID"]);

                                //Email: allows null in database so we should handle null
                                if (reader["Email"] != DBNull.Value)
                                {
                                    Email = (string)reader["Email"];
                                }
                                else
                                {
                                    Email = "";
                                }

                                //ImagePath: allows null in database so we should handle null
                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
                                }

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
       
        public static bool FindMechanicUserByIUserID(int UserID, ref int PersonID, ref string UserName, ref string Password
                                       , ref float Salary, ref bool IsActive, ref string NationalNo, ref string FirstName, ref string SecondName
                                       , ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender
                                       , ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindMechanicUserByUserID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                UserName = (string)reader["UserName"];
                                Password = (string)reader["Password"];
                                Salary = Convert.ToSingle(reader["Salary"]);
                                IsActive = (bool)reader["IsActive"];
                                
                                //Person Info
                                NationalNo = (string)reader["NationalNO"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                //ThirdName: allows null in database so we should handle null
                                if (reader["ThirdName"] != DBNull.Value)
                                {
                                    ThirdName = (string)reader["ThirdName"];
                                }
                                else
                                {
                                    ThirdName = "";
                                }

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = Convert.ToByte(reader["Gender"]);
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryID = Convert.ToByte(reader["NationalityCountryID"]);

                                //Email: allows null in database so we should handle null
                                if (reader["Email"] != DBNull.Value)
                                {
                                    Email = (string)reader["Email"];
                                }
                                else
                                {
                                    Email = "";
                                }

                                //ImagePath: allows null in database so we should handle null
                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
                                }

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

        public static bool Find(ref Nullable< int> UserID, ref int PersonID, string UserName,  string Password
                              , ref float Salary, ref bool IsActive, ref string NationalNo, ref string FirstName, ref string SecondName
                              , ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender
                              , ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindUserByUserNameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);


                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                Salary = Convert.ToSingle(reader["Salary"]);
                                IsActive = (bool)reader["IsActive"];
                              
                                // Person Info
                                NationalNo = (string)reader["NationalNO"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                //ThirdName: allows null in database so we should handle null
                                if (reader["ThirdName"] != DBNull.Value)
                                {
                                    ThirdName = (string)reader["ThirdName"];
                                }
                                else
                                {
                                    ThirdName = "";
                                }

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = Convert.ToByte(reader["Gender"]);
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryID = Convert.ToByte(reader["NationalityCountryID"]);

                                //Email: allows null in database so we should handle null
                                if (reader["Email"] != DBNull.Value)
                                {
                                    Email = (string)reader["Email"];
                                }
                                else
                                {
                                    Email = "";
                                }

                                //ImagePath: allows null in database so we should handle null
                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
                                }

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
                             
        public static Nullable<int> AddNewUser( string NationalNO,string FirstName,string SecondName,  string ThirdName,  string LastName
                                               ,DateTime DateOfBirth, byte Gender,  string Address,string Phone, string Email
                                               ,byte NationalityCountryID, string ImagePath ,  ref int PersonID, string UserName
                                               , string Password,float Salary, bool IsActive)
        {
            Nullable<int> UserID = null;
            

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                   
                        using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                            SqlParameter outputIdParam2 = new SqlParameter("@NewPersonID", SqlDbType.Int)
                            {
                              Direction = ParameterDirection.Output

                            };

                          command.Parameters.Add(outputIdParam);
                          command.Parameters.Add(outputIdParam2);


                        // Person Information
                        command.Parameters.AddWithValue("@NationalNo", NationalNO);
                            command.Parameters.AddWithValue("@FirstName", FirstName);
                            command.Parameters.AddWithValue("@SecondName", SecondName);
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);
                            command.Parameters.AddWithValue("@LastName", LastName);
                            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                            command.Parameters.AddWithValue("@Gender", Gender);
                            command.Parameters.AddWithValue("@Address", Address);
                            command.Parameters.AddWithValue("@Phone", Phone);
                            command.Parameters.AddWithValue("@Email", Email);
                            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                           
                           if(ImagePath != null) 
                               command.Parameters.AddWithValue("@ImagePath", ImagePath);
                           
                         
                            //User Information
                            command.Parameters.AddWithValue("@UserName", UserName);
                            command.Parameters.AddWithValue("@Password", Password);
                            command.Parameters.AddWithValue("@IsActive", IsActive);
                            command.Parameters.AddWithValue("@Salary", Salary);
                           
                           
                          

                            // Execute
                            connection.Open();
                            command.ExecuteNonQuery();
                            UserID = (Nullable<int>)command.Parameters["@NewID"].Value;
                            PersonID= (command.Parameters["@NewPersonID"].Value!=DBNull.Value)? (int)command.Parameters["@NewPersonID"].Value:-1;



                        }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return UserID;
        }


        public static bool UpdateUser(int UserID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName
                                               , DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email
                                               , byte NationalityCountryID, string ImagePath, int PersonID, string UserName
                                               , string Password, float Salary, bool IsActive)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    
                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@NationalNo", NationalNO);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                        if (ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);

                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                        //User Information
                        
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("SP_CheckUserExists", connection))
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
        
        public static bool IsUserExist(string NationalNO)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckUserExistsByNationalNO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNO", (object)NationalNO ?? DBNull.Value);

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
        public static bool isUserExist(string UserName)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckUserExistsByUserName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNO", (object)UserName ?? DBNull.Value);

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

        public static List<int> GetUsersPage(int PageNumber )
        {

            List<int> UserPage = new List<int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                   

                    using (SqlCommand command = new SqlCommand("SP_UserPages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int value = (int)reader["UserID"]; // Assuming the first column contains the desired integer value
                                UserPage.Add(value);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return UserPage;


        }
        
        public static List<int> GetUsersIDsByFirstNameSearch(string FirstName)
        {
            List<int> UsersIDs = new List<int>();


            try
            {
               

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    //string Query = "Select UserID From Users_View where FirstName LIKE + '' + @FirstName + '%'";

                    using (SqlCommand command = new SqlCommand("SP_FilterUserByFirstName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                UsersIDs.Add((int)reader["UserID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return UsersIDs;


        }
        
        public static List<int> GetUsersIDsByNationalNoSearch(string NationalNo)
        {
            List<int> UsersIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                  

                    using (SqlCommand command = new SqlCommand("SP_FilterUserByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                UsersIDs.Add((int)reader["UserID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return UsersIDs;


        }


        public static List<int> GetUsersIDsByPhoneNumberSearch(string PhoneNumber)
        {
            List<int> UsersIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_FilterUsersByPhoneNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                UsersIDs.Add((int)reader["UserID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return UsersIDs;


        }





















    }
}
