namespace CSharp_Practice.OOPs.Method_Overriding
{
    public class MethodOverridingDriver
    {
        public static void Main(string[] args)
        {
            MethodOverriding methodOverriding = new MethodOverridingChild();
            methodOverriding.Show(); //It will execute parent class show method.
            MethodOverridingChild methodOverridingChild = new MethodOverridingChild(); //During compilation time, it will check is there
                                                                                       //Show() available in given reference class, here
                                                                                       //we have created reference of child class but we
                                                                                       //can see we have not overriden or written show()
                                                                                       //in child class but due to inheritance concept
                                                                                       //compiler will check show() in child class first
                                                                                       //here, if it is not available in child class then
                                                                                       //it will check in parent class, if it is present
                                                                                       //then it will compile succesfully.
                                                                                       
            methodOverridingChild.Show(); //During run time it checks for which class object is created, here we have created object of
                                          //child class, so it will execute Show() of child class but this method is not available in
                                          //child class so, it wll check in parent class and it will execute Show() of parent class.
            Console.WriteLine();
            methodOverriding.Display();
            methodOverridingChild.Display();
            methodOverriding.Print();
        }
    }
}
