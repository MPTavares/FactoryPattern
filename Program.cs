using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new VehicleFactory();

            IVehicle vehicle = vehicleFactory.ApplyVeicule("car");
            vehicle.Delivery();

            vehicle = vehicleFactory.ApplyVeicule("motorbike");
            vehicle.Delivery();

            vehicle = vehicleFactory.ApplyVeicule("bike");
            vehicle.Delivery();

        }
    }
}
