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

                switch (inputArr.Length)
                {
                    case 4:
                        var flourType = char.ToUpper(inputArr[1][0]) + inputArr[1].Substring(1);
                        var bakingTechnique = char.ToUpper(inputArr[2][0]) + inputArr[2].Substring(1);
                        var doughtWeight = int.Parse(inputArr[3]);

                        try
                        {
                            var dough = new Dough(flourType, bakingTechnique, doughtWeight);
                            Console.WriteLine($"{dough.CalculateCalories():f2}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        var toppingType = char.ToUpper(inputArr[1][0]) + inputArr[1].Substring(1);
                        var toppingWeight = int.Parse(inputArr[2]);

                        try
                        {
                            var topping = new Topping(toppingType,toppingWeight);
                            Console.WriteLine($"{topping.CalculateCalories():f2}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}