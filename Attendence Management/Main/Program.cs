using System.Xml;

namespace Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"D:\Study\Courses\Fullstack\ITI C44\C# [Programming]\Attendance-Management-System-AhmedMostafa\records.xml");
            XmlNodeList records = xmlDocument.SelectNodes("//record");
            foreach (XmlNode record in records)
            {
                string date = record.SelectSingleNode("date").InnerText;
                Console.WriteLine($"Date: {date}");

                XmlNode classNode = record.SelectSingleNode(".//class");
                string className = classNode.Attributes["name"].Value;
                Console.WriteLine($"Class Name: {className}");

                XmlNodeList studentNodes = classNode.SelectNodes(".//Student");
                foreach (XmlNode studentNode in studentNodes)
                {
                    string studentName = studentNode.SelectSingleNode("studentname").InnerText;
                    string studentID = studentNode.SelectSingleNode("studentID").InnerText;
                    string status = studentNode.SelectSingleNode("status").InnerText;

                    Console.WriteLine($"Student Name: {studentName}, ID: {studentID}, Status: {status}");
                }

                Console.WriteLine(); // Separate records with an empty line
            }
        }
    }
}
