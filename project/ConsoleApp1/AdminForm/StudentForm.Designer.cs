using ClassLibrary1;
using System.Windows.Forms;

namespace Attendence_Manngment_System.PAL.Forms
{
    partial class StudentForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            dateTimePicker = new DateTimePicker();
            dataGridRecords = new DataGridView();
            panel1 = new Panel();
            StudentRolelbl = new Label();
            StudentNamelbl = new Label();
            panel3 = new Panel();
            Namelbl_Wel = new Label();
            label2 = new Label();
            label1 = new Label();
            panelExpand = new Panel();
            BtnLogOut = new Button();
            Minimize = new Button();
            pictureBox1 = new PictureBox();
            btn = new PictureBox();
            labelTime = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            comboBoxClass = new ComboBox();
            Classlbl = new Label();
            Datelbl = new Label();
            label3 = new Label();
            pictureBoxPrint = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridRecords).BeginInit();
            panel1.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(66, 101);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.Value = new DateTime(2024, 2, 8, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // dataGridRecords
            // 
            dataGridRecords.AllowUserToAddRows = false;
            dataGridRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRecords.ColumnHeadersHeight = 29;
            dataGridRecords.Dock = DockStyle.Bottom;
            dataGridRecords.Location = new Point(0, 168);
            dataGridRecords.Name = "dataGridRecords";
            dataGridRecords.RowHeadersWidth = 51;
            dataGridRecords.Size = new Size(1104, 202);
            dataGridRecords.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(StudentRolelbl);
            panel1.Controls.Add(StudentNamelbl);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Namelbl_Wel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 112);
            panel1.TabIndex = 6;
            // 
            // StudentRolelbl
            // 
            StudentRolelbl.AutoSize = true;
            StudentRolelbl.ForeColor = Color.White;
            StudentRolelbl.Location = new Point(235, 70);
            StudentRolelbl.Name = "StudentRolelbl";
            StudentRolelbl.Size = new Size(30, 20);
            StudentRolelbl.TabIndex = 4;
            StudentRolelbl.Text = "???";
            // 
            // StudentNamelbl
            // 
            StudentNamelbl.AutoSize = true;
            StudentNamelbl.ForeColor = Color.White;
            StudentNamelbl.Location = new Point(283, 35);
            StudentNamelbl.Name = "StudentNamelbl";
            StudentNamelbl.Size = new Size(30, 20);
            StudentNamelbl.TabIndex = 3;
            StudentNamelbl.Text = "???";
            // 
            // panel3
            // 
            panel3.Location = new Point(833, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 59);
            panel3.TabIndex = 0;
            // 
            // Namelbl_Wel
            // 
            Namelbl_Wel.AutoSize = true;
            Namelbl_Wel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Namelbl_Wel.Location = new Point(288, 28);
            Namelbl_Wel.Name = "Namelbl_Wel";
            Namelbl_Wel.Size = new Size(0, 25);
            Namelbl_Wel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(164, 66);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Role :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome :";
            // 
            // panelExpand
            // 
            panelExpand.BackColor = Color.FromArgb(67, 3, 125);
            panelExpand.Controls.Add(BtnLogOut);
            panelExpand.Controls.Add(Minimize);
            panelExpand.Location = new Point(845, 90);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(221, 112);
            panelExpand.TabIndex = 3;
            // 
            // BtnLogOut
            // 
            BtnLogOut.BackColor = Color.White;
            BtnLogOut.Dock = DockStyle.Top;
            BtnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogOut.ForeColor = Color.FromArgb(64, 0, 0);
            BtnLogOut.Image = (Image)resources.GetObject("BtnLogOut.Image");
            BtnLogOut.Location = new Point(0, 53);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(221, 53);
            BtnLogOut.TabIndex = 1;
            BtnLogOut.Text = "   Log Out";
            BtnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLogOut.UseVisualStyleBackColor = false;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.White;
            Minimize.Dock = DockStyle.Top;
            Minimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minimize.ForeColor = Color.Black;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(0, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(221, 53);
            Minimize.TabIndex = 0;
            Minimize.Text = "      Minimize";
            Minimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(845, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 75);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn
            // 
            btn.BackColor = Color.White;
            btn.Image = (Image)resources.GetObject("btn.Image");
            btn.Location = new Point(927, 61);
            btn.Name = "btn";
            btn.Size = new Size(20, 23);
            btn.TabIndex = 8;
            btn.TabStop = false;
            btn.Click += panelExand_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.FromArgb(69, 3, 125);
            labelTime.Location = new Point(227, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(34, 25);
            labelTime.TabIndex = 9;
            labelTime.Text = "{?}";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxClass);
            panel2.Controls.Add(Classlbl);
            panel2.Controls.Add(Datelbl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridRecords);
            panel2.Controls.Add(dateTimePicker);
            panel2.Location = new Point(53, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 370);
            panel2.TabIndex = 10;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(656, 100);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(151, 28);
            comboBoxClass.TabIndex = 9;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // Classlbl
            // 
            Classlbl.AutoSize = true;
            Classlbl.BackColor = Color.White;
            Classlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Classlbl.ForeColor = Color.FromArgb(63, 3, 125);
            Classlbl.Location = new Point(612, 60);
            Classlbl.Name = "Classlbl";
            Classlbl.Size = new Size(59, 25);
            Classlbl.TabIndex = 8;
            Classlbl.Text = "Class:";
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.BackColor = Color.White;
            Datelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Datelbl.ForeColor = Color.FromArgb(63, 3, 125);
            Datelbl.Location = new Point(21, 60);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(57, 25);
            Datelbl.TabIndex = 7;
            Datelbl.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 3, 125);
            label3.Location = new Point(66, 18);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 6;
            label3.Text = "Show Attandence";
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.Image = (Image)resources.GetObject("pictureBoxPrint.Image");
            pictureBoxPrint.InitialImage = (Image)resources.GetObject("pictureBoxPrint.InitialImage");
            pictureBoxPrint.Location = new Point(1088, 637);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(69, 68);
            pictureBoxPrint.TabIndex = 7;
            pictureBoxPrint.TabStop = false;
            pictureBoxPrint.Click += pictureBoxPrint_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(493, 637);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1222, 717);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxPrint);
            Controls.Add(panel2);
            Controls.Add(labelTime);
            Controls.Add(btn);
            Controls.Add(pictureBox1);
            Controls.Add(panelExpand);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridRecords).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox testbox;
        private DateTimePicker dateTimePicker;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridRecords;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label Namelbl_Wel;
        private Panel panelExpand;
        private PictureBox pictureBox1;
        private PictureBox btn;
        private Panel panel3;
        private Button Minimize;
        private Button BtnLogOut;
        private Label labelTime;
        private System.Windows.Forms.Timer timerDateAndTime;
        private Label StudentRolelbl;
        private Label StudentNamelbl;
        private Panel panel2;
        private Label label3;
        private Label Datelbl;
        private PictureBox pictureBoxPrint;
        private ComboBox comboBoxClass;
        private Label Classlbl;
        private PictureBox pictureBox2;
    }
}