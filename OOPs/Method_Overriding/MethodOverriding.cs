namespace CSharp_Practice.OOPs.Method_Overriding
{
    public class MethodOverriding
    {
        public void Show()
        {
            Console.WriteLine("Parent class show method");
        }

        public virtual void Display()
        {
            Console.WriteLine("Parent class Display method");
        }

        public void Print()
        {
            Console.WriteLine("Print method of parent class has been called");
        }
    }
}
