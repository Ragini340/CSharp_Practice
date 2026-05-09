using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.WithoutAbstraction
{
    public class AXIS
    {
        public void WithDrawMoney()
        {
            Console.WriteLine("Withdrawing money from AXIS bank");
        }

        public void DepositMoney()
        {
            Console.WriteLine("Depositing money in AXIS bank");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Checking balance in AXIS bank");
        }

        public void MiniStatement()
        {
            Console.WriteLine("Getting mini statement from AXIS bank");
        }
    }
}