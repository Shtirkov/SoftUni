namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private readonly double _defaultFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption { get => _defaultFuelConsumption; }
    }
}
