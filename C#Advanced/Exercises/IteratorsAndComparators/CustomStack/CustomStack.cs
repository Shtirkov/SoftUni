using System.Collections;

namespace CustomStack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> _list;
        private int _index;

        public CustomStack()
        {
            _list = new();
            _index = -1;
        }

        public void Push(params T[] elements)
        {
            elements.ToList().ForEach(element =>
            {
                _list.Add(element);
                _index++;
            });
        }

        public T Pop()
        {
            if (!_list.Any())
            {
                throw new InvalidOperationException("No elements");
            }

            var removedElement = _list[_index];
            _list.RemoveAt(_index);
            _index--;

            return removedElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _index; i >= 0; i--)
            {
                yield return _list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
