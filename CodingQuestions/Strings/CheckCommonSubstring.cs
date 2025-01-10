namespace CSharp_Practice.CodingQuestions.Strings
{
    /*Given two arrays of strings, determine whether corresponding elements contain a substring
     Ex:- a = ['ab', 'hi', 'hello', 'cd', 'ef']     
          b = ['af', 'bye', 'world', 'ee', 'ef']          
    For each test, print the result on a new line, either YES if there is a common substring, or NO.
    */
    public class CheckCommonSubstring
    {
        public static void CommonSubstring(List<string> a, List<string> b)
        {
            int sizeA = a.Count;
            int sizeB = b.Count;
            int range = (a.Count < b.Count) ? a.Count : b.Count;

            for (int i = 0; i < range; i++)
            {
                if (CommonChars(a[i], b[i]))
                {
                    Console.WriteLine("\nYES\n");
                }
                else
                {
                    Console.WriteLine("\nNO\n");
                }
            }
        }

        public static bool CommonChars(string str1, string str2)
        {
            HashSet<char> set1 = new HashSet<char>(str1);
            Console.WriteLine("Characters in Set1:-");
            foreach (var item in set1)
            {
                Console.Write(item + " ");
            }

            HashSet<char> set2 = new HashSet<char>(str2);
            Console.WriteLine("\nCharacters in Set2:-");
            foreach (var item in set2)
            {
                Console.Write(item + " ");
            }

            foreach (char c in set1)
            {
                if (set2.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }


    }

    public class Driver
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>()
            {
                "ab",
                "hi",
                "hello",
                "cd",
                "ef"
            };
            List<string> list2 = new List<string>()
            {
                "af",
                "bye",
                "world",
                "ee",
                "ef"
            };

            CheckCommonSubstring.CommonSubstring(list1, list2);
        }
    }

}