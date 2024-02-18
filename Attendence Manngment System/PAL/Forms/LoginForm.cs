using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace Attendence_Manngment_System.PAL.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            InvalidLogin.Hide();
            pictureBoxHide.Hide();
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show password");
        }
        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();

        }

        private void pictureBoxHide_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide password");
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();
        }

        private void picBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxClose, "Close");
        }

        private void picBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxMinimize, "Minimize");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            List<user> Users = xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
            user validatedUser;
            if (ValidateLogin(out validatedUser))
            {
                int index = Users.IndexOf(validatedUser);
                if (validatedUser.Rr == role.Admin)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Text = "hello"+Users[index].Name + Users[index].Rr.ToString() ;
                    adminForm.ShowDialog();
                   
                }
                else if((validatedUser.Rr == role.Teacher))
                {
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.Text = "hello" + Users[index].Name + Users[index].Rr.ToString();
                    teacherForm.ShowDialog();
                }
                else if ((validatedUser.Rr == role.Student))
                {
                    StudentForm studentForm = new StudentForm();
                    studentForm.Text = "hello" + Users[index].Name + Users[index].Rr.ToString();
                    studentForm.ShowDialog();
                }
                textBoxPassword.Text = string.Empty;
                textBoxEmail.Text = string.Empty;


            }
                else
                {
                    InvalidLogin.Show();
                textBoxPassword.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
            }
        }
        private bool ValidateLogin(out user _user)
        {
            List<user>Users = xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
            foreach(user user in Users)
            {
                if ((textBoxPassword.Text== user.Password) && (textBoxEmail.Text == user.Email))
                {
                    //MessageBox.Show($"{user.Password},{user.Email}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _user = (user)user.Clone();
                    return true;
                    
                }
            }
            _user = null;
            return false;
           
          
        }
    }
}
