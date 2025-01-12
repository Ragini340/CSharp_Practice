namespace CSharp_Practice.OOPs.ClassAndObjects.PartialClass.PartialClassWithInterface
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            PartialClass partialClass = new PartialClass();
            partialClass.CustomerMethod();
            partialClass.EmployeeMethod();
        }
    }
}