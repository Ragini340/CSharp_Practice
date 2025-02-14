namespace CSharp_Practice.OOPs.Abstraction
{
    public class ChildAbstract_Implementor : ChildAbstract
    {
        public override void Area()
        {
            Console.WriteLine("Area of ChildAbstract_Implementor");
        }

        public void Calculate()
        {
            Console.WriteLine("I am in non-abstract child class");
        }

    }
}
