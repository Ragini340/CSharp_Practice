namespace CSharp_Practice.OOPs.Constructor
{
    public class ParameterizedConstructor
    {
        public string name;
        public int id;

        public ParameterizedConstructor(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public static void Main(string[] args)
        {
            ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor("Rag", 340);
            Console.WriteLine("Name is: " + parameterizedConstructor.name);
            Console.WriteLine("Id is: " + parameterizedConstructor.id);
        }

    }
}