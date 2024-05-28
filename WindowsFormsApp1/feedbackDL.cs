using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.IO;

namespace WindowsFormsApp1
{
    class feedbackDL
    {
        public static List<string> data = new List<string>();
        public static void loadData()
        {
            string record;
            string path = "Feedback.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                while (((record = file.ReadLine()) != null))
                {
                    data.Add(record);
                }
                file.Close();
            }
        }
        public static void storeData(List<string> t)
        {
            string path = "Feedback.txt";
            StreamWriter fileVariable = new StreamWriter(path);
            if (File.Exists(path))
            {
                for (int n = 0; n < t.Count; n++)
                {
                    fileVariable.WriteLine(t[n]);
                }
                fileVariable.Flush();
                fileVariable.Close();
            }
        }
    }
}
