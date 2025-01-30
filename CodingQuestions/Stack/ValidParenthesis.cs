namespace CSharp_Practice.CodingQuestions.Stack
{
    /*
      Check whether given sequence of parenthesis are valid or not. 
      inputs:- "[]{}()"  --Valid
               "({)}" --Invalid
               "([{])" --Invalid
     Return true if parenthesis are valid otherwise false.
   */
    public class ValidParenthesis
    {
        private bool ValidateParenthesis(string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == '(' || ch == '{' || ch == '[') //Opening parenthesis push in stack
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']') //Closing parenthesis
                {
                    if (stack.Count == 0) //Closing(Right) parenthesis is more than opening parenthesis --Invalid
                    {
                        return false;
                    }
                    else //If opening parenthesis in stack is not same with closing parenthesis
                    {
                        char temp = stack.Pop();

                        if (!MatchParenthesisPair(ch, temp)) //If matching is true then we need to iterate till last expression.
                        {
                            return false;
                        }
                    }
                }
            }

            return stack.Count == 0; //If stack is not empty i.e. left parenthesis are more than right parenthesis
        }

        private bool MatchParenthesisPair(char element, char top)
        {
            if (top == '(' && element == ')')
            {
                return true;
            }
            if (top == '{' && element == '}')
            {
                return true;
            }
            if (top == '[' && element == ']')
            {
                return true;
            }
           
            return false;  
        }

        public static void Main(string[] args)
        {
            string str1 = "[]{}()";
            string str2 = "([{])";
            string str3 = "({)}";
            string str4 = "[A/(B-C)*D]";
            string str5 = "A*(B-C)}+D";
            string str6 = "[A+B-(C%D}]";

            ValidParenthesis obj = new ValidParenthesis();
            bool isValid = obj.ValidateParenthesis(str4);
            Console.WriteLine("Is given parenthesis valid? " + isValid);
        }

    }
}