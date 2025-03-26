namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class FindLargestConsecutiveSequenceInArray
    {
        public static int[] FindLargestConsecutiveSequence(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return new int[0];
            }

            HashSet<int> set = new HashSet<int>(arr);
            int longestStart = 0;
            int longestLength = 0;

            foreach (var item in set)
            {
                if (!set.Contains(item - 1))
                {
                    int currentNum = item;
                    int currentLength = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }
                    if (currentLength > longestLength)
                    {
                        longestLength = currentLength;
                        longestStart = item;
                    }
                }
            }

            int[] result = new int[longestLength];
            for (int i = 0; i < longestLength; i++)
            {
                result[i] = longestStart + i;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };  //Output: 1, 2, 3, 4
            int[] largestSequence = FindLargestConsecutiveSequence(arr);
            Console.WriteLine("Largest consecutive sequence is:");
            Console.WriteLine(string.Join(", ", largestSequence));
        }

    }
}