using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    class train
    {
        private string name;
        private int seat;
        private string route;
        private float economyPrice;
        private float businessPrice;
        public void setName(string n)
        {
            name = n;
        }
        public void setSeat(int n)
        {
            seat = n;
        }
        public void setRoute(string n)
        {
            route = n;
        }
        public void setEconomyPrice(float n)
        {
            economyPrice = n;
        }
        public void setBusinessPrice(float n)
        {
            businessPrice = n;
        }
        public string getName()
        {
            return name;
        }
        public int getSeat()
        {
            return seat;
        }
        public float getEconomyPrice()
        {
            return economyPrice;
        }
        public float getBusinessPrice()
        {
            return businessPrice;
        }
        public string getRoute()
        {
            return route;
        }
    }
}
