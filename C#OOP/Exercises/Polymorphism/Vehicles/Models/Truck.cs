namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FuelConsumedByTheAC = 1.6;

        private double _initialFuelQuantity = 0;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
             : base(fuelQuantity, fuelConsumption + FuelConsumedByTheAC, tankCapacity)
        {
            _initialFuelQuantity = fuelQuantity;
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);

            if (FuelQuantity != _initialFuelQuantity)
            {
                FuelQuantity = 0.95 * FuelQuantity;
            }
        }
    }
}
