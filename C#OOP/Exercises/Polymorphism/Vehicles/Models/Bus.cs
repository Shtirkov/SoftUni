namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double _fuelConsumedByTheAC = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {}

        public override string Drive(double distance)
        {
            FuelConsumption += _fuelConsumedByTheAC;
            return base.Drive(distance);
        }

        public string DriveEmpty(double distance)
        {
            FuelConsumption -= _fuelConsumedByTheAC;
            return base.Drive(distance);
        }
    }
}
