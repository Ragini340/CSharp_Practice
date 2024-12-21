using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.SpecFlowCalculatorApp
{
    public class CalculatorApp
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }

        public int Add()
        {
            return FirstNum + SecondNum;
        }
    }

}
