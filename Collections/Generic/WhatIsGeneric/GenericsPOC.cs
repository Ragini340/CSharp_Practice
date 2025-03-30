namespace CSharp_Practice.Collections.Generic.WhatIsGeneric
{
    public class GenericsPOC
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        public static void Main(string[] args)
        {
            bool isEqual = GenericsPOC.AreEqual(20.5, 20.5);
            if (isEqual)
            {
                Console.WriteLine("Both the numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }
        }

    }
}