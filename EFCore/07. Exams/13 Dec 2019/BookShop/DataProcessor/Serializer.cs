namespace BookShop.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using BookShop.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;
    using XmlFacade;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportMostCraziestAuthors(BookShopContext context)
        {
            var authors =
                 context.Authors
                 .Select(a => new
                 {
                     AuthorName = a.FirstName + " " + a.LastName,
                     Books = a.AuthorsBooks
                     .OrderByDescending(b => b.Book.Price)
                     .Select(b => new
                     {
                         BookName = b.Book.Name,
                         BookPrice = b.Book.Price.ToString("F2")
                     })
                    .ToList()
                 })
                 .ToList()
                 .OrderByDescending(a => a.Books.Count())
                 .ThenBy(a => a.AuthorName);

            return JsonConvert.SerializeObject(authors, Formatting.Indented);
        }

        public static string ExportOldestBooks(BookShopContext context, DateTime date)
        {
            var books =
                context.Books
                .ToList()
                .Where(b => b.PublishedOn < date && b.Genre.ToString() == "Science")
                .Select(b => new BookExportModel
                {
                    Pages = b.Pages,
                    Name = b.Name,
                    Date = b.PublishedOn.ToString("d", CultureInfo.InvariantCulture)
                })
                .OrderByDescending(b => b.Pages)
                .ThenByDescending(b => b.Date)
                .Take(10)
                .ToList();


            return XmlConverter.Serialize(books, "Books");
        }
    }
}