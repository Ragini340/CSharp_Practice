namespace CSharp_Practice.OOPs.Abstraction
{
    public abstract class AbstractionPOC
    {
        //Abstract method
        //We can't declare this abstract method in child class non abstract 
        public abstract void Area();

        /*Below calculate method cannot be overriden in abstract child class because it is not marked
         with abstract or virtual or override*/

        /*public void Calculate()
        {
            Console.WriteLine("I am the parent abstract class");
        }*/

        /*public abstract void Print()
        {
         We cannot declare the body here beacuse the method is marked as abstract.
        }*/
    }

    //Square class inheriting the AbstractionPOC class
    class Square : AbstractionPOC
    {
        //Private data member
        private int side;

        //Constructor of Square class
        public Square(int x = 0)
        {
            side = x;
        }

        public override void Area()
        {
            Console.Write("Area of Square: ");
            //return (side * side);
        }

    }
}
