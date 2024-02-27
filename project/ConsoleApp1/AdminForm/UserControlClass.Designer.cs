namespace AdminForm
{
    partial class UserControlClass
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBoxClass = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            labelNumberofUsers = new Label();
            label9 = new Label();
            dataGridViewUsers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            textBoxSearch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            buttonExcel = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 501);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonExcel);
            tabPage1.Controls.Add(comboBoxClass);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(labelNumberofUsers);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dataGridViewUsers);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(textBoxSearch);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Font = new Font("Segoe UI", 9F);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 473);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Enter += tabPage1_Enter;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DisplayMember = "Math";
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "Math", "English" });
            comboBoxClass.Location = new Point(535, 56);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 23);
            comboBoxClass.TabIndex = 27;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(535, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(535, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 26;
            label1.Text = "Class :";
            // 
            // labelNumberofUsers
            // 
            labelNumberofUsers.AutoSize = true;
            labelNumberofUsers.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumberofUsers.ForeColor = Color.FromArgb(255, 128, 0);
            labelNumberofUsers.Location = new Point(806, 433);
            labelNumberofUsers.Name = "labelNumberofUsers";
            labelNumberofUsers.Size = new Size(32, 21);
            labelNumberofUsers.TabIndex = 18;
            labelNumberofUsers.Text = "{?}";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(643, 435);
            label9.Name = "label9";
            label9.Size = new Size(157, 19);
            label9.TabIndex = 19;
            label9.Text = "Total Class Stdents : ";
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
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Email, Password, Column1 });
            dataGridViewUsers.Location = new Point(29, 111);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewUsers.ShowCellErrors = false;
            dataGridViewUsers.ShowEditingIcon = false;
            dataGridViewUsers.ShowRowErrors = false;
            dataGridViewUsers.Size = new Size(878, 318);
            dataGridViewUsers.TabIndex = 20;
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
            // Column1
            // 
            Column1.HeaderText = "Role";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_interface_symbol;
            pictureBox1.Location = new Point(383, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(132, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 21;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            textBoxSearch.Location = new Point(132, 61);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(270, 17);
            textBoxSearch.TabIndex = 22;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(132, 30);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 23;
            label7.Text = "Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(3, 6);
            label8.Name = "label8";
            label8.Size = new Size(121, 19);
            label8.TabIndex = 17;
            label8.Text = "Show Classes : ";
            // 
            // buttonExcel
            // 
            buttonExcel.BackColor = Color.FromArgb(255, 128, 0);
            buttonExcel.FlatAppearance.BorderSize = 0;
            buttonExcel.FlatStyle = FlatStyle.Flat;
            buttonExcel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonExcel.ForeColor = Color.White;
            buttonExcel.Location = new Point(29, 423);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(165, 40);
            buttonExcel.TabIndex = 18;
            buttonExcel.Text = "load to excel";
            buttonExcel.UseVisualStyleBackColor = false;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // UserControlClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Size = new Size(942, 501);
            Load += UserControlClass_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBoxClass;
        private Panel panel1;
        private Label label1;
        private Label labelNumberofUsers;
        private Label label9;
        private DataGridView dataGridViewUsers;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Column1;
        private PictureBox pictureBox1;
        private Panel panel6;
        private TextBox textBoxSearch;
        private Label label7;
        private Label label8;
        private ToolTip toolTip1;
        private Button buttonExcel;
    }
}
