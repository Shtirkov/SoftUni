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
            if (_items.Length == Count)
            {
                Resize();
            }

            _items[Count] = element;
            Count++;
        }

        public void RemoveAt(int index)
        {
            if (!IsValidIndex(index))
            {
                throw new IndexOutOfRangeException();
            }

            _items[index] = default;
            ShiftLeft(index);
            Count--;

            if (_items.Length >= Count * 4)
            {
                Shrink();
            }
        }

        public void InsertAt(int index, int element)
        {
            if (!IsValidIndex(index))
            {
                throw new IndexOutOfRangeException();
            }

            if (_items.Length == Count)
            {
                Resize();
            }

            ShiftRight(index);
            _items[index] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (!IsValidIndex(firstIndex) || !IsValidIndex(secondIndex))
            {
                throw new IndexOutOfRangeException();
            }

            var firstElement = _items[firstIndex];
            var secondElement = _items[secondIndex];

            _items[firstIndex] = secondElement;
            _items[secondIndex] = firstElement;
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

        private void ShiftLeft(int startIndex)
        {
            for (int i = startIndex; i < Count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _items[Count - 1] = default;
        }

        private void ShiftRight(int startIndex)
        {
            for (int i = Count - 1; i >= startIndex; i--)
            {
                _items[i + 1] = _items[i];
            }
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
