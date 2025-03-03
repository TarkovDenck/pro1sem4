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
        public string InsertSupplier(string name, string description, string address, string category)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null) return "Gagal terhubung ke database.";

                try
                {
                    // Ambil ID kategori berdasarkan nama kategori
                    string getCategoryIdQuery = "SELECT id FROM categories WHERE name = @categoryName";
                    MySqlCommand getCategoryCmd = new MySqlCommand(getCategoryIdQuery, conn);
                    getCategoryCmd.Parameters.AddWithValue("@categoryName", category);
                    object categoryId = getCategoryCmd.ExecuteScalar();

                    if (categoryId == null)
                    {
                        return "Kategori tidak ditemukan.";
                    }

                    // Masukkan supplier dengan category_id dari tabel categories
                    string query = "INSERT INTO suppliers (name, description, address, category_id) VALUES (@name, @description, @address, @categoryId)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0) ? "success" : "Gagal menambahkan supplier.";
                }
                catch (MySqlException ex)
                {
                    return "Database Error: " + ex.Message;
                }
            }
        }



        // Method untuk menghapus supplier berdasarkan ID
        public string DeleteSupplier(int supplierId)
        {
            string query = "DELETE FROM suppliers WHERE id = @id";

            using (MySqlConnection conn = Connection.GetConnection())
            {
                if (conn == null)
                {
                    return "Database connection failed!";
                }

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", supplierId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            return "success";
                        else
                            return "Supplier tidak ditemukan.";
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
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



    }
}
