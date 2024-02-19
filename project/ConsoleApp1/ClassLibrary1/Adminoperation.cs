﻿using System;
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
            var li =  xmloperators.DeserializeXmlFileToList();
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
            var li = xmloperators.DeserializeXmlFileToList();
            li.RemoveAt(id);
            xmloperators.changingxml(li);
        }


        //adding new user and then apply the changes to xml
        public static void AddNewUser (string _name, string _email, string _pass, role _role = role.Student ,classes _prim = classes.not)
        {

            List<user> memberList =xmloperators.DeserializeXmlFileToList();

            memberList.Add(new user()
            {
                Id = 1 + memberList[memberList.Count-1].Id,
                Name = _name,
                Email = _email,
                Password = _pass,
                Rr = _role,
                primaryClass = _prim,
            });
            xmloperators.changingxml(memberList);
        }

        //------------------------------------fill the form----------------------

        //showing students 
        // you can modify it to put students in the windows form

        public static void ShowStudents()
        {
            List<user> memberList = xmloperators.DeserializeXmlFileToList();
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
            List<user> memberList = xmloperators.DeserializeXmlFileToList();
            foreach (var item in memberList)
            {
                if (item.Rr == role.Teacher)
                {
                    // here you can fill the form 
                    Console.WriteLine(item.ToString());

                }
            }
        }


        // searching for email and pass
        








        //end of the class
    }
}
