namespace CSharp_Practice.Interface
{
    public class InterfacePOCImplementor : InterfacePOC
    {
        int speed;
        int gear;

        public void Display()
        {
            Console.WriteLine("Test");
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear; //20
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment; // 2
        }

        public void ApplyBrake(int decrement)
        {
            speed = speed - decrement; //2-1 = 1
        }

        public void PrintVehicleState()
        {
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Gear: " + gear);
        }
   
        public static void Main(string[] args)
        {
            InterfacePOCImplementor interfacePOCImplementor = new InterfacePOCImplementor();
            interfacePOCImplementor.Display();
            interfacePOCImplementor.ChangeGear(20);
            interfacePOCImplementor.ApplyBrake(1);
            interfacePOCImplementor.SpeedUp(2);
            Console.WriteLine("Print vehicle state: ");
            interfacePOCImplementor.PrintVehicleState();
        }

    }
}
