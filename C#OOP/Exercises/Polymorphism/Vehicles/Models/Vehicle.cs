namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private const string TraveledDistanceMessage = "{0} travelled {1} km";
        private const string VehicleNeedsRefuelingMessage = "{0} needs refueling";
        private const string NotEnoughTankSpaceMessage = "Cannot fit {0} fuel in the tank";
        private const string NegativeFuelMessage = "Fuel must be a positive number";

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
                Console.WriteLine(NegativeFuelMessage);
            }
            else if (TankCapacity - FuelQuantity < liters)
            {
                Console.WriteLine(NotEnoughTankSpaceMessage, liters);
            }
            else
            {
                FuelQuantity += liters;
            }
        }

        public virtual string Drive(double distance)
        {
            var requiredFuelForTheDrive = FuelConsumption * distance;

            if (FuelQuantity > requiredFuelForTheDrive)
            {
                FuelQuantity -= requiredFuelForTheDrive;
                return string.Format(TraveledDistanceMessage, GetType().Name, distance);
            }
            else
            {
                return string.Format(VehicleNeedsRefuelingMessage, GetType().Name);
            }
        }

        public string GetRemainingFuel() => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
