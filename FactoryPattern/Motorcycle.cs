using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public int Tires { get; set; } = 2;
        public string Make { get; set; } = "BMW";

        public void MyVehicle()
        {
            Console.WriteLine($"Tires count:  {Tires} Tires");
            Console.WriteLine($"Makes: {Make} ");
        }





    }
}
