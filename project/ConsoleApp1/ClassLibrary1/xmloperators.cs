﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary1
{


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
            public Teacher Teacher { get; set; }


            [XmlArray("Students")]
            [XmlArrayItem("Student")]
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


        public class Teacher : user
        {
            public string TeacherName { get; set; }

            public override string ToString()
            {
                return $"Teacher Name: {TeacherName}, Teacher ID: {this.Id}";
            }

            public List<string> GetAbsentStudents(record record)
            {
                List<string> absentStudents = new List<string>();
                foreach (var classInfo in record.ClassInfoList)
                {
                    foreach (var student in classInfo.Students)
                    {
                        if (student.Status != "Present")
                        {
                            absentStudents.Add($"{student.studentname} ({classInfo.ClassName}) : {student.status}");
                        }
                    }
                }
                return absentStudents;
            }
        }
    }


    // 
    [XmlRoot("Student")]
    public class Student : user
    {
        [XmlElement("studentname")]
        public string studentname { get; set; }

        public int studentID { get; set; }
        [XmlElement("status")]
        public string status { get; set; }

        public override string ToString()
        {
            return $"Student Name: {studentname}, Student ID: {studentID}, Status: {status}";
        }
    }
}

