using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Practice.ExceptionHandlings
{
    public class ExceptionHandlingUsingMultiTryCatch
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 0, 7, 3 };
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An exception has occurred :{0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An exception has occurred :{0}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An exception has occurred :{0}", ex.Message);
            }
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }
        }

    }
}
