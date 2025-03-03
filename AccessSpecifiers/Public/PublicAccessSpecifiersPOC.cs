namespace CSharp_Practice.AccessSpecifiers.Public
{
    /*
     public modifier provides access to the entire program. It means that another method or another assembly which contains the class 
     reference can access these members or types. This access modifier has the most permissive access level in comparison to all other 
     access modifiers.
    */
    public class PublicAccessSpecifiersPOC
    {
        public int empId;
        public string name;

        public PublicAccessSpecifiersPOC(int Id, string Name)
        {
            empId = Id;
            name = Name;
        }

        public int GetEmpId()
        {
            return empId;
        }

        public string GetName()
        {
            return name;
        }

        public static void Main(string[] args)
        {
            PublicAccessSpecifiersPOC publicAccessSpecifiers = new PublicAccessSpecifiersPOC(1, "Ragini");
            Console.WriteLine("Displaying using class members:");
            Console.WriteLine("Employee Id: {0}", publicAccessSpecifiers.empId);
            Console.WriteLine("Name: {0}", publicAccessSpecifiers.name);
            Console.WriteLine("\nDisplaying using methods:");
            Console.WriteLine("Employee Id: {0}", publicAccessSpecifiers.GetEmpId());
            Console.WriteLine("Name: {0}", publicAccessSpecifiers.GetName());
        }

    }
}