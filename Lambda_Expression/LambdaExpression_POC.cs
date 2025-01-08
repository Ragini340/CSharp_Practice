using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Lambda_Expression
{
    public class LambdaExpression_POC
    {
        /*Delegate using Handler Method:-
        public delegate string GreetingsDelegate(string name);
        public static string Greetings(string name)
        {
            return "Hello " + name + ", " + "Welcome!!";
        }

        public static void Main(string[] args)
        {
            GreetingsDelegate greetingsDelegate = new GreetingsDelegate(LambdaExpression_POC.Greetings);
            string Message = greetingsDelegate.Invoke("Ragini");
            Console.WriteLine(Message);
        }
        */

        /*Delegate using Anonymous Method:-
        public delegate string GreetingsDelegate(string name);
        public static void Main(string[] args)
        {
            GreetingsDelegate greetingsDelegate = delegate (string name)
            {
                return "Hello " + name + ", " + "Welcome!!";
            };
            string Message = greetingsDelegate.Invoke("Ragini");
            Console.WriteLine(Message);
        }
        */

        //Delegate using lambda expressions:-
        public delegate string GreetingsDelegate(string name);
        public static string Greetings(string name)
        {
            return "Hello " + name + ", " + "Welcome!!";
        }
        public static void Main(string[] args)
        {
            GreetingsDelegate greetingsDelegate = name => { return "Hello " + name + ", " + "Welcome!!"; };
            string Message = greetingsDelegate.Invoke("Ragini");
            Console.WriteLine(Message);
        }
    }

}
