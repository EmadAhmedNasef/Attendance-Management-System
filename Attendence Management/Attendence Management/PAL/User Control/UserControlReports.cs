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

namespace Attendence_Management.PAL.User_Control
{
    public partial class UserControlReports : UserControl
    {
        public UserControlReports()
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

                    // Check if the checkbox column already exists
                    DataGridViewCheckBoxColumn checkBoxColumn = (DataGridViewCheckBoxColumn)dataGridViewMarkAttendance.Columns["AttendanceColumn"];
                    bool checkboxColumnExists = checkBoxColumn != null;

                    foreach (XmlNode record in records)
                    {
                        XmlNode classNode = record.SelectSingleNode(".//class");
                        string className = classNode.Attributes["name"].Value;

                        if (className == comboBoxClass.SelectedItem.ToString())
                        {
                            XmlNode dateNode = record.SelectSingleNode(".//date");
                            DateTime recordDate;
                            if (DateTime.TryParse(dateNode.InnerText, out recordDate))
                            {
                                if (recordDate.Date == dateTimePickerDate.Value.Date)
                                {


                                    XmlNodeList studentNodes = classNode.SelectNodes(".//Student");

                                    foreach (XmlNode studentNode in studentNodes)
                                    {
                                        string studentID = studentNode.SelectSingleNode("studentID").InnerText;
                                        string studentName = studentNode.SelectSingleNode("studentname").InnerText;
                                        string status = studentNode.SelectSingleNode("status").InnerText;
                                        int rowIndex = dataGridViewMarkAttendance.Rows.Add(studentName, studentID, className, status);
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }













        private void ExportToHtml(DataGridView dataGridView, string htmlFilePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(htmlFilePath))
                {
                    sw.WriteLine("<html>");
                    sw.WriteLine("<head>");
                    sw.WriteLine("<title>Student Attendance</title>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<table border='1'>");

                    // Add headers to the table
                    sw.WriteLine("<tr>");
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        sw.WriteLine("<th>" + column.HeaderText + "</th>");
                    }
                    sw.WriteLine("</tr>");

                    // Add data to the table
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        sw.WriteLine("<tr>");
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            sw.WriteLine("<td>" + cell.Value.ToString() + "</td>");
                        }
                        sw.WriteLine("</tr>");
                    }

                    sw.WriteLine("</table>");
                    sw.WriteLine("</body>");
                    sw.WriteLine("</html>");
                }

                MessageBox.Show("HTML saved successfully at: " + htmlFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to HTML: " + ex.Message);
            }
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            string htmlFilePath = @"C:\Users\Nasef\Desktop\Project\Attendence Management\StudentAttendance.html";
            ExportToHtml(dataGridViewMarkAttendance, htmlFilePath);
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
