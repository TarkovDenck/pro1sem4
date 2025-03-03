using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_1_Semester_4
{
    internal class ClassAddAdmin
    {
        public void AddAdmin(string username, string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            string query = "INSERT INTO users (username, password_hash, role) VALUES (@username, @password, 'admin')";

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void UpdatePassword(int id, string newPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
            string query = "UPDATE users SET password_hash = @password WHERE id = @id";

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void DeleteUserByUsername(string username)
        {
            string query = "DELETE FROM users WHERE username = @username";

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public DataTable Read()
        {
            string query = "SELECT * FROM users";

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null)
                {
                    Console.WriteLine("Database connection failed!");
                    return null;
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
