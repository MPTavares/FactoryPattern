using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MotorBike : IVehicle
    {
        public void Delivery()
        {
            Console.WriteLine("Delivery using MotorBike");
        }
    }
}
