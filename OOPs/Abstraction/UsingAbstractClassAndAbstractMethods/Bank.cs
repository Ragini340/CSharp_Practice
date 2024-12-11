using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.UsingAbstractClassAndAbstractMethods
{
    public abstract class Bank
    {
        public abstract void CheckBalance();
        public abstract void UpdateBalance();
        public abstract void CheckStatement();
    }
}
