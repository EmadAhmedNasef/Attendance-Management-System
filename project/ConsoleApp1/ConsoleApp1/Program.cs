using System;
using System.Xml;

namespace ConsoleAttendance
{
    public class Class1
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


/*
private static Record LoadFromXml(string inputPath)
{
    var record = new Record();

    using (var stream = new FileStream(inputPath, FileMode.Open))
    {
        var doc = new XPathDocument(stream);
        var navigator = doc.CreateNavigator();

        // Read the Date
        var dateNode = navigator.SelectSingleNode("/Record/Date");
        record.Date = new DateOnly(DateTime.Parse(dateNode.Value));

        // Read ClassInfo elements
        var classInfoNodes = navigator.Select("/Record/ClassInfo");
        while (classInfoNodes.MoveNext())
        {
            var classInfoNode = classInfoNodes.Current;
            var classInfo = new ClassInfo
            {
                ClassName = classInfoNode.SelectSingleNode("ClassName").Value,
                Teacher = new Teacher { TeacherName = classInfoNode.SelectSingleNode("Teacher/TeacherName").Value },
                Students = new List<Student>()
            };

            // Read Students
            var studentNodes = classInfoNode.Select("Students/Student");
            while (studentNodes.MoveNext())
            {
                var studentNode = studentNodes.Current;
                var student = new Student
                {
                    studentname = studentNode.SelectSingleNode("studentname").Value,
                    studentID = int.Parse(studentNode.SelectSingleNode("studentID").Value),
                    status = studentNode.SelectSingleNode("status").Value
                };
                classInfo.Students.Add(student);
            }

            record.ClassInfoList.Add(classInfo);
        }
    }

    return record;
}

 */

/*
using System;
using System.Xml;

namespace ConsoleAttendance
{
    public class Class1
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
*/


/*
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace ConsoleAttendance
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            // Create an XML document to store the transformed data
            XDocument outputXml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Table",
                    new XElement("tr",
                        new XElement("th", "Date"),
                        new XElement("th", "Class Name"),
                        new XElement("th", "Student Name"),
                        new XElement("th", "Student ID"),
                        new XElement("th", "Status")
                    )
                )
            );

            // Load the XML document containing the attendance records
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"D:\Study\Courses\Fullstack\ITI C44\C# [Programming]\Attendance-Management-System-AhmedMostafa\records.xml");

            // Select all record nodes
            XmlNodeList records = xmlDocument.SelectNodes("//record");
            foreach (XmlNode record in records)
            {
                string date = record.SelectSingleNode("date").InnerText;
                XmlNode classNode = record.SelectSingleNode(".//class");
                string className = classNode.Attributes["name"].Value;

                // Select all student nodes within the class node
                XmlNodeList studentNodes = classNode.SelectNodes(".//Student");
                foreach (XmlNode studentNode in studentNodes)
                {
                    string studentName = studentNode.SelectSingleNode("studentname").InnerText;
                    string studentID = studentNode.SelectSingleNode("studentID").InnerText;
                    string status = studentNode.SelectSingleNode("status").InnerText;

                    // Add a new row to the output XML document for each student
                    outputXml.Root?.Add(
                        new XElement("tr",
                            new XElement("td", date),
                            new XElement("td", className),
                            new XElement("td", studentName),
                            new XElement("td", studentID),
                            new XElement("td", status)
                        )
                    );
                }
            }

            // Save the transformed data to an XML file
            outputXml.Save(@"D:\Study\Courses\Fullstack\ITI C44\C# [Programming]\Attendance-Management-System-abdellatief\project\ConsoleApp1\output.xml");

            Console.WriteLine("Data saved to: output.xml");

            // Load the XSLT stylesheet
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"D:\Study\Courses\Fullstack\ITI C44\C# [Programming]\Attendance-Management-System-abdellatief\project\ConsoleApp1\outpot.xslt");

            // Transform the XML data to HTML
            string outputPath = @"D:\Study\Courses\Fullstack\ITI C44\C# [Programming]\Attendance-Management-System-abdellatief\project\ConsoleApp1\output.html";
            using (XmlWriter writer = XmlWriter.Create(outputPath))
            {
                xslt.Transform(outputXml.CreateReader(), writer);
            }

            Console.WriteLine("HTML table saved to: " + outputPath);
        }
    }
}

*/