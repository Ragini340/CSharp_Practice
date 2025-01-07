namespace CSharp_Practice.CodingQuestions.Strings
{
    //Longest Common Prefix using Sorting
    public class LongestCommonPrefix
    {
        public static string FindLongestCommonPrefix(string[] arr)
        {
            string first = arr[0];
            string last = arr[arr.Length - 1];
            int minLength = Math.Min(first.Length, last.Length);

            int i = 0;
            while (i < minLength && first[i] == last[i])
            {
                i = i + 1;
            }
            return first.Substring(0, i);
        }

        public static void Main(string[] args)
        {
            string[] arr = { "unpleasant", "undo", "unhappy" };
            Array.Sort(arr);
            Console.WriteLine("Sorted array of string in ascending order is:-");
            foreach (string s in arr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine(FindLongestCommonPrefix(arr));
        }
    }

}