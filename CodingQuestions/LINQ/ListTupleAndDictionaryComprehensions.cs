namespace CSharp_Practice.CodingQuestions.LINQ
{
    public class ListTupleAndDictionaryComprehensions
    {
        public static void ListTupleAndDictionaryComprehension()
        {
            //List comprehension to get squares of numbers from 1 to 10
            var lists = Enumerable.Range(1, 10);
            var squares = lists.Select(n => n * n).ToList();
            Console.WriteLine("List comprehension to get squares of numbers from 1 to 10: ");
            foreach (var item in squares)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Creating tuples of (number, square) from numbers 1 to 5
            var tuples = Enumerable.Range(1, 5);
            var tupleList = tuples.Select(n => (n, n * n)).ToList();
            Console.WriteLine("\nTuples of (number, square) from numbers 1 to 5: ");
            foreach (var item in tupleList)
            {
                Console.WriteLine($"Number: {item.n}, Square: {item.Item2}");
            }

            //Creating a dictionary with numbers as keys and their squares as values
            var dic = Enumerable.Range(1, 5);
            var numberSquareDict = dic.ToDictionary(n => n, n => n * n);
            Console.WriteLine("\nDictionary with numbers as keys and their squares as values: ");
            foreach (var kvp in numberSquareDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        public static void Main(string[] args)
        {
            ListTupleAndDictionaryComprehension();
        }

        /*      
        List comprehension: Achieved using LINQ Select and ToList().
        Tuple comprehension: Achieved using LINQ Select with ValueTuple.
        Dictionary comprehension: Achieved using LINQ ToDictionary.
        */

    }
}