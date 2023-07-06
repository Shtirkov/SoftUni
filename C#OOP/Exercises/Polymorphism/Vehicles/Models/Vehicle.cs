namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private const string _traveledDistanceMessage = "{0} travelled {1} km";
        private const string _vehicleNeedsRefuelingMessage = "{0} needs refueling";

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public abstract void Refuel(double liters);

        public string Drive(double distance)
        {
            var output = "";
            var requiredFuelForTheDrive = FuelConsumption * distance;

            if (FuelQuantity > requiredFuelForTheDrive)
            {
                FuelQuantity -= requiredFuelForTheDrive;
                output = string.Format(_traveledDistanceMessage, GetType().Name, distance);
            }
            else
            {
                output = string.Format(_vehicleNeedsRefuelingMessage, GetType().Name);
            }

            return output;
        }

        public string GetRemainingFuel() => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
