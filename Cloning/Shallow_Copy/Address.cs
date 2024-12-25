using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning.Shallow_Copy
{
    public class Address
    {
        public string CityName { get; set; }
        public string StateName { get; set; }
        public int PinCode { get; set; }

        public Address() { }
       
        public override string ToString()
        {
            return CityName;
        }
    }
}
