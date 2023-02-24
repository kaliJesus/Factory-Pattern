using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
        public int Tires { get; set; }
        public string Make { get; set; }

        public void MyVehicle()
        {
            Console.WriteLine($"Tires count:  {Tires} Tires");
            Console.WriteLine($" Make: {Make} ");
        }
        
    }
}
