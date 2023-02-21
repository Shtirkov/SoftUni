using System.Text;

namespace _03.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            //The nested dictionary consists of string and double because the tests in judge.softuni.org were failing if the price was declared as decimal.
            //I agree it is not correct to treat costs and prices as double values but the task is implemented this way so the tests can pass.
            var shopsAndProducts = new SortedDictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                var shop = input.Split()[0];
                var product = input.Split()[1];
                var price = input.Split()[2];

                if (!shopsAndProducts.ContainsKey(shop))
                {
                    shopsAndProducts.Add(shop, new Dictionary<string, double>());
                }

                if (!shopsAndProducts[shop].ContainsKey(product))
                {
                    shopsAndProducts[shop].Add(product, 0);
                }

                shopsAndProducts[shop][product] = double.Parse(price);

                input = Console.ReadLine();
            }

            foreach (var shop in shopsAndProducts)
            {
                var output = new StringBuilder();
                output.AppendLine($"{shop.Key.Trim(',')}->");

                foreach (var product in shop.Value)
                {
                    output.AppendLine($"Product: {product.Key.Trim()} Price: {product.Value}");
                }
                Console.Write(output.ToString());
            }
        }
    }
}