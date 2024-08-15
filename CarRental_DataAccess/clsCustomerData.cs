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
    public class clsCustomerData
    {


        //tested
        public static bool FindCustomerByID(int CustomerID, ref int PersonID,ref string NationalNo, ref string FirstName, ref string SecondName
                                       , ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender
                                       , ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath ,ref int DriverLicenseNumber)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCustomerByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                //CustomerID = (int)reader["CustomerID"];
                                PersonID = (int)reader["PersonID"];
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
                                DriverLicenseNumber= (int)reader["DriverLicenseNumber"];

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
        public static bool FindCustomerByINationalNo(ref int CustomerID, ref int PersonID,  string NationalNo, ref string FirstName, ref string SecondName
                                       , ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender
                                       , ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath, ref int DriverLicenseNumber)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FindCustomerByNationalNO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                //CustomerID = (int)reader["CustomerID"];
                                PersonID = (int)reader["PersonID"];
                                CustomerID = (int)reader["CustomerID"];
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
                                DriverLicenseNumber = (int)reader["DriverLicenseNumber"];

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
        public static Nullable<int> AddNewCustomer(string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName
                                               , DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email
                                               , byte NationalityCountryID, string ImagePath, ref int PersonID, int DriverLicenseNumber)
        {
            Nullable<int> CustomerID = null;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_AddNewCustomer", connection))
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

                        if (ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);


                        //Customer Information
                        command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
                       




                        // Execute
                        connection.Open();
                        command.ExecuteNonQuery();
                        CustomerID = (Nullable<int>)command.Parameters["@NewID"].Value;
                        PersonID = (command.Parameters["@NewPersonID"].Value != DBNull.Value) ? (int)command.Parameters["@NewPersonID"].Value : -1;



                    }

                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return CustomerID;
        }


        //tested
        public static bool UpdateCustomer(int CustomerID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName
                                               , DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email
                                               , byte NationalityCountryID, string ImagePath, int PersonID, int DriverLicenseNumber)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_UpdateCustomer", connection))
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

                        //Customer Information

                       
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

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
        public static bool DeleteCustomer(int CustomerID)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_DeleteCustomer", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static bool IsCustomerExist(int CustomerID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckCustomerExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CustomerID", (object)CustomerID ?? DBNull.Value);

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



        public static List<int> GetCustomersPage(int PageNumber)
        {

            List<int> CustomerPage = new List<int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_CustomerPages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PageNumber", PageNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int value = reader.GetInt32(0); 
                                CustomerPage.Add(value);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return CustomerPage;

        }

        public static List<int> GetCustomersIDsByFirstNameSearch(string FirstName)
        {
            List<int> CustomersIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    using (SqlCommand command = new SqlCommand("SP_FilterCustomersByFirstName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                CustomersIDs.Add((int)reader["CustomerID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return CustomersIDs;


        }

        public static List<int> GetCustomersIDsByNationalNoSearch(string NationalNo)
        {
            List<int> CustomersIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_FilterCustomersByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                CustomersIDs.Add((int)reader["CustomerID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return CustomersIDs;


        }


        public static List<int> GetCustomersIDsByPhoneNumberSearch(string PhoneNumber)
        {
            List<int> CustomersIDs = new List<int>();


            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    using (SqlCommand command = new SqlCommand("SP_FilterCustomersByPhoneNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                CustomersIDs.Add((int)reader["CustomerID"]);
                            }
                        }
                    }



                }



            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return CustomersIDs;


        }
    }
}
