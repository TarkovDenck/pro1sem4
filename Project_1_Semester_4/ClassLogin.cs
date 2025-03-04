using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System.Windows.Forms;
using System.Security.Cryptography;
using Project_1_Semester_4;


namespace Project_1_Semester_4
{
    internal class ClassLogin
    {
        public bool LoginUser(string username, string password)
        {
            bool isAuthenticated = false;

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    string query = "SELECT password_hash, role FROM users WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader.GetString(0);
                                string role = reader.GetString(1);
                                string inputHash = ComputeSHA256(password);

                                if (storedHash.Equals(inputHash, StringComparison.OrdinalIgnoreCase))
                                {
                                    isAuthenticated = true;
                                    Session.Username = username;
                                    Session.Role = role;
                                    LogLogin(username, "success");
                                }
                                else
                                {
                                    LogLogin(username, "failed");
                                }
                            }
                            else
                            {
                                LogLogin(username, "failed");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isAuthenticated;
        }





        public static string ComputeSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower(); 
            }
        }

        public void LogLogin(string username, string status)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null)
                {
                    Console.WriteLine("Failed to get database connection.");
                    return;
                }

                try
                {
                    string query = "INSERT INTO login_logs (username, status) VALUES (@username, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Logging Login: " + ex.Message);
                }
            }
        }

    }
}
