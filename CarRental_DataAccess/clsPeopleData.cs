﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CarRental_DataAccess
{
    public static  class clsPeopleData
    {
        public static bool FindByNationalNo(ref Nullable<int> PersonID, string NationalNO,
           ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
           , ref DateTime DateOfBirth, ref byte Gender, ref string Address,
           ref string Phone, ref string Email, ref byte Nationality, ref string ImagePath)
        {
            bool isFound = false;
            try
            {



                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    //string query = "SELECT * FROM People WHERE NationalNO = @NationalNO";

                    using (SqlCommand command = new SqlCommand("SP_FindPersonByNationalNO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNO", NationalNO);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
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
                                Nationality = Convert.ToByte(reader["NationalityCountryID"]);

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
                            else
                            {
                                // The record was not found
                                isFound = false;
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



        public static bool FindByID(int PersonID, ref string NationalNO,
           ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
           , ref DateTime DateOfBirth, ref byte Gender, ref string Address,
           ref string Phone, ref string Email, ref byte Nationality, ref string ImagePath)
        {

            bool isFound = false;
            try
            {



                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    //string query = "SELECT * FROM People WHERE PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand("SP_FindPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                NationalNO = (string)reader["NationalNO"];
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
                                Nationality = Convert.ToByte(reader["NationalityCountryID"]);

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
                            else
                            {
                                // The record was not found
                                isFound = false;
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




        public static Nullable<int> AddNewPerson(string NationalNO, string FirstName, string SecondName,
             string ThirdName, string LastName
          , DateTime DateOfBirth, int Gender, string Address,
           string Phone, string Email, int Nationality, string ImagePath)
        {
            Nullable<int> PersonID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    /*                    string query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName, LastName,DateOfBirth,Gender, Address,Phone,Email,NationalityCountryID,ImagePath)
                                                 VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName, @LastName,@DateOfBirth,@Gender,@Address,@Phone,@Email, @NationalityCountryID,@ImagePath);
                                                 SELECT SCOPE_IDENTITY();";*/

                    using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputIdParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.Parameters.AddWithValue("@NationalNo", NationalNO);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@NationalityCountryID", Nationality);

                        if (ThirdName != "")
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        else
                            command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


                        if (Email != "")
                            command.Parameters.AddWithValue("@Email", Email);
                        else
                            command.Parameters.AddWithValue("@Email", System.DBNull.Value);


                        if (ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                        connection.Open();

                        int result = command.ExecuteNonQuery();

                        if (result != 0 && int.TryParse(command.Parameters["@NewPersonID"].Value.ToString(), out int insertedID))
                        {
                            PersonID = insertedID;
                        }
                    }

                }


            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }



            return PersonID;
        }



        public static bool UpdatePerson(int PersonID, string NationalNO, string FirstName, string SecondName,
             string ThirdName, string LastName
          , DateTime DateOfBirth, int Gender, string Address,
           string Phone, string Email, int Nationality, string ImagePath)
        {
            int rowsAffected = 0;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {


                    /*string query = @"Update  People  
                            set NationalNO=@NationalNO,
                                FirstName = @FirstName, 
                                SecondName=@SecondName,
                                ThirdName=@ThirdName,
                                LastName = @LastName, 
                                DateOfBirth = @DateOfBirth,
                                Gender=@Gender,
                                Address = @Address,                                 
                                Phone = @Phone,                                
                                Email = @Email, 
                                NationalityCountryID = @Nationality,
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";*/


                    using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@NationalNo", NationalNO);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@NationalityCountryID", Nationality);

                        if (ThirdName != "")
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        else
                            command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


                        if (Email != "")
                            command.Parameters.AddWithValue("@Email", Email);
                        else
                            command.Parameters.AddWithValue("@Email", System.DBNull.Value);


                        if (ImagePath != "")
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
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

        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    /*string query = @"Delete People 
                                where PersonID = @PersonID";*/

                    using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool DeletePerson(string NationalNo)
        {

            int rowsAffected = 0;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {

                    /* string query = @"Delete People 
                                 where NationalNo = @NationalNo";*/

                    using (SqlCommand command = new SqlCommand("SP_DeletePersonByNationalNO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
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

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
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

        public static DataTable GetPeople()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString()))
                {
                    string query = "SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName," +
                        " People.ThirdName, People.LastName, People.DateOfBirth," +
                        " Gender=\r\ncase \r\nwhen People.Gender=0 then 'Male'\r\nwhen People.Gender=1 then 'Female' \r\nend\r\n," +
                        " People.Address,People.Phone, People.Email, Countries.CountryName, People.ImagePath\r\nFROM     People INNER JOIN\r\n" +
                        " Countries ON People.NationalityCountryID = Countries.CountryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
