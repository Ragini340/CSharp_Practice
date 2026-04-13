using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.ControlFlow_Statements
{
    public class GoToStatement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executing Statment1");
            goto statement4;   //goto label someLabel:(here statement4:)
            Console.WriteLine("Executing Statment2");
            Console.WriteLine("Executing Statment3");
            statement4:    //label:
            Console.WriteLine("Executing Statment4");
            Console.WriteLine("Executing Statment5");
        }
    }
}