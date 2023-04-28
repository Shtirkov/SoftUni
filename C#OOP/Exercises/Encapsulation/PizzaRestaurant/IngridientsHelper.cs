namespace PizzaRestaurant
{
    public static class IngridientsHelper
    {
        public static Dictionary<string, double> FlourTypes = new()
        {
            { "White", 1.5},
            { "Wholegrain", 1.0}
        };

        public static Dictionary<string, double> BakingTechniques = new()
        {
            { "Crispy", 0.9},
            { "Chewy", 1.1},
            { "Homemade", 1.0}
        };

        public static Dictionary<string, double> Toppings = new()
        {
            { "Meat", 1.2},
            { "Veggies", 0.8},
            { "Cheese", 1.1},
            {"Sauce", 0.9 }
        };
    }
}
