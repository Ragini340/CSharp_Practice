namespace CSharp_Practice.CodingQuestions.Strings
{
    /*
     Given two strings S1 and S2, the task is to find if S1 is a substring of S2. If yes, return the index of the first occurrence, else
     return -1.
     */
    /*
     Time complexity: O(s1.Length * s2.Length) 
     Space complexity: O(1), as no extra space is required.
    */
    public class CheckIfAStringIsSubstringOfAnother
    {
        public static int FindSubstring(string s1, string s2)
        {
            //Iterating through s2
            for (int i = 0; i <= s2.Length - s1.Length; i++)
            {
                int j;
                for (j = 0; j < s1.Length; j++)
                {
                    if (s2[i + j] != s1[j])
                    {
                        break;
                    }
                }

                if (j == s1.Length)
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            string s2 = "Ragini";
            string s1 = "gin";
            Console.WriteLine("The index of the first occurrence is: " + FindSubstring(s1, s2));
        }

    }
}