namespace BookStore
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
            this.usersLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addUserAddressTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUserPhoneTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addUserNameTB = new System.Windows.Forms.TextBox();
            this.addUserB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteUserB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.editUserAddressTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editUserPhoneTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editUserNameTB = new System.Windows.Forms.TextBox();
            this.saveUserB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.userBooksLB = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addBoughtBookCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addBoughtBookB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addBookNameTB = new System.Windows.Forms.TextBox();
            this.addBookB = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addAuthorNameTB = new System.Windows.Forms.TextBox();
            this.addAuthorB = new System.Windows.Forms.Button();
            this.addBook_AuthorCB = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.deleteAuthorB = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.editAuthorNameTB = new System.Windows.Forms.TextBox();
            this.saveAuthorB = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.authorsLB = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.deleteBookB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.editBookNameTB = new System.Windows.Forms.TextBox();
            this.saveBookB = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.booksLB = new System.Windows.Forms.ListBox();
            this.editBookAuthorCB = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.proceduresCB = new System.Windows.Forms.ComboBox();
            this.callProcedureB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersLB
            // 
            this.usersLB.FormattingEnabled = true;
            this.usersLB.Location = new System.Drawing.Point(12, 25);
            this.usersLB.Name = "usersLB";
            this.usersLB.Size = new System.Drawing.Size(211, 69);
            this.usersLB.TabIndex = 0;
            this.usersLB.SelectedIndexChanged += new System.EventHandler(this.usersLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Користувачі";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addUserAddressTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addUserPhoneTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addUserNameTB);
            this.groupBox1.Controls.Add(this.addUserB);
            this.groupBox1.Location = new System.Drawing.Point(524, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати користувача";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адрес";
            // 
            // addUserAddressTB
            // 
            this.addUserAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserAddressTB.Location = new System.Drawing.Point(6, 115);
            this.addUserAddressTB.Name = "addUserAddressTB";
            this.addUserAddressTB.Size = new System.Drawing.Size(199, 20);
            this.addUserAddressTB.TabIndex = 8;
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
            // addUserPhoneTB
            // 
            this.addUserPhoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserPhoneTB.Location = new System.Drawing.Point(6, 76);
            this.addUserPhoneTB.Name = "addUserPhoneTB";
            this.addUserPhoneTB.Size = new System.Drawing.Size(199, 20);
            this.addUserPhoneTB.TabIndex = 6;
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
            // addUserNameTB
            // 
            this.addUserNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserNameTB.Location = new System.Drawing.Point(6, 37);
            this.addUserNameTB.Name = "addUserNameTB";
            this.addUserNameTB.Size = new System.Drawing.Size(199, 20);
            this.addUserNameTB.TabIndex = 4;
            // 
            // addUserB
            // 
            this.addUserB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserB.Location = new System.Drawing.Point(130, 144);
            this.addUserB.Name = "addUserB";
            this.addUserB.Size = new System.Drawing.Size(75, 23);
            this.addUserB.TabIndex = 0;
            this.addUserB.Text = "Додати";
            this.addUserB.UseVisualStyleBackColor = true;
            this.addUserB.Click += new System.EventHandler(this.addUserB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteUserB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.editUserAddressTB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.editUserPhoneTB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.editUserNameTB);
            this.groupBox2.Controls.Add(this.saveUserB);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перегляд";
            // 
            // deleteUserB
            // 
            this.deleteUserB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteUserB.Enabled = false;
            this.deleteUserB.Location = new System.Drawing.Point(6, 144);
            this.deleteUserB.Name = "deleteUserB";
            this.deleteUserB.Size = new System.Drawing.Size(75, 23);
            this.deleteUserB.TabIndex = 14;
            this.deleteUserB.Text = "Видалити";
            this.deleteUserB.UseVisualStyleBackColor = true;
            this.deleteUserB.Click += new System.EventHandler(this.deleteUserB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Адрес";
            // 
            // editUserAddressTB
            // 
            this.editUserAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editUserAddressTB.Location = new System.Drawing.Point(6, 114);
            this.editUserAddressTB.Name = "editUserAddressTB";
            this.editUserAddressTB.Size = new System.Drawing.Size(199, 20);
            this.editUserAddressTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Телефон";
            // 
            // editUserPhoneTB
            // 
            this.editUserPhoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editUserPhoneTB.Location = new System.Drawing.Point(6, 75);
            this.editUserPhoneTB.Name = "editUserPhoneTB";
            this.editUserPhoneTB.Size = new System.Drawing.Size(199, 20);
            this.editUserPhoneTB.TabIndex = 10;
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
            // editUserNameTB
            // 
            this.editUserNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editUserNameTB.Location = new System.Drawing.Point(6, 36);
            this.editUserNameTB.Name = "editUserNameTB";
            this.editUserNameTB.Size = new System.Drawing.Size(199, 20);
            this.editUserNameTB.TabIndex = 2;
            // 
            // saveUserB
            // 
            this.saveUserB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveUserB.Enabled = false;
            this.saveUserB.Location = new System.Drawing.Point(130, 144);
            this.saveUserB.Name = "saveUserB";
            this.saveUserB.Size = new System.Drawing.Size(75, 23);
            this.saveUserB.TabIndex = 1;
            this.saveUserB.Text = "Зберегти";
            this.saveUserB.UseVisualStyleBackColor = true;
            this.saveUserB.Click += new System.EventHandler(this.saveUserB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Куплені книги:";
            // 
            // userBooksLB
            // 
            this.userBooksLB.FormattingEnabled = true;
            this.userBooksLB.Location = new System.Drawing.Point(12, 292);
            this.userBooksLB.Name = "userBooksLB";
            this.userBooksLB.Size = new System.Drawing.Size(211, 69);
            this.userBooksLB.TabIndex = 5;
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
            this.groupBox3.Controls.Add(this.addBoughtBookCB);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.addBoughtBookB);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 91);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Додати куплену книгу";
            // 
            // addBoughtBookCB
            // 
            this.addBoughtBookCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addBoughtBookCB.FormattingEnabled = true;
            this.addBoughtBookCB.Location = new System.Drawing.Point(9, 36);
            this.addBoughtBookCB.Name = "addBoughtBookCB";
            this.addBoughtBookCB.Size = new System.Drawing.Size(196, 21);
            this.addBoughtBookCB.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Книга";
            // 
            // addBoughtBookB
            // 
            this.addBoughtBookB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBoughtBookB.Enabled = false;
            this.addBoughtBookB.Location = new System.Drawing.Point(130, 62);
            this.addBoughtBookB.Name = "addBoughtBookB";
            this.addBoughtBookB.Size = new System.Drawing.Size(75, 23);
            this.addBoughtBookB.TabIndex = 1;
            this.addBoughtBookB.Text = "Зберегти";
            this.addBoughtBookB.UseVisualStyleBackColor = true;
            this.addBoughtBookB.Click += new System.EventHandler(this.addBoughtBookB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addBook_AuthorCB);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.addBookNameTB);
            this.groupBox4.Controls.Add(this.addBookB);
            this.groupBox4.Location = new System.Drawing.Point(524, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 133);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Додати книгу";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Автор";
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
            // addBookNameTB
            // 
            this.addBookNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookNameTB.Location = new System.Drawing.Point(6, 37);
            this.addBookNameTB.Name = "addBookNameTB";
            this.addBookNameTB.Size = new System.Drawing.Size(199, 20);
            this.addBookNameTB.TabIndex = 4;
            // 
            // addBookB
            // 
            this.addBookB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookB.Location = new System.Drawing.Point(130, 104);
            this.addBookB.Name = "addBookB";
            this.addBookB.Size = new System.Drawing.Size(75, 23);
            this.addBookB.TabIndex = 0;
            this.addBookB.Text = "Додати";
            this.addBookB.UseVisualStyleBackColor = true;
            this.addBookB.Click += new System.EventHandler(this.addBookB_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.addAuthorNameTB);
            this.groupBox5.Controls.Add(this.addAuthorB);
            this.groupBox5.Location = new System.Drawing.Point(524, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 98);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Додати автора";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Ім\'я";
            // 
            // addAuthorNameTB
            // 
            this.addAuthorNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAuthorNameTB.Location = new System.Drawing.Point(6, 37);
            this.addAuthorNameTB.Name = "addAuthorNameTB";
            this.addAuthorNameTB.Size = new System.Drawing.Size(199, 20);
            this.addAuthorNameTB.TabIndex = 4;
            // 
            // addAuthorB
            // 
            this.addAuthorB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAuthorB.Location = new System.Drawing.Point(130, 69);
            this.addAuthorB.Name = "addAuthorB";
            this.addAuthorB.Size = new System.Drawing.Size(75, 23);
            this.addAuthorB.TabIndex = 0;
            this.addAuthorB.Text = "Додати";
            this.addAuthorB.UseVisualStyleBackColor = true;
            this.addAuthorB.Click += new System.EventHandler(this.addAuthorB_Click);
            // 
            // addBook_AuthorCB
            // 
            this.addBook_AuthorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addBook_AuthorCB.FormattingEnabled = true;
            this.addBook_AuthorCB.Location = new System.Drawing.Point(6, 76);
            this.addBook_AuthorCB.Name = "addBook_AuthorCB";
            this.addBook_AuthorCB.Size = new System.Drawing.Size(196, 21);
            this.addBook_AuthorCB.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.deleteAuthorB);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.editAuthorNameTB);
            this.groupBox6.Controls.Add(this.saveAuthorB);
            this.groupBox6.Location = new System.Drawing.Point(266, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 95);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Перегляд";
            // 
            // deleteAuthorB
            // 
            this.deleteAuthorB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteAuthorB.Enabled = false;
            this.deleteAuthorB.Location = new System.Drawing.Point(6, 66);
            this.deleteAuthorB.Name = "deleteAuthorB";
            this.deleteAuthorB.Size = new System.Drawing.Size(75, 23);
            this.deleteAuthorB.TabIndex = 14;
            this.deleteAuthorB.Text = "Видалити";
            this.deleteAuthorB.UseVisualStyleBackColor = true;
            this.deleteAuthorB.Click += new System.EventHandler(this.deleteAuthorB_Click);
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
            // editAuthorNameTB
            // 
            this.editAuthorNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editAuthorNameTB.Location = new System.Drawing.Point(6, 36);
            this.editAuthorNameTB.Name = "editAuthorNameTB";
            this.editAuthorNameTB.Size = new System.Drawing.Size(199, 20);
            this.editAuthorNameTB.TabIndex = 2;
            // 
            // saveAuthorB
            // 
            this.saveAuthorB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAuthorB.Enabled = false;
            this.saveAuthorB.Location = new System.Drawing.Point(130, 66);
            this.saveAuthorB.Name = "saveAuthorB";
            this.saveAuthorB.Size = new System.Drawing.Size(75, 23);
            this.saveAuthorB.TabIndex = 1;
            this.saveAuthorB.Text = "Зберегти";
            this.saveAuthorB.UseVisualStyleBackColor = true;
            this.saveAuthorB.Click += new System.EventHandler(this.saveAuthorB_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(266, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Автора";
            // 
            // authorsLB
            // 
            this.authorsLB.FormattingEnabled = true;
            this.authorsLB.Location = new System.Drawing.Point(266, 25);
            this.authorsLB.Name = "authorsLB";
            this.authorsLB.Size = new System.Drawing.Size(211, 69);
            this.authorsLB.TabIndex = 17;
            this.authorsLB.SelectedIndexChanged += new System.EventHandler(this.authorsLB_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.editBookAuthorCB);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.deleteBookB);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.editBookNameTB);
            this.groupBox7.Controls.Add(this.saveBookB);
            this.groupBox7.Location = new System.Drawing.Point(266, 321);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(211, 130);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Перегляд";
            // 
            // deleteBookB
            // 
            this.deleteBookB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBookB.Enabled = false;
            this.deleteBookB.Location = new System.Drawing.Point(6, 101);
            this.deleteBookB.Name = "deleteBookB";
            this.deleteBookB.Size = new System.Drawing.Size(75, 23);
            this.deleteBookB.TabIndex = 14;
            this.deleteBookB.Text = "Видалити";
            this.deleteBookB.UseVisualStyleBackColor = true;
            this.deleteBookB.Click += new System.EventHandler(this.deleteBookB_Click);
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
            // editBookNameTB
            // 
            this.editBookNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBookNameTB.Location = new System.Drawing.Point(6, 36);
            this.editBookNameTB.Name = "editBookNameTB";
            this.editBookNameTB.Size = new System.Drawing.Size(199, 20);
            this.editBookNameTB.TabIndex = 2;
            // 
            // saveBookB
            // 
            this.saveBookB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBookB.Enabled = false;
            this.saveBookB.Location = new System.Drawing.Point(130, 101);
            this.saveBookB.Name = "saveBookB";
            this.saveBookB.Size = new System.Drawing.Size(75, 23);
            this.saveBookB.TabIndex = 1;
            this.saveBookB.Text = "Зберегти";
            this.saveBookB.UseVisualStyleBackColor = true;
            this.saveBookB.Click += new System.EventHandler(this.saveBookB_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Книги";
            // 
            // booksLB
            // 
            this.booksLB.FormattingEnabled = true;
            this.booksLB.Location = new System.Drawing.Point(266, 246);
            this.booksLB.Name = "booksLB";
            this.booksLB.Size = new System.Drawing.Size(211, 69);
            this.booksLB.TabIndex = 20;
            this.booksLB.SelectedIndexChanged += new System.EventHandler(this.booksLB_SelectedIndexChanged);
            // 
            // editBookAuthorCB
            // 
            this.editBookAuthorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editBookAuthorCB.FormattingEnabled = true;
            this.editBookAuthorCB.Location = new System.Drawing.Point(6, 75);
            this.editBookAuthorCB.Name = "editBookAuthorCB";
            this.editBookAuthorCB.Size = new System.Drawing.Size(196, 21);
            this.editBookAuthorCB.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Автор";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 482);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Процедури:";
            // 
            // proceduresCB
            // 
            this.proceduresCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proceduresCB.FormattingEnabled = true;
            this.proceduresCB.Items.AddRange(new object[] {
            "remove_inactive_users",
            "drop_all_data"});
            this.proceduresCB.Location = new System.Drawing.Point(80, 479);
            this.proceduresCB.Name = "proceduresCB";
            this.proceduresCB.Size = new System.Drawing.Size(196, 21);
            this.proceduresCB.TabIndex = 24;
            // 
            // callProcedureB
            // 
            this.callProcedureB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.callProcedureB.Location = new System.Drawing.Point(293, 478);
            this.callProcedureB.Name = "callProcedureB";
            this.callProcedureB.Size = new System.Drawing.Size(75, 23);
            this.callProcedureB.TabIndex = 25;
            this.callProcedureB.Text = "Виконати";
            this.callProcedureB.UseVisualStyleBackColor = true;
            this.callProcedureB.Click += new System.EventHandler(this.callProcedureB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 513);
            this.Controls.Add(this.callProcedureB);
            this.Controls.Add(this.proceduresCB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.booksLB);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.authorsLB);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userBooksLB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersLB);
            this.Name = "Form1";
            this.Text = "Магазин книжок";
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

        private System.Windows.Forms.ListBox usersLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addUserB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editUserNameTB;
        private System.Windows.Forms.Button saveUserB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addUserNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addUserAddressTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addUserPhoneTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editUserAddressTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editUserPhoneTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox userBooksLB;
        private System.Windows.Forms.Button deleteUserB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addBoughtBookB;
        private System.Windows.Forms.ComboBox addBoughtBookCB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox addBook_AuthorCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addBookNameTB;
        private System.Windows.Forms.Button addBookB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addAuthorNameTB;
        private System.Windows.Forms.Button addAuthorB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button deleteAuthorB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox editAuthorNameTB;
        private System.Windows.Forms.Button saveAuthorB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox authorsLB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox editBookAuthorCB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button deleteBookB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editBookNameTB;
        private System.Windows.Forms.Button saveBookB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox booksLB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox proceduresCB;
        private System.Windows.Forms.Button callProcedureB;
    }
}

