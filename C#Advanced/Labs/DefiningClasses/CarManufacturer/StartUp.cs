namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();

            car.Make = "VW";
            car.Make = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 10;
            car.Drive(2000);

            Console.WriteLine(car.WhoAmI());
        }
    }
}