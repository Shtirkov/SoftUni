namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> _internalStack;

        public Box()
        {
            _internalStack = new Stack<T>();
        }

        public int Count
        {
            get => _internalStack.Count;
        }

        public void Add(T item) => _internalStack.Push(item);

        public T Remove() => _internalStack.Pop();

    }
}
