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

        public IEnumerator<Book> GetEnumerator()
        {
            return _books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
