namespace CSharp_Practice.OOPs.Abstraction
{
    public abstract class ChildAbstract : AbstractionPOC
    {
        //It is not throwing error the implement Print() abstract method because this class itself is abstract class.
        public void Calculate()
        {
            Console.WriteLine("I am child abstract class");
        }
    }
}
