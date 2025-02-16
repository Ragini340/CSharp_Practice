namespace CSharp_Practice.CodingQuestions.Strings
{
    /*Write a program to find duplicate letter using Dictionary*/
    public class FindDuplicateLetters
    {
        public static void FindDuplicateLetter(string str)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary[c] = 1;
                }
            }

            Console.WriteLine("Duplicate characters and their counts are:");
            foreach (KeyValuePair<char, int> kvps in dictionary)
            {
                if (kvps.Value > 1)
                {
                    Console.WriteLine("{0} -> {1}", kvps.Key, kvps.Value);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            FindDuplicateLetter(str);
        }

    }
}
