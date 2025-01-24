namespace CSharp_Practice.OOPs.Abstraction.SimpleExample
{
    public class B : A
    {
        public override void Display()
        {
            Console.WriteLine("Display method of class B");
        }

        public override void Print()
        {
            base.Print();
        }

    }
}