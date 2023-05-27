using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building a new motorcycle!");
        }

        public void BuildDate()
        {
            Console.WriteLine($"Production Date: {DateTime.Now}");
        }
    }
}

