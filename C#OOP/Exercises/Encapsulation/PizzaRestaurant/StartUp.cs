using PizzaRestaurant.Models;

namespace PizzaRestaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var pizzaName = Console.ReadLine().Split()[1];
            var pizza = new Pizza(pizzaName);

            var exceptions = new List<Exception>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputArr = input.Split();

                switch (inputArr[0])
                {
                    case "Dough":
                        SelectDough(inputArr, pizza, exceptions);

                        if (exceptions.Any())
                        {
                            return;
                        }

                        break;
                    case "Topping":
                        SelectTopping(inputArr, pizza, exceptions);

                        if (exceptions.Any())
                        {
                            return;
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
        }

        private static void SelectTopping(string[] inputArr, Pizza pizza, List<Exception> exceptions)
        {
            var toppingType = inputArr[1].ToLower();
            var toppingWeight = int.Parse(inputArr[2]);

            try
            {
                var topping = new Topping(toppingType, toppingWeight);
                pizza.AddTopping(topping);
            }
            catch (Exception e)
            {
                exceptions.Add(e);
                Console.WriteLine(e.Message);
            }
        }

        private static void SelectDough(string[] inputArr, Pizza pizza, List<Exception> exceptions)
        {
            var flourType = inputArr[1].ToLower();
            var bakingTechnique = inputArr[2].ToLower();
            var doughtWeight = int.Parse(inputArr[3]);

            try
            {
                var dough = new Dough(flourType, bakingTechnique, doughtWeight);
                pizza.Dough = dough;
            }
            catch (Exception e)
            {
                exceptions.Add(e);
                Console.WriteLine(e.Message);
            }
        }
    }
}