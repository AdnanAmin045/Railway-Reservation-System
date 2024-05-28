using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp1;

namespace signUp
{
    class signUpRecord
    {
        private string name;
        private string password;
        public static List<signUpRecord> signUpData = new List<signUpRecord>();
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
        public static void storeData(List<signUpRecord> t)
        {
            string path = "SignUpDetail.txt";
            StreamWriter fileVariable = new StreamWriter(path);
            if (File.Exists(path))
            {
                for (int n = 0; n < t.Count; n++)
                {
                fileVariable.WriteLine(t[n].getName() + ',' + t[n].getPassword());
                }
                fileVariable.Flush();
                fileVariable.Close();
            }
        }
        public static bool checkdata(string name, string password)
        {
            string record;
            string path = "SignUpDetail.txt";
            StreamReader file = new StreamReader(path);
            while (((record = file.ReadLine()) != null))
            {
                string[] data = record.Split(',');
                if (name == data[0] && password == data[1])
                {
                    file.Close();
                    return true;
                }
            }
            file.Close();
            return false;
        }
        public static void loadData()
        {
            string record;
            string path = "SignUpDetail.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while (((record = file.ReadLine()) != null))
                {
                    string[] d = record.Split(',');
                    signUpRecord info = new signUpRecord();
                    info.setName(d[0]);
                    info.setPassword(d[1]);
                    signUpData.Add(info);
                }
                file.Close();
            }
        }
    }



}
