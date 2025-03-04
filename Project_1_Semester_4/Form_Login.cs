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
    public partial class Form_Login : Form
    {
        private ClassLogin loginHandler = new ClassLogin();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void txUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string username = txUsername.Text.Trim();
            string password = txPassword.Text.Trim();

            ClassLogin loginHandler = new ClassLogin(); // Pastikan hanya membuat satu instance

            if (loginHandler.LoginUser(username, password))
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_MainMenu mainMenu = new Form_MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
