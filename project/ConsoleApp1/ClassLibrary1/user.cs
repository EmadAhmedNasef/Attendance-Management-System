using System;
using System.Reflection;
using System.Xml.Serialization;
namespace ClassLibrary1
{


    public enum role
    {
        Admin  = 0, Teacher = 1, Student = 2
    }

    [Serializable]
    public class user
    {
        private string _name;
        private role rr;

        public int Id { get; set; }
        public string Name {
            get { return _name; }
            set { _name = value; } 
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public role Rr { get => rr; set => rr = (role)value; }

        public override string ToString()
        {
            return $"id  = {Id}, Name = {Name} , Email = {Email} , role = {Rr}";
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
    }
}
