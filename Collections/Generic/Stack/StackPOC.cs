namespace CSharp_Practice.Collections.Generic.Stack
{
    public class StackPOC
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(3);
            //stack.Push(null); //Compile-Time Error as int is not a Reference type so null can not be accepted by this stack.
            Console.WriteLine("Stack elements are: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Contains
            Console.WriteLine("\nIs value 1 present in the Stack? " + stack.Contains(1));

            //Pop
            stack.Pop();
            Console.WriteLine("\nNow Stack elements are: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Peek
            stack.Peek();
            Console.WriteLine("\nStack elements are: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Clear
            stack.Clear();
            Console.WriteLine("\nItem's count: " + stack.Count);

            Stack<int> stack1 = new Stack<int>();
            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);
            stack1.Push(40);
            Console.WriteLine("\nstack1 elements are: ");
            foreach (var element in stack1)
            {
                Console.WriteLine(element);
            }

            //Copying the stack to an object array
            int[] arr = new int[4];
            //CopyTo(T[] array, int arrayIndex)
            stack1.CopyTo(arr, 0);
            Console.WriteLine("\nArray elements are: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}