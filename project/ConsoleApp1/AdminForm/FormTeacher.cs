using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Attendence_Management.PAL.Forms;
using Attendence_Management.PAL.User_Control;

namespace Attendence_Management.PAL.Forms
{
    public partial class FormTeacher : Form
    {
        public string Username, Role;

        public FormTeacher(string username, string role)
        {
            InitializeComponent();
            timerDateAndTime.Start();
            Username = username;
            Role = role;
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            var userControlAttendence = new UserControlAttendence();
            userControlAttendence.Dock = DockStyle.Fill;
            Controls.Add(userControlAttendence);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure to Logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
                Application.Exit();
            }
            else
            {
                panelExpand.Hide();
            }
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");

        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else { panelExpand.Visible = true; }
        }

        private void userControlAttendence1_Load(object sender, EventArgs e)
        {

        }
        private void userControlReports2_Load(object sender, EventArgs e)
        {

        }




        private void buttonAttendence_Click(object sender, EventArgs e)
        {
            userControlAttendence1.Visible = true;
            userControlReports2.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            userControlAttendence1.Visible = false;
            userControlReports2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
