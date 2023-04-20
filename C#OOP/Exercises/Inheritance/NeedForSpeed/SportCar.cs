namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            base.FuelConsumption = 10;
        }

        public override double FuelConsumption { get => base.FuelConsumption;}
    }
}
