﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overloading.Operator_Overloading
{
    public class Box
    {
        private double length;
        private double breadth;
       
        public double getAdditionOfLengthBreadth()
        {
            return length + breadth;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        //Overload + operator to add two Box objects
        public static Box operator+(Box b, Box c)
        {
           Box box = new Box();
           box.length = b.length + c.length;
           box.breadth = b.breadth + c.breadth;
           return box;
        }

        //The comparison operators 
        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length != rhs.length || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length < rhs.length && lhs.breadth < rhs.breadth)
            {

                status = true;
            }
            return status;
        }
        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length > rhs.length && lhs.breadth > rhs.breadth)
            {

                status = true;
            }
            return status;
        }
        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length <= rhs.length && lhs.breadth <= rhs.breadth)
            {

                status = true;
            }
            return status;
        }
        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length >= rhs.length && lhs.breadth >= rhs.breadth)
            {

                status = true;
            }
            return status;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1})", length, breadth);
        }
    }
}