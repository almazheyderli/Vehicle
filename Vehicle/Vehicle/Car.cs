using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car:Vehicle
    {
        public Car(string color, int year, string brand, string model, int maxSpeed) : base(color,year)
        {
            Brand= brand;
            Model= model;
            MaxSpeed= maxSpeed;

        }
        public string Brand {  get; set; }
        public string Model { get; set; }
        private int maxSpeed;
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                maxSpeed = value; 
            }

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Brand} {Model} {Year} {Color} {MaxSpeed}");
        }
    }
}
