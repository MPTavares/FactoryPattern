using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }
       public IVehicle ApplyVeicule(string type)
        {
            if (type == "bike")
            {
                return new Bike();
            }
            else if (type == "motorbike")
            {
                return new MotorBike();
            }
            else if (type == "car")
            {
                return new Car();
            }
            else
            {
                throw new Exception("Type is not defined");
            }
        }
    }
}
