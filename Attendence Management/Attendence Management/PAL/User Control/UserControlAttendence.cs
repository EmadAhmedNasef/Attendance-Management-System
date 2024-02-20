using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Attendence_Management.PAL.User_Control
{
    public partial class UserControlAttendence : UserControl
    {
        public UserControlAttendence()
        {
            InitializeComponent();
            LoadClassNames();

        }

        private void LoadClassNames()
        {
            string xmlFilePath = @"C:\Users\Nasef\Desktop\Project\XML\records.xml";

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlFilePath);

                XmlNodeList classNodes = xmlDocument.SelectNodes("//class");
                if (classNodes != null)
                {
                    foreach (XmlNode classNode in classNodes)
                    {
                        string className = classNode.Attributes["name"].Value;
                        comboBoxClass.Items.Add(className);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string xmlFilePath = @"C:\Users\Nasef\Desktop\Project\XML\records.xml";

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlFilePath);

                XmlNodeList records = xmlDocument.SelectNodes("//record");
                if (records != null)
                {
                    dataGridViewMarkAttendance.Rows.Clear();
                    foreach (XmlNode record in records)
                    {
                        XmlNode classNode = record.SelectSingleNode(".//class");
                        string className = classNode.Attributes["name"].Value;

                        if (className == comboBoxClass.SelectedItem.ToString())
                        {
                            XmlNodeList studentNodes = classNode.SelectNodes(".//Student");
                            foreach (XmlNode studentNode in studentNodes)
                            {
                                string studentID = studentNode.SelectSingleNode("studentID").InnerText;
                                string studentName = studentNode.SelectSingleNode("studentname").InnerText;
                                string status = studentNode.SelectSingleNode("status").InnerText;

                                dataGridViewMarkAttendance.Rows.Add(studentName, studentID, className, status);
                            }
                            break; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }

        private void dataGridViewMarkAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }










    }
}
