using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal abstract class Vehicle
    {
        public  Vehicle(string color,int year)
        {
            Color= color;
            Year= year;
        }
        public string Color { get; set; }
        public int Year {  get; set; }


        public abstract void ShowInfo();
    }
}
