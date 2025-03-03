using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_1_Semester_4
{
    internal class Session
    {
        public static string Username { get; set; } = null;
        public static string Role { get; set; } = null;

        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(Username);
        }

        public static void Logout()
        {
            if (!string.IsNullOrEmpty(Username))
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    try
                    {
                        string query = "INSERT INTO login_logs (username, status) VALUES (@username, 'logout')";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", Username);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error Logging Logout: " + ex.Message);
                    }
                }
            }

            Username = null;
            Role = null;
        }
    


    }
}
