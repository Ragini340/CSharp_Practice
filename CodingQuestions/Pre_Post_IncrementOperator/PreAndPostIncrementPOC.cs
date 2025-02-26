namespace CSharp_Practice.CodingQuestions.Pre_Post_IncrementOperator
{
    public class PreAndPostIncrementPOC
    {
        public static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 20;
            int postNum = num1++;
            int preNum = ++num2;

            Console.WriteLine("PostNum = " + postNum);  //Output: 15
            Console.WriteLine("num1 = " + num1);  //Output: 16
            Console.WriteLine("PreNum = " + preNum);  //Output: 21
            Console.WriteLine("num2 = " + num2);  //Output: 21
        }

    }
}