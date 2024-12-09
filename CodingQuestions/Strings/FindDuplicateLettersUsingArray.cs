using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    /*Write a program to find duplicate letter using array*/
    public class FindDuplicateLettersUsingArray
    {
        public static void Main(string[] args)
        {
            string str1 = "RaginiR";
           /* char[] characterArray = new char[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                characterArray[i] = str1[i];
            }
            Console.WriteLine(characterArray);*/

            //Using ToCharArray() Method
            char[] characterArray = str1.ToCharArray();
            Console.WriteLine(characterArray);
   
            int count;
            Console.WriteLine("Duplicates are: ");
            for (int i = 0; i < characterArray.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < characterArray.Length; j++)
                {
                    if (characterArray[i] == characterArray[j])
                    {
                        count++;
                        characterArray[j] = '1';
                    }
                }

                if (count > 1 && characterArray[i] != '1')
                {
                    Console.WriteLine(characterArray[i]);
                }
            }

        }
    }
}
