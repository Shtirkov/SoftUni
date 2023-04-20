namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double _coffeeMilliliters = 50;
        private const decimal _price = 3.50m;

        public Coffee(string name, double caffeine,double milliliters = _coffeeMilliliters, decimal price = _price)
            : base(name, price,milliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
