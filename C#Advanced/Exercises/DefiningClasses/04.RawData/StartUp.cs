namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var carInfo = Console.ReadLine();
                cars.Add(CreateCar(carInfo));
            }

            var filteredCars = FilterCars(cars, Console.ReadLine());
            filteredCars.ForEach(c => Console.WriteLine(c.Model));
        }

        private static Car CreateCar(string carInfo)
        {
            var carParameters = carInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = carParameters[0];
            var engineSpeed = int.Parse(carParameters[1]);
            var enginePower = int.Parse(carParameters[2]);
            var cargoWeight = int.Parse(carParameters[3]);
            var cargoType = carParameters[4];
            var firstTirePressure = double.Parse(carParameters[5]);
            var firstTireAge = int.Parse(carParameters[6]);
            var secondTirPressure = double.Parse(carParameters[7]);
            var secondTireAge = int.Parse(carParameters[8]);
            var thirdTirePressure = double.Parse(carParameters[9]);
            var thirdTireAge = int.Parse(carParameters[10]);
            var fourthTirePressure = double.Parse(carParameters[11]);
            var fourthTireAge = int.Parse(carParameters[12]);

            var engine = new Engine(engineSpeed, enginePower);
            var cargo = new Cargo(cargoWeight, cargoType);
            var tires = new List<Tire>()
            {
                    new Tire(firstTirePressure,fourthTireAge),
                    new Tire(secondTireAge,secondTireAge),
                    new Tire(thirdTireAge,thirdTireAge),
                    new Tire(fourthTirePressure, fourthTireAge)
            };

            return new Car(model, engine, cargo, tires);
        }

        private static List<Car> FilterCars(List<Car> cars, string filter)
        {
            switch (filter)
            {
                case "fragile": return cars.Where(c => c.Cargo.Type == filter && c.Tires.Any(t => t.Pressure < 1)).ToList();

                case "flammable": return cars.Where(c => c.Cargo.Type == filter && c.Engine.Power > 250).ToList();

                default: throw new InvalidOperationException($"{filter} is not valid filtering type. Please select between fragile or flammable");
            }
        }
    }
}