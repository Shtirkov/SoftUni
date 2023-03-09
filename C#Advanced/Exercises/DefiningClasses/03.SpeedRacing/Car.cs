namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            var requiredFuel = FuelConsumptionPerKilometer * distance;

            if (FuelAmount >= requiredFuel)
            {
                TravelledDistance += distance;
                FuelAmount -= requiredFuel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public string PrintCar()
            => $"{Model} {FuelAmount:f2} {TravelledDistance}";
    }
}
