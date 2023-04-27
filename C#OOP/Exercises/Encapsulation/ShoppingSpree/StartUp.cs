namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main()
        {

            var customers = new List<Person>();
            var products = new List<Product>();

            try
            {
                var peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToList();

                peopleInfo.ForEach(person =>
                {
                    var personName = person.Split('=')[0];
                    var personMoney = decimal.Parse(person.Split('=')[1]);

                    customers.Add(new Person(personName, personMoney));
                });

                var productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToList();

                productsInfo.ForEach(product =>
                {
                    var productName = product.Split('=')[0];
                    var productPrice = decimal.Parse(product.Split('=')[1]);

                    products.Add(new Product(productName, productPrice));
                });

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var buyer = customers.FirstOrDefault(customer => customer.Name == command.Split()[0]);
                    var desiredProduct = products.FirstOrDefault(product => product.Name == command.Split()[1]);

                    Console.WriteLine(buyer.BuyProduct(desiredProduct));

                    command = Console.ReadLine();
                }

                customers.ForEach(customer =>
                {
                    if (customer.Products.Any())
                    {
                        Console.WriteLine($"{customer.Name} - {string.Join(", ", customer.Products.Select(product => product.Name))}");
                    }
                    else
                    {
                        Console.WriteLine($"{customer.Name} - Nothing bought");
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
