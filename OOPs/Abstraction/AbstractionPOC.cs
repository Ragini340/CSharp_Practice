﻿using OOPs_Practice.OOPs.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Practice.OOPs.Abstraction
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