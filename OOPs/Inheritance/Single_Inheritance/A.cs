namespace CSharp_Practice.OOPs.Inheritance.Single_Inheritance
{
    public class A
    {
        //public virtual int k = 10; //We cannot make data member as virtual, so we cannot override the data member in child class B.
        public int k = 30;
        public static int x = 20;
        public int y = 40;
        public void Method1()
        {
            Console.WriteLine("Method1 of class A");
        }
        public void Method2()
        {
            Console.WriteLine("Method2 of class A");
        }
    }

}