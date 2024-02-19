using ClassLibrary1;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //xmloperators.SerializeListToXmlFile();
            //var mem = xmloperators.DeserializeXmlFileToList();
            //foreach (var item in mem)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Adminoperation.AddNewUser("abdellatief hamed","abdellatiefhamed@gmail.com", "14114",role.Student,classes.Math,classes.JavaScript );

            Adminoperation.ShowTeachers();
            Console.WriteLine("\n---------------\n");
            Adminoperation.ShowStudents();


            // Create a student
            Student student = new Student();
            student.Id = 1;
            student.Name = "Alice";
            student.Email = "alice@example.com";
            student.Password = "pass";
            student.Rr = role.Student;
            student.primaryClass = classes.English;

            // Add some attendance records
            student.AddAttendanceRecord(new AttendanceRecord { Date = DateTime.Today, IsPresent = true });
            student.AddAttendanceRecord(new AttendanceRecord { Date = DateTime.Today.AddDays(-1), IsPresent = false });

            // Get and display attendance records
            var attendanceRecords = student.GetAttendanceRecords();
            foreach (var record in attendanceRecords)
            {
                Console.WriteLine(record.ToString());
            }



        }

    }
}
