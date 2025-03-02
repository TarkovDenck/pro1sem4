using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_1_Semester_4
{
    internal class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;user id=root;password=;database=Inventory;port=3306";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open(); 
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Connection Error: " + ex.Message);
                return null;
            }
        }
    }
}
