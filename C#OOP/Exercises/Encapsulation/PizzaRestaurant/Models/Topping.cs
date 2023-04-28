namespace PizzaRestaurant.Models
{
    public class Topping
    {

        private const string InvalidToppingExceptionMessage = "Cannot place {0} on top of your pizza.";
        private const string InvalidWeightExceptionMessage = "{0} weight should be in the range [1..50].";

        private string _toppingType;
        private int _weight;

        public Topping(string toppingType, int weight)
        {
            ToppingType = toppingType;
            Weight = weight;
        }

        public string ToppingType
        {
            get => _toppingType;
            private set
            {
                if (!IngridientsHelper.Toppings.ContainsKey(value))
                {
                    throw new ArgumentException(string.Format(InvalidToppingExceptionMessage, value));
                }

                _toppingType = value;
            }
        }

        public int Weight
        {
            get => _weight;
            private set
            {
                if (value < 1 || value > 50)
                {                    
                    throw new ArgumentException(string.Format(InvalidWeightExceptionMessage, _toppingType));
                }

                _weight = value;
            }
        }

        public double CalculateCalories() => 2 * _weight * IngridientsHelper.Toppings[_toppingType];        
    }
}