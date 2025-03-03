namespace CSharp_Practice.AccessSpecifiers.Protected_Private
{
    public class Child : Protected_PrivateModifier_POC
    {
        public void ShowValue()
        {
            //Access value inside a derived class
            Console.WriteLine("Value = " + value);
        }

        public static void Main(string[] args)
        {
            Protected_PrivateModifier_POC protectedPrivate = new Protected_PrivateModifier_POC();
            //Error: Cannot access protected member 'member' via a qualifier of type 'type1'; the qualifier must be of type 'type2'
            //(or derived from it)
            //protectedPrivate.value = 5;

            //Using public functions to assign and using value of the member 'value'
            protectedPrivate.SetValue(4);
            Console.WriteLine("Value = " + protectedPrivate.GetValue());
        }

    }
}