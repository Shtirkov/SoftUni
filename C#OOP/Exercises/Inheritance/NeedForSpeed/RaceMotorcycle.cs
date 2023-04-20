namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            base.FuelConsumption = 8;
        }

        public override double FuelConsumption { get => base.FuelConsumption;}
    }
}
