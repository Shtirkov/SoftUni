using System.Text;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfOperations = int.Parse(Console.ReadLine());

            var historyStack = new Stack<string>();
            historyStack.Push("");

            for (int i = 0; i < numberOfOperations; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        var currentText = historyStack.Peek();
                        var textToAppend = new StringBuilder(currentText);

                        for (int k = 1; k < input.Length; k++)
                        {
                            textToAppend.Append(input[k] + " ");
                        }

                        historyStack.Push(textToAppend.ToString().TrimEnd());
                        break;
                    case 2:
                        var numberOfCharsToErase = int.Parse(input[1]);
                        var lastTextFromTheHistoryStack = historyStack.Peek();

                        if (numberOfCharsToErase <= lastTextFromTheHistoryStack.Length)
                        {
                            var modifiedText = lastTextFromTheHistoryStack.Remove(lastTextFromTheHistoryStack.Length - numberOfCharsToErase, numberOfCharsToErase);
                            historyStack.Push(modifiedText);
                        }
                        break;
                    case 3:
                        var index = int.Parse(input[1]);

                        if (index <= historyStack.Peek().Length)
                        {
                            var textToDisplay = historyStack.Peek()[index - 1];
                            Console.WriteLine(textToDisplay);
                        }
                         break;
                    case 4:
                        historyStack.Pop();
                        break;
                }
            }
        }
    }
}