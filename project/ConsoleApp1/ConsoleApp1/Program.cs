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




        }

    }
}
