namespace CSharp_Practice.Extension_Method
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputString)
        {
            if(!string.IsNullOrEmpty(inputString))
            {
                string[] strArr = inputString.Split(' ');
                return strArr.Count();
            }
            else
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {
            string word = "C# extension method";
            int wordCount = word.GetWordCount();
            Console.WriteLine("Input string word is: " + word);
            Console.WriteLine("\nWord count is: " + wordCount);
        }
    }
}
