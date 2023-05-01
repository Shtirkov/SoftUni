using PizzaRestaurant.Models;

namespace PizzaRestaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaArgs = Console.ReadLine().Split(' ');
                var pizza = new Pizza(pizzaArgs[1]);

                var doughArgs = Console.ReadLine().Split(' ');
                SelectDough(doughArgs, pizza);

                var input = Console.ReadLine();

                while (input != "END")
                {
                    var toppingArgs = input.Split(' ');

                    SelectTopping(toppingArgs, pizza);

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void SelectTopping(string[] toppingArgs, Pizza pizza)
        {
            var toppingType = toppingArgs[1].ToLower();
            var toppingWeight = int.Parse(toppingArgs[2]);

            pizza.AddTopping(new Topping(toppingType, toppingWeight));
        }

        private static void SelectDough(string[] doughArgs, Pizza pizza)
        {
            var flourType = doughArgs[1].ToLower();
            var bakingTechnique = doughArgs[2].ToLower();
            var doughtWeight = int.Parse(doughArgs[3]);

            pizza.Dough = new Dough(flourType, bakingTechnique, doughtWeight);
        }
    }
}
