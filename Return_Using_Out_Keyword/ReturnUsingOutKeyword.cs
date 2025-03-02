namespace CSharp_Practice.Return_Using_Out_Keyword
{
    public class ReturnUsingOutKeyword
    {
        public static void GetValuesUsingOutKeyword(out string stringValue, out bool boolValue, out int intValue)
        {
            stringValue = "Ragini";
            boolValue = false;
            intValue = int.MaxValue;
        }

        public static void Main(string[] args)
        {
            string stringValue;
            bool boolValue;
            int intValue;
            GetValuesUsingOutKeyword(out stringValue, out boolValue, out intValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(boolValue);
            Console.WriteLine(intValue);
        }

    }
}