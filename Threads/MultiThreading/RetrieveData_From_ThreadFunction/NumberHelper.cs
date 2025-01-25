namespace CSharp_Practice.Threads.MultiThreading.RetrieveData_From_ThreadFunction
{
    public delegate int ResultCallbackDelegate(int Results);
    public class NumberHelper
    {
        private int _Number;
        private ResultCallbackDelegate _resultCallbackDelegate;

        public NumberHelper(int Number, ResultCallbackDelegate resultCallbackDelagate)
        {
            _Number = Number;
            _resultCallbackDelegate = resultCallbackDelagate;
        }

        public void CalculateSum()
        {
            int result = 0;
            for (int i = 1; i <= _Number; i++)
            {
                result = result + i;
            }

            if (_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(result);
            }
        }

    }
}