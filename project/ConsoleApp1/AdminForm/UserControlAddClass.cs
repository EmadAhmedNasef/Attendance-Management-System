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
using System.Text.RegularExpressions;

namespace AdminForm
{
    public partial class UserControlAddClass : UserControl
    {
        public role role;
        public classes cls;
        List<user> li = xmloperators.DeserializeXmlFileToList();
        private List<user> searched = new List<user>();
        public UserControlAddClass()
        {
            InitializeComponent();
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBox1, "Search");
        }


        //matching operations
        private bool matchName()
        {
            string patternName = @"^[a-zA-Z ]{3,50}$";
            bool m = Regex.IsMatch(textBoxName.Text, patternName);
            if (!m)
            {
                DialogResult dialogResult = MessageBox.Show("Enter a valid Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return m;
        }
        private bool MatchEmail()
        {
            string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; ;
            bool m = Regex.IsMatch(textBoxEmail.Text, patternEmail);
            if (!m)
            {
                DialogResult dialogResult = MessageBox.Show("Enter a Valid Email", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return m;
        }
        private bool MathcPassword()
        {
            string patternpassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            bool m = Regex.IsMatch(textBoxPassword.Text, patternpassword);
            if (!m)
            {
                DialogResult dialogResult = MessageBox.Show("Enter a Valid Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return m;
        }
        private bool matchroleandclass()
        {
            if (comboBoxRole.SelectedIndex != -1
                && comboBoxClass.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please enter a role and class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {

            if (matchName() && MatchEmail()
                && MathcPassword()
                && operations.matchingEmail(textBoxEmail.Text, textBoxPassword.Text)
                && matchroleandclass())
            {
                Adminoperation.AddNewUser(textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, role, cls);
                DialogResult dialogResult = MessageBox.Show("operation done successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxName.Text = "";
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                comboBoxRole.SelectedIndex = -1;
                comboBoxClass.SelectedIndex = -1;
            }


        }
        // combo box operations
        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedIndex == 0) { role = role.Student; }
            if (comboBoxRole.SelectedIndex == 1) { role = role.Teacher; }
            if (comboBoxRole.SelectedIndex == 2) { role = role.Admin; }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex == 0) { cls = classes.Math; }
            if (comboBoxClass.SelectedIndex == 1) { cls = classes.English; }
        }

     
        // function to show all the data
        private void showalluser()
        {
            dataGridViewUsers.Rows.Clear();
            searched.AddRange(li);
            for (int i = 0; i < searched.Count; i++)
            {
                dataGridViewUsers.Rows.Add(searched[i].Id, searched[i].Name, searched[i].Email, searched[i].Password, searched[i].primaryClass, searched[i].Rr);
            }
            labelNumberofUsers.Text = searched.Count.ToString();
        }
        private void tabPageShow_Enter(object sender, EventArgs e)
        {
            showalluser();
        }


        private void tabPageShow_Leave(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.Clear();
        }



        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.Clear();
            role rr;
            searched = li.Where(n =>
            {
                bool s = false;
                if (Enum.TryParse(textBoxSearch.Text, out rr))
                {
                    if (rr == n.Rr)
                    { s = true; }
                }
                return n.Name.Contains(textBoxSearch.Text) || s;
            }).ToList();

            for (int i = 0; i < searched.Count; i++)
            {
                dataGridViewUsers.Rows.Add(searched[i].Id, searched[i].Name, searched[i].Email, searched[i].Password, searched[i].primaryClass, searched[i].Rr);
            }
            labelNumberofUsers.Text = searched.Count.ToString();
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];


                textBoxName1.Text = selectedRow.Cells[1].Value.ToString();
                textBoxEmail1.Text = selectedRow.Cells[2].Value.ToString();
                textBoxPassword1.Text = selectedRow.Cells[3].Value.ToString();
                comboBoxClass1.SelectedItem = selectedRow.Cells[4].Value.ToString();
                comboBoxRole1.SelectedItem = selectedRow.Cells[5].Value.ToString();

            }
        }
    }
}
