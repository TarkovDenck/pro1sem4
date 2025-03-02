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
    }
}
