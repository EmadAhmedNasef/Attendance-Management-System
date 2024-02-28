using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibrary3.YourNamespace;
using ClassLibrary3;
using ClassLibrary1;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

//using iTextSharp.text.pdf;
//using iTextSharp.text;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendence_Manngment_System.PAL.Forms
{
    public partial class StudentForm : Form
    {
        private readonly ClassLibrary1.user currentUser;
        HashSet<string> _classes;
        List<record> _records;
        private DateOnly dateOnly;
        public StudentForm() { }
        public StudentForm(ClassLibrary1.user _currentUser)
        {
            this.currentUser = _currentUser;
            int id = currentUser.Id;
            _records = getRecords(currentUser.Id);
            loadClasses();
            InitializeComponent();
            timerDateAndTime.Start();

            dataGridRecords.Columns.Add("StudentID", "Student ID");
            dataGridRecords.Columns.Add("StudentName", "Student Name");
            dataGridRecords.Columns.Add("Status", "Status");
            dataGridRecords.Columns.Add("ClassName", "Class");
            dataGridRecords.Columns.Add("TeacherName", "Teacher");
            dataGridRecords.Columns.Add("Date", "date");
            comboBoxClass.Items.AddRange(_classes.ToArray());
        }
        private void loadClasses()
        {
            _classes = new HashSet<string>();
            foreach (record record in _records)
            {
                foreach (ClassInfo s in record.ClassInfoList)
                {
                    _classes.Add(s.ClassName);
                }
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value;
            dateOnly = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);

            bool found = false;
            //textBox1.Text = string.Empty;
            //testbox.Text = string.Empty;
            //textBox2.Text = string.Empty;
            //records = getRecords(currentUser.Id);
            dataGridRecords.Rows.Clear();
            foreach (var record in _records)
            {
                if (record.Date == dateOnly)
                {
                    foreach (var classInfo in record.ClassInfoList)
                    {
                        foreach (var student in classInfo.Students)
                        {
                            // Create a new DataGridViewRow
                            DataGridViewRow row = new DataGridViewRow();

                            // Add cells to the row
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = student.Id });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = student.Name });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = student.Status });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = classInfo.ClassName });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = classInfo.Teacher.Name });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = record.Date });

                            // Add the row to the DataGridView
                            dataGridRecords.Rows.Add(row);
                        }
                    }
                }
            }
            //for (int i = 0; i < records.Count; i++)
            //{
            //    if (records[i].Date == dateOnly)
            //    {

            //        for (int j = 0; j < records[i].ClassInfoList.Count; j++)
            //        {

            //            textBox2.Text += records[i].ClassInfoList[j].Teacher.Name;
            //            for (int k = 0; k < records[i].ClassInfoList[j].Students.Count; k++)
            //            {
            //                testbox.Text += records[i].ClassInfoList[j].Students[k].ToString();
            //                found = true;
            //                // break;
            //            }

            //        }
            //    }
            //}

            //if (!found)
            //{
            //    testbox.Text = ""; 
            //}

        }

        public List<record> getRecords(int id)
        {
            List<record> records = new List<record>();
            string filepath = @"C:\Users\Nasef\Desktop\Attendance-Management-System-abdellatief\XML\record.xml";
            XDocument doc = XDocument.Load(filepath);

            var query = from record in doc.Descendants("record")
                        let dateElements = record.Element("date").Value.Split('/')
                        let date = new DateOnly(int.Parse(dateElements[0]), int.Parse(dateElements[1]), int.Parse(dateElements[2]))
                        from cls in record.Descendants("class")
                        let className = (string)cls.Attribute("name")
                        let teacherName = (string)cls.Descendants("teacher").FirstOrDefault()?.Element("teacherName")
                        where cls.Descendants("student").Any(s => (int)s.Element("studentID") == id)
                        from student in cls.Descendants("student")
                        where (int)student.Element("studentID") == id
                        select new record
                        {
                            Date = date,
                            ClassInfoList = new List<ClassInfo>
                    {
                        new ClassInfo
                        {
                            ClassName = className,
                            Teacher = new ClassLibrary3.user
                            {
                                Name = teacherName,
                                Id = (int)cls.Descendants("teacher").FirstOrDefault()?.Element("teacherID")
                            },
                            Students = new List<Student>
                            {
                                new Student
                                {
                                    Name = (string)student.Element("studentname"),
                                    Id = (int)student.Element("studentID"),
                                    Status = (string)student.Element("status")
                                }
                            }
                        }
                    }
                        };

            records = query.ToList();
            return records;
        }

        private void studentControl1_Load(object sender, EventArgs e)
        {

        }

        private void panelExand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
            {
                panelExpand.Visible = true;
            }
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            labelTime.Text = date.ToString();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Log Out?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panelExpand.Hide();
            }

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            StudentNamelbl.Text = currentUser.Name;
            StudentRolelbl.Text = currentUser.Rr.ToString();
            panelExpand.Hide();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedClass = comboBoxClass.SelectedItem.ToString();
            dataGridRecords.Rows.Clear();
            foreach (var record in _records)
            {

                foreach (var classInfo in record.ClassInfoList)
                {
                    if (classInfo.ClassName == SelectedClass)
                    {
                        foreach (var student in classInfo.Students)
                        {
                            ClassLibrary3.user s = new ClassLibrary3.user();
                            dataGridRecords.Rows.Add(
                                student.Id,
                                student.Name,
                                student.Status,
                                classInfo.ClassName,
                                classInfo.Teacher.Name,
                                record.Date
                            );

                        }
                    }
                }
            }
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {

            if (dataGridRecords.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridRecords.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridRecords.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridRecords.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridRecords.Rows.Count > 0)
            {
                // Export DataGridView data to Excel
                try
                {
                    // Creating a Excel object.
                    Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                    // Adding Workseet to workbook.
                    worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;

                    // Setting the Header Column Names.
                    for (int i = 1; i < dataGridRecords.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridRecords.Columns[i - 1].HeaderText;
                    }

                    // Adding Rows and Columns
                    for (int i = 0; i < dataGridRecords.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridRecords.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridRecords.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // Save the Excel file.
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                    saveFileDialog1.Title = "Save Excel File";
                    saveFileDialog1.ShowDialog();

                    if (saveFileDialog1.FileName != "")
                    {
                        workbook.SaveAs(saveFileDialog1.FileName);
                        MessageBox.Show("Excel file saved successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}

