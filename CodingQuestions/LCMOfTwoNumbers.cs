namespace CSharp_Practice.CodingQuestions
{
    public class LCMOfTwoNumbers
    {
        public static int FindLCMOfTwoNums(int num1, int num2)
        {
            int max, lcm;
            max = (num1 > num2) ? num1 : num2;
            lcm = max;

            while ((lcm % num1 != 0) || (lcm % num2 != 0))
            {
                lcm = lcm + max;
            }
            return lcm;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("LCM of two numbers is: " + FindLCMOfTwoNums(num1, num2));
        }

    }
}