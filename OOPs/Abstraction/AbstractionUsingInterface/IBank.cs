using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.AbstractionUsingInterface
{
    public interface IBank
    {
        void ValidateCard(); // No deed to write Interface methods with public and abstract as by default interfaces are public and abstract.
        public void CheckBalance(); // We cannot declare abstract method as private because private methods are inaccessible in
                                    // other classes but interface requires implementations
        public abstract void CheckStatement();
    }
}
