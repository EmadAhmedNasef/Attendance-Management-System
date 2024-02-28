using ClassLibrary1;
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

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(dataGridViewUsers.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridViewUsers.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridViewUsers.Rows)
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
    }
}
