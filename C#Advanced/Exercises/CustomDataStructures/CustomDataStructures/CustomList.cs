namespace CustomDataStructures
{
    public class CustomList
    {
        private const int _initialCapacity = 2;
        private int[] _items;

        public CustomList()
        {
            _items = new int[_initialCapacity];   
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }

                return _items[index];
            }
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }

                _items[index] = value;
            }
        } 

        public void Add(int element)
        {
            if (Count == _items.Length)
            {
                Resize();
            }

            _items[Count] = element;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (!IsValidIndex(index))
            {
                throw new IndexOutOfRangeException();
            }

            var removedElement = _items[index];

            _items[index] = default;
            Shift(index);
            Count--;

            if (_items.Length >= Count * 4)
            {
                Shrink();
            }
            return removedElement;
        }

        private void Resize()
        {
            var copy = new int[_items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = _items[i];
            }

            _items = copy;
        }

        private void Shrink()
        {
            var copy = new int[_items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = _items[i];
            }

            _items = copy; 
        }

        private void Shift(int startIndex)
        {
            for (int i = startIndex; i < Count-1; i++)
            {
                _items[i] = _items[i+1];
            }
            _items[Count - 1] = 0;
        }

        private bool IsValidIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                return false;
            }

            return true;
        }
    }
}
