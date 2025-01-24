namespace CSharp_Practice.OOPs.Abstraction.SimpleExample
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            //A a = new A(); //Cannot create an instance of the abstract type or interface 'A'
            B b = new B();
            b.Display();    //Output: Display method of class B
            b.Print();      //Output: Print method of class A
            A a1 = new B();
            a1.Display();   //Output: Display method of class B
            a1.Print();    //Output: Print method of class A
        }

    }
}