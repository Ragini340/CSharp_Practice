using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern.Factory_Design_Vehicle
{
    public class FactoryDriver
    {
        public static void Main(string[] args)
        {
            IVehicle vehicleBike = VehicleFactory.GetVehicleObject("Bike");
            Console.WriteLine("Object type is: " + vehicleBike.VehicleType());

            IVehicle vehicleCar = VehicleFactory.GetVehicleObject("Car");
            Console.WriteLine("Object type is: " + vehicleCar.VehicleType());

            IVehicle vehicleRikshaw = VehicleFactory.GetVehicleObject("Rikshaw");
            Console.WriteLine("Object type is: " + vehicleRikshaw.VehicleType());
        }
    }
}
