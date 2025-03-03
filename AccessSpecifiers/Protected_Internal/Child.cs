namespace CSharp_Practice.AccessSpecifiers.Protected_Internal
{
    public class Child : Protected_InternalPOC
    {
        public static void Main(String[] args)
        {
            Child obj = new Child();
            obj.value = 9;   //Member value is accessible
            Console.WriteLine("Value = " + obj.value);
        }
    }
}