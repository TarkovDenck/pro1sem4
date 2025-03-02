namespace Project_1_Semester_4
{
    partial class Form_SupplierControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Mainmenu = new System.Windows.Forms.Button();
            this.btSupAdd = new System.Windows.Forms.Button();
            this.bt_SupCari = new System.Windows.Forms.Button();
            this.tx_SupName = new System.Windows.Forms.TextBox();
            this.tx_SupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSupplier = new System.Windows.Forms.DataGridView();
            this.tx_SupAddress = new System.Windows.Forms.TextBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.btStoControl = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btSupControl = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_SupDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btStoUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplier)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Mainmenu
            // 
            this.bt_Mainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bt_Mainmenu.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.bt_Mainmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_Mainmenu.Location = new System.Drawing.Point(1108, 701);
            this.bt_Mainmenu.Name = "bt_Mainmenu";
            this.bt_Mainmenu.Size = new System.Drawing.Size(148, 39);
            this.bt_Mainmenu.TabIndex = 35;
            this.bt_Mainmenu.Text = "Back";
            this.bt_Mainmenu.UseVisualStyleBackColor = false;
            this.bt_Mainmenu.Click += new System.EventHandler(this.bt_Mainmenu_Click);
            // 
            // btSupAdd
            // 
            this.btSupAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btSupAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btSupAdd.Location = new System.Drawing.Point(256, 632);
            this.btSupAdd.Name = "btSupAdd";
            this.btSupAdd.Size = new System.Drawing.Size(353, 41);
            this.btSupAdd.TabIndex = 34;
            this.btSupAdd.Text = "Add";
            this.btSupAdd.UseVisualStyleBackColor = false;
            this.btSupAdd.Click += new System.EventHandler(this.btSupAdd_Click);
            // 
            // bt_SupCari
            // 
            this.bt_SupCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.bt_SupCari.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SupCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_SupCari.Location = new System.Drawing.Point(595, 150);
            this.bt_SupCari.Name = "bt_SupCari";
            this.bt_SupCari.Size = new System.Drawing.Size(75, 26);
            this.bt_SupCari.TabIndex = 25;
            this.bt_SupCari.Text = "Cari";
            this.bt_SupCari.UseVisualStyleBackColor = false;
            this.bt_SupCari.Click += new System.EventHandler(this.bt_SupCari_Click);
            // 
            // tx_SupName
            // 
            this.tx_SupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            this.tx_SupName.Location = new System.Drawing.Point(229, 239);
            this.tx_SupName.Name = "tx_SupName";
            this.tx_SupName.Size = new System.Drawing.Size(441, 21);
            this.tx_SupName.TabIndex = 24;
            // 
            // tx_SupID
            // 
            this.tx_SupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            this.tx_SupID.Location = new System.Drawing.Point(229, 152);
            this.tx_SupID.Name = "tx_SupID";
            this.tx_SupID.Size = new System.Drawing.Size(354, 21);
            this.tx_SupID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Supplier ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 54);
            this.label2.TabIndex = 20;
            this.label2.Text = "SUPPLIER CONTROL";
            // 
            // dgSupplier
            // 
            this.dgSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplier.Location = new System.Drawing.Point(692, 82);
            this.dgSupplier.Name = "dgSupplier";
            this.dgSupplier.RowHeadersWidth = 51;
            this.dgSupplier.RowTemplate.Height = 24;
            this.dgSupplier.Size = new System.Drawing.Size(564, 600);
            this.dgSupplier.TabIndex = 18;
            // 
            // tx_SupAddress
            // 
            this.tx_SupAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            this.tx_SupAddress.Location = new System.Drawing.Point(229, 320);
            this.tx_SupAddress.Name = "tx_SupAddress";
            this.tx_SupAddress.Size = new System.Drawing.Size(441, 21);
            this.tx_SupAddress.TabIndex = 36;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(229, 405);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(209, 24);
            this.cb_Category.TabIndex = 37;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dASHBOARDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(206, 752);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dASHBOARDToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(193, 42);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logout.Location = new System.Drawing.Point(12, 714);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(68, 26);
            this.bt_Logout.TabIndex = 48;
            this.bt_Logout.Text = "Logout";
            this.bt_Logout.UseVisualStyleBackColor = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // btStoControl
            // 
            this.btStoControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btStoControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStoControl.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStoControl.Location = new System.Drawing.Point(12, 301);
            this.btStoControl.Name = "btStoControl";
            this.btStoControl.Size = new System.Drawing.Size(176, 39);
            this.btStoControl.TabIndex = 49;
            this.btStoControl.Text = "Stocks Control";
            this.btStoControl.UseVisualStyleBackColor = false;
            this.btStoControl.Click += new System.EventHandler(this.btStoControl_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(12, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "Stocks Management:";
            // 
            // btSupControl
            // 
            this.btSupControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btSupControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSupControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupControl.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupControl.Location = new System.Drawing.Point(15, 134);
            this.btSupControl.Name = "btSupControl";
            this.btSupControl.Size = new System.Drawing.Size(179, 39);
            this.btSupControl.TabIndex = 51;
            this.btSupControl.Text = "Supplier Control";
            this.btSupControl.UseVisualStyleBackColor = false;
            this.btSupControl.Click += new System.EventHandler(this.btSupControl_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(12, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "Supplier Management:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(19, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "--------------------------------";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(15, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Warehouse Management";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(226, 676);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "--";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_SupDelete
            // 
            this.bt_SupDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bt_SupDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.bt_SupDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_SupDelete.Location = new System.Drawing.Point(256, 695);
            this.bt_SupDelete.Name = "bt_SupDelete";
            this.bt_SupDelete.Size = new System.Drawing.Size(353, 41);
            this.bt_SupDelete.TabIndex = 57;
            this.bt_SupDelete.Text = "Delete";
            this.bt_SupDelete.UseVisualStyleBackColor = false;
            this.bt_SupDelete.Click += new System.EventHandler(this.bt_SupDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 58;
            this.label4.Text = "Supplier Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 59;
            this.label5.Text = "Supplier Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 60;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1117, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 61;
            this.label7.Text = "Supplier Data:";
            // 
            // btStoUpdate
            // 
            this.btStoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btStoUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStoUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStoUpdate.Location = new System.Drawing.Point(12, 363);
            this.btStoUpdate.Name = "btStoUpdate";
            this.btStoUpdate.Size = new System.Drawing.Size(176, 39);
            this.btStoUpdate.TabIndex = 62;
            this.btStoUpdate.Text = "Stocks Update";
            this.btStoUpdate.UseVisualStyleBackColor = false;
            this.btStoUpdate.Click += new System.EventHandler(this.btStoUpdate_Click);
            // 
            // Form_SupplierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_1_Semester_4.Properties.Resources.hetchbawah2;
            this.ClientSize = new System.Drawing.Size(1283, 752);
            this.Controls.Add(this.btStoUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_SupDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btSupControl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btStoControl);
            this.Controls.Add(this.bt_Logout);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.tx_SupAddress);
            this.Controls.Add(this.bt_Mainmenu);
            this.Controls.Add(this.btSupAdd);
            this.Controls.Add(this.bt_SupCari);
            this.Controls.Add(this.tx_SupName);
            this.Controls.Add(this.tx_SupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgSupplier);
            this.Name = "Form_SupplierControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SupplierControl";
            this.Load += new System.EventHandler(this.Form_SupplierControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplier)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Mainmenu;
        private System.Windows.Forms.Button btSupAdd;
        private System.Windows.Forms.Button bt_SupCari;
        private System.Windows.Forms.TextBox tx_SupName;
        private System.Windows.Forms.TextBox tx_SupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgSupplier;
        private System.Windows.Forms.TextBox tx_SupAddress;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Button btStoControl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btSupControl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_SupDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btStoUpdate;
    }
}