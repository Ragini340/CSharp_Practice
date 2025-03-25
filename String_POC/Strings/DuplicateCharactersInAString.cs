namespace CSharp_Practice.String_POC.Strings
{
    public class DuplicateCharactersInAString
    {
        public static void FindDuplicateCharacters(string str)
        {
            int[] count = new int[256];

            Console.WriteLine("Duplicate characters in the string and their counts are:");

            foreach (char c in str)
            {
                count[c] = count[c] + 1;
            }

            for (int i = 0; i < 256; i++)
            {
                if (count[i] > 1)
                {
                    Console.WriteLine($"Character: {(char)i}, Count: {count[i]}");
                }
            }
        }

        public static void Main()
        {
            string inputString = "Hello";
            FindDuplicateCharacters(inputString);
        }
          
    }
}