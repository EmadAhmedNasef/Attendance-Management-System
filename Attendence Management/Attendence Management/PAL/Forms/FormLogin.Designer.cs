namespace Attendence_Management.NewFolder.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxClose = new PictureBox();
            pictureBoxMin = new PictureBox();
            groupBox1 = new GroupBox();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            pictureBoxEXC = new PictureBox();
            textBoxName = new TextBox();
            labelError = new Label();
            label1 = new Label();
            labelFP = new Label();
            UserName = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEXC).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.White;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.Hopstarter_Button_Button_Close_64;
            pictureBoxClose.Location = new Point(1121, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(67, 67);
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBoxMin
            // 
            pictureBoxMin.BackColor = Color.White;
            pictureBoxMin.Cursor = Cursors.Hand;
            pictureBoxMin.Location = new Point(1046, 12);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(60, 67);
            pictureBoxMin.TabIndex = 0;
            pictureBoxMin.TabStop = false;
            pictureBoxMin.Click += pictureBoxMin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(pictureBoxEXC);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelFP);
            groupBox1.Controls.Add(UserName);
            groupBox1.Font = new Font("Century Gothic", 10F);
            groupBox1.Location = new Point(92, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 397);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login First";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(67, 3, 125);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(116, 328);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 40);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(66, 189);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(332, 28);
            textBoxPassword.TabIndex = 2;
            // 
            // pictureBoxEXC
            // 
            pictureBoxEXC.BackColor = Color.White;
            pictureBoxEXC.Cursor = Cursors.Hand;
            pictureBoxEXC.Image = (Image)resources.GetObject("pictureBoxEXC.Image");
            pictureBoxEXC.Location = new Point(66, 236);
            pictureBoxEXC.Name = "pictureBoxEXC";
            pictureBoxEXC.Size = new Size(49, 54);
            pictureBoxEXC.TabIndex = 0;
            pictureBoxEXC.TabStop = false;
            pictureBoxEXC.Visible = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(66, 92);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(332, 28);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 10F);
            labelError.ForeColor = Color.Coral;
            labelError.Location = new Point(121, 258);
            labelError.Name = "labelError";
            labelError.Size = new Size(261, 21);
            labelError.TabIndex = 0;
            labelError.Text = "Invalid UserName or Password";
            labelError.Visible = false;
            labelError.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.Location = new Point(66, 146);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "Password:";
            label1.Click += label1_Click;
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            labelFP.ForeColor = SystemColors.MenuHighlight;
            labelFP.Location = new Point(144, 293);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(152, 19);
            labelFP.TabIndex = 0;
            labelFP.Text = "Forgot Password?";
            labelFP.Click += label2_Click;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            UserName.Location = new Point(66, 59);
            UserName.Name = "UserName";
            UserName.Size = new Size(99, 19);
            UserName.TabIndex = 0;
            UserName.Text = "UserName:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(709, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 450);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(799, 371);
            label2.Name = "label2";
            label2.Size = new Size(307, 21);
            label2.TabIndex = 0;
            label2.Text = "Attendence Managdement System";
            label2.Click += label1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxMin);
            Controls.Add(label2);
            Controls.Add(pictureBoxClose);
            Cursor = Cursors.Hand;
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEXC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMin;
        private GroupBox groupBox1;
        private Button buttonLogin;
        private TextBox textBoxName;
        private Label label1;
        private Label UserName;
        private TextBox textBoxPassword;
        private Label labelError;
        private Label labelFP;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBoxEXC;
    }
}