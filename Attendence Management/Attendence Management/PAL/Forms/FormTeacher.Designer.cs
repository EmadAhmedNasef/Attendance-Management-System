namespace Attendence_Management.PAL.Forms
{
    partial class FormTeacher
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
            panel1 = new Panel();
            buttonReport = new Button();
            buttonAttendence = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panelBack = new Panel();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            panelTop = new Panel();
            panelExpand = new Panel();
            buttonLogOut = new Button();
            buttonMinimize = new Button();
            panel4 = new Panel();
            labelRole = new Label();
            labelUsername = new Label();
            labelR = new Label();
            labelWelcome = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            panelExpand.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonAttendence);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 720);
            panel1.TabIndex = 0;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.White;
            buttonReport.Cursor = Cursors.Hand;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReport.ForeColor = Color.FromArgb(67, 3, 125);
            buttonReport.Image = Properties.Resources.report;
            buttonReport.Location = new Point(41, 394);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(169, 67);
            buttonReport.TabIndex = 2;
            buttonReport.Text = "    Reports";
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = false;
            // 
            // buttonAttendence
            // 
            buttonAttendence.BackColor = Color.White;
            buttonAttendence.Cursor = Cursors.Hand;
            buttonAttendence.FlatAppearance.BorderSize = 0;
            buttonAttendence.FlatStyle = FlatStyle.Flat;
            buttonAttendence.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAttendence.ForeColor = Color.FromArgb(67, 3, 125);
            buttonAttendence.Image = Properties.Resources.attendance;
            buttonAttendence.Location = new Point(41, 283);
            buttonAttendence.Name = "buttonAttendence";
            buttonAttendence.Size = new Size(169, 67);
            buttonAttendence.TabIndex = 2;
            buttonAttendence.Text = "    Attendence";
            buttonAttendence.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendence.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(263, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.students2;
            pictureBox1.Location = new Point(40, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 168);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(258, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(942, 165);
            panelBack.TabIndex = 1;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.arrow_down_sign_to_navigate;
            pictureBoxExpand.Location = new Point(747, 3);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(98, 34);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 2;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Graphicloads_100_Flat_Student_256;
            pictureBox2.Location = new Point(633, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.White;
            labelTime.ForeColor = Color.FromArgb(67, 3, 125);
            labelTime.Location = new Point(23, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(35, 28);
            labelTime.TabIndex = 1;
            labelTime.Text = "(?)";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(67, 3, 125);
            panelTop.Controls.Add(panelExpand);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(labelR);
            panelTop.Controls.Add(labelWelcome);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 40);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(942, 125);
            panelTop.TabIndex = 0;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(buttonMinimize);
            panelExpand.Controls.Add(panel4);
            panelExpand.Location = new Point(604, 3);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(250, 125);
            panelExpand.TabIndex = 2;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Segoe UI", 9F);
            buttonLogOut.ForeColor = Color.FromArgb(67, 3, 125);
            buttonLogOut.Image = Properties.Resources.logout;
            buttonLogOut.Location = new Point(-1, 61);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(250, 63);
            buttonLogOut.TabIndex = 2;
            buttonLogOut.Text = "    Logout";
            buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Segoe UI", 9F);
            buttonMinimize.ForeColor = Color.FromArgb(67, 3, 125);
            buttonMinimize.Image = Properties.Resources.minus_button;
            buttonMinimize.Location = new Point(0, 5);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(248, 59);
            buttonMinimize.TabIndex = 1;
            buttonMinimize.Text = "    Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 5);
            panel4.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.FromArgb(67, 3, 125);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(180, 65);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(35, 28);
            labelRole.TabIndex = 1;
            labelRole.Text = "(?)";
            labelRole.Click += label5_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(67, 3, 125);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(180, 24);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(35, 28);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "(?)";
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.BackColor = Color.FromArgb(67, 3, 125);
            labelR.ForeColor = Color.White;
            labelR.Location = new Point(50, 65);
            labelR.Name = "labelR";
            labelR.Size = new Size(65, 28);
            labelR.TabIndex = 1;
            labelR.Text = "Role: ";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.FromArgb(67, 3, 125);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(50, 24);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(110, 28);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Welcome: ";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // FormTeacher
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTeacher";
            WindowState = FormWindowState.Maximized;
            Load += FormTeacher_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelExpand.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panelBack;
        private Label labelTime;
        private Panel panelTop;
        private Label labelRole;
        private Label labelUsername;
        private Label labelR;
        private Label labelWelcome;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBox2;
        private Panel panelExpand;
        private Button buttonMinimize;
        private Panel panel4;
        private Button buttonLogOut;
        private Button buttonAttendence;
        private Button buttonReport;
        private System.Windows.Forms.Timer timerDateAndTime;
    }
}