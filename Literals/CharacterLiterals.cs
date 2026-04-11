using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Literals
{
    public class CharacterLiterals
    {
        //Character literal using single quote
        char ch1 = 'A';
        //Character literal using Unicode representation
        char ch2 = '\u0041';

        public static void Main(string[] args)
        {
            CharacterLiterals characterLiterals = new CharacterLiterals();

            Console.WriteLine("Single Quote: " + characterLiterals.ch1);
            Console.WriteLine("Unicode: " + characterLiterals.ch2);
            //Character literal using Escape character
            Console.WriteLine("Escape: Hello\nRagini\tSingh");

        }
    }
}