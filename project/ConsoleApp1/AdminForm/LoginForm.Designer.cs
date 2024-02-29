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
            Language = new Label();
            English = new RadioButton();
            Arabic = new RadioButton();
            التحويلاللياللغهالانجليزيهToolStripMenuItem = new ToolStripMenuItem();
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
            resources.ApplyResources(picBoxClose, "picBoxClose");
            picBoxClose.BorderStyle = BorderStyle.FixedSingle;
            picBoxClose.Name = "picBoxClose";
            picBoxClose.TabStop = false;
            toolTip1.SetToolTip(picBoxClose, resources.GetString("picBoxClose.ToolTip"));
            picBoxClose.Click += picBoxClose_Click;
            picBoxClose.MouseHover += picBoxClose_MouseHover;
            // 
            // picBoxMaxmizie
            // 
            resources.ApplyResources(picBoxMaxmizie, "picBoxMaxmizie");
            picBoxMaxmizie.BorderStyle = BorderStyle.FixedSingle;
            picBoxMaxmizie.Name = "picBoxMaxmizie";
            picBoxMaxmizie.TabStop = false;
            toolTip1.SetToolTip(picBoxMaxmizie, resources.GetString("picBoxMaxmizie.ToolTip"));
            // 
            // picBoxMinimize
            // 
            resources.ApplyResources(picBoxMinimize, "picBoxMinimize");
            picBoxMinimize.BorderStyle = BorderStyle.FixedSingle;
            picBoxMinimize.Name = "picBoxMinimize";
            picBoxMinimize.TabStop = false;
            toolTip1.SetToolTip(picBoxMinimize, resources.GetString("picBoxMinimize.ToolTip"));
            picBoxMinimize.Click += picBoxMinimize_Click;
            picBoxMinimize.MouseHover += picBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(InvalidLogin);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(lblusername);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            toolTip1.SetToolTip(groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // InvalidLogin
            // 
            resources.ApplyResources(InvalidLogin, "InvalidLogin");
            InvalidLogin.ForeColor = Color.Red;
            InvalidLogin.Name = "InvalidLogin";
            toolTip1.SetToolTip(InvalidLogin, resources.GetString("InvalidLogin.ToolTip"));
            // 
            // pictureBoxHide
            // 
            resources.ApplyResources(pictureBoxHide, "pictureBoxHide");
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.TabStop = false;
            toolTip1.SetToolTip(pictureBoxHide, resources.GetString("pictureBoxHide.ToolTip"));
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover_1;
            // 
            // pictureBoxShow
            // 
            resources.ApplyResources(pictureBoxShow, "pictureBoxShow");
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.TabStop = false;
            toolTip1.SetToolTip(pictureBoxShow, resources.GetString("pictureBoxShow.ToolTip"));
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.Bisque;
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Name = "btnLogin";
            toolTip1.SetToolTip(btnLogin, resources.GetString("btnLogin.ToolTip"));
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(textBoxPassword, "textBoxPassword");
            textBoxPassword.Name = "textBoxPassword";
            toolTip1.SetToolTip(textBoxPassword, resources.GetString("textBoxPassword.ToolTip"));
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(textBoxEmail, "textBoxEmail");
            textBoxEmail.Name = "textBoxEmail";
            toolTip1.SetToolTip(textBoxEmail, resources.GetString("textBoxEmail.ToolTip"));
            // 
            // lblusername
            // 
            resources.ApplyResources(lblusername, "lblusername");
            lblusername.Name = "lblusername";
            toolTip1.SetToolTip(lblusername, resources.GetString("lblusername.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            toolTip1.SetToolTip(groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Blue;
            label3.Name = "label3";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // Language
            // 
            resources.ApplyResources(Language, "Language");
            Language.Name = "Language";
            toolTip1.SetToolTip(Language, resources.GetString("Language.ToolTip"));
            // 
            // English
            // 
            resources.ApplyResources(English, "English");
            English.Name = "English";
            English.TabStop = true;
            toolTip1.SetToolTip(English, resources.GetString("English.ToolTip"));
            English.UseVisualStyleBackColor = true;
            English.Location = new Point(250,64);
            English.Text = "English";
            English.CheckedChanged += English_CheckedChanged;
            
            // 
            // Arabic
            // 
            resources.ApplyResources(Arabic, "Arabic");
            Arabic.Name = "Arabic";
            Arabic.TabStop = true;
            toolTip1.SetToolTip(Arabic, resources.GetString("Arabic.ToolTip"));
            Arabic.UseVisualStyleBackColor = true;
            Arabic.Location = new Point(400, 64);
            Arabic.Text = "Arabic";  
            Arabic.CheckedChanged += Arabic_CheckedChanged;
            // 
        
            // 
          
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Arabic);
            Controls.Add(English);
            Controls.Add(Language);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(picBoxMinimize);
            Controls.Add(picBoxMaxmizie);
            Controls.Add(picBoxClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private ToolStripMenuItem التحويلاللياللغهالانجليزيهToolStripMenuItem;
        private Label Language;
        private RadioButton English;
        private RadioButton Arabic;
    }
}