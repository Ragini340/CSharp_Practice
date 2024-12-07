using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern.Factory_Design_CreditCard
{
    public class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 200;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 700;
        }
    }
}
