namespace PizzaRestaurant
{
    public static class IngridientsHelper
    {
        public static Dictionary<string, double> FlourTypes = new()
        {
            { "white", 1.5},
            { "wholegrain", 1.0}
        };

        public static Dictionary<string, double> BakingTechniques = new()
        {
            { "crispy", 0.9},
            { "chewy", 1.1},
            { "homemade", 1.0}
        };

        public static Dictionary<string, double> Toppings = new()
        {
            { "meat", 1.2},
            { "veggies", 0.8},
            { "cheese", 1.1},
            { "sauce", 0.9 }
        };
    }
}
