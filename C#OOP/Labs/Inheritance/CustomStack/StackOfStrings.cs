namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => Count > 0;

        public Stack<string> AddRange(params string[] elements)
        {
            foreach (var element in elements)
            {
                Push(element);
            }
            return this;
        }
    }
}
