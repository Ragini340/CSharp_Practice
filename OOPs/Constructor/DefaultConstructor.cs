namespace CSharp_Practice.OOPs.Constructor
{
    public class DefaultConstructor
    {
        public int num = 1;
        public int age = 20;

        public DefaultConstructor()
        {
            Console.WriteLine("Default constructor called");
        }

        public static void Main(string[] args)
        {
            DefaultConstructor defaultConstructor = new DefaultConstructor();
            Console.WriteLine(defaultConstructor.num);
            Console.WriteLine(defaultConstructor.age);
        }

    }
}