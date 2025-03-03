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
            Form_AddAdmin form_AddAdminLink = new Form_AddAdmin();
            form_AddAdminLink.Show();
            this.Hide();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Form_Login form_LoginLink = new Form_Login();
            form_LoginLink.Show();
            this.Hide();
        }

        private void bt_Mainmenu_Click(object sender, EventArgs e)
        {
            Form_MainMenu form_Form_MainMenuLink = new Form_MainMenu();
            form_Form_MainMenuLink.Show();
            this.Hide();
        }

        private void bt_AdmSearch_Click(object sender, EventArgs e)
        {
            //// Validasi input minimal satu filter harus terisi
            //if (string.IsNullOrWhiteSpace(tx_AdmUsername.Text) && cb_AdmStatus.SelectedIndex == -1 && !dt_AdmLog.Checked)
            //{
            //    MessageBox.Show("Silakan masukkan setidaknya satu parameter pencarian!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //string username = tx_AdmUsername.Text.Trim();
            //string status = cb_AdmStatus.SelectedIndex != -1 ? cb_AdmStatus.SelectedItem.ToString() : "";
            //string login_time = dt_AdmLog.Checked ? dt_AdmLog.Value.ToString("yyyy-MM-dd") : "";

            //ClassHLogin classHLogin = new ClassHLogin();

            //// Ambil hasil pencarian dari database
            //List<Dictionary<string, string>> hasil = classHLogin.CariLoginLogs(username, login_time, status);

            //// Debugging: Cek apakah ada data yang ditemukan
            //Console.WriteLine("Total Data Ditemukan: " + hasil.Count);
            //foreach (var log in hasil)
            //{
            //    Console.WriteLine($"Username: {log["username"]}, Status: {log["status"]}, Timestamp: {log["timestamp"]}");
            //}

            //if (hasil == null || hasil.Count == 0)
            //{
            //    MessageBox.Show("Tidak ada log ditemukan untuk pencarian ini!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dglogs.DataSource = null; // Hapus data sebelumnya
            //    return;
            //}

            //// Buat DataTable untuk menyimpan hasil
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Username", typeof(string));
            //dt.Columns.Add("Status", typeof(string));
            //dt.Columns.Add("Timestamp", typeof(string));

            //// Tambahkan hasil ke DataTable
            //foreach (var log in hasil)
            //{
            //    dt.Rows.Add(log["username"], log["status"], log["timestamp"]);
            //}

            //// Binding DataTable ke DataGridView
            //dglogs.DataSource = dt;
            //dglogs.Refresh();
        
        }

        private void cb_AdmStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
