namespace CSharp_Practice.AccessSpecifiers.Private
{
    /*
     private access modifier limits access to members of a class so that only the class itself can use them. Private members cannot 
     be accessed from outside the class, not even by derived classes.
     */
    public class PrivateAccessSpecifiersPOC
    {
        private int data;
        public void SetValue(int value)
        {
            data = value;
        }

        public int GetValue()
        {
            return data;
        }

        public static void Main(string[] args)
        {
            PrivateAccessSpecifiersPOC privateAccessSpecifiers = new PrivateAccessSpecifiersPOC();
            privateAccessSpecifiers.SetValue(4);
            Console.WriteLine("Value = " + privateAccessSpecifiers.GetValue());
        }

    }
}