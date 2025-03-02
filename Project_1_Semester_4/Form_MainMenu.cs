using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_1_Semester_4
{
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();


        }
        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn())
            {
                MessageBox.Show("Anda harus login terlebih dahulu!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void bt_SupControl_Click(object sender, EventArgs e)
        {
            Form_SupplierControl Form_SupplierControlLink = new Form_SupplierControl();
            Form_SupplierControlLink.Show();
            this.Hide();
        }

        private void btStoControl_Click(object sender, EventArgs e)
        {
            Form_StockControl form_StockControlLink = new Form_StockControl();
            form_StockControlLink.Show();
            this.Hide();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Session.Logout(); 

            MessageBox.Show("Anda telah logout!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form_Login loginForm = new Form_Login();
            loginForm.Show();

            this.Close(); 
        }

        private void btStoUpdate_Click(object sender, EventArgs e)
        {
            Form_StockUpdate form_StockUpdateLink = new Form_StockUpdate();
            form_StockUpdateLink.Show();
            this.Hide();
        }
    }
}
