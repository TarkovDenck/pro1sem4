﻿namespace Project_1_Semester_4
{
    partial class Form_StockControl
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
            this.btStoUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_StoDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btSupControl = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btStoControl = new System.Windows.Forms.Button();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.tx_StoPrice = new System.Windows.Forms.TextBox();
            this.bt_Mainmenu = new System.Windows.Forms.Button();
            this.btStoAdd = new System.Windows.Forms.Button();
            this.bt_SupCari = new System.Windows.Forms.Button();
            this.tx_StoName = new System.Windows.Forms.TextBox();
            this.tx_SupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgStocks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_StoDesc = new System.Windows.Forms.TextBox();
            this.nu_StoAmount = new System.Windows.Forms.NumericUpDown();
            this.btAdmAdd = new System.Windows.Forms.Button();
            this.btAdmLog = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_StoAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btStoUpdate
            // 
            this.btStoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btStoUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStoUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStoUpdate.Location = new System.Drawing.Point(12, 364);
            this.btStoUpdate.Name = "btStoUpdate";
            this.btStoUpdate.Size = new System.Drawing.Size(176, 39);
            this.btStoUpdate.TabIndex = 87;
            this.btStoUpdate.Text = "Stocks Update";
            this.btStoUpdate.UseVisualStyleBackColor = false;
            this.btStoUpdate.Click += new System.EventHandler(this.btStoUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1147, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 86;
            this.label7.Text = "Stocks Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 85;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 28);
            this.label5.TabIndex = 84;
            this.label5.Text = "Stock Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 83;
            this.label4.Text = "Stock Name";
            // 
            // bt_StoDelete
            // 
            this.bt_StoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bt_StoDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.bt_StoDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_StoDelete.Location = new System.Drawing.Point(269, 679);
            this.bt_StoDelete.Name = "bt_StoDelete";
            this.bt_StoDelete.Size = new System.Drawing.Size(353, 41);
            this.bt_StoDelete.TabIndex = 82;
            this.bt_StoDelete.Text = "Delete";
            this.bt_StoDelete.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(237, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 16);
            this.label8.TabIndex = 81;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "--";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(19, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 16);
            this.label13.TabIndex = 80;
            this.label13.Text = "--------------------------------";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(15, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 16);
            this.label14.TabIndex = 79;
            this.label14.Text = "Warehouse Management";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(12, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Supplier Management:";
            // 
            // btSupControl
            // 
            this.btSupControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btSupControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSupControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupControl.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupControl.Location = new System.Drawing.Point(15, 135);
            this.btSupControl.Name = "btSupControl";
            this.btSupControl.Size = new System.Drawing.Size(179, 39);
            this.btSupControl.TabIndex = 77;
            this.btSupControl.Text = "Supplier Control";
            this.btSupControl.UseVisualStyleBackColor = false;
            this.btSupControl.Click += new System.EventHandler(this.btSupControl_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(12, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 16);
            this.label11.TabIndex = 76;
            this.label11.Text = "Stocks Management:";
            // 
            // btStoControl
            // 
            this.btStoControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btStoControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStoControl.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStoControl.Location = new System.Drawing.Point(12, 302);
            this.btStoControl.Name = "btStoControl";
            this.btStoControl.Size = new System.Drawing.Size(176, 39);
            this.btStoControl.TabIndex = 75;
            this.btStoControl.Text = "Stocks Control";
            this.btStoControl.UseVisualStyleBackColor = false;
            this.btStoControl.Click += new System.EventHandler(this.btStoControl_Click);
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logout.Location = new System.Drawing.Point(12, 715);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(68, 26);
            this.bt_Logout.TabIndex = 74;
            this.bt_Logout.Text = "Logout";
            this.bt_Logout.UseVisualStyleBackColor = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
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
            this.menuStrip1.TabIndex = 73;
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
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(242, 364);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(209, 24);
            this.cb_Category.TabIndex = 72;
            // 
            // tx_StoPrice
            // 
            this.tx_StoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            this.tx_StoPrice.Location = new System.Drawing.Point(242, 293);
            this.tx_StoPrice.Name = "tx_StoPrice";
            this.tx_StoPrice.Size = new System.Drawing.Size(441, 21);
            this.tx_StoPrice.TabIndex = 71;
            // 
            // bt_Mainmenu
            // 
            this.bt_Mainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bt_Mainmenu.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.bt_Mainmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_Mainmenu.Location = new System.Drawing.Point(1121, 701);
            this.bt_Mainmenu.Name = "bt_Mainmenu";
            this.bt_Mainmenu.Size = new System.Drawing.Size(148, 39);
            this.bt_Mainmenu.TabIndex = 70;
            this.bt_Mainmenu.Text = "Back";
            this.bt_Mainmenu.UseVisualStyleBackColor = false;
            this.bt_Mainmenu.Click += new System.EventHandler(this.bt_Mainmenu_Click);
            // 
            // btStoAdd
            // 
            this.btStoAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btStoAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btStoAdd.Location = new System.Drawing.Point(269, 616);
            this.btStoAdd.Name = "btStoAdd";
            this.btStoAdd.Size = new System.Drawing.Size(353, 41);
            this.btStoAdd.TabIndex = 69;
            this.btStoAdd.Text = "Add";
            this.btStoAdd.UseVisualStyleBackColor = false;
            // 
            // bt_SupCari
            // 
            this.bt_SupCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.bt_SupCari.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SupCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.bt_SupCari.Location = new System.Drawing.Point(608, 150);
            this.bt_SupCari.Name = "bt_SupCari";
            this.bt_SupCari.Size = new System.Drawing.Size(75, 26);
            this.bt_SupCari.TabIndex = 68;
            this.bt_SupCari.Text = "Cari";
            this.bt_SupCari.UseVisualStyleBackColor = false;
            this.bt_SupCari.Click += new System.EventHandler(this.bt_SupCari_Click);
            // 
            // tx_StoName
            // 
            this.tx_StoName.BackColor = System.Drawing.Color.White;
            this.tx_StoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            this.tx_StoName.Location = new System.Drawing.Point(242, 228);
            this.tx_StoName.Name = "tx_StoName";
            this.tx_StoName.Size = new System.Drawing.Size(441, 21);
            this.tx_StoName.TabIndex = 67;
            // 
            // tx_SupID
            // 
            this.tx_SupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            this.tx_SupID.Location = new System.Drawing.Point(242, 152);
            this.tx_SupID.Name = "tx_SupID";
            this.tx_SupID.Size = new System.Drawing.Size(354, 21);
            this.tx_SupID.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 65;
            this.label3.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 54);
            this.label2.TabIndex = 64;
            this.label2.Text = "STOCK CONTROL";
            // 
            // dgStocks
            // 
            this.dgStocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStocks.Location = new System.Drawing.Point(705, 68);
            this.dgStocks.Name = "dgStocks";
            this.dgStocks.RowHeadersWidth = 51;
            this.dgStocks.RowTemplate.Height = 24;
            this.dgStocks.Size = new System.Drawing.Size(564, 600);
            this.dgStocks.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 89;
            this.label1.Text = "Stock Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 28);
            this.label9.TabIndex = 90;
            this.label9.Text = "Description";
            // 
            // tx_StoDesc
            // 
            this.tx_StoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.12F);
            this.tx_StoDesc.Location = new System.Drawing.Point(242, 502);
            this.tx_StoDesc.Multiline = true;
            this.tx_StoDesc.Name = "tx_StoDesc";
            this.tx_StoDesc.Size = new System.Drawing.Size(441, 88);
            this.tx_StoDesc.TabIndex = 91;
            // 
            // nu_StoAmount
            // 
            this.nu_StoAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_StoAmount.Location = new System.Drawing.Point(242, 431);
            this.nu_StoAmount.Name = "nu_StoAmount";
            this.nu_StoAmount.Size = new System.Drawing.Size(441, 30);
            this.nu_StoAmount.TabIndex = 92;
            // 
            // btAdmAdd
            // 
            this.btAdmAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btAdmAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdmAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmAdd.Location = new System.Drawing.Point(12, 502);
            this.btAdmAdd.Name = "btAdmAdd";
            this.btAdmAdd.Size = new System.Drawing.Size(176, 39);
            this.btAdmAdd.TabIndex = 95;
            this.btAdmAdd.Text = "Add Admin";
            this.btAdmAdd.UseVisualStyleBackColor = false;
            this.btAdmAdd.Click += new System.EventHandler(this.btAdmAdd_Click);
            // 
            // btAdmLog
            // 
            this.btAdmLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.btAdmLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdmLog.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmLog.Location = new System.Drawing.Point(12, 551);
            this.btAdmLog.Name = "btAdmLog";
            this.btAdmLog.Size = new System.Drawing.Size(176, 39);
            this.btAdmLog.TabIndex = 94;
            this.btAdmLog.Text = "Login History";
            this.btAdmLog.UseVisualStyleBackColor = false;
            this.btAdmLog.Click += new System.EventHandler(this.btAdmLog_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(12, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 93;
            this.label10.Text = "Admin Management:";
            // 
            // Form_StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_1_Semester_4.Properties.Resources.hetchbawah2;
            this.ClientSize = new System.Drawing.Size(1283, 752);
            this.Controls.Add(this.btAdmAdd);
            this.Controls.Add(this.btAdmLog);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nu_StoAmount);
            this.Controls.Add(this.tx_StoDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStoUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_StoDelete);
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
            this.Controls.Add(this.tx_StoPrice);
            this.Controls.Add(this.bt_Mainmenu);
            this.Controls.Add(this.btStoAdd);
            this.Controls.Add(this.bt_SupCari);
            this.Controls.Add(this.tx_StoName);
            this.Controls.Add(this.tx_SupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgStocks);
            this.Name = "Form_StockControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_StockControl";
            this.Load += new System.EventHandler(this.Form_StockControl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_StoAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStoUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_StoDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btSupControl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btStoControl;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox tx_StoPrice;
        private System.Windows.Forms.Button bt_Mainmenu;
        private System.Windows.Forms.Button btStoAdd;
        private System.Windows.Forms.Button bt_SupCari;
        private System.Windows.Forms.TextBox tx_StoName;
        private System.Windows.Forms.TextBox tx_SupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_StoDesc;
        private System.Windows.Forms.NumericUpDown nu_StoAmount;
        private System.Windows.Forms.Button btAdmAdd;
        private System.Windows.Forms.Button btAdmLog;
        private System.Windows.Forms.Label label10;
    }
}