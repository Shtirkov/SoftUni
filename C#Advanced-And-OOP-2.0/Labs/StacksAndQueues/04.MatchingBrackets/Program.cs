namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var bracketIndecies = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    bracketIndecies.Push(i);
                }
                else if (expression[i] == ')')
                {
                    var startIndex = bracketIndecies.Pop();
                    Console.WriteLine(expression.Substring(startIndex, i-startIndex + 1));
                }
            }
        }
    }
}