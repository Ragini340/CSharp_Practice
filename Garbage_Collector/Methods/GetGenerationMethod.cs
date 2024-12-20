using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Garbage_Collector.Methods
{
    //This method returns the generation number of the target object.
    //It requires a single parameter that is the target object for which the generation number is required.
    //In the below code, GetGeneration() method will return the generation number of the target object.
    //Object of the class will be passed as a input parameter for the GetGeneration() method.
    //When we will execute the calss it will show the output as 0.
    public class GetGenerationMethod
    {
        public static void Main(string[] args)
        {
            GetGenerationMethod getGenerationMethod = new GetGenerationMethod();
            Console.WriteLine("Total number of generations for the created getGenerationMethod object is: " + GC.GetGeneration(getGenerationMethod));
            GC.Collect(0);
            Console.WriteLine("Garbage collection in generation 0 is: " + GC.CollectionCount(0));
        }
    }
}
