namespace CSharp_Practice.OOPs.ClassAndObjects
{
    public static class StaticClassEx
    {
        public static string firstName = "A";
        public static string lastName = "B";

        public static void Details()
        {
            Console.WriteLine("The details of person is:");
        }
    }

    public class DriverOfStaticClassEx
    {
        static public void Main()
        {
            StaticClassEx.Details();

            Console.WriteLine("First Name : {0} ", StaticClassEx.firstName);
            Console.WriteLine("Last Name : {0} ", StaticClassEx.lastName);
        }
    }

}
