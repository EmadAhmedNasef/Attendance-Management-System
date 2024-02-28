using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    namespace YourNamespace
    {
        [Serializable]
        [XmlRoot("record")]
        public class record
        {
            private DateOnly date;
           
            private List<ClassInfo> classInfoList;
           
            public DateOnly Date { get => date; set => date = value; }
            [XmlElement("class")]
            public List<ClassInfo> ClassInfoList { get => classInfoList; set => classInfoList = value; }

            public override string ToString()
            {
                return $"Date: {Date}";
            }
        }

        public class ClassInfo
        {
            [XmlAttribute("name")]
            public string ClassName { get; set; }

            [XmlElement("Teacher")]
            public user Teacher { get; set; }


           
            public List<Student> Students { get; set; }
            public ClassInfo()
            {
                Students = new List<Student>();
            }

            public override string ToString()
            {
                return $"Course Name: {ClassName}\nTeacher Name: {Teacher}";
            }
        }




        

        // 
        [XmlRoot("Student")]
        public class Student:user
        {
            
            public string status { get; set; }

            public override string ToString()
            {
                return $"Student Name: {Name}, Student ID: {Id}, Status: {status}";
            }
        }
    }
}
