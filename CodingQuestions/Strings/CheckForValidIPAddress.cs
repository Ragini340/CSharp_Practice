namespace CSharp_Practice.CodingQuestions.Strings
{
    /*A valid IP address must consist of four numbers separated by periods (.), with each number ranging from 0 to 255;
      essentially following the format "x.x.x.x" where each "x" represents a number between 0 and 255.

      Key rules for a valid IP address:-
      Four octets: An IP address must have four parts (octets) separated by periods. 
      Number range: Each octet must be a number between 0 and 255. 
      Decimal format: Each octet should be represented as a decimal number. 
      No leading zeros: Leading zeros in an octet are not allowed, unless the entire octet is "0". 

      Example of a valid IP address: 192.168.1.1 
                                     128.0.0.1

      Example of invalid IP addresses:
      256.1.2.3 (exceeds the valid range of 0-255)
      1.2.3 (here IP address has only three parts)
      123.45.67.890 (exceeds the valid range of 0-255)
      001.2.3.4 (leading zero in first octet) 
      128.01.02.1 (leading zero in second and third octet) 
    */

    /*Program to check if a given string is valid IP address or not
      Time complexity: O(n) 
      Space complexity: O(1)
    */
    public class CheckForValidIPAddress
    {
        public static bool ValidIPPart(string s)
        {
            if (s.Length > 3)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] >= 0 && s[i] <= '9'))
                {
                    return false;
                }
            }

            if (s.IndexOf('0') == 0 && s.Length > 1)
            {
                return false;
            }

            int x = 0;
            int.TryParse(s, out x);
            if (x < 0 || x > 255)
            {
                return false;
            }

            return false;
        }

        //Returning 1 if IP string is valid, else return 0
        public static int IsValidIPAddress(string str)
        {
            if (str == null)
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    count = count + 1;
                }
            }
            if (count != 3)
            {
                return 0;
            }

            string[] arr = str.Split('.');
            if (arr.Length != 4)
            {
                return 0;
            }
            foreach (string part in arr)
            {
                if (!ValidIPPart(part))
                {
                    return 0;
                }
            }

            return 1;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the IP address: ");
            string iP1 = Console.ReadLine();
            Console.WriteLine(IsValidIPAddress(iP1) == 1 ? "Valid" : "Not valid");
        }

    }
}