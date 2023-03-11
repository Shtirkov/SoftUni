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

            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var carInfo = Console.ReadLine();
                cars.Add(CreateCar(carInfo, engines));
            }

            Console.WriteLine(PrepareOutput(cars));
        }

        private static Engine CreateEngine(string engineInfo)
        {
            var engineParameters = engineInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = engineParameters[0];
            var power = int.Parse(engineParameters[1]);
            var displacement = "n/a";
            var efficiency = "n/a";

            if (engineParameters.Length == 3 && IsNumeric(engineParameters[2]))
            {
                displacement = engineParameters[2];
            }
            else if (engineParameters.Length == 3 && !IsNumeric(engineParameters[2]))
            {
                efficiency = engineParameters[2];
            }
            else if (engineParameters.Length == 4)
            {
                displacement = engineParameters[2];
                efficiency = engineParameters[3];
            }

            return new Engine(model, power, displacement, efficiency);
        }

        private static Car CreateCar(string carInfo, List<Engine> engines)
        {
            var carParameters = carInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = carParameters[0];
            var engine = engines.Where(e => e.Model == carParameters[1]).FirstOrDefault();
            var weight = "n/a";
            var color = "n/a";

            if (carParameters.Length == 3 && IsNumeric(carParameters[2]))
            {
                weight = carParameters[2];
            }
            else if (carParameters.Length == 3 && !IsNumeric(carParameters[2]))
            {
                color = carParameters[2];
            }
            else if (carParameters.Length == 4)
            {
                weight = carParameters[2];
                color = carParameters[3];
            }

            return new Car(model, engine, weight, color);
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

        private static bool IsNumeric(string str) => int.TryParse(str, out var result);
    }
}