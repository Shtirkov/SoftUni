namespace VaporStore.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using VaporStore.DataProcessor.Dto.Export;
    using XmlFacade;

    public static class Serializer
    {
        public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
        {
            var genres =
                context.Genres
                .Where(g => genreNames.Contains(g.Name))
                .ToList()
                .Select(x => new
                {
                    Id = x.Id,
                    Genre = x.Name,
                    Games = x.Games.Where(g => g.Purchases.Count() > 0).Select(g => new
                    {
                        Id = g.Id,
                        Title = g.Name,
                        Developer = g.Developer.Name,
                        Tags = string.Join(", ", g.GameTags.Select(t => t.Tag.Name)),
                        Players = g.Purchases.Count()
                    })
                    .ToList()
                    .OrderByDescending(g => g.Players)
                    .ThenBy(g => g.Id),
                    TotalPlayers = x.Games.Sum(g => g.Purchases.Count())
                })
                .OrderByDescending(g => g.TotalPlayers)
                .ThenBy(g => g.Id);


            var result = JsonConvert.SerializeObject(genres, Formatting.Indented);

            return result.ToString().TrimEnd();
        }

        public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
        {
            var purchases =
                context.Users
                .ToList()
                .Where(u => u.Cards.Any(c => c.Purchases.Any(p => p.Type.ToString() == storeType)))
                .Select(x => new UserExportModel
                {
                    Username = x.Username,                   
                    TotalSpent = x.Cards.Sum(c => c.Purchases.Where(p => p.Type.ToString() == storeType).Sum(p => p.Game.Price)),
                    Purchases = x.Cards.SelectMany(c => c.Purchases)
                                .Where(p => p.Type.ToString() == storeType)
                                .Select(p => new PurchaseExportModel
                                {
                                    Card = p.Card.Number,
                                    Cvc = p.Card.Cvc,
                                    Date = p.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                                    Game = new GameExportModel
                                    {
                                        Title = p.Game.Name,
                                        Price = p.Game.Price,
                                        Genre = p.Game.Genre.Name
                                    }
                                })
                                .OrderBy(p => p.Date)
                                .ToList()
                })
                .OrderByDescending(u => u.TotalSpent)
                .ThenBy(u => u.Username)
                .ToList();

            var result = XmlConverter.Serialize(purchases, "Users");


            return result.ToString().TrimEnd();
        }
    }
}