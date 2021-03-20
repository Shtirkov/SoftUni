using RealEstates.Data;
using RealEstates.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RealEstates.Importer
{
    class Program
    {
        static void Main(string[] args)
        {
            var apartments = File.ReadAllText("imot.bg-raw-data-2021-03-18.json");
            ImportJson(apartments);
            var houses = File.ReadAllText("imot.bg-houses-Sofia-raw-data-2021-03-18.json");
            ImportJson(houses);
        }

        private static void ImportJson(string jsonFile)
        {
            var dbContext = new RealEstateDbContext();
            var properties = JsonSerializer.Deserialize<IEnumerable<PropertiesAsJson>>(jsonFile);
            IPropertiesService propertiesService = new PropertiesService(dbContext);

            foreach (var property in properties)
            {
                propertiesService.Add(property.Size, property.YardSize, property.Floor,
                                      property.TotalFloors, property.District, property.Year,
                                      property.Type, property.BuildingType, property.Price);
            }
        }
    }
}
