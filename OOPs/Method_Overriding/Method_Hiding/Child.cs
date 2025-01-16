namespace CSharp_Practice.OOPs.Method_Overriding.Method_Hiding
{
    public class Child : Parent
    {
        public void Show()
        {
            base.Print();
            base.Show();
            base.Show();
            Console.WriteLine("Show method of child class has been called"); //Since Show method is virtual in parent class but in child class
                                                                             //we are not using override keyword, so this is method hiding.                                           
        }

        public new void Display() //Here we are also performing method hiding as in parent class we have not marked Dispay method as
                                  //virtual.
        {
            Console.WriteLine("Display method of child class has been called");
        }

        public override void Print() //Here we are overriding Print method of parent class.
        {
            Console.WriteLine("Child class print method has been called");
        }

        public static void Main(string[] args)
        {
            Parent parent = new Child();
            parent.Show();
            parent.Display();
            parent.Print();
            //For hiding the parent class method we need to create reference and object of child class.
            Child child = new Child();
            child.Show();
            child.Display();
            child.Print();
            //If we want to print the parent class method then we have to create the instance of parent class.
            Parent parent1 = new Parent();
            parent.x = 100;//We can initialize the data member of parent class using child class object and reference of parent class
            Console.WriteLine(parent.x);
            child.x = 200;//We can access the data member of parent class here in child class due to inheritance concept.
            Console.WriteLine(child.x);
            child.y = 60;
            Console.WriteLine(child.y);
        }

    }
}