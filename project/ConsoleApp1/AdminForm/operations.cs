using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminForm
{
    public static class operations
    {

        public static bool matchingEmail(String Email, string pass)
        {
            bool s = true;
            List<user> li = xmloperators.DeserializeXmlFileToList();
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].Email == Email && li[i].Password == pass)
                {
                    s = false;
                    DialogResult dialogResult = MessageBox.Show("Choose Different Email and Pass", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            return s;
        }

        public static int search(int _id)
        {
            List<user> li = xmloperators.DeserializeXmlFileToList();
            for(int i = 0;i < li.Count;i++)
            {
                if (li[i].Id == _id) { return i; }
            }
            return -1;
        }

        public static bool lastuser( role rr)
        {
            int count = 0;
            List<user>li =  xmloperators.DeserializeXmlFileToList();
            for(int i = 0; i < li.Count ; i++) 
            {
                if (li[i].Rr == rr)
                {
                    count++;
                    if (count >= 2) { return true; }
                }
            }
            return false;
        }
    }
}
