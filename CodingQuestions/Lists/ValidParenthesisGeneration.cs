namespace CSharp_Practice.CodingQuestions.Lists
{
    /* Given an integer A pairs of parentheses, write a function to generate all combinations of well-formed parentheses of length 2*A.
       Problem Constraints:- 1 <= A <= 10
       Input Format:-
       First and only argument is integer A.
       Output Format:-
       Return a sorted list of all possible parenthesis.

       Example Input:-
       Input 1:
       A = 3
       Input 2:
       A = 1

       Example Output:-
       Output 1:
       [ "((()))", "(()())", "(())()", "()(())", "()()()" ]
       Output 2:
       [ "()" ]

       Example Explanation:-
       Explanation 1:
       All paranthesis are given in the output list.
       Explanation 2:
       All paranthesis are given in the output list.
    */
    //Time Complexity: O(2^N) 
    public class ValidParenthesisGeneration
    {
        private List<string> GenerateAllParenthesis(int n)
        {
            List<string> validParenthesis = new List<string>();
            GenerateValidParenthesis(n, 0, 0, validParenthesis, "");
            return validParenthesis;
        }

        private void GenerateValidParenthesis(int n, int opening, int closing, List<string> validParenthesis, string str)
        {
            if (closing > opening)
            {
                return;
            }
            if (opening == closing && closing == n)
            {
                validParenthesis.Add(str);
            }
            if (opening < n)
            {
                GenerateValidParenthesis(n, opening + 1, closing, validParenthesis, str + "(");
            }
            if (opening > closing)
            {
                GenerateValidParenthesis(n, opening, closing + 1, validParenthesis, str + ")");
            }
        }

        public static void Main(string[] args)
        {
            ValidParenthesisGeneration obj = new ValidParenthesisGeneration();
            int N = 3;
            List<string> resultList = obj.GenerateAllParenthesis(N);
            Console.WriteLine(string.Join(", ", resultList));
        }

    }
}