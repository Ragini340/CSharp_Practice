using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.UsingAbstractClassAndAbstractMethods
{
    public class FactoryBank
    {
        public static Bank GetBankDetail(string type)
        {
            Bank bank = null;
            if (type == "SBI Bank")
            {
                bank = new BankDetails();
            }
            return bank;
        }
    }
}
