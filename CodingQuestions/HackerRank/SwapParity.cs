using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.HackerRank
{
    /*Maximum number that can be obtain by swapping adjacent digits of same parity*/
    public class SwapParity
    {
        public static String GetLargestNumber(string num)
        {
            int N = num.Length;
            int[] digits = new int[N];
            for (int i = 0; i < N; i++)
            {
                digits[i] = int.Parse(num[i].ToString());
            }

            List<List<int>> list = new List<List<int>>();
            int left = 0;
            while (left < N)
            {
                int right = left;
                List<int> temp = new List<int>();
                while (right < (N - 1) && (digits[right]) % 2 == (digits[right + 1]) % 2)
                {
                    temp.Add(digits[right]);
                    right++;
                }
                temp.Add(digits[right]);
                temp.Reverse();
                temp.Sort((a, b) => b.CompareTo(a));
                list.Add(temp);
                left = right + 1;
            }

            string result = "";
            foreach (var l in list)
            {
                foreach (var x in l)
                {
                    result = result + x;
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string num = Console.ReadLine();
            /*
            Sample input1: 7596801
            Output: 9758601
            Sample input2: 5528200
            Output: 5582200
            */
            string results = SwapParity.GetLargestNumber(num);
            Console.WriteLine("The largest possible value of swap parity is: " + results);
        }
    }

}
