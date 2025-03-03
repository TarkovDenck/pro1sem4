using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_1_Semester_4
{
    public partial class Form_HistoryLogin : Form
    {
        public Form_HistoryLogin()
        {
            InitializeComponent();
        }

        private void tx_AdmUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_HistoryLogin_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
            LoadDatauser();
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


        void LoadDatauser()
        {
            ClassHLogin emp = new ClassHLogin();
            DataTable dt = emp.Read();
            dglogs.DataSource = dt;

        }

        private void InitializeComboBox()
        {
            
            cb_AdmStatus.Items.Clear();
            cb_AdmStatus.Items.Add("success");
            cb_AdmStatus.Items.Add("failed");
            cb_AdmStatus.Items.Add("logout");
            cb_AdmStatus.SelectedIndex = -1; 
        }




        private void cb_AdmStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dt_AdmLog_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btSupControl_Click(object sender, EventArgs e)
        {
            Form_SupplierControl form_SupplierControlLink = new Form_SupplierControl();
            form_SupplierControlLink.Show();
            this.Hide();
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

        private void bt_AdmAdd(object sender, EventArgs e)
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

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Session.Logout();

            MessageBox.Show("Anda telah logout!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form_Login loginForm = new Form_Login();
            loginForm.Show();

            this.Close();
        }

        private void bt_Mainmenu_Click(object sender, EventArgs e)
        {
            Form_MainMenu form_Form_MainMenuLink = new Form_MainMenu();
            form_Form_MainMenuLink.Show();
            this.Hide();
        }

        private void bt_AdmSearch_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tx_AdmUsername.Text) && cb_AdmStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan masukkan setidaknya satu parameter pencarian!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = tx_AdmUsername.Text.Trim();
            string status = cb_AdmStatus.SelectedIndex != -1 ? cb_AdmStatus.SelectedItem.ToString() : "";

            ClassHLogin classHLogin = new ClassHLogin();

            
            List<Dictionary<string, string>> hasil = classHLogin.CariLoginLogs(username, status);

            // Debugging: Cek apakah ada data yang ditemukan
            Console.WriteLine("Total Data Ditemukan: " + hasil.Count);
            foreach (var log in hasil)
            {
                Console.WriteLine($"Username: {log["username"]}, Status: {log["status"]}, Timestamp: {log["timestamp"]}");
            }

            if (hasil == null || hasil.Count == 0)
            {
                MessageBox.Show("Tidak ada log ditemukan untuk pencarian ini!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dglogs.DataSource = null; // Hapus data sebelumnya
                return;
            }

            // Buat DataTable untuk menyimpan hasil
            DataTable dt = new DataTable();
            dt.Columns.Add("username", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("Timestamp", typeof(string));

            // Tambahkan hasil ke DataTable
            foreach (var log in hasil)
            {
                dt.Rows.Add(log["username"], log["status"], log["timestamp"]);
            }

            // Binding DataTable ke DataGridView
            dglogs.DataSource = dt;
            dglogs.Refresh();

        }

        private void cb_AdmStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
    }
}
