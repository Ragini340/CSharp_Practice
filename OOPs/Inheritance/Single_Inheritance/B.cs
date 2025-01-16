namespace CSharp_Practice.OOPs.Inheritance.Single_Inheritance
{
    public class B : A
    {
        public int k = 60;
        public int x = 40;
        public int y = 80;
        public void Method3()
        {
            Console.WriteLine("Method3 of class B");
        }
        public static void Main()
        {
            A a = new B();
            a.Method1();
            a.Method2();
     
            Console.WriteLine("Value of k: " + a.k); //k = 30, it is pickig from class A as we have created reference of class A and 
                                                     //it is decided at compile time which class reference has been created.

            //Console.WriteLine(a.x); //We cannot access k of A class with reference of A class because we cannot override data 
                                      // member.
            
            //Console.WriteLine(a.x); //We cannot access x of class A as we cannot override the static member x of class A.

            Console.WriteLine(a.y); // y = 40, it is picking from parent class A because parent class reference has been created,
                                    // so overriding is not possible on data members.

            Console.WriteLine("\nWhen I am creating reference as well as object of child class then it will print data member of child class");
           
            /*
            C# supports overriding on instance methods and properties but not on fields or on any static members. 
            It requires an explicit action within both the base class and the derived class. The base class must mark 
            each member for which it allows overriding as virtual. If public or protected members do not include the virtual 
            modifier, subclasses will not be able to override those members.
            */
        }
    }

}