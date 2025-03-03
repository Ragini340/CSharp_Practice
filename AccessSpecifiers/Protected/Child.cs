namespace CSharp_Practice.AccessSpecifiers.Protected
{
    public class Child : ProtectedModifierPOC
    {
        public static void Main(string[] args)
        {
            Child child = new Child();
            //Accessing name field and printing it
            Console.WriteLine("Name: " + child.name);
            //Since the protected member can be accessed from derived classes, we are able to access name from the Child class.
        }

    }
}