using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.OOPs.Inheritance;

namespace CSharp_Practice.Interface.Interface_Indexers
{
    public class Driver
    {
        public static void Main()
        {
            InterfaceIndexer_Implementor interfaceIndexer_Implementor = new InterfaceIndexer_Implementor();
            interfaceIndexer_Implementor[1] = 1; 
            Console.WriteLine(((SampleInterface2)interfaceIndexer_Implementor)[1].ToString());
        }
    }
}
