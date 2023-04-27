namespace ShoppingSpree
{
    public class Person
    {
        private const string CanAffordProductErrorMessage = "{0} bought {1}";
        private const string CanNotAffordProductErrorMessage = "{0} can't afford {1}";

        private string _name;
        private decimal _money;
        private readonly List<Product> _products;

        public Person(string name, decimal money)
        {
            Name = name; 
            Money = money;
            _products = new List<Product>();
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Constants.EmptyNameErrorMessage);
                }
                _name = value;
            }
        }

        public decimal Money
        {
            get => _money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Constants.NegativeMoneyErrorMessage);
                }
                _money = value;
            }
        }

        public IReadOnlyCollection<Product> Products { get => _products.AsReadOnly(); }

        public string BuyProduct(Product product)
        {
            if (Money < product.Cost)
            {
                return string.Format(CanNotAffordProductErrorMessage, Name, product.Name);
            }

            _products.Add(product);
            Money -= product.Cost;

            return string.Format(CanAffordProductErrorMessage, Name, product.Name);
        }
    }
}
