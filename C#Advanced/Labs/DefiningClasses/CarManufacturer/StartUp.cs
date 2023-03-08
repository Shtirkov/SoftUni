namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<List<Tire>>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            var tiresInput = Console.ReadLine();

            while (tiresInput != "No more tires")
            {
                tires.Add(CreateTires(tiresInput));
                tiresInput = Console.ReadLine();
            }

            var engineInput = Console.ReadLine();

            while (engineInput != "Engines done")
            {
                engines.Add(CreateEngine(engineInput));
                engineInput = Console.ReadLine();
            }

            var carInput = Console.ReadLine();

            while (carInput != "Show special")
            {
                cars.Add(CreateCar(tires, engines, carInput));
                carInput = Console.ReadLine();
            }

            var filteredCars = cars
                .Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(t => t.Pressure) >= 9 && car.Tires.Sum(t => t.Pressure) <= 10)
                .ToList();

            filteredCars.ForEach(car => car.Drive(20));
            filteredCars.ForEach(car => Console.WriteLine(car.WhoAmI()));
        }

        private static Car CreateCar(List<List<Tire>> tires, List<Engine> engines, string carInput)
        {
            var make = carInput.Split()[0];
            var model = carInput.Split()[1];
            var year = int.Parse(carInput.Split()[2]);
            var fuelQuantity = double.Parse(carInput.Split()[3]);
            var fuelConsumption = double.Parse(carInput.Split()[4]);
            var engineIndex = int.Parse(carInput.Split()[5]);
            var tiresIndex = int.Parse(carInput.Split()[6]);

            return new Car(
                make,
                model,
                year,
                fuelQuantity,
                fuelConsumption,
                engines[engineIndex],
                tires[tiresIndex].ToArray());
        }

        private static Engine CreateEngine(string engineInput)
        {
            var horsePower = int.Parse(engineInput.Split()[0]);
            var cubicCapacity = double.Parse(engineInput.Split()[1]);

            return new Engine(horsePower, cubicCapacity);
        }

        private static List<Tire> CreateTires(string tiresInput)
        {
            var tires = new List<Tire>();
            var yearIndex = 0;
            var pressureIndex = 1;

            for (int i = 0; i < 4; i++)
            {
                var year = int.Parse(tiresInput.Split()[yearIndex]);
                var pressure = double.Parse(tiresInput.Split()[pressureIndex]);

                yearIndex += 2;
                pressureIndex += 2;

                tires.Add(new Tire(year, pressure));
            }

            return tires;
        }
    }
}