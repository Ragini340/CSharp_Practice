using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.DependencyInversionPrinciple.With_DependencyInversionPrinciple
{
    public class DebitCard : BankCard
    {
        public void DoTransaction(int amount)
        {
            Console.WriteLine("Transaction done with DebitCard");
        }
    }
}
