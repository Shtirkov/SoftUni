namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double _fuelConsumedByTheAC = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            :base(fuelQuantity, fuelConsumption + _fuelConsumedByTheAC)
        {}

        public override void Refuel(double liters) => FuelQuantity += liters;
    }
}
