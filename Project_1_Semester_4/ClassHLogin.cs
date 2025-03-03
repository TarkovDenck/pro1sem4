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

        public List<Dictionary<string, string>> CariLoginLogs(string username = "", string tanggal = "", string status = "")
        {
            List<Dictionary<string, string>> logs = new List<Dictionary<string, string>>();

            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    // Gunakan StringBuilder untuk membangun query dinamis
                    StringBuilder queryBuilder = new StringBuilder("SELECT username, status, login_time FROM login_logs WHERE 1=1");

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;

                        // Debugging: Reset query sebelum menambahkan filter
                        Console.WriteLine("=== QUERY BEFORE FILTER ===");
                        Console.WriteLine(queryBuilder.ToString());

                        // Filter berdasarkan parameter input
                        if (!string.IsNullOrEmpty(username))
                        {
                            queryBuilder.Append(" AND username = @username");
                            cmd.Parameters.AddWithValue("@username", username.Trim());
                        }

                        if (!string.IsNullOrEmpty(tanggal))
                        {
                            if (DateTime.TryParse(tanggal, out DateTime parsedDate))
                            {
                                queryBuilder.Append(" AND login_time BETWEEN @tanggal_start AND @tanggal_end");
                                cmd.Parameters.AddWithValue("@tanggal_start", parsedDate.Date);
                                cmd.Parameters.AddWithValue("@tanggal_end", parsedDate.Date.AddDays(1).AddSeconds(-1));

                                Console.WriteLine($"Tanggal Start: {parsedDate.Date}");
                                Console.WriteLine($"Tanggal End: {parsedDate.Date.AddDays(1).AddSeconds(-1)}");
                            }
                            else
                            {
                                MessageBox.Show("Format tanggal tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return logs;
                            }
                        }

                        if (!string.IsNullOrEmpty(status))
                        {
                            queryBuilder.Append(" AND status = @status");
                            cmd.Parameters.AddWithValue("@status", status.Trim());
                        }

                        // Urutkan berdasarkan waktu terbaru
                        queryBuilder.Append(" ORDER BY login_time DESC");

                        // Set query ke command
                        cmd.CommandText = queryBuilder.ToString();
                        Console.WriteLine("=== FINAL QUERY ===");
                        Console.WriteLine(cmd.CommandText);

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
                Console.WriteLine("Error: " + ex.ToString());
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return logs;
        }


    }
}
