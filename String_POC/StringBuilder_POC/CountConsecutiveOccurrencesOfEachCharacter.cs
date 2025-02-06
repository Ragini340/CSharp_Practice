using System.Text;

namespace CSharp_Practice.String_POC.StringBuilder_POC
{
    /*Input: Test
      Output: 1T1E1S1T
    */
    public class CountConsecutiveOccurrencesOfEachCharacter
    {
        public static string FindCharacterCountString(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1 && str[i] == str[i + 1])
                {
                    count = count + 1;
                }
                else
                {
                    stringBuilder.Append(count);
                    stringBuilder.Append(str[i]);
                    count = 1;
                }
            }

            return stringBuilder.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            string result = FindCharacterCountString(str);
            Console.WriteLine(result.ToUpper());
        }

    }
}