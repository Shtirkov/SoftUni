namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
            };

            var engine = new Engine(500, 6300);

            var car = new Car("Mercedes", "S63 AMG", 2023, 300, 15, engine, tires);
        }
    }
}