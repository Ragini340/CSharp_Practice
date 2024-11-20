using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.ExceptionHandlings
{
    public class DivisionByZero : Exception
    {
        public DivisionByZero()
        {
            Console.Write("Exception has occurred: ");
        }
    }

    class UserDefinedException
    {
        public double DivisionOperation(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivisionByZero();
            }
            else
            {
                return numerator / denominator;
            }
        }

        static void Main(string[] args)
        {
            UserDefinedException userDefinedException = new UserDefinedException();
            double num = 8, den = 0, quo;
            try
            {
                quo = userDefinedException.DivisionOperation(num, den);
                Console.WriteLine("Quotient : {0}", quo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
