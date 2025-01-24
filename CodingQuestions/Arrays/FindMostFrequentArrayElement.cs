namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class FindMostFrequentArrayElement
    {
        public static int MostFrequentElement(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                if (dic.ContainsKey(key))
                {
                    int freq = dic[key];
                    freq = freq + 1;
                    dic[key] = freq;
                }
                else
                {
                    dic.Add(key, 1);
                }
            }

            int min_count = 0;
            int result = -1;

            foreach (KeyValuePair<int, int> kvp in dic)
            {
                if (min_count < kvp.Value)
                {
                    result = kvp.Key;
                    min_count = kvp.Value;
                }
            }
            return result;
        }

        public static void Main()
        {
            int[] arr = new int[] { 1, 5, 2, 4, 6, 1 };
            Console.Write("Most frequent arr element is: " + MostFrequentElement(arr));
        }

    }
}