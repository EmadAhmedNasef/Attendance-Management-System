namespace Attendence_Manngment_System.PAL.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            picBoxClose = new PictureBox();
            picBoxMaxmizie = new PictureBox();
            picBoxMinimize = new PictureBox();
            groupBox1 = new GroupBox();
            InvalidLogin = new Label();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            btnLogin = new Button();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxEmail = new TextBox();
            lblusername = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMaxmizie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            SuspendLayout();
            // 
            // picBoxClose
            // 
            picBoxClose.BorderStyle = BorderStyle.FixedSingle;
            picBoxClose.Image = (Image)resources.GetObject("picBoxClose.Image");
            picBoxClose.Location = new Point(1330, 12);
            picBoxClose.Margin = new Padding(0);
            picBoxClose.Name = "picBoxClose";
            picBoxClose.Size = new Size(31, 31);
            picBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxClose.TabIndex = 0;
            picBoxClose.TabStop = false;
            picBoxClose.Click += picBoxClose_Click;
            picBoxClose.MouseHover += picBoxClose_MouseHover;
            // 
            // picBoxMaxmizie
            // 
            picBoxMaxmizie.BorderStyle = BorderStyle.FixedSingle;
            picBoxMaxmizie.ErrorImage = (Image)resources.GetObject("picBoxMaxmizie.ErrorImage");
            picBoxMaxmizie.Image = (Image)resources.GetObject("picBoxMaxmizie.Image");
            picBoxMaxmizie.Location = new Point(846, 232);
            picBoxMaxmizie.Name = "picBoxMaxmizie";
            picBoxMaxmizie.Size = new Size(355, 294);
            picBoxMaxmizie.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxMaxmizie.TabIndex = 1;
            picBoxMaxmizie.TabStop = false;
            // 
            // picBoxMinimize
            // 
            picBoxMinimize.BorderStyle = BorderStyle.FixedSingle;
            picBoxMinimize.ErrorImage = (Image)resources.GetObject("picBoxMinimize.ErrorImage");
            picBoxMinimize.Image = (Image)resources.GetObject("picBoxMinimize.Image");
            picBoxMinimize.Location = new Point(1291, 12);
            picBoxMinimize.Name = "picBoxMinimize";
            picBoxMinimize.Size = new Size(31, 31);
            picBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxMinimize.TabIndex = 2;
            picBoxMinimize.TabStop = false;
            picBoxMinimize.Click += picBoxMinimize_Click;
            picBoxMinimize.MouseHover += picBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InvalidLogin);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(lblusername);
            groupBox1.Location = new Point(254, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 348);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login First";
            // 
            // InvalidLogin
            // 
            InvalidLogin.AutoSize = true;
            InvalidLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvalidLogin.ForeColor = Color.Red;
            InvalidLogin.Location = new Point(126, 250);
            InvalidLogin.Name = "InvalidLogin";
            InvalidLogin.Size = new Size(249, 23);
            InvalidLogin.TabIndex = 7;
            InvalidLogin.Text = "invalid username or password";
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.ErrorImage = (Image)resources.GetObject("pictureBoxHide.ErrorImage");
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(421, 196);
            pictureBoxHide.Margin = new Padding(0);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(34, 27);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 6;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover_1;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.ErrorImage = (Image)resources.GetObject("pictureBoxShow.ErrorImage");
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(421, 196);
            pictureBoxShow.Margin = new Padding(0);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(34, 27);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 5;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Bisque;
            btnLogin.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(147, 288);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(201, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(64, 196);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(354, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 150);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 2;
            label1.Text = "Password :";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(64, 103);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(354, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(64, 59);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(64, 23);
            lblusername.TabIndex = 0;
            lblusername.Text = "Email :";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(795, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(10, 441);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(846, 534);
            label3.Name = "label3";
            label3.Size = new Size(369, 31);
            label3.TabIndex = 8;
            label3.Text = "Attendencd Management System";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1334, 825);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(picBoxMinimize);
            Controls.Add(picBoxMaxmizie);
            Controls.Add(picBoxClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMaxmizie).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxClose;
        private PictureBox picBoxMaxmizie;
        private PictureBox picBoxMinimize;
        private GroupBox groupBox1;
        private TextBox textBoxEmail;
        private Label lblusername;
        private Label label1;
        private PictureBox pictureBoxShow;
        private Button btnLogin;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxHide;
        private Label InvalidLogin;
        private GroupBox groupBox2;
        private Label label3;
        private ToolTip toolTip1;
    }
}