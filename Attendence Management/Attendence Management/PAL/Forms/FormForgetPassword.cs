using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Attendence_Management.PAL.Forms
{
    public partial class FormForgetPassword : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public FormForgetPassword(string username, string password)
        {
            InitializeComponent();

            // Populate the text boxes with the username and password
            textBox1.Text = username;
            textBox2.Text = password;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password from the text boxes
            Username = textBox1.Text;
            Password = textBox2.Text;

            // Validate username and password (optional)

            // Set the DialogResult to OK to indicate the form was submitted successfully
            DialogResult = DialogResult.OK;

            // Close the form
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
