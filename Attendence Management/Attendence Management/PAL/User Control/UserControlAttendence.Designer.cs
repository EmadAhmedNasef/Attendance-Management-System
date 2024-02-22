namespace Attendence_Management.PAL.User_Control
{
    partial class UserControlAttendence
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
            tabPageMarkAttendence = new TabPage();
            dataGridViewMarkAttendance = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            comboBoxClass = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPageMarkAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageMarkAttendence
            // 
            tabPageMarkAttendence.Controls.Add(dataGridViewMarkAttendance);
            tabPageMarkAttendence.Controls.Add(comboBoxClass);
            tabPageMarkAttendence.Controls.Add(dateTimePickerDate);
            tabPageMarkAttendence.Controls.Add(label3);
            tabPageMarkAttendence.Controls.Add(label1);
            tabPageMarkAttendence.Controls.Add(label2);
            tabPageMarkAttendence.Cursor = Cursors.Hand;
            tabPageMarkAttendence.Location = new Point(4, 4);
            tabPageMarkAttendence.Name = "tabPageMarkAttendence";
            tabPageMarkAttendence.Padding = new Padding(3);
            tabPageMarkAttendence.Size = new Size(934, 467);
            tabPageMarkAttendence.TabIndex = 0;
            tabPageMarkAttendence.Text = "MarkAttendence";
            tabPageMarkAttendence.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMarkAttendance
            // 
            dataGridViewMarkAttendance.AllowUserToAddRows = false;
            dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            dataGridViewMarkAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMarkAttendance.BackgroundColor = Color.White;
            dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarkAttendance.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column4, Column3 });
            dataGridViewMarkAttendance.Location = new Point(26, 127);
            dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            dataGridViewMarkAttendance.RowHeadersWidth = 51;
            dataGridViewMarkAttendance.Size = new Size(902, 188);
            dataGridViewMarkAttendance.TabIndex = 4;
            dataGridViewMarkAttendance.CellContentClick += dataGridViewMarkAttendance_CellContentClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "Class";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(647, 49);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(249, 29);
            comboBoxClass.TabIndex = 3;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CustomFormat = "yyyy/MM/dd";
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new Point(114, 52);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(277, 29);
            dateTimePickerDate.TabIndex = 2;
            // 
            // label3
            // 

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(68, 3, 125);
            label1.Location = new Point(50, 52);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Date: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(68, 3, 125);
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 1;
            label2.Text = "Mark Attendence: ";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPageMarkAttendence);
            tabControl1.Location = new Point(0, 0);
            tabControl1.MinimumSize = new Size(942, 501);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 501);
            tabControl1.TabIndex = 0;
            // 
            // UserControlAttendence
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9.75F);
            Name = "UserControlAttendence";
            Size = new Size(942, 501);
            tabPageMarkAttendence.ResumeLayout(false);
            tabPageMarkAttendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageMarkAttendence;
        private TabControl tabControl1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerDate;
        private Label label3;
        private ComboBox comboBoxClass;
        private DataGridView dataGridViewMarkAttendance;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Attendence;
    }
}
