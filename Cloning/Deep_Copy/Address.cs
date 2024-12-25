using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning.Deep_Copy
{
    public class Address : ICloneable
    {
        public string CityName { get; set; }
        public string StateName { get; set; }
        public int PinCode { get; set; }

        public Address() { }

        public override string ToString()
        {
            return this.CityName;
        }

        public Object Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
