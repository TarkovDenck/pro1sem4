using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_1_Semester_4
{
    internal class ClassHLogin
    {

        public DataTable Read()
        {
            string query = "SELECT * FROM login_logs";

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

        public List<Dictionary<string, string>> CariLoginLogs(string username = "", string status = "")
        {
            List<Dictionary<string, string>> logs = new List<Dictionary<string, string>>();

            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    if (conn.State == ConnectionState.Closed) conn.Open(); // Cek sebelum Open()

                    StringBuilder queryBuilder = new StringBuilder("SELECT username, status, login_time FROM login_logs WHERE 1=1");
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;

                        if (!string.IsNullOrEmpty(username))
                        {
                            queryBuilder.Append(" AND username = @username");
                            cmd.Parameters.AddWithValue("@username", username.Trim());
                        }

                        if (!string.IsNullOrEmpty(status))
                        {
                            queryBuilder.Append(" AND status = @status");
                            cmd.Parameters.AddWithValue("@status", status.Trim());
                        }

                        queryBuilder.Append(" ORDER BY login_time DESC");
                        cmd.CommandText = queryBuilder.ToString();

                        Console.WriteLine("Query: " + queryBuilder.ToString()); // Debugging Query

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                logs.Add(new Dictionary<string, string>
                                {
                                    { "username", reader["username"].ToString() },
                                    { "status", reader["status"].ToString() },
                                    { "timestamp", reader["login_time"].ToString() }
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return logs;
        }


    }
}
