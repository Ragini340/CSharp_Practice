using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Destructors
{
    public class DestructorEx
    {
        int real;
        int imaginary;

        public DestructorEx()
        {
            real = 0;
            imaginary = 0;
        }

        public void SetValues(int r, int i)
        {
            real = r;
            imaginary = i;
        }

        public void DisplayValue()
        {
            Console.WriteLine("Real: " + real);
            Console.WriteLine("Imaginary: " + imaginary);
        }

        /*
         * Destructor is not working in VS, but in online compiler it is working
         * https://www.sololearn.com/en/compiler-playground/ciHFz1vNThhY
        */
        ~DestructorEx()
        {
            Console.WriteLine("Destructor was called");
        }

    }
}
