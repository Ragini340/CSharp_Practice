namespace CSharp_Practice.Threads.MultiThreading.Type_Safe_ThreadFunction
{
    public class HelperNumber
    {
        int _Number;
        public HelperNumber(int Number)
        {
            _Number = Number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _Number; i++)
            {
                Console.WriteLine("Method1 Type-Safe: " + i);
            }
        }

    }
}