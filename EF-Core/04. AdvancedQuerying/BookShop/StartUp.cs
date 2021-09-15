namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            // DbInitializer.ResetDatabase(db);

            Console.WriteLine(GetTotalProfitByCategory(db));
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var profitForEachCategory =
              context.Categories             
              .Select(c => new
              {
                  Name = c.Name,        
                  Profit = c.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies)
              })
              .OrderByDescending(b => b.Profit)
              .ThenBy(b => b.Name)
              .ToList();            

            var sb = new StringBuilder();

            foreach (var category in profitForEachCategory)
            {
                sb.AppendLine($"{category.Name} ${category.Profit:f2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var totalBookCopiesPerAuthor =
                context.Authors
                .Select(a => new
                {
                    AuthorFullName = $"{a.FirstName} {a.LastName}",
                    Copies = a.Books.Sum(a => a.Copies)
                })
                .OrderByDescending(a => a.Copies)
                .ToList();

            var sb = new StringBuilder();

            foreach (var author in totalBookCopiesPerAuthor)
            {
                sb.AppendLine($"{author.AuthorFullName} - {author.Copies}");
            }

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books =
                context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .ToList();

            return books.Count();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books =
               context.Books
               .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
               .Select(b => new
               {
                   Title = b.Title,
                   AuthorFullName = b.Author.FirstName + ' ' + b.Author.LastName,
                   Id = b.BookId
               })
               .OrderBy(b => b.Id)
               .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorFullName})");
            }

            return sb.ToString().TrimEnd();
                
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books =
                context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors =
                context.Authors
                .ToList()
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .OrderBy(a => a.FullName);
                //.ToList();

            var sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine(author.FullName);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books =
                context.Books
                .Where(b => b.ReleaseDate < parsedDate)
                .Select(b => new
                {
                    BookTitle = b.Title,
                    EditionType = b.EditionType,
                    Price = b.Price,
                    ReleaseDate = b.ReleaseDate
                })
                .OrderByDescending(b => b.ReleaseDate)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.BookTitle} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] categoriesToLower = new string[categories.Length];

            for (int i = 0; i < categories.Length; i++)
            {
                categoriesToLower[i] = categories[i].ToLower();
            }

            

            var books =
                context.Books
                .Where(b => b.BookCategories.Any(c => categoriesToLower.Contains(c.Category.Name.ToLower())))
                .OrderBy(c => c.Title)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books =
                context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }
        
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books =
                context.Books
                .Where(b => b.Price > 40m)
                .OrderByDescending(b => b.Price)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
                
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var type = Enum.Parse<EditionType>("Gold");

            var books =
                context.Books
                .Where(b => b.EditionType == type && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var books =
                context.Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .OrderBy(b => b.Title)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
                
        }
    }
}
