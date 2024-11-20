using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC
{
    public class ArrayOfString
    {
        static void Main(string[] args)
        {
            String[] str_arr = new String[3];

            // Initialising the array of strings
            str_arr[0] = "Ab";
            str_arr[1] = "Cd";
            str_arr[2] = "Ef";

            //Printing String array
            for (int i = 0; i < str_arr.Length; i++)
            {
                Console.WriteLine("Value at index position" + i + " is " + str_arr[i]);
            }
        }

    }
}
