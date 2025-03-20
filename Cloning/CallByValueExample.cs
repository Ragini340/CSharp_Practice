namespace CSharp_Practice.Cloning
{
    public class CallByValueExample
    {
        public static void ModifyValue(int num)
        {
            Console.WriteLine($"Value of num before modification: {num}");
            num = num * 2;
            Console.WriteLine($"Value of num after modification: {num}");
        }

        public static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine("Before calling ModifyValue method:");
            Console.WriteLine($"Value of number: {number}");

            ModifyValue(number);
            Console.WriteLine("After calling ModifyValue method:");
            Console.WriteLine($"Value of number: {number}");
        }

    }
}