using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_BusinessLayer
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Car Rental USER LOGIN";


                if (Username == "")
                {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                        {
                            if (key != null)
                            {
                                // Delete the specified value
                                key.DeleteValue("UserName");
                                key.DeleteValue("Password");



                            }

                        }

                    }

                    // concatonate username and passwrod withe seperator.


                    // Write the value to the Registry


                }
                Registry.SetValue(keyPath, "UserName", Username, RegistryValueKind.String);
                Registry.SetValue(keyPath, "Password", Password, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {


                // Path for the file that contains the credential.
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Car Rental USER LOGIN";

                // Check if the file exists before attempting to read it


                Username = Registry.GetValue(keyPath, "UserName", null) as string;

                Password = Registry.GetValue(keyPath, "Password", null) as string;

                if (Username != "" && Password != "")
                {

                    return true;
                }


                return false;

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

    }
}
