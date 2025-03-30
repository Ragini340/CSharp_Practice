namespace CSharp_Practice.String_POC.Strings
{
    /*Time Complexity: O(n), where n is the length of the input string.
      Space Complexity: O(1), no extra data structures used.*/
    public class StringPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            //If no mismatch is found, return true (palindrome)
            return true;
        }

        public static void Main(string[] args)
        {
            string s = "abba";
            Console.WriteLine("Is input string is palindrome? " + IsPalindrome(s));
        }

    }
}