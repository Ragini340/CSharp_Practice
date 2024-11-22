using CSharp_Practice.OOPs.Abstraction;
using CSharp_Practice.OOPs.ClassAndObjects;
using CSharp_Practice.OOPs.Constructor;
using CSharp_Practice.OOPs.Inheritance;

namespace CSharp_Practice.OOPs
{
    public class DriverOOPs
    {
        public static void Main()
        {
            /*--CopyConstructor--*/
            //Creating a new object of class
            CopyConstructor copyConstructor1 = new CopyConstructor("Aug", 2000);
            //Copying copyConstructor1 details copying to copyConstructor2
            CopyConstructor copyConstructor2 = new CopyConstructor(copyConstructor1);
            Console.WriteLine("CopyConstructor: ");
            Console.WriteLine(copyConstructor2.Details);
            Console.WriteLine();

            /*--PrivateConstructor--*/
            PrivateConstructor.count = 99;
            // Accessing without any instance of the class
            PrivateConstructor.CountMethod();
            Console.WriteLine("PrivateConstructor: ");
            Console.WriteLine(PrivateConstructor.count);
            // Accessing without any instance of the class
            PrivateConstructor.CountMethod();
            Console.WriteLine(PrivateConstructor.count);
            Console.WriteLine();

            /*--StaticConstructor--*/
            // Here Both Static and instance constructors are invoked for first instance
            StaticConstructor staticConstructor = new StaticConstructor(1);
            Console.WriteLine(staticConstructor.StaticConstructorDetail("Rag", 1));
            // Here only instance constructor
            // will be invoked
            StaticConstructor obj1 = new StaticConstructor(2);
            Console.WriteLine(obj1.StaticConstructorDetail("RagSin", 2));
            Console.WriteLine();

            /*--Animal--*/
            //Single inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            //Multi-level inheritance
            Horse horse = new Horse();
            horse.Eat();
            horse.Run();
            horse.Gallop();
            //Hierarchical inheritance
            Eagle eagle = new Eagle();
            Penguin penguin = new Penguin();
            eagle.Fly();
            eagle.Hunt();
            penguin.Fly();
            penguin.Swim();
            //Multiple inheritance
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();
            Console.WriteLine();

            /*--Abstraction--*/
            //Creating reference of shape class which refer to AbstractionPOC class instance
            AbstractionPOC abstractionPOC = new Square(4);
            int result = abstractionPOC.area();
            Console.Write("{0}", result);
            Console.WriteLine();

            /*--ClassAndObject--*/
            // Creating object
            ClassAndObject classAndObject = new ClassAndObject("Rag", "Abc", 5, "white");
            Console.WriteLine(classAndObject.PrintProperties());
            Console.WriteLine();

            /*DefaultConstructor*/
            DefaultConstructor defaultConstructor = new DefaultConstructor();
            Console.WriteLine(defaultConstructor.num);
            Console.WriteLine(defaultConstructor.age);

        }

    }
}
