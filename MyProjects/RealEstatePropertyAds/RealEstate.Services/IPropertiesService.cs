using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.Services
{
    public interface IPropertiesService
    {
        void Add(int size, int yardSize, int floor,
            int totalFloors, string district, int buildingYear,
            string propertyType, string buildingType, int price);

        decimal AveragePricePerSquareMeter();

        IEnumerable<PropertyInfoDto> Search(int minPrice, int maxPrice, int minSize, int maxSize);
    }
}
