using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace Project_1_Semester_4
{
    internal class ClassSupplierCon
    {
        // Method untuk menambahkan supplier
        public string InsertSupplier(string name, string description, string address, string category, string username)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null) return "Gagal terhubung ke database.";

                try
                {
                    string getCategoryIdQuery = "SELECT id FROM categories WHERE name = @categoryName";
                    MySqlCommand getCategoryCmd = new MySqlCommand(getCategoryIdQuery, conn);
                    getCategoryCmd.Parameters.AddWithValue("@categoryName", category);
                    object categoryId = getCategoryCmd.ExecuteScalar();

                    if (categoryId == null)
                    {
                        return "Kategori tidak ditemukan.";
                    }

                    // Insert ke suppliers
                    string query = "INSERT INTO suppliers (name, description, address, category_id) VALUES (@name, @description, @address, @categoryId)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.ExecuteNonQuery();

                    // Dapatkan ID supplier yang baru saja dimasukkan
                    long supplierId = cmd.LastInsertedId;

                    // Insert ke history_suppliers
                    string historyQuery = "INSERT INTO history_suppliers (supplier_id, name, description, address, category_id, username, action_type) " +
                                          "VALUES (@supplierId, @name, @description, @address, @categoryId, @username, 'INSERT')";
                    MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn);
                    historyCmd.Parameters.AddWithValue("@supplierId", supplierId);
                    historyCmd.Parameters.AddWithValue("@name", name);
                    historyCmd.Parameters.AddWithValue("@description", description);
                    historyCmd.Parameters.AddWithValue("@address", address);
                    historyCmd.Parameters.AddWithValue("@categoryId", categoryId);
                    historyCmd.Parameters.AddWithValue("@username", username); 
                    historyCmd.ExecuteNonQuery();

                    return "success";
                }
                catch (MySqlException ex)
                {
                    return "Database Error: " + ex.Message;
                }
            }
        }





        // Method untuk menghapus supplier berdasarkan ID
        public string DeleteSupplier(int supplierId, string username)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null) return "Gagal terhubung ke database.";

                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    // Gunakan transaksi agar query dieksekusi bersama-sama
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Ambil informasi supplier sebelum dihapus
                            string selectQuery = "SELECT name, description, address, category_id FROM suppliers WHERE id = @supplierId";
                            MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn, transaction);
                            selectCmd.Parameters.AddWithValue("@supplierId", supplierId);

                            string name = "", description = "", address = "";
                            int categoryId = 0;

                            using (MySqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    return "Supplier tidak ditemukan.";
                                }

                                name = reader.GetString(0);
                                description = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                address = reader.GetString(2);
                                categoryId = reader.GetInt32(3);
                            }

                            // Simpan history DELETE sebelum supplier dihapus
                            string historyQuery = "INSERT INTO history_suppliers (supplier_id, name, description, address, category_id, username, action_type) " +
                                                  "VALUES (@supplierId, @name, @description, @address, @categoryId, @username, 'DELETE')";
                            MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn, transaction);
                            historyCmd.Parameters.AddWithValue("@supplierId", supplierId);
                            historyCmd.Parameters.AddWithValue("@name", name);
                            historyCmd.Parameters.AddWithValue("@description", description);
                            historyCmd.Parameters.AddWithValue("@address", address);
                            historyCmd.Parameters.AddWithValue("@categoryId", categoryId);
                            historyCmd.Parameters.AddWithValue("@username", username);
                            historyCmd.ExecuteNonQuery();

                            // Hapus supplier setelah history DELETE tersimpan
                            string deleteQuery = "DELETE FROM suppliers WHERE id = @supplierId";
                            MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn, transaction);
                            deleteCmd.Parameters.AddWithValue("@supplierId", supplierId);
                            int rowsAffected = deleteCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit(); // Simpan semua perubahan jika sukses
                                return "success";
                            }
                            else
                            {
                                transaction.Rollback(); // Batalkan jika gagal hapus supplier
                                return "Gagal menghapus supplier.";
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Batalkan transaksi jika ada error
                            return "Database Error: " + ex.Message;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    return "Database Error: " + ex.Message;
                }
            }
        }









        public DataTable Read()
        {
            string query = @"
            SELECT s.id, s.name, s.description, s.address, c.name AS category
            FROM suppliers s
            JOIN categories c ON s.category_id = c.id";

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


        public DataTable SearchSupplier(string name)
        {
            string query = @"
            SELECT 
                s.id AS supplier_id, 
                s.name AS supplier_name, 
                s.description, 
                s.address, 
                c.name AS category 
            FROM suppliers s
            LEFT JOIN categories c ON s.category_id = c.id
            WHERE s.name LIKE @name";

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null)
                {
                    Console.WriteLine("Database connection failed!");
                    return null;
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null) return categories;

                string query = "SELECT name FROM categories";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader["name"].ToString());
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return categories;
        }

        private void InsertHistory(int supplierId, string name, string description, string address, int categoryId, string username, string actionType)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    string hashedUsername = ClassLogin.ComputeSHA256(username); // Hash username

                    string query = @"INSERT INTO history_suppliers (supplier_id, name, description, address, category_id, username, action_type) 
                             VALUES (@supplierId, @name, @description, @address, @categoryId, @username, @actionType)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Parameters.AddWithValue("@username", hashedUsername);
                    cmd.Parameters.AddWithValue("@actionType", actionType);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error Logging History: " + ex.Message);
                }
            }
        }




    }
}
