namespace CustomStack
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack<int>();


            while (true)
            {
                var inputArr = Console.ReadLine().Replace(',', ' ').Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (inputArr[0] == "END")
                {
                    break;
                }
                else if (inputArr[0] == "Push")
                {
                    var elements = inputArr.Skip(1).Select(int.Parse).ToList();
                    elements.ForEach(element => stack.Push(element));
                }
                else if (inputArr[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }                                
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}