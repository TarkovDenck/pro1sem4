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
    public partial class Form_AddAdmin : Form
    {
        public Form_AddAdmin()
        {
            InitializeComponent();

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

        private void btAdmLog_Click(object sender, EventArgs e)
        {
            Form_HistoryLogin form_HistoryLoginLink = new Form_HistoryLogin();
            form_HistoryLoginLink.Show();
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

        private void Form_AddAdmin_Load(object sender, EventArgs e)
        {
            LoadUserTable();
        }

        private void LoadUserTable()
        {
            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    if (conn != null)
                    {
                        string query = "SELECT * FROM users";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dgusers.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data pengguna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_AdmAddToDatabase_Click(object sender, EventArgs e)
        {
            string username = tx_AdmUsername.Text.Trim();
            string password = tx_AdmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClassAddAdmin addAdmin = new ClassAddAdmin();
                addAdmin.AddAdmin(username, password);
                MessageBox.Show("Admin berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                LoadUserTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_AdmUpdate_Click(object sender, EventArgs e)
        {
            if (dgusers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih pengguna yang ingin diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = tx_AdmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password baru tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedUserId = Convert.ToInt32(dgusers.SelectedRows[0].Cells["id"].Value);

                ClassAddAdmin updateAdmin = new ClassAddAdmin();
                updateAdmin.UpdatePassword(selectedUserId, newPassword);

                MessageBox.Show("Password berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh tabel setelah update
                LoadUserTable();

                // Kosongkan field password setelah update
                tx_AdmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_AdmDelete_Click(object sender, EventArgs e)
        {
            string username = tx_AdmUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Masukkan username yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus pengguna '{username}'?",
                                                   "Konfirmasi Hapus",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    ClassAddAdmin deleteAdmin = new ClassAddAdmin();
                    deleteAdmin.DeleteUserByUsername(username);

                    MessageBox.Show("Pengguna berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh tabel setelah penghapusan
                    LoadUserTable();

                    // Kosongkan field username setelah delete
                    tx_AdmUsername.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus pengguna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
