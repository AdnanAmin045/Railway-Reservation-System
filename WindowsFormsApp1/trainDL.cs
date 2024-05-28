using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.IO;

namespace WindowsFormsApp1
{
    class trainDL : train
    {

        public static List<train> trainData = new List<train>();
        public static void storeData(List<train> t)
        {
            string path = "TrainDetail.txt";
            StreamWriter fileVariable = new StreamWriter(path);
            if (File.Exists(path))
            {
                for (int n = 0; n < t.Count; n++)
                {
                    fileVariable.WriteLine(t[n].getName() + ',' + t[n].getSeat() + ',' + t[n].getRoute() + ',' + t[n].getEconomyPrice() + ',' + t[n].getBusinessPrice());
                }
                fileVariable.Flush();
                fileVariable.Close();
            }
        }
        public static void loadData()
        {
            string record;
            string path = "TrainDetail.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                while (((record = file.ReadLine()) != null))
                {
                    string[] d = record.Split(',');
                    train info = new train();
                    info.setName(d[0]);
                    info.setSeat(int.Parse(d[1]));
                    info.setRoute(d[2]);
                    info.setEconomyPrice(float.Parse(d[3]));
                    info.setBusinessPrice(float.Parse(d[4]));
                    trainData.Add(info);
                }
                file.Close();
            }
        }
        public static bool searchTrain(string n1)
        {
            for (int n = 0; n < trainData.Count; n++)
            {
                if (n1 == trainData[n].getName())
                {
                    return true;
                }
            }
            return false;
        }
        public static int checkIndex(string n1)
        {
            for (int n = 0; n < trainData.Count; n++)
            {
                if (n1 == trainData[n].getName())
                {
                    return n;
                }
            }
            return 0;

        }
        public static void changeSeat(string n, string n1, string n2)
        {
            int index = checkIndex(n);
            if (searchTrain(n))
            {
                if (n1 == "Add")
                {
                    trainData[index].setSeat(int.Parse(n2) + trainData[index].getSeat());
                    storeData(trainData);
                }
                if (n1 == "Subtract")
                {
                    trainData[index].setSeat(trainData[index].getSeat() - int.Parse(n2));
                    storeData(trainData);
                }
            }

        }
        public static void changePrice(string n, string n1, string n2)
        {
            int index = checkIndex(n);
            if (searchTrain(n))
            {
                if (n1 == "Economy")
                {
                    trainData[index].setEconomyPrice(float.Parse(n2));
                    storeData(trainData);
                }
                if (n1 == "Business")
                {
                    trainData[index].setBusinessPrice(float.Parse(n2));
                    storeData(trainData);
                }
            }
        }
        public static void deleteTrain(string n)
        {
            int index = checkIndex(n);
            if (searchTrain(n))
            {
                trainData.RemoveAt(index);
                storeData(trainData);
            }
        }
    }
}

