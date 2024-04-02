namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Car("qara", 2020, "Toyota", "Land Cruiser", 200);
            vehicles[1] = new Bus("qirmizi", 2018, 30);
            vehicles[2] = new Bus("ag", 2012, 35);

            for(int i = 0; i < 3; i++)
            {
                vehicles[i].ShowInfo(); 
            }
        }

    }
}
