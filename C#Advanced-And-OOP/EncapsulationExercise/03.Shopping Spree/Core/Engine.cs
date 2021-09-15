using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Shopping_Spree.Core
{
    public class Engine
    {
        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                this.ValidatePeopleInput();
                this.ValidateProductInput();

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string personName = input[0];
                    string productName = input[1];

                    Person person = this.people.FirstOrDefault(p => p.Name == personName);
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        string result = person.BuyProduct(product);
                        Console.WriteLine(result);
                    }

                    command = Console.ReadLine();
                }

                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

        }

        private void ValidatePeopleInput()
        {
            string[] peopleArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var person in peopleArgs)
            {
                string[] personArgs = person.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string personName = personArgs[0];
                decimal personMoney = decimal.Parse(personArgs[1]);
                Person p = new Person(personName, personMoney);
                this.people.Add(p);
            }
        }

        private void ValidateProductInput()
        {
            string[] productsArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var productArgs in productsArgs)
            {
                string[] productArgss = productArgs.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string productName = productArgss[0];
                decimal productCost = decimal.Parse(productArgss[1]);
                Product product = new Product(productName, productCost);
                this.products.Add(product);
            }
        }
    }
}
