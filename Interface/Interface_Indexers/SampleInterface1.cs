using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Interface.Interface_Indexers
{
    public interface SampleInterface1
    {
        int this[int index]
        {
            get;
            set;
        }
    }
}
