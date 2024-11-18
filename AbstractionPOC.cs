using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    abstract class AbstractionPOC
    {
        //Abstract method
        public abstract int area();
    }

    //Square class inheriting the AbstractionPOC class
    class Square : AbstractionPOC
    {
        //Private data member
        private int side;

        //Method of Square class
        public Square(int x = 0)
        {
            side = x;
        }

        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }

    }
}
