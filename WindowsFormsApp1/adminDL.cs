using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    class adminDL
    {
        public static List<adminData> admin = new List<adminData>();
        public static void loadData()
        {
            string record;
            string path = "Admin.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                while (((record = file.ReadLine()) != null))
                {
                    string[] d = record.Split(',');
                    adminData info = new adminData();
                    info.setName(d[0]);
                    info.setPassword(d[1]);
                    admin.Add(info);
                }
                file.Close();
            }
        }
        public static void storeData(List<adminData> t)
        {
            string path = "Admin.txt";
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
        public static bool searchPassword(string name)
        {
            for(int n = 0; n<admin.Count;n++)
            {
                if(admin[n].getPassword() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool searchName(string name)
        {
            for (int n = 0; n < admin.Count; n++)
            {
                if (admin[n].getName() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static int index(string name)
        {
            for (int n = 0; n < admin.Count; n++)
            {
                if (admin[n].getPassword() == name)
                {
                    return n;
                }
            }
            return 0;
        }
    }
}
