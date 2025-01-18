namespace CSharp_Practice.Interface.Diamond_Problem.Diamond_Problem_New
{
    public interface B : A
    {
        void A.Method()
        {
            Console.WriteLine("I am from interface B");
        }
    }
}