namespace CSharp_Practice.OOPs.Method_Overriding
{
    public class MethodOverridingChild : MethodOverriding
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Child class Display method has been called");
        }

        // public override Show() { } //Since Show method in parent class is not virtaul, so we cannot use override keyword in child
                                     // class.


        public void Print()  //This Print method will be considered as method of child class because we have not used virtual keyword 
                             // in parent class with Print method, so it will depend on reference which method shoud be executed at
                             // compile time.
        {
            Console.WriteLine("Print method of child class has been called");
        }
    }
}
