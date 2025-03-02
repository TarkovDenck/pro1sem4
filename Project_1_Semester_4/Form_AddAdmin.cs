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
    }
}
