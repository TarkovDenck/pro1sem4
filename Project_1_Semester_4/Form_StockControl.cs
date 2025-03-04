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
    public partial class Form_StockControl : Form
    {
        public Form_StockControl()
        {
            InitializeComponent();
        }

        private void Form_StockControl_Load(object sender, EventArgs e)
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

        private void bt_Mainmenu_Click(object sender, EventArgs e)
        {
            Form_MainMenu Form_Form_MainMenuLink = new Form_MainMenu();
            Form_Form_MainMenuLink.Show();
            this.Hide();
        }

        private void bt_SupCari_Click(object sender, EventArgs e)
        {

        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Form_Login Form_LoginLink = new Form_Login();
            Form_LoginLink.Show();
            this.Hide();
        }

        private void btSupControl_Click(object sender, EventArgs e)
        {
            Form_SupplierControl Form_SupplierControlLink = new Form_SupplierControl();
            Form_SupplierControlLink.Show();
            this.Hide();
        }

        private void btStoUpdate_Click(object sender, EventArgs e)
        {
            Form_StockUpdate form_StockUpdateLink = new Form_StockUpdate();
            form_StockUpdateLink.Show();
            this.Hide();
        }

        private void btStoControl_Click(object sender, EventArgs e)
        {

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

        private void bt_HistoryStocks_Click(object sender, EventArgs e)
        {
            Form_HistoryStock form_HistoryStockLink = new Form_HistoryStock();
            form_HistoryStockLink.Show();
            this.Hide();
        }

        private void bt_History_Supplier_Click(object sender, EventArgs e)
        {
            Form_HistorySupplier form_HistorySupplierLink = new Form_HistorySupplier();
            form_HistorySupplierLink.Show();
            this.Hide();
        }
    }
}
