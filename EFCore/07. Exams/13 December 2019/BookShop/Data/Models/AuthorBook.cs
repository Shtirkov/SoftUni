namespace BookShop.Data
{
    public class AuthorBook
    {
        //AuthorBook
        //•	AuthorId - integer, Primary Key, Foreign key(required)
        //•	Author -  Author
        //•	BookId - integer, Primary Key, Foreign key(required)
        //•	Book - Book

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}