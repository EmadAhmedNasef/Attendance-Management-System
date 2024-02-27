namespace AdminForm
{
    partial class UserControlAddClass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            tabControlUsers = new TabControl();
            tabcontrolAddclass = new TabPage();
            comboBoxClass = new ComboBox();
            comboBoxRole = new ComboBox();
            buttonAddUser = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            textBoxEmail = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageShow = new TabPage();
            buttonExcel = new Button();
            labelNumberofUsers = new Label();
            label9 = new Label();
            dataGridViewUsers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            textBoxSearch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tabPageEdit = new TabPage();
            buttonDelete = new Button();
            comboBoxClass1 = new ComboBox();
            comboBoxRole1 = new ComboBox();
            buttonEdit = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            label11 = new Label();
            panel9 = new Panel();
            label12 = new Label();
            textBoxPassword1 = new TextBox();
            panel10 = new Panel();
            label13 = new Label();
            textBoxEmail1 = new TextBox();
            panel11 = new Panel();
            label14 = new Label();
            textBoxName1 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            tabControlUsers.SuspendLayout();
            tabcontrolAddclass.SuspendLayout();
            tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageEdit.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlUsers
            // 
            tabControlUsers.Alignment = TabAlignment.Bottom;
            tabControlUsers.Controls.Add(tabcontrolAddclass);
            tabControlUsers.Controls.Add(tabPageShow);
            tabControlUsers.Controls.Add(tabPageEdit);
            tabControlUsers.Dock = DockStyle.Fill;
            tabControlUsers.Location = new Point(0, 0);
            tabControlUsers.Name = "tabControlUsers";
            tabControlUsers.SelectedIndex = 0;
            tabControlUsers.Size = new Size(942, 501);
            tabControlUsers.TabIndex = 0;
            // 
            // tabcontrolAddclass
            // 
            tabcontrolAddclass.Controls.Add(comboBoxClass);
            tabcontrolAddclass.Controls.Add(comboBoxRole);
            tabcontrolAddclass.Controls.Add(buttonAddUser);
            tabcontrolAddclass.Controls.Add(panel5);
            tabcontrolAddclass.Controls.Add(panel4);
            tabcontrolAddclass.Controls.Add(label6);
            tabcontrolAddclass.Controls.Add(panel3);
            tabcontrolAddclass.Controls.Add(label5);
            tabcontrolAddclass.Controls.Add(textBoxPassword);
            tabcontrolAddclass.Controls.Add(panel2);
            tabcontrolAddclass.Controls.Add(label4);
            tabcontrolAddclass.Controls.Add(textBoxEmail);
            tabcontrolAddclass.Controls.Add(panel1);
            tabcontrolAddclass.Controls.Add(label3);
            tabcontrolAddclass.Controls.Add(textBoxName);
            tabcontrolAddclass.Controls.Add(label2);
            tabcontrolAddclass.Controls.Add(label1);
            tabcontrolAddclass.Location = new Point(4, 4);
            tabcontrolAddclass.Name = "tabcontrolAddclass";
            tabcontrolAddclass.Padding = new Padding(3);
            tabcontrolAddclass.Size = new Size(934, 472);
            tabcontrolAddclass.TabIndex = 0;
            tabcontrolAddclass.Text = "Add User";
            tabcontrolAddclass.UseVisualStyleBackColor = true;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "Math", "English" });
            comboBoxClass.Location = new Point(110, 336);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 24);
            comboBoxClass.TabIndex = 0;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FlatStyle = FlatStyle.Flat;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Student", "Teacher", "Admin" });
            comboBoxRole.Location = new Point(557, 230);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(270, 24);
            comboBoxRole.TabIndex = 0;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.FromArgb(255, 128, 0);
            buttonAddUser.FlatAppearance.BorderSize = 0;
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonAddUser.ForeColor = Color.White;
            buttonAddUser.Location = new Point(557, 328);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(165, 40);
            buttonAddUser.TabIndex = 0;
            buttonAddUser.Text = "Add User";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(110, 366);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(557, 261);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(110, 310);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 0;
            label6.Text = "Class  : ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(110, 261);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(557, 205);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 0;
            label5.Text = "Role :";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxPassword.Location = new Point(110, 237);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(270, 17);
            textBoxPassword.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(557, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(110, 205);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 0;
            label4.Text = "Password  : ";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxEmail.Location = new Point(557, 124);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 17);
            textBoxEmail.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(110, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(557, 92);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 0;
            label3.Text = "Email : ";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxName.Location = new Point(110, 124);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 17);
            textBoxName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(110, 92);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 0;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Add User :";
            // 
            // tabPageShow
            // 
            tabPageShow.Controls.Add(buttonExcel);
            tabPageShow.Controls.Add(labelNumberofUsers);
            tabPageShow.Controls.Add(label9);
            tabPageShow.Controls.Add(dataGridViewUsers);
            tabPageShow.Controls.Add(pictureBox1);
            tabPageShow.Controls.Add(panel6);
            tabPageShow.Controls.Add(textBoxSearch);
            tabPageShow.Controls.Add(label7);
            tabPageShow.Controls.Add(label8);
            tabPageShow.Location = new Point(4, 4);
            tabPageShow.Name = "tabPageShow";
            tabPageShow.Padding = new Padding(3);
            tabPageShow.Size = new Size(934, 472);
            tabPageShow.TabIndex = 1;
            tabPageShow.Text = "Show Users";
            tabPageShow.UseVisualStyleBackColor = true;
            tabPageShow.Enter += tabPageShow_Enter;
            tabPageShow.Leave += tabPageShow_Leave;
            // 
            // buttonExcel
            // 
            buttonExcel.BackColor = Color.FromArgb(255, 128, 0);
            buttonExcel.FlatAppearance.BorderSize = 0;
            buttonExcel.FlatStyle = FlatStyle.Flat;
            buttonExcel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonExcel.ForeColor = Color.White;
            buttonExcel.Location = new Point(31, 434);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(165, 40);
            buttonExcel.TabIndex = 7;
            buttonExcel.Text = "load to excel";
            buttonExcel.UseVisualStyleBackColor = false;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // labelNumberofUsers
            // 
            labelNumberofUsers.AutoSize = true;
            labelNumberofUsers.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumberofUsers.ForeColor = Color.FromArgb(255, 128, 0);
            labelNumberofUsers.Location = new Point(808, 453);
            labelNumberofUsers.Name = "labelNumberofUsers";
            labelNumberofUsers.Size = new Size(32, 21);
            labelNumberofUsers.TabIndex = 0;
            labelNumberofUsers.Text = "{?}";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(693, 453);
            label9.Name = "label9";
            label9.Size = new Size(102, 19);
            label9.TabIndex = 0;
            label9.Text = "Total Users  : ";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToResizeColumns = false;
            dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Email, Password, Class, Column1 });
            dataGridViewUsers.Location = new Point(31, 131);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewUsers.ShowCellErrors = false;
            dataGridViewUsers.ShowEditingIcon = false;
            dataGridViewUsers.ShowRowErrors = false;
            dataGridViewUsers.Size = new Size(878, 318);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            Class.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Role";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_interface_symbol;
            pictureBox1.Location = new Point(402, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(151, 105);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxSearch.Location = new Point(151, 81);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(270, 17);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(151, 50);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 0;
            label7.Text = "Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(6, 3);
            label8.Name = "label8";
            label8.Size = new Size(103, 19);
            label8.TabIndex = 0;
            label8.Text = "Show Users : ";
            // 
            // tabPageEdit
            // 
            tabPageEdit.Controls.Add(buttonDelete);
            tabPageEdit.Controls.Add(comboBoxClass1);
            tabPageEdit.Controls.Add(comboBoxRole1);
            tabPageEdit.Controls.Add(buttonEdit);
            tabPageEdit.Controls.Add(panel7);
            tabPageEdit.Controls.Add(panel8);
            tabPageEdit.Controls.Add(label11);
            tabPageEdit.Controls.Add(panel9);
            tabPageEdit.Controls.Add(label12);
            tabPageEdit.Controls.Add(textBoxPassword1);
            tabPageEdit.Controls.Add(panel10);
            tabPageEdit.Controls.Add(label13);
            tabPageEdit.Controls.Add(textBoxEmail1);
            tabPageEdit.Controls.Add(panel11);
            tabPageEdit.Controls.Add(label14);
            tabPageEdit.Controls.Add(textBoxName1);
            tabPageEdit.Controls.Add(label15);
            tabPageEdit.Controls.Add(label16);
            tabPageEdit.Location = new Point(4, 4);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Padding = new Padding(3);
            tabPageEdit.Size = new Size(934, 473);
            tabPageEdit.TabIndex = 2;
            tabPageEdit.Text = "Edit And Delete";
            tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(695, 336);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 32);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Delete User";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxClass1
            // 
            comboBoxClass1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass1.FlatStyle = FlatStyle.Flat;
            comboBoxClass1.FormattingEnabled = true;
            comboBoxClass1.Items.AddRange(new object[] { "Math", "English" });
            comboBoxClass1.Location = new Point(110, 336);
            comboBoxClass1.Name = "comboBoxClass1";
            comboBoxClass1.Size = new Size(270, 24);
            comboBoxClass1.TabIndex = 0;
            comboBoxClass1.SelectedIndexChanged += comboBoxClass1_SelectedIndexChanged;
            // 
            // comboBoxRole1
            // 
            comboBoxRole1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole1.FlatStyle = FlatStyle.Flat;
            comboBoxRole1.FormattingEnabled = true;
            comboBoxRole1.Items.AddRange(new object[] { "Student", "Teacher", "Admin" });
            comboBoxRole1.Location = new Point(557, 230);
            comboBoxRole1.Name = "comboBoxRole1";
            comboBoxRole1.Size = new Size(270, 24);
            comboBoxRole1.TabIndex = 0;
            comboBoxRole1.SelectedIndexChanged += comboBoxRole1_SelectedIndexChanged;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 128, 0);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(557, 336);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 32);
            buttonEdit.TabIndex = 0;
            buttonEdit.Text = "Edit User";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(110, 366);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(557, 261);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 128, 0);
            label11.Location = new Point(110, 310);
            label11.Name = "label11";
            label11.Size = new Size(64, 19);
            label11.TabIndex = 0;
            label11.Text = "Class  : ";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Location = new Point(110, 261);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(557, 205);
            label12.Name = "label12";
            label12.Size = new Size(50, 19);
            label12.TabIndex = 0;
            label12.Text = "Role :";
            // 
            // textBoxPassword1
            // 
            textBoxPassword1.BorderStyle = BorderStyle.None;
            textBoxPassword1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxPassword1.Location = new Point(110, 237);
            textBoxPassword1.Name = "textBoxPassword1";
            textBoxPassword1.Size = new Size(270, 17);
            textBoxPassword1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightGray;
            panel10.Location = new Point(557, 148);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 2);
            panel10.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(110, 205);
            label13.Name = "label13";
            label13.Size = new Size(96, 19);
            label13.TabIndex = 0;
            label13.Text = "Password  : ";
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.BorderStyle = BorderStyle.None;
            textBoxEmail1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxEmail1.Location = new Point(557, 124);
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(270, 17);
            textBoxEmail1.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGray;
            panel11.Location = new Point(110, 148);
            panel11.Name = "panel11";
            panel11.Size = new Size(270, 2);
            panel11.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(255, 128, 0);
            label14.Location = new Point(557, 92);
            label14.Name = "label14";
            label14.Size = new Size(64, 19);
            label14.TabIndex = 0;
            label14.Text = "Email : ";
            // 
            // textBoxName1
            // 
            textBoxName1.BorderStyle = BorderStyle.None;
            textBoxName1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxName1.Location = new Point(110, 124);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(270, 17);
            textBoxName1.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(255, 128, 0);
            label15.Location = new Point(110, 92);
            label15.Name = "label15";
            label15.Size = new Size(66, 19);
            label15.TabIndex = 0;
            label15.Text = "Name :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(255, 128, 0);
            label16.Location = new Point(6, 3);
            label16.Name = "label16";
            label16.Size = new Size(86, 19);
            label16.TabIndex = 0;
            label16.Text = "Add User :";
            // 
            // UserControlAddClass
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlUsers);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            Size = new Size(942, 501);
            tabControlUsers.ResumeLayout(false);
            tabcontrolAddclass.ResumeLayout(false);
            tabcontrolAddclass.PerformLayout();
            tabPageShow.ResumeLayout(false);
            tabPageShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageEdit.ResumeLayout(false);
            tabPageEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControlUsers;
        private TabPage tabcontrolAddclass;
        private TabPage tabPageShow;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxEmail;
        private Label label3;
        private Panel panel3;
        private TextBox textBoxPassword;
        private Label label4;
        private Button buttonAddUser;
        private Panel panel5;
        private TextBox textBoxEmail1;
        private Panel panel4;
        private Label label6;
        private TextBox textBoxPassword1;
        private Label label5;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxClass;
        private PictureBox pictureBox1;
        private Panel panel6;
        private TextBox textBoxSearch;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewUsers;
        private Label labelNumberofUsers;
        private Label label9;
        private TabPage tabPageEdit;
        private ComboBox comboBoxClass1;
        private ComboBox comboBoxRole1;
        private Button buttonEdit;
        private Panel panel7;
        private Panel panel8;
        private Label label11;
        private Panel panel9;
        private Label label12;
        private Panel panel10;
        private Label label13;
        private Panel panel11;
        private Label label14;
        private TextBox textBoxName1;
        private Label label15;
        private Label label16;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Column1;
        private Button buttonExcel;
    }
}
