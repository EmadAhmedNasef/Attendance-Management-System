using ClassLibrary1;
using System.Data;
using System.Text.RegularExpressions;

namespace AdminForm
{
    public partial class UserControlAddClass : UserControl
    {
        public role role;
        public classes cls;
        List<user> li = xmloperators.DeserializeXmlFileToList();
        private List<user> searched = new List<user>();
        private int id_;
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
        //add user button
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
            searched.Clear();
            searched.AddRange(li);
            for (int i = 0; i < searched.Count; i++)
            {
                dataGridViewUsers.Rows.Add(searched[i].Id, searched[i].Name, searched[i].Email, searched[i].Password, searched[i].primaryClass, searched[i].Rr);
            }
            labelNumberofUsers.Text = searched.Count.ToString();
        }
        private void tabPageShow_Enter(object sender, EventArgs e)
        {
            li.Clear();
            li.AddRange(xmloperators.DeserializeXmlFileToList());
            showalluser();
        }


        private void tabPageShow_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            //dataGridViewUsers.Rows.Clear();
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
        //selected user from data grid view
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewUsers.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];

                id_ = (int)selectedRow.Cells[0].Value;
                textBoxName1.Text = selectedRow.Cells[1].Value.ToString();
                textBoxEmail1.Text = selectedRow.Cells[2].Value.ToString();
                textBoxPassword1.Text = selectedRow.Cells[3].Value.ToString();
                comboBoxClass1.SelectedItem = selectedRow.Cells[4].Value.ToString();
                comboBoxRole1.SelectedItem = selectedRow.Cells[5].Value.ToString();

                if (selectedRow.Cells[5].Value.ToString() == "Admin")
                {
                    label11.Hide();
                    comboBoxClass1.Hide();
                    panel7.Hide();
                }
                else
                {
                    label11.Show();
                    comboBoxClass1.Show();
                    panel7.Show();
                }
                role = (role)Enum.Parse(typeof(role), selectedRow.Cells[5].Value.ToString());

            }
        }

        // edit button
        private bool matchName1()
        {
            string patternName = @"^[a-zA-Z ]{3,50}$";
            bool m = Regex.IsMatch(textBoxName1.Text, patternName);
            if (!m)
            {
                DialogResult dialogResult = MessageBox.Show("Enter a valid Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return m;
        }
        private bool MatchEmail1()
        {
            string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; ;
            bool m = Regex.IsMatch(textBoxEmail1.Text, patternEmail);
            if (!m)
            {
                DialogResult dialogResult = MessageBox.Show("Enter a Valid Email", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return m;
        }
        private bool MathcPassword1()
        {
            string patternpassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            bool m = Regex.IsMatch(textBoxPassword1.Text, patternpassword);
            if (!m)
            {
                DialogResult dialogResult = MessageBox.Show("Enter a Valid Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return m;
        }

        private bool selecteditem()
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please select a user first", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private bool lastofKind(role rr, int ind)
        {
            List<user> li = xmloperators.DeserializeXmlFileToList();
            if (li[ind].Rr == role.Student || operations.lastuser(li[ind].Rr) || li[ind].Rr == rr)
            {
                return true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("We can't Edit the role for this user currently", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        //actual edit button
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            List<user> li = xmloperators.DeserializeXmlFileToList();
            int index = operations.search(id_);
            if (selecteditem() &&
                matchName1() && MatchEmail1()
                && MathcPassword1()
                && lastofKind(role, index)
                //&& operations.matchingEmail(textBoxEmail1.Text, textBoxPassword1.Text)
                )
            {
                li[index].Name = textBoxName1.Text;
                li[index].Email = textBoxEmail1.Text;
                li[index].Password = textBoxPassword1.Text;
                li[index].primaryClass = cls;
                li[index].Rr = role;
                DialogResult dialogResult = MessageBox.Show("operation Done Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xmloperators.changingxml(li);
            }
        }


        //delete button
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                int index = operations.search(id_);
                if (dialogResult == DialogResult.Yes)
                {
                    if (role == role.Admin && !operations.lastuser(role.Admin))
                    {
                        DialogResult dialogResult1 = MessageBox.Show("Sorry we Can't Delete Last Admin", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Adminoperation.RemoveUser(index);
                        textBoxName1.Text = "";
                        textBoxEmail1.Text = "";
                        textBoxPassword1.Text = "";
                        comboBoxClass1.SelectedIndex = -1;
                        comboBoxRole1.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please select a user", "error", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }

        private void comboBoxRole1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole1.SelectedIndex == 0) 
            { 
                role = role.Student;
                label11.Show();
                comboBoxClass1.Show();
                panel7.Show();
            }
            if (comboBoxRole1.SelectedIndex == 1) 
            {
                role = role.Teacher;
                label11.Show();
                comboBoxClass1.Show();
                panel7.Show();
            }
            if (comboBoxRole1.SelectedIndex == 2)
            {
                role = role.Admin;
                label11.Hide();
                comboBoxClass1.Hide();
                panel7.Hide();
            }
        }

        private void comboBoxClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex == 0) { cls = classes.Math; }
            if (comboBoxClass1.SelectedIndex == 1)
            {
                cls = classes.English;
            }
        }
    }
}
