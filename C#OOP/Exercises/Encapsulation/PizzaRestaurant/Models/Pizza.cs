namespace PizzaRestaurant.Models
{
    public class Pizza
    {
        private const string InvalidPizzaNameExceptionMessage = "Pizza name should be between 1 and 15 symbols.";
        private const string TooManyToppingsExceptionMessage = "Number of toppings should be in range [0..10].";

        private string _name;
        private ICollection<Topping> _toppings;

        public Pizza(string name)
        {
            Name = name;
            _toppings = new List<Topping>();    
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException(InvalidPizzaNameExceptionMessage);
                }

                _name = value;
            }
        }

        public Dough Dough { get; set; }

        public double TotalCalories => Dough.CalculateCalories() + _toppings.ToList().Sum(topping => topping.CalculateCalories());

        public int NumberOfToppings => _toppings.Count;

        public void AddTopping(Topping topping)
        {
            if (_toppings.Count == 10)
            {
                throw new ArgumentException(TooManyToppingsExceptionMessage);
            }

            _toppings.Add(topping);
        }
    }
}
