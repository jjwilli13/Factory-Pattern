using System;
namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {

        }

        public void Drive()
        {
            Console.WriteLine("Building a new BigRig!");
        }

        public void BuildDate()
        {
            Console.WriteLine($"Production Date: {DateTime.Now}");
        }

    }
}

