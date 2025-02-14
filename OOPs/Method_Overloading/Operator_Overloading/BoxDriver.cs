namespace CSharp_Practice.OOPs.Method_Overloading.Operator_Overloading
{
    public class BoxDriver
    {
        public static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            Box box4 = new Box();
            box1.SetLength(6.0);
            box1.SetBreadth(7.0);
            box2.SetLength(12.0);
            box2.SetBreadth(13.0);

            Console.WriteLine("Box 1: {0}", box1.ToString());
            Console.WriteLine("Box 2: {0}", box2.ToString());

            //Adding two object as follows:
            box3 = box1 + box2;
            Console.WriteLine("Box 3: {0}", box3.ToString());

            //Comparing the boxes
            if (box1 > box2)
            {
                Console.WriteLine("Box1 is greater than Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not greater than Box2");
            }

            if (box1 < box2)
            {
                Console.WriteLine("Box1 is less than Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not less than Box2");
            }

            if (box1 >= box2)
            {
                Console.WriteLine("Box1 is greater or equal to Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not greater or equal to Box2");
            }

            if (box1 <= box2)
            {
                Console.WriteLine("Box1 is less or equal to Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not less or equal to Box2");
            }

            if (box1 != box2)
            {
                Console.WriteLine("Box1 is not equal to Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not greater or equal to Box2");
            }

            box4 = box3;
            if (box3 == box4)
            {
                Console.WriteLine("Box3 is equal to Box4");
            }
            else
            {
                Console.WriteLine("Box3 is not equal to Box4");
            }
        }
    }
}
