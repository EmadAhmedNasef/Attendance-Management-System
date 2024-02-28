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

            xmloperators.SerializeListToXmlFile();
            Adminoperation.ShowTeachers();
            Console.WriteLine("\n---------------\n");
            Adminoperation.ShowStudents();




        }

    }
}
