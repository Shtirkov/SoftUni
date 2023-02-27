namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine().Trim(' ');
            var stackedBrackets = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                var currentBracket = expression[i];

                if (stackedBrackets.Count > 0)
                {
                    var lastBracket = stackedBrackets.Peek();

                    if (CheckIfBracketsAreMatching(currentBracket, lastBracket))
                    {
                        stackedBrackets.Pop();
                    }
                    else
                    {
                        stackedBrackets.Push(currentBracket);
                    }
                }
                else
                {
                    stackedBrackets.Push(currentBracket);
                }
            }

            if (stackedBrackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool CheckIfBracketsAreMatching(char currentBracket, char lastBracket)
        {
            if (currentBracket == '}')
            {
                return lastBracket == '{' ? true : false;
            }
            else if (currentBracket == ']')
            {
                return lastBracket == '[' ? true : false;
            }
            else if (currentBracket == ')')
            {
                return lastBracket == '(' ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}