namespace CSharp_Practice.Interface.Default_Method
{
    public interface IUPIAdditional : IUPI
    {
        //Overriden CashBack method from IUPI interface
        void IUPI.CashBack() //We can override CashBack method of interface IUPI uisng InterfaceName.MethodName
        {
            Console.WriteLine("I am an overriden default method");
        }

        public abstract void ScratchCard();
    }
}