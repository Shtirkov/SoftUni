using RealEstates.Data;
using RealEstates.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RealEstates.Services
{
    public class PropertiesService : IPropertiesService
    {
        private readonly RealEstateDbContext dbContext;

        public PropertiesService(RealEstateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(int size, int yardSize, int floor,
            int totalFloors, string district, int buildingYear,
            string propertyType, string buildingType, int price)
        {
            var property = new Property
            {
                Size = size,
                YardSize = yardSize <= 0 ? null : (int?)yardSize,
                Floor = floor <= 0 || floor > 350 ? null : (byte?)floor,
                TotalFloors = totalFloors <= 0 || totalFloors > 350 ? null : (byte?)totalFloors,
                Year = buildingYear <= 0 ? null : (int?)buildingYear,
                Price = price <= 1800 ? null : (int?)price,

            };

            var dbDistrict =
                dbContext.Districts
                .FirstOrDefault(d => d.Name == district);

            if (dbDistrict == null)
            {
                dbDistrict = new District { Name = district };
            }

            property.District = dbDistrict;

            var dbPropertyType =
                dbContext.PropertyTypes
                .FirstOrDefault(pt => pt.Name == propertyType);

            if (dbPropertyType == null)
            {
               dbPropertyType = new PropertyType { Name = propertyType };
            }

            property.Type = dbPropertyType;

            var dbBuildingType =
                dbContext.BuildingTypes
                .FirstOrDefault(bt => bt.Name == buildingType);

            if (dbBuildingType == null)
            {
             dbBuildingType=new BuildingType { Name = buildingType };
            }

            property.BuildingType = dbBuildingType;

            dbContext.Properties.Add(property);
            dbContext.SaveChanges();
        }

        public decimal AveragePricePerSquareMeter()
        {
            var averagePrice =
                dbContext.Properties
                .Where(p => p.Price.HasValue)
                .Average(p => p.Price / (decimal)p.Size) ?? 0;

            return averagePrice;
        }

        public IEnumerable<PropertyInfoDto> Search(int minPrice, int maxPrice, int minSize, int maxSize)
        {
            var properties =
                 dbContext.Properties
                 .Where(p => p.Price >= minPrice && p.Price <= maxPrice && p.Size >= minSize && p.Size <= maxSize)
                 .Select(p => new PropertyInfoDto
                 {
                     DistrictName = p.District.Name,
                     Price = p.Price ?? 0,
                     Floor = p.Floor ?? 0,
                     Size = p.Size,
                     PropertyType = p.Type.Name,
                     BuildingType = p.BuildingType.Name
                 })
                 .ToList();

            return properties;            
        }
    }
}
