using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.UsingAbstractClassAndAbstractMethods
{
    public class BankDetails : Bank
    {
        public override void CheckBalance()
        {
            Console.WriteLine("Balance");
        }

        public override void CheckStatement()
        {
          Console.WriteLine("Statement");
        }

        public override void UpdateBalance()
        {
            Console.WriteLine("Update Balance");
        }
    }
}
