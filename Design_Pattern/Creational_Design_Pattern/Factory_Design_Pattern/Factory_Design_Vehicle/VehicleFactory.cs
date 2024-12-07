using CSharp_Practice.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern.Factory_Design_Vehicle
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicleObject(string type)
        {
            IVehicle vehicle = null;
            if (type.Equals("Bike"))
            {
                vehicle = new Bike();
            }
            else if (type.Equals("Car"))
            {
                vehicle = new Car();
            }
            else if (type.Equals("Rikshaw"))
            {
                vehicle = new Rikshaw();
            }
            return vehicle;
        }
    }
}
