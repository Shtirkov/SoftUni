namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double _fuelConsumedByTheAC = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + _fuelConsumedByTheAC, tankCapacity)
        { }
    }
}
