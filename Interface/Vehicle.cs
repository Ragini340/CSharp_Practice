using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Interface
{
    public class Vehicle : InterfacePOC
    {
        int gear;
        int speed;

        public void Display()
        {
            Console.WriteLine("Test1");
        }

        public void ChangeGear(int vehiclegear)
        {
            gear = vehiclegear; //5
        }

        public void SpeedUp(int inc)
        {
            speed = speed + inc; //2
        }

        public void ApplyBrake(int dec)
        {
            speed = speed - dec; //2-0 = 2
        }

        public void state()
        {
            Console.WriteLine("Vehicle's gear :" + gear);
            Console.WriteLine("Vehicle's speed: " + speed);
        }

        public static void Main()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.ChangeGear(5);
            vehicle.SpeedUp(2);
            vehicle.ApplyBrake(0);
            vehicle.state();
        }

    }
}
