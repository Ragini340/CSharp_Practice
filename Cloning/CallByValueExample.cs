namespace CSharp_Practice.Cloning
{
    public class CallByValueExample
    {
        public static void ModifyValue(int num)
        {
            Console.WriteLine($"Value of num before modification: {num}"); //Output: 10
            num = num * 2;
            Console.WriteLine($"Value of num after modification: {num}"); //Output: 20
        }

        public static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine("Before calling ModifyValue method:");
            Console.WriteLine($"Value of number: {number}"); //Output: 10

            ModifyValue(number);
            Console.WriteLine("After calling ModifyValue method:");
            Console.WriteLine($"Value of number: {number}"); //Output: 10
        }

    }
}