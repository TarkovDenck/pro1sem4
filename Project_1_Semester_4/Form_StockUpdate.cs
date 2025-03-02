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
    public partial class Form_StockUpdate : Form
    {
        public Form_StockUpdate()
        {
            InitializeComponent();
        }

        private void btSupControl_Click(object sender, EventArgs e)
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

        private void btStoUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Form_Login Form_LoginLink = new Form_Login();
            Form_LoginLink.Show();
            this.Hide();
        }

        private void bt_Mainmenu_Click(object sender, EventArgs e)
        {
            Form_MainMenu Form_Form_MainMenuLink = new Form_MainMenu();
            Form_Form_MainMenuLink.Show();
            this.Hide();
        }

        private void btStoDataUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Form_StockUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btAdmAdd_Click(object sender, EventArgs e)
        {
            Form_AddAdmin form_AddAdminLink = new Form_AddAdmin();
            form_AddAdminLink.Show();
            this.Hide();
        }

        private void btAdmLog_Click(object sender, EventArgs e)
        {
            Form_HistoryLogin form_HistoryLoginLink = new Form_HistoryLogin();
            form_HistoryLoginLink.Show();
            this.Hide();
        }
    }
}
