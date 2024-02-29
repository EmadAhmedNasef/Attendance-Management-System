using iTextSharp.text.pdf;
using iTextSharp.text;
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
            string xmlFilePath = @"../../../../../../XML/record.xml";
            HashSet<string> classNames = new HashSet<string>();

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
                        classNames.Add(className);
                    }

                    comboBoxClass.Items.Clear();
                    foreach (string className in classNames)
                    {
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
            string xmlFilePath = @"../../../../../../XML/record.xml";

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
                        XmlNode dateNode = record.SelectSingleNode(".//date");
                        DateTime recordDate;
                        if (DateTime.TryParse(dateNode.InnerText, out recordDate) && recordDate.Date == dateTimePickerDate.Value.Date)
                        {
                            XmlNodeList classNodes = record.SelectNodes(".//class");
                            foreach (XmlNode classNode in classNodes)
                            {
                                string className = classNode.Attributes["name"].Value;
                                if (className == comboBoxClass.SelectedItem.ToString())
                                {


                                    XmlNodeList studentNodes = classNode.SelectNodes(".//student");

                                    foreach (XmlNode studentNode in studentNodes)
                                    {
                                        string studentID = studentNode.SelectSingleNode("studentID").InnerText;
                                        string studentName = studentNode.SelectSingleNode("studentname").InnerText;
                                        string status = studentNode.SelectSingleNode("status").InnerText;
                                        int rowIndex = dataGridViewMarkAttendance.Rows.Add(studentName, studentID, className, status);
                                    }
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












        //private void ExportToHtml(DataGridView dataGridView, string htmlFilePath)
        //{
        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter(htmlFilePath))
        //        {
        //            sw.WriteLine("<html>");
        //            sw.WriteLine("<head>");
        //            sw.WriteLine("<title>Student Attendance</title>");
        //            sw.WriteLine("</head>");
        //            sw.WriteLine("<body>");
        //            sw.WriteLine("<table border='1'>");

        //            // Add headers to the table
        //            sw.WriteLine("<tr>");
        //            foreach (DataGridViewColumn column in dataGridView.Columns)
        //            {
        //                sw.WriteLine("<th>" + column.HeaderText + "</th>");
        //            }
        //            sw.WriteLine("</tr>");

        //            // Add data to the table
        //            foreach (DataGridViewRow row in dataGridView.Rows)
        //            {
        //                sw.WriteLine("<tr>");
        //                foreach (DataGridViewCell cell in row.Cells)
        //                {
        //                    sw.WriteLine("<td>" + cell.Value.ToString() + "</td>");
        //                }
        //                sw.WriteLine("</tr>");
        //            }

        //            sw.WriteLine("</table>");
        //            sw.WriteLine("</body>");
        //            sw.WriteLine("</html>");
        //        }

        //        MessageBox.Show("HTML saved successfully at: " + htmlFilePath);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error exporting to HTML: " + ex.Message);
        //    }
        //}

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            //string htmlFilePath = @"C:\Users\Nasef\Desktop\Project\Attendence Management\StudentAttendance.html";
            //ExportToHtml(dataGridViewMarkAttendance, htmlFilePath);
            if (dataGridViewMarkAttendance.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(dataGridViewMarkAttendance.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridViewMarkAttendance.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridViewMarkAttendance.Rows)
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

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarkAttendance.Rows.Count > 0)
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
                    for (int i = 1; i < dataGridViewMarkAttendance.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewMarkAttendance.Columns[i - 1].HeaderText;
                    }

                    // Adding Rows and Columns
                    for (int i = 0; i < dataGridViewMarkAttendance.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewMarkAttendance.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewMarkAttendance.Rows[i].Cells[j].Value.ToString();
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

