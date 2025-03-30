namespace CSharp_Practice.OOPs.Method_Overloading
{
    public class MethodOverloadingPOCs
    {
        //Program to demonstrate the function overloading by changing the Number of parameters
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        //Program to demonstrate the function overloading by changing the Data types of the parameters 
        public int Add(int a)
        {
            int sum = a;
            return sum;
        }
        public double Add(double a)
        {
            double sum = a;
            return sum;
        }

        //Program to demonstrate the function overloading by changing the Order of the parameters
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
        }
        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
        }

        //Program to show error when method signature is the same and the return type is different.
        public int Add(int a, int b, int c, int d)
        {
            int sum = a + b + c + d;
            return sum;
        }
        /*Below Add method will throw error as:-
        Type already defines a member called 'Add' with the same parameter types
        public double Add(int a, int b, int c, int d)
        {
            double sum = a + b + c + d;
            return sum;
        }
        What happens when method signature is same and the return type is different?
        =>The compiler will give error as the return value alone is not sufficient for the compiler to figure out which function 
        it has to call. Only if both methods have different parameter types (so, they have the different signature), then Method
        overloading is possible. Hence, complile time error will be thrown.
        */

        //Constructor overloading
        public MethodOverloadingPOCs()
        {
           Console.WriteLine("Default constructor will also act as method overloading.");
        }

        public MethodOverloadingPOCs(int a, int b)
        {
            Console.WriteLine("Parametrized constructor will also act as method overloading.");
        }

        static MethodOverloadingPOCs()
        {
            Console.WriteLine("Static constructor will also act as method overloading.");
        }

        public static void Main(string[] args)
        {
            MethodOverloadingPOCs methodOverloadingPOCs = new MethodOverloadingPOCs();
            MethodOverloadingPOCs obj = new MethodOverloadingPOCs(1, 2);

            int sum1 = methodOverloadingPOCs.Add(1, 2);
            Console.WriteLine("Sum of the two integer value: " + sum1);
            int sum2 = methodOverloadingPOCs.Add(1, 2, 3);
            Console.WriteLine("Sum of the three integer value: " + sum2);

            int sum3 = methodOverloadingPOCs.Add(1);
            Console.WriteLine("sum is: " + sum3);
            double sum4 = methodOverloadingPOCs.Add(1.0);
            Console.WriteLine("sum is: " + sum4);

            methodOverloadingPOCs.Identity("Gabby", 1);
            methodOverloadingPOCs.Identity(2, "Bree");
        }

    }
}