namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var expressionArr = Console.ReadLine().Split(' ').Reverse().ToArray();
            var stackedExpression = new Stack<string>(expressionArr);
            var sum = int.Parse(stackedExpression.Pop());

            while (stackedExpression.Count() != 0)
            {
                var sign = stackedExpression.Pop();
                var number = int.Parse(stackedExpression.Pop());

                switch (sign)
                {
                    case "+":
                        sum += number;
                        break;
                    case "-":
                        sum -= number;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}