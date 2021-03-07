using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] commandToArray = command.Split();
                string productName = commandToArray[0];
                double productPrice = double.Parse(commandToArray[1]);
                int productQuantity = int.Parse(commandToArray[2]);

                Product product = new Product(productName, productPrice, productQuantity);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, product);
                }
                else
                {
                    products[productName].Price = productPrice;
                    products[productName].Quantity += productQuantity;
                }


                command = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity:f2}");
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Product (string name, double price, int quantity)
            {
                this.Name = name;
                this.Price = price;
                this.Quantity = quantity;
            }
        }
    }
}
