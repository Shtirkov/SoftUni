namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private const string TraveledDistanceMessage = "{0} travelled {1} km";
        private const string VehicleNeedsRefuelingMessage = "{0} needs refueling";
        private const string NotEnoughTankSpaceMessage = "Cannot fit {0} fuel in the tank";
        private const string NegativeFuelMessage = "Fuel must be a positive number";
        private const string NegativeFuelConsumptionMessage = "Fuel consumption can not be negative";
        private const string NegativeTankCapacity = "Tank capacity can not be 0 or negative";
        private const string NegativeDistanceMessage = "Distance can not be negative";

        private double _fuelQuantity;
        private double _fuelConsumption;
        private double _tankCapacity;

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

        protected double FuelQuantity
        {
            get => _fuelQuantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(NegativeFuelMessage);
                }

                _fuelQuantity = value;
            }
        }

        protected double FuelConsumption
        {
            get => _fuelConsumption;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(NegativeFuelConsumptionMessage);
                }

                _fuelConsumption = value;
            }
        }

        protected double TankCapacity
        {
            get => _tankCapacity;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(NegativeTankCapacity);
                }

                _tankCapacity = value;
            }
        }

        public virtual void Refuel(double liters)
        {
            if (TankCapacity - FuelQuantity < liters)
            {
                Console.WriteLine(NotEnoughTankSpaceMessage, liters);
            }
            else if (liters <= 0)
            {
                Console.WriteLine(NegativeFuelMessage);
            }
            else
            {
                FuelQuantity += liters;
            }
        }

        public virtual string Drive(double distance)
        {
            var requiredFuelForTheDrive = FuelConsumption * distance;

            if (distance < 0)
            {
                return NegativeDistanceMessage;
            }
            else if (FuelQuantity >= requiredFuelForTheDrive)
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
