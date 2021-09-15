using Microsoft.EntityFrameworkCore;
using RealEstates.Data;
using RealEstates.Services;
using System;
using System.Text;

namespace RealEstates.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var dbContext = new RealEstateDbContext();
            dbContext.Database.Migrate();

            while (true)
            {
                Console.Clear();               
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Property search");
                Console.WriteLine("2. Most expensive districts");
                Console.WriteLine("3. Average price per square meter");
                Console.WriteLine("0. Exit");

                bool isValid = int.TryParse(Console.ReadLine(), out int option);

                if (isValid && option >= 0 && option <=3)
                {
                    switch (option)
                    {
                        case 0:
                            return;
                        case 1:
                            Search(dbContext);
                            break;
                        case 2:
                            MostExpensiveDistricts(dbContext);
                            break;
                        case 3:
                            AveragePricePerSquareMeter(dbContext);
                            break;
                    }

                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }

        public static void MostExpensiveDistricts(RealEstateDbContext dbContext)
        {
            Console.WriteLine("Select districts count:");
            int count = int.Parse(Console.ReadLine());

            IDistrictsService service = new DistrictsService(dbContext);
            var mostExpensiveDistricts = service.GetMostExpensiveDistricts(count);

            foreach (var district in mostExpensiveDistricts)
            {
                Console.WriteLine($"{district.Name} -> {district.PropertiesCount} -> {district.AveragePricePerSquareMeter:f2}€/m²");
            }

        }

        public static void Search(RealEstateDbContext dbContext)
        {
            Console.WriteLine("Min price:");
            int minPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Max price:");
            int maxPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Min size:");
            int minSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Max size:");
            int maxSize = int.Parse(Console.ReadLine());

            IPropertiesService service = new PropertiesService(dbContext);
            var properties = service.Search(minPrice, maxPrice, minSize, maxSize);

            foreach (var property in properties)
            {
                Console.WriteLine($"{property.DistrictName} -> {property.BuildingType} -> {property.PropertyType} -> {property.Size}m² -> {property.Price:f2}€");
            }
        }

        public static void AveragePricePerSquareMeter(RealEstateDbContext dbContext)
        {
            IPropertiesService service = new PropertiesService(dbContext);
            Console.WriteLine($"The average price per square meter is {service.AveragePricePerSquareMeter():f2}€/m²");
        }
    }
}
