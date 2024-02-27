using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ClassLibrary1
{

 
    public enum role
    {
        Admin = 0, Teacher = 1, Student = 2

    }
    public enum classes
    {
       not = 0 , JavaScript = 1, English = 2, Math = 3
    }


   
    [Serializable]
    
    [XmlRoot("user")]
    public class user
    {


        private string _name;
        private role rr;
        private List<classes> Class;
        private classes prim;
        private classes second;


        public int Id { get; set; }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public role Rr { get => rr; set => rr = (role)value; }

        //[XmlArray("classes")]
        //[XmlArrayItem("class")]
        //public List<classes> Classes
        //{
        //    get { return Class ; }
        //    set { Class = value; }
        //}

        

        
        public classes primaryClass { get => prim; set => prim = (classes)value; }
        
        //public classes SecondryClass { get => second; set => second = (classes)value; }

        public override string ToString()
        {

            if (Rr == role.Admin)
            {
                return $"id  = {Id}, Name = {Name} , Email = {Email} , role = {Rr}";
            }
            else if (Rr == role.Teacher)
            {
                return $"id  = {Id}, Name = {Name} , Email = {Email} , role = {Rr} , class = {primaryClass}";
            }
            return $"id  = {Id}, Name = {Name} , Email = {Email} , role = {Rr} , class = {primaryClass} ";
        }

        public static bool operator == (user left, user right)
        {
            return left.Id == right.Id ;
        }
        public static bool operator !=(user left, user right)
        {
            return !(left.Id == right.Id);
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(obj.GetType() != typeof(user)) {
                return false;
            }
            user user = (user)obj;
            if (user == null)
            {
                return false;
            }
            return user.Id==Id;
        }


        public bool ShouldSerializeprimaryClass()
        {
            // Serialize only if Property is not equal to default value
            return prim != classes.not && rr != role.Admin;
        }
        //public bool ShouldSerializeSecondryClass()
        //{
        //    // Serialize only if Property is not equal to default value
        //    return second != classes.not;
        //}
    }
}
