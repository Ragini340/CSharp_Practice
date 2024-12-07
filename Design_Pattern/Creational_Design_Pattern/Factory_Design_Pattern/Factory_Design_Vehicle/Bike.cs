using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern.Factory_Design_Vehicle
{
    public class Bike : IVehicle
    {
        public int NoOfWheels()
        {
            return 2;
        }

        public string VehicleType()
        {
            return "Bike";
        }
    }
}
