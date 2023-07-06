namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double FuelConsumedByTheAC = 1.4;

        private double _initialFuelConsumption = 0;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            _initialFuelConsumption = fuelConsumption;
        }

        public override string Drive(double distance)
        {
            FuelConsumption = _initialFuelConsumption + FuelConsumedByTheAC;
            return base.Drive(distance);
        }

        public string DriveEmpty(double distance)
        {
            FuelConsumption = _initialFuelConsumption;
            return base.Drive(distance);
        }
    }
}
