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
    public partial class Form_HistorySupplier : Form
    {
        public Form_HistorySupplier()
        {
            InitializeComponent();
        }

        private void btSupControl_HSu_Click(object sender, EventArgs e)
        {
            Form_SupplierControl Form_SupplierControlLink = new Form_SupplierControl();
            Form_SupplierControlLink.Show();
            this.Hide();
        }

        private void btStoControl_HSu_Click(object sender, EventArgs e)
        {
            Form_StockControl form_StockControlLink = new Form_StockControl();
            form_StockControlLink.Show();
            this.Hide();
        }

        private void btStoUpdate_HSu_Click(object sender, EventArgs e)
        {
            Form_StockUpdate form_StockUpdateLink = new Form_StockUpdate();
            form_StockUpdateLink.Show();
            this.Hide();
        }

        private void bt_HistoryStocks_HSu_Click(object sender, EventArgs e)
        {
            Form_HistoryStock form_HistoryStockLink = new Form_HistoryStock();
            form_HistoryStockLink.Show();
            this.Hide();
        }

        private void btAdmAdd_HSu_Click(object sender, EventArgs e)
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

        private void btAdmLog_HSu_Click(object sender, EventArgs e)
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

        private void bt_Logout_HSu_Click(object sender, EventArgs e)
        {
            Session.Logout();

            MessageBox.Show("Anda telah logout!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form_Login loginForm = new Form_Login();
            loginForm.Show();

            this.Close();
        }

        private void bt_Mainmenu_HSu_Click(object sender, EventArgs e)
        {
            Form_MainMenu form_Form_MainMenuLink = new Form_MainMenu();
            form_Form_MainMenuLink.Show();
            this.Hide();
        }
    }
}
