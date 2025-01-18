namespace CSharp_Practice.Interface.Default_Method.RealTime_Example
{
    public class TraceLogger : ILogger
    {
        public void WriteMeesage(LogLevel level, string message)
        {
            Console.WriteLine($"{level}: {message}");
        }
    }
}