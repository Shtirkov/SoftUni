namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double _fuelConsumedByTheAC = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
             : base(fuelQuantity, fuelConsumption + _fuelConsumedByTheAC, tankCapacity)
        {}

        public override void Refuel(double liters)
        {
            var previousFuelQuantity = FuelQuantity;
            base.Refuel(liters);

            if (previousFuelQuantity != FuelQuantity)
            {
                FuelQuantity = FuelQuantity * 0.95;
            }
        }
    }
}
