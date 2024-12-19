using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Arrays
{
    //Input array: { 1, 2, 0, 4, 3, 0, 5, 0, 7 }
    //Output array:{ 1, 2, 4, 3, 5, 7, 0, 0, 0 }

    //Test case 2: { 1, 2, -1, 4, 3, -1, 5, -1, 7 }
    //Output array:{ 1, 2, 4, 3, 5, 7, -1, -1, -1 }
    public class MoveZerosAtEnd
    {
        static void MoveAllZerosToEndInArray(int[] arr)
        {
            int count = 0;
            int k = 0;
            int[] resultArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    count++;
                }
                else
                {
                    resultArr[k] = arr[i];
                    k= k + 1;
                }

            }

            //For Test case 2: { 1, 2, -1, 4, 3, -1, 5, -1, 7 }
            /*for (int i = k; i < arr.Length; i++)
            {
                resultArr[i] = -1;
            }*/
            
            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine(resultArr[i]);
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 4, 3, 0, 5, 0, 7 };
            MoveAllZerosToEndInArray(arr);
        }

    }
}