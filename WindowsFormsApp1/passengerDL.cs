using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    class passengerDL : passenger
    {
       
        public static List<passenger> passengerData = new List<passenger>();
        public static void storeData(List<passenger> t)
        {
            string path = "PassengerInformation.txt";
            StreamWriter fileVariable = new StreamWriter(path);
            if (File.Exists(path))
            {
                for (int n = 0; n < t.Count; n++)
                {
                    fileVariable.WriteLine(t[n].getName() + ',' + t[n].getCNIC() + ',' + t[n].getTrainName() + ',' +t[n].getCategory());
                }
                fileVariable.Flush();
                fileVariable.Close();
            }
        }
        public static void loadData()
        {
            string record;
            string path = "PassengerInformation.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {             
            while (((record = file.ReadLine()) != null))
            {
                string[] d = record.Split(',');
                passenger info = new passenger();
                info.setName(d[0]);
                info.setCNIC(d[1]);
                info.setTrainName(d[2]);
                info.setCategory(d[3]);
                passengerData.Add(info);
            }
            file.Close();
            }
        }
        public static bool searchPerson(string n1,string n2)
        {
            for(int n =0;n< passengerData.Count;n++)
            {
                if (passengerData[n].getName() == n1 && passengerData[n].getCNIC() == n2)
                {
                    return true;
                }
            }
            return false;
        }
        public static int findIndex(string n1,string n2)
        {
            int index = 0;
            for (int n = 0; n < passengerData.Count; n++)
            {
                if (passengerData[n].getName() == n1 && passengerData[n].getCNIC() == n2)
                {
                     index = n;
                }
            }
            return index;
        }


    }
}
