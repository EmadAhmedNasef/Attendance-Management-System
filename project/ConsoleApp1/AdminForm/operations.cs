using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace AdminForm
{
    public static class operations
    {

        public static bool matchingEmail(String Email, string pass)
        {
            bool s = true;
            List<user> li = xmloperators.DeserializeXmlFileToList();
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].Email == Email && li[i].Password == pass)
                {
                    s = false;
                    DialogResult dialogResult = MessageBox.Show("Choose Different Email and Pass", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            return s;
        }

        public static int search(int _id)
        {
            List<user> li = xmloperators.DeserializeXmlFileToList();
            for(int i = 0;i < li.Count;i++)
            {
                if (li[i].Id == _id) { return i; }
            }
            return -1;
        }

        public static bool lastuser( role rr)
        {
            int count = 0;
            List<user>li =  xmloperators.DeserializeXmlFileToList();
            for(int i = 0; i < li.Count ; i++) 
            {
                if (li[i].Rr == rr)
                {
                    count++;
                    if (count >= 2) { return true; }
                }
            }
            return false;
        }
        public static bool lastuserofkind(int ind)
        {
            int count = 0;
            List<user> li = xmloperators.DeserializeXmlFileToList();
            role rr = li[ind].Rr;
            classes cls = li[ind].primaryClass;
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].Rr == rr && li[i].primaryClass==cls)
                {
                    count++;
                    if (count >= 2) { return true; }
                }
            }
            return false;
        }
        public static void writeinexcel( List<user> li ,String thing= "" , string name = "users")
        {
            

            using (ExcelPackage excelPackage = new ExcelPackage(new System.IO.FileInfo(@$"D:\iti\xml\attendance\Attendance-Management-System\project\ConsoleApp1\{name}.xlsx")))
            {
                // Add a new worksheet to the package
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add($"{thing}{DateTime.Now}");

                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 3].Value = "Email";
                worksheet.Cells[1, 4].Value = "Password";
                worksheet.Cells[1, 5].Value = "role";
                worksheet.Cells[1, 6].Value = "class";

                // Write data to the cells
                for (int i = 0;i < li.Count;i++)
                {
                    worksheet.Cells[i+2,1].Value = li[i].Id;
                    worksheet.Cells[i+2,2].Value = li[i].Name;
                    worksheet.Cells[i + 2, 3].Value = li[i].Email;
                    worksheet.Cells[i + 2, 4].Value = li[i].Password;
                    worksheet.Cells[i + 2, 5].Value = li[i].Rr;
                    worksheet.Cells[i + 2, 6].Value = li[i].primaryClass;
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Save the package to a file
                excelPackage.Save(); 
            }
        }

    }
}
