using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Bus:Vehicle
    {
        private int passengersCount;
        public Bus(string color, int year, int passangersCount):base(color,year)
        {
            PassengersCount = passangersCount; 
        }




        public int PassengersCount
        {
            get { return passengersCount; }
            set
            {
                if (value >= 0) 
                {
                    passengersCount = value; 
                }
                else
                {
                   
                    Console.WriteLine("menfi ola bilmez");
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Color} {Year} {PassengersCount}");
        }
    }
}
