﻿namespace CSharp_Practice.Cloning.String_Cloning
{
    public class SampleStringCloning
    {
        public static void Main(string[] args)
        {
            string s1 = "Birds of a feather flock together";
            string s2 = (string)s1.Clone();

            Console.WriteLine("Original string is: " + s1);
            Console.WriteLine("Original string hashcode: " + s1.GetHashCode());
            Console.WriteLine("Cloned sring is: " + s2);
            Console.WriteLine("Cloned sring hashcode: " + s2.GetHashCode());

            s2 = "The end";
            Console.WriteLine("Modified cloned string is:" + s2);
            Console.WriteLine("Modified cloned string hashcode:" + s2.GetHashCode());
        }

    }
}