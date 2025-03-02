using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            ComboBoxAdd();
        }

        private void ComboBoxAdd()
        {
            Dictionary<string, string> content = new Dictionary<string, string>();
            content.Add("Success", "Success");
            content.Add("Failed", "Failed");
            content.Add("Logout", "Logout");
            cb_AdmStatus.DataSource = new BindingSource(content, null);
            cb_AdmStatus.DisplayMember = "Value";
            cb_AdmStatus.ValueMember = "Key";
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
    }
}
