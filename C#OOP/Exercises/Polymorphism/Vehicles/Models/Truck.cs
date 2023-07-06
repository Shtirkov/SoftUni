namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FuelConsumedByTheAC = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
             : base(fuelQuantity, fuelConsumption + FuelConsumedByTheAC, tankCapacity)
        { }

        public override void Refuel(double liters)
         {
            var previousFuelQuantity = FuelQuantity;
            base.Refuel(liters);

            if (FuelQuantity != previousFuelQuantity)
            {
                FuelQuantity = 0.95 * FuelQuantity;                
            }
        }
    }
}
