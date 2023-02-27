namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialNumbers = Console.ReadLine().Split(' ').Select(int.Parse);
            var stack = new Stack<int>(initialNumbers);
            var inputArray = Console.ReadLine().Split(' ');
            var command = inputArray[0].ToLower();
            var sum = 0;

            while (command != "end")
            {
                if (command == "add")
                {
                    for (int i = 1; i < inputArray.Length; i++)
                    {
                        stack.Push(int.Parse(inputArray[i]));
                    }
                }
                else if (command == "remove")
                {
                    var elementsToBeRemoved = int.Parse(inputArray[1]);

                    if (elementsToBeRemoved <= stack.Count)
                    {
                        for (int i = 0; i < elementsToBeRemoved; i++)
                        {
                            stack.Pop();
                        }
                    }                   
                }

                inputArray = Console.ReadLine().Split(' ');
                command = inputArray[0].ToLower();
            }

            foreach (var number in stack)
            {
                sum += number;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}