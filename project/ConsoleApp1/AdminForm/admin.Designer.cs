using ClassLibrary1;
namespace AdminForm
{
    partial class admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            panel1 = new Panel();
            buttonRepots = new Button();
            buttonAttendance = new Button();
            buttonClasses = new Button();
            buttonUsers = new Button();
            panel6 = new Panel();
            panelSide = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PanelBack = new Panel();
            pictureBoxExpand = new PictureBox();
            panel4 = new Panel();
            button2 = new Button();
            buttonMiniMize = new Button();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            panelTop = new Panel();
            labelRole = new Label();
            label7 = new Label();
            labelUserName = new Label();
            label4 = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            userControlAddClass1 = new UserControlAddClass();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(buttonRepots);
            panel1.Controls.Add(buttonAttendance);
            panel1.Controls.Add(buttonClasses);
            panel1.Controls.Add(buttonUsers);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 681);
            panel1.TabIndex = 0;
            // 
            // buttonRepots
            // 
            buttonRepots.Dock = DockStyle.Top;
            buttonRepots.FlatAppearance.BorderSize = 0;
            buttonRepots.FlatStyle = FlatStyle.Flat;
            buttonRepots.ForeColor = Color.White;
            buttonRepots.Image = (Image)resources.GetObject("buttonRepots.Image");
            buttonRepots.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRepots.Location = new Point(8, 321);
            buttonRepots.Name = "buttonRepots";
            buttonRepots.Size = new Size(250, 47);
            buttonRepots.TabIndex = 0;
            buttonRepots.Text = "Reports";
            buttonRepots.UseVisualStyleBackColor = true;
            buttonRepots.Click += buttonRepots_Click;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Dock = DockStyle.Top;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Image = (Image)resources.GetObject("buttonAttendance.Image");
            buttonAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.Location = new Point(8, 274);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(250, 47);
            buttonAttendance.TabIndex = 0;
            buttonAttendance.Text = "Attendance";
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // buttonClasses
            // 
            buttonClasses.Dock = DockStyle.Top;
            buttonClasses.FlatAppearance.BorderSize = 0;
            buttonClasses.FlatStyle = FlatStyle.Flat;
            buttonClasses.ForeColor = Color.White;
            buttonClasses.Image = (Image)resources.GetObject("buttonClasses.Image");
            buttonClasses.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClasses.Location = new Point(8, 227);
            buttonClasses.Name = "buttonClasses";
            buttonClasses.Size = new Size(250, 47);
            buttonClasses.TabIndex = 0;
            buttonClasses.Text = "Classes";
            buttonClasses.UseVisualStyleBackColor = true;
            buttonClasses.Click += buttonClasses_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Dock = DockStyle.Top;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.ForeColor = Color.White;
            buttonUsers.Image = Properties.Resources.user1;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(8, 180);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(250, 47);
            buttonUsers.TabIndex = 0;
            buttonUsers.Text = "Users";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(panelSide);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(8, 501);
            panel6.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(8, 47);
            panelSide.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(264, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 0;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 106);
            label1.Name = "label1";
            label1.Size = new Size(212, 19);
            label1.TabIndex = 0;
            label1.Text = "Attendance Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.students;
            pictureBox1.Location = new Point(81, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PanelBack
            // 
            PanelBack.Controls.Add(pictureBoxExpand);
            PanelBack.Controls.Add(panel4);
            PanelBack.Controls.Add(pictureBox2);
            PanelBack.Controls.Add(labelTime);
            PanelBack.Controls.Add(panelTop);
            PanelBack.Dock = DockStyle.Top;
            PanelBack.Location = new Point(258, 0);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(926, 165);
            PanelBack.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(796, 34);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(27, 24);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 4;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(buttonMiniMize);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(730, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 107);
            panel4.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(67, 3, 125);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 53);
            button2.Name = "button2";
            button2.Size = new Size(198, 48);
            button2.TabIndex = 0;
            button2.Text = "    Log Out";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonMiniMize
            // 
            buttonMiniMize.BackColor = Color.White;
            buttonMiniMize.Dock = DockStyle.Top;
            buttonMiniMize.FlatAppearance.BorderSize = 0;
            buttonMiniMize.FlatStyle = FlatStyle.Flat;
            buttonMiniMize.Font = new Font("Century Gothic", 12F);
            buttonMiniMize.ForeColor = Color.FromArgb(67, 3, 125);
            buttonMiniMize.Image = (Image)resources.GetObject("buttonMiniMize.Image");
            buttonMiniMize.Location = new Point(0, 5);
            buttonMiniMize.Name = "buttonMiniMize";
            buttonMiniMize.Size = new Size(198, 48);
            buttonMiniMize.TabIndex = 0;
            buttonMiniMize.Text = "    Minimize";
            buttonMiniMize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMiniMize.UseVisualStyleBackColor = false;
            buttonMiniMize.Click += buttonMiniMize_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(198, 5);
            panel5.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.audience;
            pictureBox2.Location = new Point(730, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.ForeColor = Color.FromArgb(255, 128, 0);
            labelTime.Location = new Point(24, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(28, 19);
            labelTime.TabIndex = 0;
            labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(255, 128, 0);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label7);
            panelTop.Controls.Add(labelUserName);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 65);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(926, 100);
            panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(233, 60);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(28, 19);
            labelRole.TabIndex = 0;
            labelRole.Text = "{?}";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 60);
            label7.Name = "label7";
            label7.Size = new Size(46, 19);
            label7.TabIndex = 0;
            label7.Text = "Role:";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.ForeColor = Color.White;
            labelUserName.Location = new Point(233, 22);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(28, 19);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "{?}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 22);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 0;
            label4.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // userControlAddClass1
            // 
            userControlAddClass1.BackColor = Color.White;
            userControlAddClass1.Dock = DockStyle.Fill;
            userControlAddClass1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            userControlAddClass1.Location = new Point(258, 165);
            userControlAddClass1.Name = "userControlAddClass1";
            userControlAddClass1.Size = new Size(926, 516);
            userControlAddClass1.TabIndex = 0;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            Controls.Add(userControlAddClass1);
            Controls.Add(PanelBack);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += admin_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelBack.ResumeLayout(false);
            PanelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel3;
        private Panel PanelBack;
        private Panel panelTop;
        private PictureBox pictureBox2;
        private Label labelTime;
        private Label labelRole;
        private Label label7;
        private Label labelUserName;
        private Label label4;
        private PictureBox pictureBoxExpand;
        private Panel panel4;
        private Button buttonMiniMize;
        private Panel panel5;
        private Button button2;
        private Panel panel6;
        private Button buttonUsers;
        private Panel panelSide;
        private Button buttonClasses;
        private Button buttonRepots;
        private Button buttonAttendance;
        private System.Windows.Forms.Timer timerDateAndTime;
        private UserControlAddClass userControlAddClass1;
    }
}
