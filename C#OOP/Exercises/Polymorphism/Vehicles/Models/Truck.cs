namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double _fuelConsumedByTheAC = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption)
             : base(fuelQuantity, fuelConsumption + _fuelConsumedByTheAC)
        {}

        public override void Refuel(double liters) => FuelQuantity += 0.95 * liters;
    }
}
