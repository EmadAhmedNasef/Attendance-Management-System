namespace Attendence_Management.PAL.User_Control
{
    partial class UserControlReports
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
            tabPageReports = new TabPage();
            dataGridViewMarkAttendance = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            pictureBoxPrint = new PictureBox();
            comboBoxClass = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageReports
            // 
            tabPageReports.Controls.Add(dataGridViewMarkAttendance);
            tabPageReports.Controls.Add(label2);
            tabPageReports.Controls.Add(pictureBoxPrint);
            tabPageReports.Controls.Add(comboBoxClass);
            tabPageReports.Controls.Add(dateTimePickerDate);
            tabPageReports.Controls.Add(label3);
            tabPageReports.Controls.Add(label1);
            tabPageReports.Location = new Point(4, 4);
            tabPageReports.Name = "tabPageReports";
            tabPageReports.Padding = new Padding(3);
            tabPageReports.Size = new Size(931, 464);
            tabPageReports.TabIndex = 0;
            tabPageReports.Text = "tabPageReports";
            tabPageReports.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMarkAttendance
            // 
            dataGridViewMarkAttendance.AllowUserToAddRows = false;
            dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            dataGridViewMarkAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMarkAttendance.BackgroundColor = Color.White;
            dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarkAttendance.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column4, Column3 });
            dataGridViewMarkAttendance.Location = new Point(14, 138);
            dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            dataGridViewMarkAttendance.RowHeadersWidth = 51;
            dataGridViewMarkAttendance.Size = new Size(902, 188);
            dataGridViewMarkAttendance.TabIndex = 12;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(68, 3, 125);
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 11;
            label2.Text = "Reports:";
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.Image = Properties.Resources.pngtree_vector_print_icon_png_image_553795;
            pictureBoxPrint.Location = new Point(430, 42);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(97, 56);
            pictureBoxPrint.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPrint.TabIndex = 10;
            pictureBoxPrint.TabStop = false;
            pictureBoxPrint.Click += pictureBoxPrint_Click;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(651, 54);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(249, 29);
            comboBoxClass.TabIndex = 9;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CustomFormat = "yyyy/MM/dd";
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new Point(115, 54);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(277, 29);
            dateTimePickerDate.TabIndex = 8;
            dateTimePickerDate.ValueChanged += dateTimePickerDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(68, 3, 125);
            label3.Location = new Point(574, 57);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 6;
            label3.Text = "Class: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(68, 3, 125);
            label1.Location = new Point(51, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 7;
            label1.Text = "Date: ";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPageReports);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(939, 498);
            tabControl1.TabIndex = 0;
            // 
            // UserControlReports
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9.75F);
            Name = "UserControlReports";
            Size = new Size(942, 501);
            tabPageReports.ResumeLayout(false);
            tabPageReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageReports;
        private TabControl tabControl1;
        private PictureBox pictureBoxPrint;
        private ComboBox comboBoxClass;
        private DateTimePicker dateTimePickerDate;
        private Label label3;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewMarkAttendance;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
    }
}
