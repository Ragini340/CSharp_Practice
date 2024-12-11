using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.AbstractionUsingInterface
{
    public class BankFactory
    {
        public static IBank GetBankDetails(string type)
        {
            IBank bank = null;
            if (type == "SBI")
            {
                bank = new SBI();
            }
            return bank;
        }
    }
}
