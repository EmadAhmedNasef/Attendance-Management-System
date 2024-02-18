namespace Attendence_Management.PAL.Forms
{
    partial class FormForgetPassword
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
            userName = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(250, 213);
            userName.Name = "userName";
            userName.Size = new Size(81, 20);
            userName.TabIndex = 0;
            userName.Text = "UserName:";
            userName.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 287);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            label2.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 319);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // FormForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(userName);
            Name = "FormForgetPassword";
            Text = "FormForgetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userName;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}