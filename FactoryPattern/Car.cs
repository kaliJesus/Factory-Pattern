using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public Car()
        {

        }
        public int Tires { get; set; } = 4;
        public string Make { get; set; } = "tesla";

        public void MyVehicle()
        {
            Console.WriteLine($" Tire count:  {Tires} Tires");
            Console.WriteLine($"Make: {Make} ");
        }
    }
}
