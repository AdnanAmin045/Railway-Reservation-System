using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class adminData
    {
        private string name;
        private string password;
        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public void setName(string n)
        {
            name = n;
        }
        public void setPassword(string n)
        {
            password = n;
        }
        public static List<adminData> admin = new List<adminData>();

    }
}
