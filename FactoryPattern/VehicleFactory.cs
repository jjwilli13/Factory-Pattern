using System;
namespace FactoryPattern
{
    static class VehicleFactory
    {

        public static IVehicle GetVehicle()
        {
            Console.WriteLine("What type of vehicle would you like to build?");
            Console.WriteLine("Enter the number of tires based on the following: 4 = Car, 18 = BigRig, 2 = Motorcycle");
                

            var answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                case 18:
                    return new BigRig();
                default:
                    return new Car();


            }


        }

       
    }
}

