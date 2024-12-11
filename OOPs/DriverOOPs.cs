using CSharp_Practice.AccessModifiers.Private;
using CSharp_Practice.AccessModifiers.Protected;
using CSharp_Practice.AccessModifiers.Public;
using CSharp_Practice.OOPs.Abstraction;
using CSharp_Practice.OOPs.ClassAndObjects;
using CSharp_Practice.OOPs.Constructor;
using CSharp_Practice.OOPs.Encapsulation;
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
            //var result = abstractionPOC.area();
            //Console.Write("{0}", result);
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
            Console.WriteLine();

            /*ParametrizedConstructor*/
            ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor("Rag", 340);
            Console.WriteLine("Name is: " + parameterizedConstructor.name);
            Console.WriteLine("Id is: " + parameterizedConstructor.id);
            Console.WriteLine();

            /*EncapsulationPOC*/
            EncapsulationPOC encapsulationPOC = new EncapsulationPOC();
            encapsulationPOC.Name = "test";
            encapsulationPOC.Age = 5;
            Console.WriteLine("Name: " + encapsulationPOC.Name);
            Console.WriteLine("Age: " +encapsulationPOC.Age);
            Console.WriteLine();

            /*Encapsulations*/
            Encapsulations encapsulations = new Encapsulations();
            encapsulations.Name = "Rag";
            encapsulations.Email = "test1@gmail.com";
            encapsulations.Id = 12;
            Console.WriteLine("Name: " + encapsulations.Name);
            Console.WriteLine("Email: " + encapsulations.Email);
            Console.WriteLine("Id: " + encapsulations.Id);
            Console.WriteLine();

            //Abstractions
            ChildAbstract_Implementor childAbstract = new ChildAbstract_Implementor(); //Here reference of child class 
            childAbstract.area();
            childAbstract.calculate();

            ChildAbstract obj = new ChildAbstract_Implementor(); //Here reference of Abstract class, so it is calling calculate of Abstract class method
            obj.calculate();

            //PublicAccessModifierPOC
            /*public: The public members can be accessed by any other code in the same assembly or another assembly that references it.*/
            PublicAccessModifierPOC publicAccessModifierPOC = new PublicAccessModifierPOC();
            publicAccessModifierPOC.data = 1;

            //PrivateAccessModifierPOC
            /*private: The private members can be accessed only by code in the same class.*/
            PrivateAccessModifierPOC privateAccessModifierPOC = new PrivateAccessModifierPOC();
            /* We cannot access data in below:
            privateAccessModifierPOC.data = 1;
            */

            //ProtectedAccessModifierPOC
            /*protected: The protected Members in C# are available within the same class as well as to the classes that are derived from that class.*/
            ProtectedAccessModifierPOC protectedAccessModifierPOC = new ProtectedAccessModifierPOC();
            /*'member' is inaccessible due to its protection level 
            protectedAccessModifierPOC.data = 1;
            */
        }

    }
}
