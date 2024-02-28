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
using System.Configuration;
using Attendence_Management.PAL.Forms;
using AdminForm;

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
           
        
            List<user> Users = xmloperators.DeserializeXmlFileToList();
            user validatedUser;

            if (ValidateLogin(out validatedUser))
            {
                int index = Users.IndexOf(validatedUser);
                if (validatedUser.Rr == role.Admin)
                {
                    admin adminForm = new admin(validatedUser.Name);
                    adminForm.Text = "hello"+Users[index].Name + Users[index].Rr.ToString() ;
                    adminForm.Name = Users[index].Name;
                    adminForm.Show();
                    //this.Close();
                   
                }
                else if((validatedUser.Rr == role.Teacher))
                {
                    FormTeacher teacherForm = new FormTeacher(validatedUser.Name,validatedUser.Rr.ToString());
                    teacherForm.Text = "hello" + Users[index].Name + Users[index].Rr.ToString();
                    teacherForm.Show();
                    //this.Close();
                }
                else if ((validatedUser.Rr == role.Student))
                {
                    StudentForm studentForm = new StudentForm(validatedUser);
                    studentForm.Text = "hello" + Users[index].Name + Users[index].Rr.ToString();
                    studentForm.Show();
                    //this.Close();
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
            List<user> Users = xmloperators.DeserializeXmlFileToList();
            foreach (user user in Users)
            {
                if (user != null && textBoxPassword.Text == user.Password && textBoxEmail.Text == user.Email)
                {
                    _user = (user)user.Clone();
                    return true;
                }
            }
            _user = null;
            return false;
        }


        public user getCurrentUserInformation()
        {
            user Currentuser = new user();
            ValidateLogin(out Currentuser);
            return Currentuser;
        }
    }
}
