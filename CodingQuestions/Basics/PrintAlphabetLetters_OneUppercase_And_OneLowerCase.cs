namespace CSharp_Practice.CodingQuestions
{
    public class PrintAlphabetLetters_OneUppercase_And_OneLowerCase
    {
        public static void AlphabetLettersOneUppercaseAndOneLowerCase()
        {
            for (int i = 0; i < 26; i++)
            {
                char letter = (char)('A' + i);
                if (i % 2 == 0)
                {
                    Console.Write(letter + " ");
                }
                else
                {
                    Console.Write(char.ToLower(letter) + " ");
                }
            }
        }

        public static void Main(string[] args)
        {
            AlphabetLettersOneUppercaseAndOneLowerCase();
        }

    }
}