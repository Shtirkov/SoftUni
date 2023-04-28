using PizzaRestaurant.Models;

namespace PizzaRestaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputArr = input.Split();
                var ingridient = inputArr[0];
                var flourType = inputArr[1];
                var bakingTechnique = inputArr[2];
                var weight = int.Parse(inputArr[3]);

                try
                {
                    var dough = new Dough(flourType, bakingTechnique, weight);
                    Console.WriteLine($"{dough.CalculateCalories():f2}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}