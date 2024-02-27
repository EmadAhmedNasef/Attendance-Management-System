using ClassLibrary1;

namespace AdminForm
{
    public partial class admin : Form
    {

        public string username = "abdellatief";
        public role role = role.Admin;
        public admin()
        {
            InitializeComponent();
            timerDateAndTime.Start();


        }

        private void buttonMiniMize_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            this.WindowState = FormWindowState.Minimized;
            //WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }
        private void moveSidePanel(Control button)
        {
            panelSide.Location = new Point(0, button.Location.Y - 180);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want to log out ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panel4.Hide();
            }
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panel4.Visible)
            {
                panel4.Hide();
            }
            else
            {
                panel4.Show();
            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            userControlClass1.Visible = false;
            userControlAddClass1.Visible = true;
            moveSidePanel(buttonUsers);
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            userControlClass1.Visible = true;
            userControlAddClass1.Visible = false;
            moveSidePanel(buttonClasses);
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            userControlClass1.Visible = false;
            userControlAddClass1.Visible = false;
            moveSidePanel(buttonAttendance);
        }

        private void buttonRepots_Click(object sender, EventArgs e)
        {
            userControlClass1.Visible = false;
            userControlAddClass1.Visible = false;
            moveSidePanel(buttonRepots);
        }

        private void admin_Load(object sender, EventArgs e)
        {
            panel4.Hide();
            labelUserName.Text = username;
            labelRole.Text = role.ToString();

            if (role == role.Student)
            {
                buttonUsers.Hide();
                buttonClasses.Hide();
            }
        }
    }
}
