using CSharp_Practice.AccessSpecifiers.Private;
using CSharp_Practice.AccessSpecifiers.Public;

namespace CSharp_Practice.OOPs
{
    public class PublicAccessSpecifiersPOC_Driver
    {
        public static void Main(string[] args)
        {
            //PublicAccessSpecifiersPOC
            /*public: The public members can be accessed by any other code in the same assembly or another assembly that references it.*/
            PublicAccessSpecifiersPOC publicAccessSpecifiers = new PublicAccessSpecifiersPOC(1, "Ragini");
            Console.WriteLine("Displaying using class members:");
            Console.WriteLine("Employee Id: {0}", publicAccessSpecifiers.empId);
            Console.WriteLine("Name: {0}", publicAccessSpecifiers.name);
            Console.WriteLine("\nDisplaying using methods:");
            Console.WriteLine("Employee Id: {0}", publicAccessSpecifiers.GetEmpId());
            Console.WriteLine("Name: {0}", publicAccessSpecifiers.GetName());

            //PrivateAccessSpecifiersPOC
            /*private: The private members can be accessed only by code in the same class.*/
            PrivateAccessSpecifiersPOC privateAccessModifierPOC = new PrivateAccessSpecifiersPOC();
            /* We cannot access data in below:
            privateAccessModifierPOC.data = 1;
            */
        }

    }
}