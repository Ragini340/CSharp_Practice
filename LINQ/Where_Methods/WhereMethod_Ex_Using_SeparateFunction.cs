namespace CSharp_Practice.LINQ.Where_Methods
{
    public class WhereMethod_Ex_Using_SeparateFunction
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Method syntax
            IEnumerable<int> filteredData = list.Where(num => CheckNumber(num));
            foreach (int number in filteredData)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }

        public static bool CheckNumber(int number)
        {
            if (number > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}