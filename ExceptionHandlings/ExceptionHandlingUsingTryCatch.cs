using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.ExceptionHandlings
{
    public class ExceptionHandlingUsingTryCatch : System.Exception
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
        }

    }
}
