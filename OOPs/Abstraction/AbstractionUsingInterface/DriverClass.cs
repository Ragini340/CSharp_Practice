using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.AbstractionUsingInterface
{
    public class DriverClass
    {
        public static void Main(string[] args)
        {
            IBank sbi = BankFactory.GetBankDetails("SBI");
            sbi.ValidateCard();
            sbi.CheckBalance();
            sbi.CheckStatement();
        }
    }
}
