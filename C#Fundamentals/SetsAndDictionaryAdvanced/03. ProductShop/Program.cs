using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string shop = command.Split(", ")[0];
                string product = command.Split(", ")[1];
                double price = double.Parse(command.Split(", ")[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop][product] = price;
                }               

                command = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                var products = shop.Value;

                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
