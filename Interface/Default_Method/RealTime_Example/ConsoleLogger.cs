namespace CSharp_Practice.Interface.Default_Method.RealTime_Example
{
    public enum LogLevel
    {
        Information,
        Warning,
        Error
    }

    public class ConsoleLogger : ILogger
    {
        public void WriteMeesage(LogLevel level, string message)
        {
            Console.WriteLine($"{level}: {message}");
        }
    }
}