using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.WithoutAbstraction
{
    public class SBI
    {
        public void WithDrawMoney()
        {
            Console.WriteLine("Withdrawing money from SBI bank");
        }

        public void DepositMoney()
        {
            Console.WriteLine("Depositing money in SBI bank");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Checking balance in SBI bank");
        }

        public void MiniStatement()
        {
            Console.WriteLine("Getting mini statement from SBI bank");
        }
    }
}