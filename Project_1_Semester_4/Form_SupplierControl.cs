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
            Combo_Box_Item_add();
        }

        private void Combo_Box_Item_add()
        {
            cb_Category.Items.Add("Placeholder1");
            cb_Category.Items.Add("Placeholder2");
            cb_Category.Items.Add("Placeholder3");
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

        }

        private void bt_SupDelete_Click(object sender, EventArgs e)
        {

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
    }
}
