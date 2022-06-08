namespace CarStore
{
    partial class Form1
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
            this.customersLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addCustomerNameTB = new System.Windows.Forms.TextBox();
            this.addCustomerB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteCustomerB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editCustomerNameTB = new System.Windows.Forms.TextBox();
            this.saveCustomerB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.customerBoughtCarsLB = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCustomerBoughtCarCarCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addCustomerBoughtCarB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addCarManufacturerCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addCarNameTB = new System.Windows.Forms.TextBox();
            this.addCarB = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addManufacturerNameTB = new System.Windows.Forms.TextBox();
            this.addManufacturerB = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.deleteManufacturerB = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.editManufacturerNameTB = new System.Windows.Forms.TextBox();
            this.saveManufacturerB = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.manufacturersLB = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.editCarManufacturerCB = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.deleteCarB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.editCarNameTB = new System.Windows.Forms.TextBox();
            this.saveCarB = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.carsLB = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.proceduresCB = new System.Windows.Forms.ComboBox();
            this.callProcedureB = new System.Windows.Forms.Button();
            this.deleteCustomerBoughtCarB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addCustomerPhoneTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addCustomerAddressTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editCustomerAddressTB = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.editCustomerPhoneTB = new System.Windows.Forms.TextBox();
            this.addCustomerBoughtCarPriceNB = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomerBoughtCarPriceNB)).BeginInit();
            this.SuspendLayout();
            // 
            // customersLB
            // 
            this.customersLB.FormattingEnabled = true;
            this.customersLB.Location = new System.Drawing.Point(12, 25);
            this.customersLB.Name = "customersLB";
            this.customersLB.Size = new System.Drawing.Size(211, 69);
            this.customersLB.TabIndex = 0;
            this.customersLB.SelectedIndexChanged += new System.EventHandler(this.customersLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клієнти";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addCustomerAddressTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addCustomerPhoneTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addCustomerNameTB);
            this.groupBox1.Controls.Add(this.addCustomerB);
            this.groupBox1.Location = new System.Drawing.Point(524, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати клієнта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ім\'я";
            // 
            // addCustomerNameTB
            // 
            this.addCustomerNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerNameTB.Location = new System.Drawing.Point(6, 37);
            this.addCustomerNameTB.Name = "addCustomerNameTB";
            this.addCustomerNameTB.Size = new System.Drawing.Size(199, 20);
            this.addCustomerNameTB.TabIndex = 4;
            // 
            // addCustomerB
            // 
            this.addCustomerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerB.Location = new System.Drawing.Point(130, 145);
            this.addCustomerB.Name = "addCustomerB";
            this.addCustomerB.Size = new System.Drawing.Size(75, 23);
            this.addCustomerB.TabIndex = 0;
            this.addCustomerB.Text = "Додати";
            this.addCustomerB.UseVisualStyleBackColor = true;
            this.addCustomerB.Click += new System.EventHandler(this.addCustomerB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.editCustomerAddressTB);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.editCustomerPhoneTB);
            this.groupBox2.Controls.Add(this.deleteCustomerB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.editCustomerNameTB);
            this.groupBox2.Controls.Add(this.saveCustomerB);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перегляд";
            // 
            // deleteCustomerB
            // 
            this.deleteCustomerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteCustomerB.Enabled = false;
            this.deleteCustomerB.Location = new System.Drawing.Point(6, 138);
            this.deleteCustomerB.Name = "deleteCustomerB";
            this.deleteCustomerB.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomerB.TabIndex = 14;
            this.deleteCustomerB.Text = "Видалити";
            this.deleteCustomerB.UseVisualStyleBackColor = true;
            this.deleteCustomerB.Click += new System.EventHandler(this.deleteCustomerB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ім\'я";
            // 
            // editCustomerNameTB
            // 
            this.editCustomerNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCustomerNameTB.Location = new System.Drawing.Point(6, 36);
            this.editCustomerNameTB.Name = "editCustomerNameTB";
            this.editCustomerNameTB.Size = new System.Drawing.Size(199, 20);
            this.editCustomerNameTB.TabIndex = 2;
            // 
            // saveCustomerB
            // 
            this.saveCustomerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveCustomerB.Enabled = false;
            this.saveCustomerB.Location = new System.Drawing.Point(130, 138);
            this.saveCustomerB.Name = "saveCustomerB";
            this.saveCustomerB.Size = new System.Drawing.Size(75, 23);
            this.saveCustomerB.TabIndex = 1;
            this.saveCustomerB.Text = "Зберегти";
            this.saveCustomerB.UseVisualStyleBackColor = true;
            this.saveCustomerB.Click += new System.EventHandler(this.saveCustomerB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Куплені машини";
            // 
            // customerBoughtCarsLB
            // 
            this.customerBoughtCarsLB.FormattingEnabled = true;
            this.customerBoughtCarsLB.Location = new System.Drawing.Point(12, 302);
            this.customerBoughtCarsLB.Name = "customerBoughtCarsLB";
            this.customerBoughtCarsLB.Size = new System.Drawing.Size(211, 69);
            this.customerBoughtCarsLB.TabIndex = 5;
            this.customerBoughtCarsLB.SelectedIndexChanged += new System.EventHandler(this.customerBoughtCarsLB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addCustomerBoughtCarPriceNB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addCustomerBoughtCarCarCB);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.addCustomerBoughtCarB);
            this.groupBox3.Location = new System.Drawing.Point(12, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 131);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Додати покупку";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ціна";
            // 
            // addCustomerBoughtCarCarCB
            // 
            this.addCustomerBoughtCarCarCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCustomerBoughtCarCarCB.FormattingEnabled = true;
            this.addCustomerBoughtCarCarCB.Location = new System.Drawing.Point(9, 36);
            this.addCustomerBoughtCarCarCB.Name = "addCustomerBoughtCarCarCB";
            this.addCustomerBoughtCarCarCB.Size = new System.Drawing.Size(196, 21);
            this.addCustomerBoughtCarCarCB.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Автомобіль";
            // 
            // addCustomerBoughtCarB
            // 
            this.addCustomerBoughtCarB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerBoughtCarB.Enabled = false;
            this.addCustomerBoughtCarB.Location = new System.Drawing.Point(130, 102);
            this.addCustomerBoughtCarB.Name = "addCustomerBoughtCarB";
            this.addCustomerBoughtCarB.Size = new System.Drawing.Size(75, 23);
            this.addCustomerBoughtCarB.TabIndex = 1;
            this.addCustomerBoughtCarB.Text = "Зберегти";
            this.addCustomerBoughtCarB.UseVisualStyleBackColor = true;
            this.addCustomerBoughtCarB.Click += new System.EventHandler(this.addCustomerBoughtCarB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addCarManufacturerCB);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.addCarNameTB);
            this.groupBox4.Controls.Add(this.addCarB);
            this.groupBox4.Location = new System.Drawing.Point(524, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 134);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Додати авто";
            // 
            // addCarManufacturerCB
            // 
            this.addCarManufacturerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCarManufacturerCB.FormattingEnabled = true;
            this.addCarManufacturerCB.Location = new System.Drawing.Point(6, 80);
            this.addCarManufacturerCB.Name = "addCarManufacturerCB";
            this.addCarManufacturerCB.Size = new System.Drawing.Size(196, 21);
            this.addCarManufacturerCB.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Виробник";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Назва";
            // 
            // addCarNameTB
            // 
            this.addCarNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCarNameTB.Location = new System.Drawing.Point(6, 37);
            this.addCarNameTB.Name = "addCarNameTB";
            this.addCarNameTB.Size = new System.Drawing.Size(199, 20);
            this.addCarNameTB.TabIndex = 4;
            // 
            // addCarB
            // 
            this.addCarB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCarB.Location = new System.Drawing.Point(130, 105);
            this.addCarB.Name = "addCarB";
            this.addCarB.Size = new System.Drawing.Size(75, 23);
            this.addCarB.TabIndex = 0;
            this.addCarB.Text = "Додати";
            this.addCarB.UseVisualStyleBackColor = true;
            this.addCarB.Click += new System.EventHandler(this.addCarB_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.addManufacturerNameTB);
            this.groupBox5.Controls.Add(this.addManufacturerB);
            this.groupBox5.Location = new System.Drawing.Point(524, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 98);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Додати виробника";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Назва";
            // 
            // addManufacturerNameTB
            // 
            this.addManufacturerNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addManufacturerNameTB.Location = new System.Drawing.Point(6, 37);
            this.addManufacturerNameTB.Name = "addManufacturerNameTB";
            this.addManufacturerNameTB.Size = new System.Drawing.Size(199, 20);
            this.addManufacturerNameTB.TabIndex = 4;
            // 
            // addManufacturerB
            // 
            this.addManufacturerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addManufacturerB.Location = new System.Drawing.Point(130, 69);
            this.addManufacturerB.Name = "addManufacturerB";
            this.addManufacturerB.Size = new System.Drawing.Size(75, 23);
            this.addManufacturerB.TabIndex = 0;
            this.addManufacturerB.Text = "Додати";
            this.addManufacturerB.UseVisualStyleBackColor = true;
            this.addManufacturerB.Click += new System.EventHandler(this.addManufacturerB_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.deleteManufacturerB);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.editManufacturerNameTB);
            this.groupBox6.Controls.Add(this.saveManufacturerB);
            this.groupBox6.Location = new System.Drawing.Point(266, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 95);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Перегляд";
            // 
            // deleteManufacturerB
            // 
            this.deleteManufacturerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteManufacturerB.Enabled = false;
            this.deleteManufacturerB.Location = new System.Drawing.Point(6, 66);
            this.deleteManufacturerB.Name = "deleteManufacturerB";
            this.deleteManufacturerB.Size = new System.Drawing.Size(75, 23);
            this.deleteManufacturerB.TabIndex = 14;
            this.deleteManufacturerB.Text = "Видалити";
            this.deleteManufacturerB.UseVisualStyleBackColor = true;
            this.deleteManufacturerB.Click += new System.EventHandler(this.deleteManufacturerB_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Ім\'я";
            // 
            // editManufacturerNameTB
            // 
            this.editManufacturerNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editManufacturerNameTB.Location = new System.Drawing.Point(6, 36);
            this.editManufacturerNameTB.Name = "editManufacturerNameTB";
            this.editManufacturerNameTB.Size = new System.Drawing.Size(199, 20);
            this.editManufacturerNameTB.TabIndex = 2;
            // 
            // saveManufacturerB
            // 
            this.saveManufacturerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveManufacturerB.Enabled = false;
            this.saveManufacturerB.Location = new System.Drawing.Point(130, 66);
            this.saveManufacturerB.Name = "saveManufacturerB";
            this.saveManufacturerB.Size = new System.Drawing.Size(75, 23);
            this.saveManufacturerB.TabIndex = 1;
            this.saveManufacturerB.Text = "Зберегти";
            this.saveManufacturerB.UseVisualStyleBackColor = true;
            this.saveManufacturerB.Click += new System.EventHandler(this.saveManufacturerB_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(266, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Виробники";
            // 
            // manufacturersLB
            // 
            this.manufacturersLB.FormattingEnabled = true;
            this.manufacturersLB.Location = new System.Drawing.Point(266, 25);
            this.manufacturersLB.Name = "manufacturersLB";
            this.manufacturersLB.Size = new System.Drawing.Size(211, 69);
            this.manufacturersLB.TabIndex = 17;
            this.manufacturersLB.SelectedIndexChanged += new System.EventHandler(this.manufacturersLB_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.editCarManufacturerCB);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.deleteCarB);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.editCarNameTB);
            this.groupBox7.Controls.Add(this.saveCarB);
            this.groupBox7.Location = new System.Drawing.Point(266, 302);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(211, 134);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Перегляд";
            // 
            // editCarManufacturerCB
            // 
            this.editCarManufacturerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editCarManufacturerCB.FormattingEnabled = true;
            this.editCarManufacturerCB.Location = new System.Drawing.Point(6, 77);
            this.editCarManufacturerCB.Name = "editCarManufacturerCB";
            this.editCarManufacturerCB.Size = new System.Drawing.Size(199, 21);
            this.editCarManufacturerCB.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Виробник";
            // 
            // deleteCarB
            // 
            this.deleteCarB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteCarB.Enabled = false;
            this.deleteCarB.Location = new System.Drawing.Point(6, 105);
            this.deleteCarB.Name = "deleteCarB";
            this.deleteCarB.Size = new System.Drawing.Size(75, 23);
            this.deleteCarB.TabIndex = 14;
            this.deleteCarB.Text = "Видалити";
            this.deleteCarB.UseVisualStyleBackColor = true;
            this.deleteCarB.Click += new System.EventHandler(this.deleteCarB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Назва";
            // 
            // editCarNameTB
            // 
            this.editCarNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCarNameTB.Location = new System.Drawing.Point(6, 36);
            this.editCarNameTB.Name = "editCarNameTB";
            this.editCarNameTB.Size = new System.Drawing.Size(199, 20);
            this.editCarNameTB.TabIndex = 2;
            // 
            // saveCarB
            // 
            this.saveCarB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveCarB.Enabled = false;
            this.saveCarB.Location = new System.Drawing.Point(130, 105);
            this.saveCarB.Name = "saveCarB";
            this.saveCarB.Size = new System.Drawing.Size(75, 23);
            this.saveCarB.TabIndex = 1;
            this.saveCarB.Text = "Зберегти";
            this.saveCarB.UseVisualStyleBackColor = true;
            this.saveCarB.Click += new System.EventHandler(this.saveCarB_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Автомобілі";
            // 
            // carsLB
            // 
            this.carsLB.FormattingEnabled = true;
            this.carsLB.Location = new System.Drawing.Point(266, 227);
            this.carsLB.Name = "carsLB";
            this.carsLB.Size = new System.Drawing.Size(211, 69);
            this.carsLB.TabIndex = 20;
            this.carsLB.SelectedIndexChanged += new System.EventHandler(this.carsLB_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(282, 484);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Процедури:";
            // 
            // proceduresCB
            // 
            this.proceduresCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.proceduresCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proceduresCB.FormattingEnabled = true;
            this.proceduresCB.Items.AddRange(new object[] {
            "remove_inactive_users",
            "drop_all_data"});
            this.proceduresCB.Location = new System.Drawing.Point(350, 481);
            this.proceduresCB.Name = "proceduresCB";
            this.proceduresCB.Size = new System.Drawing.Size(196, 21);
            this.proceduresCB.TabIndex = 24;
            // 
            // callProcedureB
            // 
            this.callProcedureB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.callProcedureB.Location = new System.Drawing.Point(564, 481);
            this.callProcedureB.Name = "callProcedureB";
            this.callProcedureB.Size = new System.Drawing.Size(75, 23);
            this.callProcedureB.TabIndex = 25;
            this.callProcedureB.Text = "Виконати";
            this.callProcedureB.UseVisualStyleBackColor = true;
            this.callProcedureB.Click += new System.EventHandler(this.callProcedureB_Click);
            // 
            // deleteCustomerBoughtCarB
            // 
            this.deleteCustomerBoughtCarB.Enabled = false;
            this.deleteCustomerBoughtCarB.Location = new System.Drawing.Point(111, 280);
            this.deleteCustomerBoughtCarB.Margin = new System.Windows.Forms.Padding(0);
            this.deleteCustomerBoughtCarB.Name = "deleteCustomerBoughtCarB";
            this.deleteCustomerBoughtCarB.Size = new System.Drawing.Size(112, 22);
            this.deleteCustomerBoughtCarB.TabIndex = 26;
            this.deleteCustomerBoughtCarB.Text = "видалити обрану";
            this.deleteCustomerBoughtCarB.UseVisualStyleBackColor = true;
            this.deleteCustomerBoughtCarB.Click += new System.EventHandler(this.deleteCustomerBoughtCarB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефон";
            // 
            // addCustomerPhoneTB
            // 
            this.addCustomerPhoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerPhoneTB.Location = new System.Drawing.Point(6, 76);
            this.addCustomerPhoneTB.Name = "addCustomerPhoneTB";
            this.addCustomerPhoneTB.Size = new System.Drawing.Size(199, 20);
            this.addCustomerPhoneTB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адреса";
            // 
            // addCustomerAddressTB
            // 
            this.addCustomerAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerAddressTB.Location = new System.Drawing.Point(6, 115);
            this.addCustomerAddressTB.Name = "addCustomerAddressTB";
            this.addCustomerAddressTB.Size = new System.Drawing.Size(199, 20);
            this.addCustomerAddressTB.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Адреса";
            // 
            // editCustomerAddressTB
            // 
            this.editCustomerAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCustomerAddressTB.Location = new System.Drawing.Point(6, 115);
            this.editCustomerAddressTB.Name = "editCustomerAddressTB";
            this.editCustomerAddressTB.Size = new System.Drawing.Size(199, 20);
            this.editCustomerAddressTB.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Телефон";
            // 
            // editCustomerPhoneTB
            // 
            this.editCustomerPhoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCustomerPhoneTB.Location = new System.Drawing.Point(6, 76);
            this.editCustomerPhoneTB.Name = "editCustomerPhoneTB";
            this.editCustomerPhoneTB.Size = new System.Drawing.Size(199, 20);
            this.editCustomerPhoneTB.TabIndex = 15;
            // 
            // addCustomerBoughtCarPriceNB
            // 
            this.addCustomerBoughtCarPriceNB.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addCustomerBoughtCarPriceNB.Location = new System.Drawing.Point(9, 77);
            this.addCustomerBoughtCarPriceNB.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.addCustomerBoughtCarPriceNB.Name = "addCustomerBoughtCarPriceNB";
            this.addCustomerBoughtCarPriceNB.Size = new System.Drawing.Size(196, 20);
            this.addCustomerBoughtCarPriceNB.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 520);
            this.Controls.Add(this.deleteCustomerBoughtCarB);
            this.Controls.Add(this.callProcedureB);
            this.Controls.Add(this.proceduresCB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.carsLB);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.manufacturersLB);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customerBoughtCarsLB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersLB);
            this.Name = "Form1";
            this.Text = "Автосалон";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomerBoughtCarPriceNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customersLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addCustomerB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editCustomerNameTB;
        private System.Windows.Forms.Button saveCustomerB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addCustomerNameTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox customerBoughtCarsLB;
        private System.Windows.Forms.Button deleteCustomerB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addCustomerBoughtCarB;
        private System.Windows.Forms.ComboBox addCustomerBoughtCarCarCB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox addCarManufacturerCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addCarNameTB;
        private System.Windows.Forms.Button addCarB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addManufacturerNameTB;
        private System.Windows.Forms.Button addManufacturerB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button deleteManufacturerB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox editManufacturerNameTB;
        private System.Windows.Forms.Button saveManufacturerB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox manufacturersLB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox editCarManufacturerCB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button deleteCarB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editCarNameTB;
        private System.Windows.Forms.Button saveCarB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox carsLB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox proceduresCB;
        private System.Windows.Forms.Button callProcedureB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteCustomerBoughtCarB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addCustomerAddressTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addCustomerPhoneTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editCustomerAddressTB;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox editCustomerPhoneTB;
        private System.Windows.Forms.NumericUpDown addCustomerBoughtCarPriceNB;
    }
}

