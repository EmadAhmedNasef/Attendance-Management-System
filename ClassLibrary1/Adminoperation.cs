using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Adminoperation
    {

        // login operation compare things to each other 
        public static int login ( string Email="", string pass = "")
        {
            var li =  xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].Email == Email && li[i].Password == pass)
                {
                    return i;
                }
            }
            return -1;
        }

        //-----------------------remove and add----------------------------


        //reomove user from list then apply chnages to xml 
        // you can complete the function to make changes appear in the form
        public static void RemoveUser (int id)
        {
            var li = xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
            li.RemoveAt(id);
            xmloperators.changingxml(li, @"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
        }


        //adding new user and then apply the changes to xml
        public static void AddNewUser (string _name, string _email, string _pass, role _role = role.Student ,classes _prim = classes.not, classes _secon = classes.not)
        {

            List<user> memberList =xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");

            memberList.Add(new user()
            {
                Id = 1 + memberList.Count,
                Name = _name,
                Email = _email,
                Password = _pass,
                Rr = _role,
                primaryClass = _prim,
                SecondryClass = _secon,
            });
            xmloperators.changingxml(memberList, @"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
        }

        //------------------------------------fill the form----------------------

        //showing students 
        // you can modify it to put students in the windows form

        public static void ShowStudents()
        {
            List<user> memberList = xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml"); ;
            foreach (var item in memberList)
            {
                if (item.Rr == role.Student)
                {
                    // here you can fill the form 
                    Console.WriteLine(item.ToString());

                }
            }
        }
        public static void ShowTeachers()
        {
            List<user> memberList = xmloperators.DeserializeXmlFileToList(@"C:\Users\Ahmed Mostafa\Desktop\attendence system - Copy\Attendence Manngment System\sampl01.xml");
            foreach (var item in memberList)
            {
                if (item.Rr == role.Teacher)
                {
                    // here you can fill the form 
                    Console.WriteLine(item.ToString());

                }
            }
        }
    

    
    
    
    
    
    
    
    //end of the class
    }
}
