namespace Football
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
            this.playersLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPlayerNameTB = new System.Windows.Forms.TextBox();
            this.addPlayerB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deletePlayerB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editPlayerNameTB = new System.Windows.Forms.TextBox();
            this.savePlayerB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.playerPositionsLB = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addPlayerPositionNameTB = new System.Windows.Forms.TextBox();
            this.addPlayerPositionMatchCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addPlayerPositionB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.addMatchTeam2TB = new System.Windows.Forms.TextBox();
            this.addMatchStadiumCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addMatchTeam1TB = new System.Windows.Forms.TextBox();
            this.addMatchB = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addStadiumNameTB = new System.Windows.Forms.TextBox();
            this.addStadiumB = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.deleteStadiumB = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.editStadiumNameTB = new System.Windows.Forms.TextBox();
            this.saveStadiumB = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.statiumsLB = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editMatchTeam2TB = new System.Windows.Forms.TextBox();
            this.editMatchStadiumCB = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.deleteMatchB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.editMatchTeam1TB = new System.Windows.Forms.TextBox();
            this.saveMatchB = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.matchesLB = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.proceduresCB = new System.Windows.Forms.ComboBox();
            this.callProcedureB = new System.Windows.Forms.Button();
            this.deletePlayerPositionB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // playersLB
            // 
            this.playersLB.FormattingEnabled = true;
            this.playersLB.Location = new System.Drawing.Point(12, 25);
            this.playersLB.Name = "playersLB";
            this.playersLB.Size = new System.Drawing.Size(211, 69);
            this.playersLB.TabIndex = 0;
            this.playersLB.SelectedIndexChanged += new System.EventHandler(this.playersLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ігроки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addPlayerNameTB);
            this.groupBox1.Controls.Add(this.addPlayerB);
            this.groupBox1.Location = new System.Drawing.Point(524, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати ігрока";
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
            // addPlayerNameTB
            // 
            this.addPlayerNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerNameTB.Location = new System.Drawing.Point(6, 37);
            this.addPlayerNameTB.Name = "addPlayerNameTB";
            this.addPlayerNameTB.Size = new System.Drawing.Size(199, 20);
            this.addPlayerNameTB.TabIndex = 4;
            // 
            // addPlayerB
            // 
            this.addPlayerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerB.Location = new System.Drawing.Point(130, 61);
            this.addPlayerB.Name = "addPlayerB";
            this.addPlayerB.Size = new System.Drawing.Size(75, 23);
            this.addPlayerB.TabIndex = 0;
            this.addPlayerB.Text = "Додати";
            this.addPlayerB.UseVisualStyleBackColor = true;
            this.addPlayerB.Click += new System.EventHandler(this.addPlayerB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deletePlayerB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.editPlayerNameTB);
            this.groupBox2.Controls.Add(this.savePlayerB);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перегляд";
            // 
            // deletePlayerB
            // 
            this.deletePlayerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletePlayerB.Enabled = false;
            this.deletePlayerB.Location = new System.Drawing.Point(6, 60);
            this.deletePlayerB.Name = "deletePlayerB";
            this.deletePlayerB.Size = new System.Drawing.Size(75, 23);
            this.deletePlayerB.TabIndex = 14;
            this.deletePlayerB.Text = "Видалити";
            this.deletePlayerB.UseVisualStyleBackColor = true;
            this.deletePlayerB.Click += new System.EventHandler(this.deletePlayerB_Click);
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
            // editPlayerNameTB
            // 
            this.editPlayerNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPlayerNameTB.Location = new System.Drawing.Point(6, 36);
            this.editPlayerNameTB.Name = "editPlayerNameTB";
            this.editPlayerNameTB.Size = new System.Drawing.Size(199, 20);
            this.editPlayerNameTB.TabIndex = 2;
            // 
            // savePlayerB
            // 
            this.savePlayerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePlayerB.Enabled = false;
            this.savePlayerB.Location = new System.Drawing.Point(130, 60);
            this.savePlayerB.Name = "savePlayerB";
            this.savePlayerB.Size = new System.Drawing.Size(75, 23);
            this.savePlayerB.TabIndex = 1;
            this.savePlayerB.Text = "Зберегти";
            this.savePlayerB.UseVisualStyleBackColor = true;
            this.savePlayerB.Click += new System.EventHandler(this.savePlayerB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Позіції:";
            // 
            // playerPositionsLB
            // 
            this.playerPositionsLB.FormattingEnabled = true;
            this.playerPositionsLB.Location = new System.Drawing.Point(11, 230);
            this.playerPositionsLB.Name = "playerPositionsLB";
            this.playerPositionsLB.Size = new System.Drawing.Size(211, 69);
            this.playerPositionsLB.TabIndex = 5;
            this.playerPositionsLB.SelectedIndexChanged += new System.EventHandler(this.playerPositionsLB_SelectedIndexChanged);
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
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addPlayerPositionNameTB);
            this.groupBox3.Controls.Add(this.addPlayerPositionMatchCB);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.addPlayerPositionB);
            this.groupBox3.Location = new System.Drawing.Point(11, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 131);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Додати позицію";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Позиція";
            // 
            // addPlayerPositionNameTB
            // 
            this.addPlayerPositionNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerPositionNameTB.Location = new System.Drawing.Point(6, 76);
            this.addPlayerPositionNameTB.Name = "addPlayerPositionNameTB";
            this.addPlayerPositionNameTB.Size = new System.Drawing.Size(199, 20);
            this.addPlayerPositionNameTB.TabIndex = 5;
            // 
            // addPlayerPositionMatchCB
            // 
            this.addPlayerPositionMatchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addPlayerPositionMatchCB.FormattingEnabled = true;
            this.addPlayerPositionMatchCB.Location = new System.Drawing.Point(9, 36);
            this.addPlayerPositionMatchCB.Name = "addPlayerPositionMatchCB";
            this.addPlayerPositionMatchCB.Size = new System.Drawing.Size(196, 21);
            this.addPlayerPositionMatchCB.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Матч";
            // 
            // addPlayerPositionB
            // 
            this.addPlayerPositionB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerPositionB.Enabled = false;
            this.addPlayerPositionB.Location = new System.Drawing.Point(130, 102);
            this.addPlayerPositionB.Name = "addPlayerPositionB";
            this.addPlayerPositionB.Size = new System.Drawing.Size(75, 23);
            this.addPlayerPositionB.TabIndex = 1;
            this.addPlayerPositionB.Text = "Зберегти";
            this.addPlayerPositionB.UseVisualStyleBackColor = true;
            this.addPlayerPositionB.Click += new System.EventHandler(this.addPlayerPositionB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.addMatchTeam2TB);
            this.groupBox4.Controls.Add(this.addMatchStadiumCB);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.addMatchTeam1TB);
            this.groupBox4.Controls.Add(this.addMatchB);
            this.groupBox4.Location = new System.Drawing.Point(524, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 170);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Додати матч";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Команда 1";
            // 
            // addMatchTeam2TB
            // 
            this.addMatchTeam2TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMatchTeam2TB.Location = new System.Drawing.Point(6, 76);
            this.addMatchTeam2TB.Name = "addMatchTeam2TB";
            this.addMatchTeam2TB.Size = new System.Drawing.Size(199, 20);
            this.addMatchTeam2TB.TabIndex = 9;
            // 
            // addMatchStadiumCB
            // 
            this.addMatchStadiumCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addMatchStadiumCB.FormattingEnabled = true;
            this.addMatchStadiumCB.Location = new System.Drawing.Point(7, 115);
            this.addMatchStadiumCB.Name = "addMatchStadiumCB";
            this.addMatchStadiumCB.Size = new System.Drawing.Size(196, 21);
            this.addMatchStadiumCB.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Стадіон";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Команда 1";
            // 
            // addMatchTeam1TB
            // 
            this.addMatchTeam1TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMatchTeam1TB.Location = new System.Drawing.Point(6, 37);
            this.addMatchTeam1TB.Name = "addMatchTeam1TB";
            this.addMatchTeam1TB.Size = new System.Drawing.Size(199, 20);
            this.addMatchTeam1TB.TabIndex = 4;
            // 
            // addMatchB
            // 
            this.addMatchB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMatchB.Location = new System.Drawing.Point(130, 141);
            this.addMatchB.Name = "addMatchB";
            this.addMatchB.Size = new System.Drawing.Size(75, 23);
            this.addMatchB.TabIndex = 0;
            this.addMatchB.Text = "Додати";
            this.addMatchB.UseVisualStyleBackColor = true;
            this.addMatchB.Click += new System.EventHandler(this.addMatchB_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.addStadiumNameTB);
            this.groupBox5.Controls.Add(this.addStadiumB);
            this.groupBox5.Location = new System.Drawing.Point(524, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 98);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Додати стадіон";
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
            // addStadiumNameTB
            // 
            this.addStadiumNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addStadiumNameTB.Location = new System.Drawing.Point(6, 37);
            this.addStadiumNameTB.Name = "addStadiumNameTB";
            this.addStadiumNameTB.Size = new System.Drawing.Size(199, 20);
            this.addStadiumNameTB.TabIndex = 4;
            // 
            // addStadiumB
            // 
            this.addStadiumB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStadiumB.Location = new System.Drawing.Point(130, 69);
            this.addStadiumB.Name = "addStadiumB";
            this.addStadiumB.Size = new System.Drawing.Size(75, 23);
            this.addStadiumB.TabIndex = 0;
            this.addStadiumB.Text = "Додати";
            this.addStadiumB.UseVisualStyleBackColor = true;
            this.addStadiumB.Click += new System.EventHandler(this.addStadiumB_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.deleteStadiumB);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.editStadiumNameTB);
            this.groupBox6.Controls.Add(this.saveStadiumB);
            this.groupBox6.Location = new System.Drawing.Point(266, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 95);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Перегляд";
            // 
            // deleteStadiumB
            // 
            this.deleteStadiumB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteStadiumB.Enabled = false;
            this.deleteStadiumB.Location = new System.Drawing.Point(6, 66);
            this.deleteStadiumB.Name = "deleteStadiumB";
            this.deleteStadiumB.Size = new System.Drawing.Size(75, 23);
            this.deleteStadiumB.TabIndex = 14;
            this.deleteStadiumB.Text = "Видалити";
            this.deleteStadiumB.UseVisualStyleBackColor = true;
            this.deleteStadiumB.Click += new System.EventHandler(this.deleteStadiumB_Click);
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
            // editStadiumNameTB
            // 
            this.editStadiumNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editStadiumNameTB.Location = new System.Drawing.Point(6, 36);
            this.editStadiumNameTB.Name = "editStadiumNameTB";
            this.editStadiumNameTB.Size = new System.Drawing.Size(199, 20);
            this.editStadiumNameTB.TabIndex = 2;
            // 
            // saveStadiumB
            // 
            this.saveStadiumB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStadiumB.Enabled = false;
            this.saveStadiumB.Location = new System.Drawing.Point(130, 66);
            this.saveStadiumB.Name = "saveStadiumB";
            this.saveStadiumB.Size = new System.Drawing.Size(75, 23);
            this.saveStadiumB.TabIndex = 1;
            this.saveStadiumB.Text = "Зберегти";
            this.saveStadiumB.UseVisualStyleBackColor = true;
            this.saveStadiumB.Click += new System.EventHandler(this.saveStadiumB_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(266, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Стадіони";
            // 
            // statiumsLB
            // 
            this.statiumsLB.FormattingEnabled = true;
            this.statiumsLB.Location = new System.Drawing.Point(266, 25);
            this.statiumsLB.Name = "statiumsLB";
            this.statiumsLB.Size = new System.Drawing.Size(211, 69);
            this.statiumsLB.TabIndex = 17;
            this.statiumsLB.SelectedIndexChanged += new System.EventHandler(this.stadiumsLB_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.editMatchTeam2TB);
            this.groupBox7.Controls.Add(this.editMatchStadiumCB);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.deleteMatchB);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.editMatchTeam1TB);
            this.groupBox7.Controls.Add(this.saveMatchB);
            this.groupBox7.Location = new System.Drawing.Point(266, 302);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(211, 174);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Перегляд";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Команда 2";
            // 
            // editMatchTeam2TB
            // 
            this.editMatchTeam2TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMatchTeam2TB.Location = new System.Drawing.Point(6, 76);
            this.editMatchTeam2TB.Name = "editMatchTeam2TB";
            this.editMatchTeam2TB.Size = new System.Drawing.Size(199, 20);
            this.editMatchTeam2TB.TabIndex = 17;
            // 
            // editMatchStadiumCB
            // 
            this.editMatchStadiumCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editMatchStadiumCB.FormattingEnabled = true;
            this.editMatchStadiumCB.Location = new System.Drawing.Point(6, 118);
            this.editMatchStadiumCB.Name = "editMatchStadiumCB";
            this.editMatchStadiumCB.Size = new System.Drawing.Size(199, 21);
            this.editMatchStadiumCB.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Стадіон";
            // 
            // deleteMatchB
            // 
            this.deleteMatchB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteMatchB.Enabled = false;
            this.deleteMatchB.Location = new System.Drawing.Point(6, 145);
            this.deleteMatchB.Name = "deleteMatchB";
            this.deleteMatchB.Size = new System.Drawing.Size(75, 23);
            this.deleteMatchB.TabIndex = 14;
            this.deleteMatchB.Text = "Видалити";
            this.deleteMatchB.UseVisualStyleBackColor = true;
            this.deleteMatchB.Click += new System.EventHandler(this.deleteMatchB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Команда 1";
            // 
            // editMatchTeam1TB
            // 
            this.editMatchTeam1TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMatchTeam1TB.Location = new System.Drawing.Point(6, 36);
            this.editMatchTeam1TB.Name = "editMatchTeam1TB";
            this.editMatchTeam1TB.Size = new System.Drawing.Size(199, 20);
            this.editMatchTeam1TB.TabIndex = 2;
            // 
            // saveMatchB
            // 
            this.saveMatchB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveMatchB.Enabled = false;
            this.saveMatchB.Location = new System.Drawing.Point(130, 145);
            this.saveMatchB.Name = "saveMatchB";
            this.saveMatchB.Size = new System.Drawing.Size(75, 23);
            this.saveMatchB.TabIndex = 1;
            this.saveMatchB.Text = "Зберегти";
            this.saveMatchB.UseVisualStyleBackColor = true;
            this.saveMatchB.Click += new System.EventHandler(this.saveMatchB_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Матчі";
            // 
            // matchesLB
            // 
            this.matchesLB.FormattingEnabled = true;
            this.matchesLB.Location = new System.Drawing.Point(266, 227);
            this.matchesLB.Name = "matchesLB";
            this.matchesLB.Size = new System.Drawing.Size(211, 69);
            this.matchesLB.TabIndex = 20;
            this.matchesLB.SelectedIndexChanged += new System.EventHandler(this.matchesLB_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 490);
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
            this.proceduresCB.Location = new System.Drawing.Point(79, 487);
            this.proceduresCB.Name = "proceduresCB";
            this.proceduresCB.Size = new System.Drawing.Size(196, 21);
            this.proceduresCB.TabIndex = 24;
            // 
            // callProcedureB
            // 
            this.callProcedureB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.callProcedureB.Location = new System.Drawing.Point(293, 487);
            this.callProcedureB.Name = "callProcedureB";
            this.callProcedureB.Size = new System.Drawing.Size(75, 23);
            this.callProcedureB.TabIndex = 25;
            this.callProcedureB.Text = "Виконати";
            this.callProcedureB.UseVisualStyleBackColor = true;
            this.callProcedureB.Click += new System.EventHandler(this.callProcedureB_Click);
            // 
            // deletePlayerPositionB
            // 
            this.deletePlayerPositionB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePlayerPositionB.Enabled = false;
            this.deletePlayerPositionB.Location = new System.Drawing.Point(110, 208);
            this.deletePlayerPositionB.Margin = new System.Windows.Forms.Padding(0);
            this.deletePlayerPositionB.Name = "deletePlayerPositionB";
            this.deletePlayerPositionB.Size = new System.Drawing.Size(112, 22);
            this.deletePlayerPositionB.TabIndex = 26;
            this.deletePlayerPositionB.Text = "видалити обрану";
            this.deletePlayerPositionB.UseVisualStyleBackColor = true;
            this.deletePlayerPositionB.Click += new System.EventHandler(this.deletePlayerPositionB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 522);
            this.Controls.Add(this.deletePlayerPositionB);
            this.Controls.Add(this.callProcedureB);
            this.Controls.Add(this.proceduresCB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.matchesLB);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.statiumsLB);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.playerPositionsLB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playersLB);
            this.Name = "Form1";
            this.Text = "ПСЖ";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playersLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addPlayerB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editPlayerNameTB;
        private System.Windows.Forms.Button savePlayerB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addPlayerNameTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox playerPositionsLB;
        private System.Windows.Forms.Button deletePlayerB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addPlayerPositionB;
        private System.Windows.Forms.ComboBox addPlayerPositionMatchCB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox addMatchStadiumCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addMatchTeam1TB;
        private System.Windows.Forms.Button addMatchB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addStadiumNameTB;
        private System.Windows.Forms.Button addStadiumB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button deleteStadiumB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox editStadiumNameTB;
        private System.Windows.Forms.Button saveStadiumB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox statiumsLB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox editMatchStadiumCB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button deleteMatchB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editMatchTeam1TB;
        private System.Windows.Forms.Button saveMatchB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox matchesLB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox proceduresCB;
        private System.Windows.Forms.Button callProcedureB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addPlayerPositionNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editMatchTeam2TB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox addMatchTeam2TB;
        private System.Windows.Forms.Button deletePlayerPositionB;
    }
}

