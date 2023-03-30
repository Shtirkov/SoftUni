namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private readonly List<T> _list;
        private int _index;

        public ListyIterator(List<T> collection)
        {
            _list = collection;
            _index = 0;
        }

        public bool HasNext() => _index < _list.Count - 1;

        public bool Move()
        {
            if (HasNext())
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (!_list.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(_list[_index]);
        }
    }
}
