namespace ShoppingSpree
{
    public class Product
    {
        private string _name;
        private decimal _cost;
       
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
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

        public decimal Cost
        {
            get => _cost;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Constants.NegativeMoneyErrorMessage);
                }
                _cost = value;
            }
        }
    }
}
