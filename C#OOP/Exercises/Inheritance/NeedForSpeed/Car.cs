namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private readonly double _defaultFuelConsumption = 3;

        public Car(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption { get => _defaultFuelConsumption; }
    }
}
