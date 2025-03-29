namespace CSharp_Practice.OOPs.Inheritance
{
    public class AnimalDriver
    {
        public static void Main(string[] args)
        {
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
        }

    }
}