using System.Text;

namespace CSharp_Practice.String_POC.StringBuilder_POC
{
    public class StringBuilderPOC
    {
        public static void Main(string[] args)
        {
            //StringBuilder AppendFormat Method
            StringBuilder s = new StringBuilder("The total amount is: ");
            s.AppendFormat("{0:C} ", 50);
            Console.WriteLine(s);

            //StringBuilder Append Method
            StringBuilder str = new StringBuilder("Hello ", 20);
            str.Append("abc");
            //AppendLine() method appends the string with a newline at the end.
            str.AppendLine("def");
            str.Append("ghi");
            Console.WriteLine("\n" + str);

            //StringBuilder Insert Method
            StringBuilder sb = new StringBuilder("Hello ", 20);
            //"Abc" is inserted after 6th index 
            sb.Insert(6, "Abc");
            Console.WriteLine("\n" + sb);

            //StringBuilder Remove Method
            StringBuilder remove = new StringBuilder("Abcdefghi", 20);
            //Remove starts from index 5 and remove happes 3 index after index 5 
            remove.Remove(5, 3);
            Console.WriteLine("\n" + remove);

            //StringBuilder Replace Method
            StringBuilder replace = new StringBuilder("ABC defg ", 20);
            //Replace "ABC" with "Pqr xyz" 
            replace.Replace("ABC", "Pqr xyz");
            Console.WriteLine("\n" + replace);
        }

    }
}