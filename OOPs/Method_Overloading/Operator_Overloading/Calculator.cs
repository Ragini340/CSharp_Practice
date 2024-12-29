using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overloading.Operator_Overloading
{
    public class Calculator
    {
        public int number1;
        public int number2;

        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static Calculator operator -(Calculator c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }

        public static int operator +(Calculator a,int b)  //If we pass only premitive type of data for both parameter like +(int a,int b), it will
        {                                                 //throw error for "One of the parameters of a binary operator must be the containing type"
            return a + b;                                 //,it means operator overloading can't be perform on premitive data types.
        }
        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }
    }
}
