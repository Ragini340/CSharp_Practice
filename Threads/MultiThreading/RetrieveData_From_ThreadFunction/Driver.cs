namespace CSharp_Practice.Threads.MultiThreading.RetrieveData_From_ThreadFunction
{
    public class Driver
    {
        public static int ResultCallBackMethod(int result)
        {
            int res = result;
            Console.WriteLine(res);
            return res;
        }

        public static void Main(string[] args)
        {
            ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);
            int number = 10;
            NumberHelper obj = new NumberHelper(number, resultCallbackDelegate);
            Thread thread1 = new Thread(new ThreadStart(obj.CalculateSum));
            thread1.Start();
        }

    }
}