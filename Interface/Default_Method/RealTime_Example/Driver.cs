namespace CSharp_Practice.Interface.Default_Method.RealTime_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.WriteWarning("Console Logger Warning Message");
            consoleLogger.WriteInformation("Console Logger Information Message");

            ILogger traceLogger = new TraceLogger();
            traceLogger.WriteWarning("Trace Logger Warning Message");
            traceLogger.WriteInformation("Trace Logger Information Message");
        }
    }
}