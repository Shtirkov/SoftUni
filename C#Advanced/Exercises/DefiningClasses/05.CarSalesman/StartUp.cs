using System.Text;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var enginesCount = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < enginesCount; i++)
            {
                var engineInfo = Console.ReadLine();
                engines.Add(CreateEngine(engineInfo));
            }

            engines = PrepareEngineOutput(engines);

            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var carInfo = Console.ReadLine();
                cars.Add(CreateCar(carInfo, engines));
            }

            cars = PrepareCarsOutput(cars);

            Console.WriteLine(PrepareOutput(cars));
        }

        private static Engine CreateEngine(string engineInfo)
        {
            var engineParameters = engineInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = engineParameters[0];
            var power = int.Parse(engineParameters[1]);
            var displacement = engineParameters.Length > 2 ? engineParameters[2] : "";
            var efficiency = engineParameters.Length > 3 ? engineParameters[3] : "";

            return new Engine(model, power, displacement, efficiency);
        }

        private static Car CreateCar(string carInfo, List<Engine> engines)
        {
            var carParameters = carInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = carParameters[0];
            var engine = engines.Where(e => e.Model == carParameters[1]).FirstOrDefault();
            var weight = carParameters.Length > 2 ? carParameters[2] : "";
            var color = carParameters.Length > 3 ? carParameters[3] : "";

            return new Car(model, engine, weight, color);
        }

        private static List<Engine> PrepareEngineOutput(List<Engine> engines)
        {
            engines.ForEach(e =>
            {
                if (string.IsNullOrEmpty(e.Displacement))
                {
                    e.Displacement = "n/a";
                }

                if (string.IsNullOrEmpty(e.Efficiency))
                {
                    e.Efficiency = "n/a";
                }
            });

            return engines;
        }

        private static List<Car> PrepareCarsOutput(List<Car> cars)
        {
            cars.ForEach(c =>
            {
                if (string.IsNullOrEmpty(c.Weight))
                {
                    c.Weight = "n/a";
                }

                if (string.IsNullOrEmpty(c.Color))
                {
                    c.Color = "n/a";
                }
            });

            return cars;
        }

        private static string PrepareOutput(List<Car> cars)
        {
            var sb = new StringBuilder();

            foreach (var car in cars)
            {
                sb.AppendLine($"{car.Model}:");
                sb.AppendLine($"    {car.Engine.Model}:");
                sb.AppendLine($"        Power: {car.Engine.Power}");
                sb.AppendLine($"        Displacement: {car.Engine.Displacement}");
                sb.AppendLine($"        Efficiency: {car.Engine.Efficiency}");
                sb.AppendLine($"    Weight: {car.Weight}");
                sb.AppendLine($"    Color: {car.Color}");
            }

            return sb.ToString();
        }
    }
}