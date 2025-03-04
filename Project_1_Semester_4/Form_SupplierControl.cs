using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

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
            LoadDatasuppllier();
            Formcb_Load();
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

        void LoadDatasuppllier()
        {
            ClassSupplierCon emp = new ClassSupplierCon();
            DataTable dt = emp.Read();
            dgSupplier.DataSource = dt;

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
            string name = tx_SupName.Text.Trim();
            string description = tx_SupDes.Text.Trim();
            string address = tx_SupAddress.Text.Trim();
            string category = cb_Category.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil username asli dari session
            string username = Session.Username;

            ClassSupplierCon supplierCon = new ClassSupplierCon();
            string result = supplierCon.InsertSupplier(name, description, address, category, username);

            if (result == "success")
            {
                MessageBox.Show("Supplier berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDatasuppllier(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tx_SupName.Text = "";
            tx_SupDes.Text = "";
            tx_SupAddress.Text = "";
            cb_Category.SelectedIndex = -1; 
        }

        private void Formcb_Load()
        {
            cb_Category.Items.Clear(); // Kosongkan ComboBox sebelum mengisi ulang

            ClassSupplierCon supplierCon = new ClassSupplierCon();
            List<string> categories = supplierCon.GetCategories();

            if (categories.Count > 0)
            {
                cb_Category.Items.AddRange(categories.ToArray());
            }
            else
            {
                MessageBox.Show("Tidak ada kategori yang ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_SupDelete_Click(object sender, EventArgs e)
        {
            if (dgSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih supplier yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil ID Supplier dari DataGridView
            int supplierId = Convert.ToInt32(dgSupplier.SelectedRows[0].Cells["id"].Value);

            // Konfirmasi penghapusan
            DialogResult dialogResult = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus supplier ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Ambil username asli dari session
            string username = Session.Username;

            // Panggil fungsi delete dari ClassSupplierCon
            ClassSupplierCon supplierCon = new ClassSupplierCon();
            string result = supplierCon.DeleteSupplier(supplierId, username);

            if (result == "success")
            {
                MessageBox.Show("Supplier berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatasuppllier(); // Refresh DataGridView setelah penghapusan
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_SupCari_Click(object sender, EventArgs e)
        {
            string name = tx_SupName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Harap masukkan nama supplier yang ingin dicari!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClassSupplierCon supplierCon = new ClassSupplierCon();
            DataTable dt = supplierCon.SearchSupplier(name);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgSupplier.DataSource = dt;

                // Pastikan header kolom sesuai alias
                dgSupplier.Columns["supplier_name"].HeaderText = "Nama Supplier";
                dgSupplier.Columns["description"].HeaderText = "Deskripsi";
                dgSupplier.Columns["address"].HeaderText = "Alamat";
                dgSupplier.Columns["category"].HeaderText = "Kategori";
            }
            else
            {
                MessageBox.Show("Supplier tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
