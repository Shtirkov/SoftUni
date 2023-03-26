using System.Collections;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> _books;

        public Library(params Book[] books)
        {
            _books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator() => new LibraryIterator(_books);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> _books;
            private int _currentIndex = -1;

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                _books = books.ToList();
            }

            public Book Current => _books[_currentIndex];

            object IEnumerator.Current => _books[_currentIndex];

            public void Dispose()
            {

            }

            public bool MoveNext() => ++_currentIndex < _books.Count;

            public void Reset() => _currentIndex = -1;
        }
    }   
}
