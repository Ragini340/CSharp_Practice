using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern
{
    public class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 2000;
        }
    }
}
