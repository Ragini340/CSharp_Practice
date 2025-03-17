namespace CSharp_Practice.CodingQuestions.LINQ
{
    //Given a list, write a LINQ query to fetch even numbers.
    public class QueryToFetchEvenNumbers
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from number in list
                              where number % 2 == 0
                              select number;

            Console.WriteLine("Even numbers are: ");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
        }

    }
}