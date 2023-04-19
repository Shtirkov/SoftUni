namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();
            stack.AddRange("ivan", "pesho", "gosho");

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}