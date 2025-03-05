namespace CSharp_Practice.CodingQuestions
{
    /*
    Given an array of strings strs, group the anagrams together. You can return the answer in any order.
     */

    /*
     Time complexity: O(m∗nlogn)
     Space complexity: O(m∗n)
     where, m is the number of strings and n is the length of the longest string.
     */
    public class GroupAnagrams
    {
        public List<List<string>> GroupAnagram(string[] str)
        {
            var result = new Dictionary<string, List<string>>();
            foreach (var s in str)
            {
                char[] charArray = s.ToCharArray();
                Array.Sort(charArray);
                string sorted = new string(charArray);
                if (!result.ContainsKey(sorted))
                {
                    result[sorted] = new List<string>();
                }
                result[sorted].Add(s);
            }
            return result.Values.ToList<List<string>>();
        }

        public static void Main(string[] args)
        {
            string[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };
            GroupAnagrams obj = new GroupAnagrams();
            List<List<string>> result = obj.GroupAnagram(arr);
            foreach (var group in result)
            {
                foreach (var word in group)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }
        }

    }
}