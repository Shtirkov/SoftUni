using RealEstates.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstates.Services
{
    public class DistrictsService : IDistrictsService
    {
        private readonly RealEstateDbContext dbContext;

        public DistrictsService(RealEstateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<DistrictInfoDto> GetMostExpensiveDistricts(int count)
        {
            var properties =
                dbContext.Districts               
                .Select(x => new DistrictInfoDto
                {
                    Name = x.Name,
                    PropertiesCount = x.Properties.Count(),
                    AveragePricePerSquareMeter = x.Properties.Where(p => p.Price.HasValue).Average(p => p.Price / (decimal)p.Size) ?? 0
                })
                .OrderByDescending(d => d.AveragePricePerSquareMeter)
                .Take(count)
                .ToList();

            return properties;


        }
    }
}
