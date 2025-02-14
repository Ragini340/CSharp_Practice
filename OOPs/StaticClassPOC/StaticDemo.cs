namespace CSharp_Practice.OOPs.StaticClassPOC
{
    public static class StaticDemo
    {
        public static int data;

        /*Below constructor cannot be created
        StaticDemo()
        {
          Console.WriteLine("We cannot create the constructor of static class");
        }
        */

        //Area of rectange
        public static int Area(int a, int b)
        {
            return a * b;
        }

        //Area of square
        public static int Area(int a)
        {
            return a * a;
        }

        public static void Print()
        {
            Console.WriteLine("Static method");
        }

    }
}
