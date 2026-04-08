namespace CSharp_Practice.CodingQuestions
{
    public class FibonacciSeries
    {
        public static int Fibonacci(int num)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < num; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number upto which fibonacci series has to be find: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci series upto " + num + " is: ");
            for (int i = 0; i <= num; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

    }
}