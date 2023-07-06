namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private const string _traveledDistanceMessage = "{0} travelled {1} km";
        private const string _vehicleNeedsRefuelingMessage = "{0} needs refueling";
        private const string _notEnoughTankSpaceMessage = "Cannot fit {0} fuel in the tank";
        private const string _negativeFuelMessage = "Fuel must be a positive number";

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }

            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        protected double FuelQuantity { get; set; }

        protected double FuelConsumption { get; set; }

        protected double TankCapacity { get; private set; }       

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine(_negativeFuelMessage);
            }
            else if (TankCapacity - FuelQuantity < liters)
            {
                Console.WriteLine(_notEnoughTankSpaceMessage, liters);
            }
            else
            {
                FuelQuantity += liters;
            }
        }

        public virtual string Drive(double distance)
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
