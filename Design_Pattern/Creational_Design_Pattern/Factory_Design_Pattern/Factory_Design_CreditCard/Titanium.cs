using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern
{
    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 1000;
        }
    }
}
