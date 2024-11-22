using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class ParameterizedConstructor
    {
        public string name;
        public int id;

        public ParameterizedConstructor(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

    }
}
