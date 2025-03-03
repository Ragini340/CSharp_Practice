namespace CSharp_Practice.AccessSpecifiers.Protected
{
    public class Accessing_ProtectedMember
    {
        public static void Main(string[] args)
        {
            ProtectedModifierPOC protectedModifier = new ProtectedModifierPOC();
            //Accessing name field and printing it
            //'protectedModifier.name' is inaccessible due to its protection level
            //Console.WriteLine("Name: " + protectedModifier.name);
        }

    }
}