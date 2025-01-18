namespace CSharp_Practice.Interface.Default_Method.RealTime_Example
{
    public interface ILogger
    {
        public void WriteMeesage(LogLevel level, string message);

        public void WriteInformation(string message)
        {
            WriteMeesage(LogLevel.Information, message);
        }

        public void WriteWarning(string message)
        {
            WriteMeesage(LogLevel.Warning, message);
        }

        public void WriteError(string message)
        {
            WriteMeesage(LogLevel.Error, message);
        }
    }
}