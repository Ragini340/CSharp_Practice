namespace CSharp_Practice.CodingQuestions.Strings
{
    //This program will reverse the words of a sentence except the fist and last word
    public class ReverseWord
    {
        public static void ReverseWords(string str1)
        {
            string[] arrStr = str1.Split(" ");
            string reverseWord1 = "";

            for (int i = 0; i <= arrStr.Length - 1; i++)
            {
                string word = arrStr[i];
                string reverseWord = "";

                if (i != 0 && i != (arrStr.Length - 1))
                {
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverseWord = reverseWord + word[j];
                    }
                }
                else
                {
                    reverseWord = word;
                }

                reverseWord1 = reverseWord1 + reverseWord + " ";
            }
            reverseWord1 = reverseWord1.Trim();
            Console.WriteLine("Revered sentence's word except the fist and last word are: " + reverseWord1);
            Console.WriteLine("Length of the revered sentence is: " + reverseWord1.Length);
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str1 = Console.ReadLine();
            ReverseWords(str1);
        }

    }
}