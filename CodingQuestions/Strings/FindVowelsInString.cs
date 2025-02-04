namespace CSharp_Practice.CodingQuestions.Strings
{
    public class FindVowelsInString
    {
        public static int FindVowels(String str)
        {
            int vowelCount = 0;

            if (str != null)
            {
                var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
                foreach (char ch in str.ToLower())
                {
                    if (vowels.Contains(ch))
                    {
                        vowelCount++;
                    }
                }
            }

            return vowelCount;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Vowels count is: " + FindVowels(str));
        }

    }
}