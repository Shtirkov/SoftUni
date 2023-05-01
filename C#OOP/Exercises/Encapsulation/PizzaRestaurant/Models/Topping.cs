namespace PizzaRestaurant.Models
{
    public class Topping
    {

        private const string InvalidToppingExceptionMessage = "Cannot place {0} on top of your pizza.";
        private const string InvalidWeightExceptionMessage = "{0} weight should be in the range [1..50].";
        private const int BaseCaloriesPerGram = 2;
        private const int MinToppingWeight = 1;
        private const int MaxToppingWeight = 50; 

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
                    throw new ArgumentException(string.Format(InvalidToppingExceptionMessage, char.ToUpper(value[0]) + value.Substring(1)));
                }

                _toppingType = value;
            }
        }

        public int Weight
        {
            get => _weight;
            private set
            {
                if (value < MinToppingWeight || value > MaxToppingWeight)
                {                    
                    throw new ArgumentException(string.Format(InvalidWeightExceptionMessage, char.ToUpper(_toppingType[0]) + _toppingType.Substring(1)));
                }

                _weight = value;
            }
        }

        public double CalculateCalories() => BaseCaloriesPerGram * _weight * IngridientsHelper.Toppings[_toppingType];        
    }
}