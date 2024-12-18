using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.DependencyInversionPrinciple.Without_DependencyInversionPrinciple
{
    public class CreditCard
    {
        public void DoTransaction(int amount)
        {
            Console.WriteLine("Transaction done with CreditCard");
        }
    }
}
