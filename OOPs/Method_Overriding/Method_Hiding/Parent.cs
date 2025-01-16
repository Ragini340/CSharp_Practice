namespace CSharp_Practice.OOPs.Method_Overriding.Method_Hiding
{
    public class Parent
    {
        public int x;
        public int y = 30;
        public virtual void Show()
        {
            Console.WriteLine("Show method of parent class has been called");
        }

        public void Display()
        {
            Console.WriteLine("Display method of parent class has been called");
        }

        public virtual void Print()
        {
            Console.WriteLine("Print method of parent class has been called");
        }

    }
}