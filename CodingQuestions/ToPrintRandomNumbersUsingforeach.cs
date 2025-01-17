namespace CSharp_Practice.CodingQuestions
{
    /*
      Print ten random numbers using foreach
   */
    public class ToPrintRandomNumbersUsingforeach
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNum = random.Next();
                list.Add(randomNum);
            }

            Console.WriteLine("Ten random numbers are: ");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
        }

    }
}