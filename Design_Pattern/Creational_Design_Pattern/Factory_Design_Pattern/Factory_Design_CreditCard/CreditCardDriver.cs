using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern.Factory_Design_CreditCard
{
    public class CreditCardDriver
    {
        public static void Main(string[] args)
        {
            CreditCard cardDetails1 = CreditCardFactory.GetCreditCard("MoneyBack");
            Console.WriteLine();
            CreditCard cardDetails2 = CreditCardFactory.GetCreditCard("Titanium");
            Console.WriteLine();
            CreditCard cardDetails3 = CreditCardFactory.GetCreditCard("Platinum");
            Console.WriteLine();
        }
    }
}
