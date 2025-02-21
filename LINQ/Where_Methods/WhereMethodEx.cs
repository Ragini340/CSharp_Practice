namespace CSharp_Practice.LINQ.Where_Methods
{
    public class WhereMethodEx
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Method Syntax
            IEnumerable<int> filteredData = list.Where(num => num > 5);
            Console.WriteLine("Using method syntax:");
            foreach (int number in filteredData)
            {
                Console.Write(number + " ");
            }

            //Query Syntax
            IEnumerable<int> filteredResult = from num in list
                                              where num > 5
                                              select num;
            Console.WriteLine("\nUsing query syntax:");
            foreach (int number in filteredResult)
            {
                Console.Write(number + " ");
            }
        }

    }
}