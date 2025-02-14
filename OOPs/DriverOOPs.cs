using CSharp_Practice.AccessSpecifiers.Private;
using CSharp_Practice.AccessSpecifiers.Public;
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
            AbstractionPOC abstractionPOC = new Square(4);  //Which class should be instantiated It decide at run time  so It is called Dynamic polymorphism 
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

            //Abstractions
            ChildAbstract_Implementor childAbstract = new ChildAbstract_Implementor(); //Here reference of child class 
            childAbstract.Area();
            childAbstract.Calculate();

            ChildAbstract obj = new ChildAbstract_Implementor(); //Here reference of Abstract class, so it is calling calculate of Abstract class method
            obj.Calculate();

            //PublicAccessSpecifiersPOC
            /*public: The public members can be accessed by any other code in the same assembly or another assembly that references it.*/
            PublicAccessSpecifiersPOC publicAccessModifierPOC = new PublicAccessSpecifiersPOC();
            publicAccessModifierPOC.data = 1;

            //PrivateAccessSpecifiersPOC
            /*private: The private members can be accessed only by code in the same class.*/
            PrivateAccessSpecifiersPOC privateAccessModifierPOC = new PrivateAccessSpecifiersPOC();
            /* We cannot access data in below:
            privateAccessModifierPOC.data = 1;
            */

        }

    }
}
