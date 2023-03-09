namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var fuelConsumptionPerKm = double.Parse(carInfo[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumptionPerKm));
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                var splitted = command.Split();
                var carModel = splitted[1];
                var distance = double.Parse(splitted[2]);

                var currentCar = cars.Where(c => c.Model == carModel).FirstOrDefault();
                currentCar.Drive(distance);

                command = Console.ReadLine();
            }

            cars.ForEach(c => Console.WriteLine(c.PrintCar()));
        }
    }
}