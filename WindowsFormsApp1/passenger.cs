using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    class passenger
    {
        private string name;
        private string cnic;
        private string trainName;
        private string category;
        public string getName()
        {
            return name;
        }
        public string getCNIC()
        {
            return cnic;
        }
        public string getTrainName()
        {
            return trainName;
        }
        public string getCategory()
        {
            return category;
        }
        public void setName(string n)
        {
            name = n;
        }
        public void setCNIC(string n)
        {
            cnic = n;
        }
        public void setTrainName(string n)
        {
            trainName = n;
        }
        public void setCategory(string n)
        {
            category = n;
        }
    }
}
