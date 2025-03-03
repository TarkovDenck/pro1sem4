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
    public partial class Form_SupplierControl : Form
    {
        public Form_SupplierControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_SupplierControl_Load(object sender, EventArgs e)
        {
            

            if (!Session.IsLoggedIn())
            {
                MessageBox.Show("Anda harus login terlebih dahulu!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            if (Session.Role != "superadmin")
            {
                btAdmAdd.Enabled = false;
                btAdmLog.Enabled = false;
            }
        }

       

        private void btSupControl_Click(object sender, EventArgs e)
        {

        }

        private void btStoControl_Click(object sender, EventArgs e)
        {
            Form_StockControl form_StockControlLink = new Form_StockControl();
            form_StockControlLink.Show();
            this.Hide();
        }

        private void btStoUpdate_Click(object sender, EventArgs e)
        {
            Form_StockUpdate form_StockUpdateLink = new Form_StockUpdate();
            form_StockUpdateLink.Show();
            this.Hide();
        }

        private void bt_Mainmenu_Click(object sender, EventArgs e)
        {
            Form_MainMenu Form_Form_MainMenuLink = new Form_MainMenu();
            Form_Form_MainMenuLink.Show();
            this.Hide();
        }

        private void btSupAdd_Click(object sender, EventArgs e)
        {

        }

        private void bt_SupDelete_Click(object sender, EventArgs e)
        {

        }

        private void bt_SupCari_Click(object sender, EventArgs e)
        {

        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Session.Logout();

            MessageBox.Show("Anda telah logout!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form_Login loginForm = new Form_Login();
            loginForm.Show();

            this.Close();
        }

        private void btAdmAdd_Click(object sender, EventArgs e)
        {
            if (Session.Role == "superadmin")
            {
                Form_AddAdmin form_AddAdminLink = new Form_AddAdmin();
                form_AddAdminLink.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda tidak memiliki izin untuk menambahkan admin!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAdmLog_Click(object sender, EventArgs e)
        {
            if (Session.Role == "superadmin")
            {
                Form_HistoryLogin form_HistoryLoginLink = new Form_HistoryLogin();
                form_HistoryLoginLink.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda tidak memiliki izin untuk melihat riwayat login!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAdmAdd_Click_1(object sender, EventArgs e)
        {
            if (Session.Role == "superadmin")
            {
                Form_AddAdmin form_AddAdminLink = new Form_AddAdmin();
                form_AddAdminLink.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda tidak memiliki izin untuk menambahkan admin!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAdmLog_Click_1(object sender, EventArgs e)
        {
            if (Session.Role == "superadmin")
            {
                Form_HistoryLogin form_HistoryLoginLink = new Form_HistoryLogin();
                form_HistoryLoginLink.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda tidak memiliki izin untuk melihat riwayat login!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
