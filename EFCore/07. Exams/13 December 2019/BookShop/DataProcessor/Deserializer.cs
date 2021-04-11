namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using XmlFacade;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var books = XmlConverter.Deserializer<BookImportModel>(xmlString, "Books");
            var booksToAdd = new List<Book>();

            foreach (var currentBook in books)
            {
                var isValidDate = DateTime.TryParseExact(currentBook.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate);

                if (!IsValid(currentBook) || !isValidDate)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var book = new Book
                {
                    Name = currentBook.Name,
                    Genre = (Genre)currentBook.Genre,
                    Price = currentBook.Price,
                    Pages = currentBook.Pages,
                    PublishedOn = releaseDate
                };

                booksToAdd.Add(book);
                sb.AppendLine($"Successfully imported book {book.Name} for {book.Price.ToString("f2")}.");
            }
            context.Books.AddRange(booksToAdd);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportAuthors(BookShopContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var authors = JsonConvert.DeserializeObject<ICollection<AuthorImportModel>>(jsonString);

            var emails = new List<string>();
            var bookIds = context.Books.Select(b => b.Id).ToList();

            var authorsToAdd = new List<Author>();

            foreach (var currentAuthor in authors)
            {
                var currentAuthorEmail = currentAuthor.Email;

                if (!IsValid(currentAuthor))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                                
                if (emails.Contains(currentAuthorEmail))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var author = new Author
                {
                    FirstName = currentAuthor.FirstName,
                    LastName = currentAuthor.LastName,
                    Email = currentAuthor.Email,
                    Phone = currentAuthor.Phone
                };

                emails.Add(currentAuthorEmail);

                foreach (var currentBook in currentAuthor.Books)
                {

                    if (!currentBook.Id.HasValue)
                    {
                        continue;
                    }
                   

                    if (!bookIds.Contains(currentBook.Id.Value))
                    {
                        continue;
                    }

                    var bookToAdd = new AuthorBook
                    {
                        AuthorId = author.Id,
                        BookId = currentBook.Id.Value
                    };

                    author.AuthorsBooks.Add(bookToAdd);        
                }
                if (author.AuthorsBooks.Count == 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                authorsToAdd.Add(author);
                sb.AppendLine($"Successfully imported author - {author.FirstName} {author.LastName} with {author.AuthorsBooks.Count} books.");
            }
            context.Authors.AddRange(authorsToAdd);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}