using System.Reflection.Metadata;
using System.Xml.Serialization;
using ClassLibrary1;
using ClassLibrary1.YourNamespace;
using System.IO;
using System.Collections.Generic;
namespace ConsoleAttendence;

internal class Program
{
    static void Main(string[] args)
    {

        //var mem = xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
        //foreach (var item in mem)
        //{
        //    Console.WriteLine(item);
        //}

        //// Adminoperation.AddNewUser("abdellatief hamed", "abdellatiefhamed@gmail.com", "14114", role.Student, classes.Math, classes.JavaScript);
        //Console.WriteLine("\n---------------------\n");
        //Adminoperation.ShowTeachers();
        //Console.WriteLine("\n---------------\n");
        //Adminoperation.ShowStudents();





         string xmlFilePath = @"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\records.xml";
      
        List<record> records=new List<record>();
        var xmlRoot = new XmlRootAttribute("records");
        XmlSerializer serializer = new XmlSerializer(typeof(List<record>), xmlRoot);


        using (StreamReader reader = new StreamReader(xmlFilePath))
        {
            records = (List<record>)serializer.Deserialize(reader);            
        }


      
        

        foreach (var record in records)
        {

            Console.WriteLine($"Date: {record}");

            foreach (var course in record.ClassInfoList)
            {
                Console.WriteLine($"Course Name: {course.ClassName}");
                Console.WriteLine($"Teacher Name: {course.Teacher.teacherName}");

                foreach (var student in course.Students)
                {
                    Console.WriteLine($"Student Name: {student.studentname}, Status: {student.status}");
                }
            }
        }

    }
 }

