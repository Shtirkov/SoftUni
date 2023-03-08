namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            var requiredFuelForTheTrip = distance * FuelConsumption;

            if (FuelQuantity > requiredFuelForTheTrip)
            {
                FuelQuantity -= requiredFuelForTheTrip;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI() => $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}L";
    }
}
