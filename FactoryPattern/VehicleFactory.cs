using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int VehicleType)
        {

            switch (VehicleType)
            {
                case 1:
                    return new Motorcycle();
                case 2:
                    return new Car();
                default:
                    return new Car();
                   



            }



        }
    }
}
