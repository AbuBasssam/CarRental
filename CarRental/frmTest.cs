using CarRental_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRental
{
    public partial class frmTest : Form
    {
        public static List<clsUser> GetUsersPage(string FirstName)
        {

            List<clsUser> UserPage = new List<clsUser>();
            string connectionString = "Server=.;Database=MyCarRental;User Id=sa; Password=sa123456;";

            clsUser User;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string Query = "Select * From Users_View where FirstName LIKE + '' + @FirstName + '%'";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                User = new clsUser();
                                User.UserID = (int)reader["UserID"];
                               User.PersonID = (int)reader["PersonID"];
                               User.Salary = Convert.ToSingle(reader["Salary"]);
                                User. IsActive = (bool)reader["IsActive"];

                                // Person Info
                               User. NationalNo = (string)reader["NationalNO"];
                               User. FirstName = (string)reader["FirstName"];
                               User. SecondName = (string)reader["SecondName"];

                                //ThirdName: allows null in database so we should handle null
                                if (reader["ThirdName"] != DBNull.Value)
                                {
                                    User.ThirdName = (string)reader["ThirdName"];
                                }
                                else
                                {
                                    User.ThirdName = "";
                                }

                                User.LastName = (string)reader["LastName"];
                                User.DateOfBirth = (DateTime)reader["DateOfBirth"];
                                User.Gender = Convert.ToByte(reader["Gender"]);
                                User.Address = (string)reader["Address"];
                                User.Phone = (string)reader["Phone"];
                                User.NationalityCountryID = Convert.ToByte(reader["NationalityCountryID"]);

                                //Email: allows null in database so we should handle null
                                if (reader["Email"] != DBNull.Value)
                                {
                                   User. Email = (string)reader["Email"];
                                }
                                else
                                {
                                    User.Email = "";
                                }

                                //ImagePath: allows null in database so we should handle null
                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    User.ImagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    User.ImagePath = "";
                                }
                                UserPage.Add(User);
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
        List<clsUser> UsersID;
        public frmTest()
        {
            InitializeComponent();
        }
        public void LoadResults()
        {
            foreach(clsUser User in UsersID)
            {
                ctrlSearchBar Result = new ctrlSearchBar();
                Result.SearchResult(User);
                flowLayoutPanel1.Controls.Add(Result);
            }
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
            //List<clsUser> UsersID = GetUsersPage("A");

            /* Bitmap Image = new Bitmap(@"C:\Users\Hp\Desktop\Person1.png");

             guna2CirclePictureBox1.Load(@"C:\Users\Hp\Desktop\Person1.png");
             guna2CirclePictureBox2.Image = Image;
             guna2CirclePictureBox1.Image.Dispose();
             guna2CirclePictureBox2.Image.Dispose();

            File.Delete(@"C:\Users\Hp\Desktop\Person1.png");*/
            //clsWarranty.DeleteWarranty(1);
            //ctrlCarCard1.LoadCarInfo(26);
            //ctrlCarProfile1.LoadCarInfo(26);
            //  ctrlRegularMaintenanceTypeRecord1.LoadRegularMaintenanceTypeInfo(1,3);
            //   ctrlRegularMaintenanceSchedule1.LoadScheduleInfo(1);
            /*clsRenralTransaction frm = new clsRenralTransaction();
            frm.BookingID = 11;
            frm.PaymentDetails = "";
            frm.PaidIntialTotalDueAmount = (float)726.45;
            frm.TransactionDate = DateTime.Now;
            if (frm.Save())
            {
                MessageBox.Show($"Transaction Saved Successfully with Amount{frm.PaidIntialTotalDueAmount}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/
        }

        

        private void txtSearchResult_TextChanged(object sender, EventArgs e)
        {
           /* if (txtSearchResult.TextLength >= 1)
            {
                flowLayoutPanel1.Controls.Clear();
                //ctrlSearchBar  result = new ctrlSearchBar();
               UsersID = GetUsersPage(txtSearchResult.Text);
                LoadResults();
                flowLayoutPanel1.Height = flowLayoutPanel1.Controls.Count * 50;
            }
            else
            {
                flowLayoutPanel1.Height = 0;
            }*/
        }

        
    }
    
}
