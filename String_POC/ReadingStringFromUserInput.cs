using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC
{
    public class ReadingStringFromUserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            string read = Console.ReadLine();
            Console.WriteLine("User has been entered : " + read);
        }

    }
}
