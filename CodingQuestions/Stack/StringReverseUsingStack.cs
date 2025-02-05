namespace CSharp_Practice.CodingQuestions.Stack
{
    public class StringReverseUsingStack
    {
        public void ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                stack.Push(c);   
            }

            string result = "";
            while(stack.Count > 0)
            {
                  result = result +  stack.Pop();
            }
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            StringReverseUsingStack obj = new StringReverseUsingStack();
            obj.ReverseString(str);
        }

    }
}