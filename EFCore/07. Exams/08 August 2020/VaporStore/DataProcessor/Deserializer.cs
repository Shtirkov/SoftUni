namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.DataProcessor.Dto.Import;
    using XmlFacade;

    public static class Deserializer
	{
		public static string ImportGames(VaporStoreDbContext context, string jsonString)
		{
			var sb = new StringBuilder();

			var games = JsonConvert.DeserializeObject<IEnumerable<GamesImportModel>>(jsonString);

            foreach (var game in games)
            {
                if (!IsValid(game) || game.Tags.Count() <= 0)
				{
					sb.AppendLine("Invalid Data");
					continue;
                }

                var isValidDate = DateTime.TryParseExact(game.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

                if (!isValidDate)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var developer =
					context.Developers
					.FirstOrDefault(d => d.Name == game.Developer)					
					?? new Developer {Name = game.Developer };

				var genre =
					context.Genres
					.FirstOrDefault(g => g.Name == game.Genre)
					?? new Genre { Name = game.Genre };

				var currentGame = new Game
				{
					Name = game.Name,
					Price = game.Price,
					Genre = genre,
					ReleaseDate = date,
					Developer = developer,					
				};

                foreach (var currentTag in game.Tags)
                {
					var tag =
						context.Tags
						.FirstOrDefault(t => t.Name == currentTag)
						?? new Tag { Name = currentTag };

					currentGame.GameTags.Add(new GameTag { Tag = tag });
                }

				context.Games.Add(currentGame);
				sb.AppendLine($"Added {game.Name} ({game.Genre}) with {game.Tags.Count()} tags");
				context.SaveChanges();

			}

			return sb.ToString().TrimEnd();
		}

		public static string ImportUsers(VaporStoreDbContext context, string jsonString)
		{
			var sb = new StringBuilder();

			var users = JsonConvert.DeserializeObject<ICollection<UsersCardsImportModel>>(jsonString);

            foreach (var currentUser in users)
            {
                if (!IsValid(currentUser) || !currentUser.Cards.All(IsValid))
                {
					sb.AppendLine("Invalid Data");
					continue;
                }




				var user = new User
				{
					FullName = currentUser.FullName,
					Username = currentUser.Username,
					Age = currentUser.Age,
					Email = currentUser.Email,
					Cards = currentUser.Cards.Select(c => new Card
					{
						Number = c.Number,
						Cvc = c.CVC,
						Type = c.Type
					}).ToList()
				};

				context.Users.Add(user);
				context.SaveChanges();
				sb.AppendLine($"Imported {user.Username} with {user.Cards.Count()} cards");
            }

			return sb.ToString().TrimEnd();
		}

		public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
		{
			var sb = new StringBuilder();

			var purchases = XmlConverter.Deserializer<PurchasesImportModel>(xmlString, "Purchases");

            foreach (var currentPurchase in purchases)
            {
                if (!IsValid(currentPurchase))
                {
					sb.AppendLine("Invalid Data");
					continue;
                }

				var IsDateValid = DateTime.TryParseExact(currentPurchase.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);
                if (!IsDateValid)
                {
					sb.AppendLine("Invalid Data");
					continue;
				}


				var purchase = new Purchase
				{
					Type = currentPurchase.Type,
					ProductKey = currentPurchase.Key,
					Date = date
				};

				purchase.Card =
					context.Cards
					.FirstOrDefault(c => c.Number == currentPurchase.Card);

				purchase.Game =
					context.Games
					.FirstOrDefault(g => g.Name == currentPurchase.Title);

				context.Purchases.Add(purchase);
				context.SaveChanges();

				var buyer =
					context.Users
					.FirstOrDefault(x => x.Cards.Contains(purchase.Card));
				sb.AppendLine($"Imported {purchase.Game.Name} for {buyer.Username}");
            }

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