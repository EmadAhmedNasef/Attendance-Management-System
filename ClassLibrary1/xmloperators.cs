using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    public static class xmloperators
    {
        
        public static void serializedtoxml()
        {
            user user1 = new user
            {
                Id = 10,
                Name = "abdo",
                Email = "hello@gmail.com",
                Password = "password",

                Rr = role.Admin
            };
            var xmlserializer = new XmlSerializer(typeof(user));
            using (var writer = new StringWriter())
            {
                xmlserializer.Serialize(writer, user1);
                var xmlcontent = writer.ToString();
                Console.WriteLine(xmlcontent);

            };
        }


        public static void DeserializeXmlStringToObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(user));
            using (var reader = new StringReader(xmlString))
            {
                var member = (user)xmlSerializer.Deserialize(reader);
            }
        }

        public static void SerializeObjectToXmlFile(string filepath)
        {
            var member = new user
            {
                Id = 10,
                Name = "abdo",
                Email = "hello@gmail.com",
                Password = "password",
                Rr = role.Admin
            };

            var xmlSerializer = new XmlSerializer(typeof(user));
            if (filepath != null)
            {
                // Add the missing closing parenthesis for the using block
                using (var writer = new StreamWriter(filepath))
                {
                    xmlSerializer.Serialize(writer, member);
                }
            }
        }


        public static void SerializeListToXmlFile(string filepath)
        {
            
            var memberList = new List<user>
            {
                new user
                {
                    Id = 1,
                    Name = "abdo",
                    Email = "abdo@gmail.com",
                    Password = "password",
                    Rr = role.Admin
                },
                new user
                {
                    Id = 2,
                    Name = "hamed",
                    Email = "hamed@gmail.com",
                    Password = "password",
                    Rr = role.Teacher,
                    primaryClass = classes.English

                },
                new user
                {
                    Id = 3,
                    Name = "mohamed",
                    Email = "mohamed@gmail.com",
                    Password = "password",
                    
                    Rr = role.Student,
                    primaryClass = classes.English,
                    SecondryClass = classes.Math
                },
                new user
                {
                    Id = 4,
                    Name = "sayed",
                    Email = "sayed@gmail.com",
                    Password = "password",
                    
                    Rr = role.Student,
                    primaryClass = classes.English,
                    SecondryClass = classes.JavaScript
                }
            };
            changingxml(memberList, filepath);
        }



        public static void changingxml (List<user> memberList,string filepath)
        {
            var xmlRoot = new XmlRootAttribute("users");
            var xmlSerializer = new XmlSerializer(typeof(List<user>), xmlRoot);
            using (var writer = new StreamWriter(filepath))
            {
                xmlSerializer.Serialize(writer, memberList);
            }
        }



        // getting all users in a list

        public static List<user> DeserializeXmlFileToList(string filepath)
        {
            List<user> members = new List<user>();
            var xmlRoot = new XmlRootAttribute("users");
            var xmlSerializer = new XmlSerializer(typeof(List<user>), xmlRoot);
            using (var reader = new StreamReader(filepath))
            {
                members = (List<user>)xmlSerializer.Deserialize(reader);
                
            }
           

            return members;
        }


    }
}
