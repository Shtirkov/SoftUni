using AutoMapper;
using CarDealer.Data;
using CarDealer.DataTransferObjects.Input;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        static IMapper mapper;

        public static void Main(string[] args)
        {
            var context = new CarDealerContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var suppliersXml = File.ReadAllText("Datasets\\suppliers.xml");
            var partsXml = File.ReadAllText("Datasets\\parts.xml");
            var carsXml = File.ReadAllText("Datasets\\cars.xml");
            var customersXml = File.ReadAllText("Datasets\\customers.xml");
            var salesXml = File.ReadAllText("Datasets\\sales.xml");

            ImportSuppliers(context, suppliersXml);
            ImportParts(context, partsXml);
            ImportCars(context, carsXml);
            ImportCustomers(context, customersXml);
            Console.WriteLine(ImportSales(context, salesXml));
        }

        private static void InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            });
            mapper = config.CreateMapper();
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            InitializeMapper();

            var serializer = new XmlSerializer(typeof(List<SaleInputModel>), new XmlRootAttribute("Sales"));
            var reader = new StringReader(inputXml);
            var salesDto = serializer.Deserialize(reader) as List<SaleInputModel>;

            var carIds =
                context.Cars
                .Select(c => c.Id)
                .ToList();

            var sales =
                salesDto.Where(c => carIds.Contains(c.CarId))
                .ToList();

            var parsedSales = mapper.Map<List<Sale>>(sales);

            context.Sales.AddRange(parsedSales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}";
        }
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            InitializeMapper();

            var serializer = new XmlSerializer(typeof(List<CustomerInputModel>), new XmlRootAttribute("Customers"));
            var reader = new StringReader(inputXml);
            var customersDto = serializer.Deserialize(reader) as List<CustomerInputModel>;
            var customers = mapper.Map<List<Customer>>(customersDto);

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}";
        }
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            InitializeMapper();

            var serializer = new XmlSerializer(typeof(List<CarInputModel>), new XmlRootAttribute("Cars"));
            var reader = new StringReader(inputXml);
            var dtoCars = serializer.Deserialize(reader) as List<CarInputModel>;

            var partIds =
                context.Parts
                .Select(c => c.Id)
                .ToList();

            var cars =
                 dtoCars.Select(c => new Car
                 {
                     Make = c.Make,
                     Model = c.Model,
                     TravelledDistance = c.TravelledDistance,
                     PartCars = c.CarPartsInputModel.Select(p => p.PartId)
                     .Distinct()
                     .Intersect(partIds)
                     .Select(pc => new PartCar
                     {
                         PartId = pc
                     })
                     .ToList()
                 })
                 .ToList();

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            InitializeMapper();

            XmlSerializer serializer = new XmlSerializer(typeof(List<PartInputModel>), new XmlRootAttribute("Parts"));
            var reader = new StringReader(inputXml);
            var partsDto = serializer.Deserialize(reader) as List<PartInputModel>;

            var supplierIds =
               context.Suppliers
               .Select(s => s.Id)
               .ToList();

            var existingPars =
                partsDto
                .Where(p => supplierIds.Contains(p.SupplierId))
                .ToList();

            var parts = mapper.Map<List<Part>>(existingPars);

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count()}";
        }
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            InitializeMapper();

            XmlSerializer serializer = new XmlSerializer(typeof(List<SupplierInputModel>), new XmlRootAttribute("Suppliers"));

            var reader = new StringReader(inputXml);
            var suppliersDto = serializer.Deserialize(reader) as List<SupplierInputModel>;
            //var test = suppliersDto.Select
            var suppliers = mapper.Map<List<Supplier>>(suppliersDto);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}"; ;
        }


    }
}