using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Project_1_Semester_4
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection.GetConnection();
            if (conn != null)
            {
                try
                {
                    
                    MessageBox.Show("Koneksi berhasil!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Koneksi GAGAL: " + ex.Message);
                }
                finally
                {
                    conn.Close(); // HARUS ditutup secara manual
                }
            }
            else
            {
                MessageBox.Show("Gagal mendapatkan koneksi");
            }

        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }
    }
}
