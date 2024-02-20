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

namespace AdminForm
{
    public partial class UserControlClass : UserControl
    {
        classes cls;
        List<user> li = new List<user>();
        List<user> search = new List<user>();
        List<user> ll = new List<user>();
        public UserControlClass()
        {
            InitializeComponent();
            comboBoxClass.SelectedIndex = 0;
            cls = classes.Math;
        }
        public void showusers(classes cc)
        {

            dataGridViewUsers.Rows.Clear();
            search.Clear();
            search.AddRange(li);
            search = search.Where(n =>
            {
                return n.primaryClass == cc;
            }).ToList();
            for (int i = 0; i < search.Count; i++)
            {
                dataGridViewUsers.Rows.Add(search[i].Id, search[i].Name, search[i].Email, search[i].Password, search[i].Rr);
            }
            labelNumberofUsers.Text = search.Count.ToString();
        }
        private void UserControlClass_Load(object sender, EventArgs e)
        {
            showusers(cls);
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex == 0)
            {
                cls = classes.Math;
                showusers(cls);
            }
            else if (comboBoxClass.SelectedIndex == 1)
            {
                cls = classes.English;
                showusers(cls);
            }
            textBoxSearch.Text = "";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.Clear();
            ll.Clear();
            ll = search.Where(n =>
            {
                return n.Name.Contains(textBoxSearch.Text);
            }).ToList();
            for (int i = 0; i < ll.Count; i++)
            {
                dataGridViewUsers.Rows.Add(ll[i].Id, ll[i].Name, ll[i].Email, ll[i].Password, ll[i].Rr);
            }
            labelNumberofUsers.Text = ll.Count.ToString();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            li = xmloperators.DeserializeXmlFileToList();
            cls = classes.Math;
            showusers(cls);
        }
    }
}
