namespace CSharp_Practice.AccessSpecifiers.Internal
{
    /*
     Access is limited to only the current Assembly, that is any class or type declared as internal is accessible anywhere inside 
     the same namespace. It is the default access modifier in C#. It is useful when you want to restrict access to code that should 
     only be used within the same project or library.
    */
    internal class InternalModifierPOC
    {
        int real;
        int img;

        public void SetData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void DisplayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }

        public static void Main(string[] args)
        {
            InternalModifierPOC internalModifierPOC = new InternalModifierPOC();
            internalModifierPOC.SetData(2, 1);
            internalModifierPOC.DisplayData();
        }

    }
}