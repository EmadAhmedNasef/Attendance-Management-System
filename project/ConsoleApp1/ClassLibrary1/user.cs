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

<<<<<<< HEAD

=======
 
>>>>>>> origin/abdellatief
    public enum role
    {
        Admin = 0, Teacher = 1, Student = 2

    }
    public enum classes
    {
<<<<<<< HEAD
        not = 0, JavaScript = 1, English = 2, Math = 3
    }



    [Serializable]

    [XmlRoot("user")]
    public class user : ICloneable, IComparable<user>
=======
       not = 0 , JavaScript = 1, English = 2, Math = 3
    }


   
    [Serializable]
    
    [XmlRoot("user")]
    public class user
>>>>>>> origin/abdellatief
    {


        private string _name;
        private role rr;
        private List<classes> Class;
        private classes prim;
        private classes second;
<<<<<<< HEAD
        public string Status { get; set; }


        public int Id { get; set; }
        public string Name
        {
=======


        public int Id { get; set; }
        public string Name {
>>>>>>> origin/abdellatief
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

<<<<<<< HEAD



        public classes primaryClass { get => prim; set => prim = (classes)value; }

        public classes SecondryClass { get => second; set => second = (classes)value; }
=======
        

        
        public classes primaryClass { get => prim; set => prim = (classes)value; }
        
        //public classes SecondryClass { get => second; set => second = (classes)value; }
>>>>>>> origin/abdellatief

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
<<<<<<< HEAD
            return $"id  = {Id}, Name = {Name} , Email = {Email} , role = {Rr} , primaryclass = {primaryClass} , secondryclass = {SecondryClass}";
        }

        public static bool operator ==(user left, user right)
        {
            return left.Id == right.Id;
=======
            return $"id  = {Id}, Name = {Name} , Email = {Email} , role = {Rr} , class = {primaryClass} ";
        }

        public static bool operator == (user left, user right)
        {
            return left.Id == right.Id ;
>>>>>>> origin/abdellatief
        }
        public static bool operator !=(user left, user right)
        {
            return !(left.Id == right.Id);
        }


        public override bool Equals(object? obj)
        {
<<<<<<< HEAD
            if (obj is user user)
            {
                return (this.Id == user.Id);
            }
            return false;
        }
        public int CompareTo(user? other)
        {
            return other.Id.CompareTo(Id);
        }

        public object Clone()
        {
            user ClonnedUser = new user();
            ClonnedUser.Id = Id;
            ClonnedUser.Name = Name;
            ClonnedUser.Rr = Rr;
            ClonnedUser.Email = Email;
            ClonnedUser.second = second;
            ClonnedUser.prim = prim;
            return ClonnedUser;
        }
        public bool ShouldSerializeprimaryClass()
        {
            // Serialize only if Property is not equal to default value
            return prim != classes.not;
        }
        public bool ShouldSerializeSecondryClass()
        {
            // Serialize only if Property is not equal to default value
            return second != classes.not;
        }
    }


=======
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
>>>>>>> origin/abdellatief
}
