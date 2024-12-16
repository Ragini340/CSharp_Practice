using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Interface.Interface_Indexers
{
    public class InterfaceIndexer_Implementor : SampleInterface1, SampleInterface2
    {
        private int[] arrayOfStrings = new int[100];

        public InterfaceIndexer_Implementor()
        {
        }

        public int this[int index] 
        {
            get
            {
                return arrayOfStrings[index];
            }
            set
            {
                arrayOfStrings[index] = value;
            }
        }

        string SampleInterface2.this[int index]
        {
            get
            {
                return arrayOfStrings[index].ToString() + " String";
            }
        }
    }
}

